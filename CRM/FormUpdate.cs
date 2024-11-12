using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Dapper;

namespace CRM
{
    public partial class FormUpdate : Form
    {
        
        private CombinedCustomerContact _selectedCustomer;
        private List<CustomerContact> _contactsList = new List<CustomerContact>();
        public FormUpdate(CombinedCustomerContact selectedCustomer)
        {
            InitializeComponent();
            _selectedCustomer = selectedCustomer;
            LoadCustomerDetails();
            LoadCustomerContacts(); // 載入聯絡人資料

            // 設置 DataGridView 為唯讀模式
            dataGridView1.ReadOnly = true;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }
        // 載入選定的客戶詳細資訊
        private void LoadCustomerDetails()
        {
            textBoxCustName.Text = _selectedCustomer.CustName;
            textBoxCustomer.Text = _selectedCustomer.Customer;
            textBoxIndustryRemark.Text = _selectedCustomer.IndustryRemark;
            textBoxAddress.Text = _selectedCustomer.Address;
            textBoxWebSite.Text = _selectedCustomer.WebSite;
            textBoxAOC.Text = _selectedCustomer.AOC.ToString();
            comboBoxCustStatus.SelectedItem = _selectedCustomer.CustStatus.ToString();
            comboBoxCSR.SelectedItem = _selectedCustomer.CSR.ToString();
            comboBoxSME.SelectedItem = _selectedCustomer.SME.ToString();
            comboBoxSFE.SelectedItem = _selectedCustomer.SFE.ToString();
            textBoxGSTNo.Text = _selectedCustomer.GSTNo;
            textBoxNOE.Text = _selectedCustomer.NOE.ToString();
            richTextBoxRemark.Text = _selectedCustomer.Remark;  // 使用 RichTextBox 來顯示 Remark
            textBoxSystem.Text = _selectedCustomer.System;
            textBoxSystemRemark.Text = _selectedCustomer.SystemRemark;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string customerCode = textBoxCustomer.Text.Trim();
            string customerName = textBoxCustName.Text.Trim();
            int noe = 0; // 預設值為 0
            if (!string.IsNullOrEmpty(textBoxNOE.Text) && (!int.TryParse(textBoxNOE.Text, out noe) || noe < 0))
            {
                MessageBox.Show("員工人數必須為有效的非負整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查 AOC（資本額）是否為有效的數字，並且不得為負數
            decimal aoc = 0m; // 預設值為 0
            if (!string.IsNullOrEmpty(textBoxAOC.Text) && (!decimal.TryParse(textBoxAOC.Text, out aoc) || aoc < 0))
            {
                MessageBox.Show("資本額必須為有效的非負數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 檢查客戶編號和名稱是否已存在於資料庫
            if (CustomerExists(customerCode, customerName))
            {
                MessageBox.Show("公司代碼或該公司名稱已存在，請輸入其他代碼。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 更新 _selectedCustomer 物件中的值
            _selectedCustomer.CustName = textBoxCustName.Text;
            _selectedCustomer.Customer = textBoxCustomer.Text;
            _selectedCustomer.IndustryRemark = textBoxIndustryRemark.Text;
            _selectedCustomer.Address = textBoxAddress.Text;
            _selectedCustomer.WebSite = textBoxWebSite.Text;
            _selectedCustomer.AOC = aoc;  // 若為空，aoc 已為 0
            _selectedCustomer.CustStatus = comboBoxCustStatus.Text;
            _selectedCustomer.CSR = comboBoxCSR.Text;
            _selectedCustomer.SME = comboBoxSME.Text;
            _selectedCustomer.SFE = comboBoxSFE.Text;
            _selectedCustomer.GSTNo = textBoxGSTNo.Text;
            _selectedCustomer.NOE = noe;  // 若為空，noe 已為 0
            _selectedCustomer.Remark = richTextBoxRemark.Text;  // 使用 RichTextBox 更新 Remark
            _selectedCustomer.System = textBoxSystem.Text;
            _selectedCustomer.SystemRemark = textBoxSystemRemark.Text;

            // 這裡可以呼叫更新資料庫的函式，將資料寫回資料庫
            UpdateCustomerInDatabase(_selectedCustomer);

            MessageBox.Show("資料已更新");
        }
        private bool CustomerExists(string customerCode, string customerName)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "SELECT COUNT(1) FROM CustomerInfo WHERE Customer = @Customer OR CustName = @CustName";
                int count = connection.ExecuteScalar<int>(query, new { Customer = customerCode, CustName = customerName });
                return count > 0;
            }
        }
        private void UpdateCustomerInDatabase(CombinedCustomerContact selectedCustomer)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                var query = "UPDATE CustomerInfo SET CustName = @CustName, IndustryRemark = @IndustryRemark, Address = @Address, " +
                            "WebSite = @WebSite, AOC = @AOC, CustStatus = @CustStatus, CSR = @CSR, SME = @SME, " +
                            "SFE = @SFE, GSTNo = @GSTNo, NOE = @NOE, Remark = @Remark, System = @System, SystemRemark = @SystemRemark " +
                            "WHERE Customer = @Customer";

                connection.Execute(query, selectedCustomer);  // 使用 Dapper 或 SqlCommand 執行更新操作
            }
        }

        // 從資料庫中載入聯絡人資料
        private void LoadCustomerContacts()
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "SELECT Customer, CustName, PrimaryContact, Department, JobTitle, Phone, Fax, " +
                               "MobilePhone, Email, ContactNote, IsPrimaryContact " +
                               "FROM CustomerContacts WHERE Customer = @Customer";
                _contactsList = connection.Query<CustomerContact>(query, new { Customer = _selectedCustomer.Customer }).ToList();
            }

            // 將聯絡人資料綁定到 dataGridView1
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _contactsList;

            // 設置 DataGridView 標題
            dataGridView1.Columns["Customer"].HeaderText = "客戶編號";
            dataGridView1.Columns["CustName"].HeaderText = "客戶名稱";
            dataGridView1.Columns["PrimaryContact"].HeaderText = "聯絡人";
            dataGridView1.Columns["Department"].HeaderText = "部門";
            dataGridView1.Columns["JobTitle"].HeaderText = "職稱";
            dataGridView1.Columns["Phone"].HeaderText = "電話";
            dataGridView1.Columns["Fax"].HeaderText = "傳真";
            dataGridView1.Columns["MobilePhone"].HeaderText = "行動電話";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["ContactNote"].HeaderText = "聯絡人備註";
            dataGridView1.Columns["IsPrimaryContact"].HeaderText = "是否為主要聯絡人";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            // 直接使用 _selectedCustomer 的 Customer 和 CustName
            string customer = _selectedCustomer.Customer;
            string custName = _selectedCustomer.CustName;

            var formNewCustomerContact = new FormNewCustomerContact(customer, custName);
            if (formNewCustomerContact.ShowDialog() == DialogResult.OK)
            {
                // 成功新增後重新載入聯絡人資料
                LoadCustomerContacts();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 取得選定的聯絡人
                var selectedContact = (CustomerContact)dataGridView1.SelectedRows[0].DataBoundItem;

                // 若選中的聯絡人是主要聯絡人，則提示並不執行刪除
                if (selectedContact.IsPrimaryContact == 'Y')
                {
                    MessageBox.Show("請將其他聯絡人設定為主要聯絡人後再刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // 取消刪除操作
                }

                // 顯示確認刪除的訊息框
                var result = MessageBox.Show($"是否要刪除聯絡人 {selectedContact.PrimaryContact} 的資訊？",
                                             "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 執行刪除聯絡人
                    DeleteContactFromDatabase(selectedContact);
                    LoadCustomerContacts(); // 刪除後重新載入聯絡人資料
                    MessageBox.Show("聯絡人已成功刪除");
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的聯絡人");
            }
        }
        // 從資料庫中刪除聯絡人
        private void DeleteContactFromDatabase(CustomerContact contact)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string deleteQuery = "DELETE FROM CustomerContacts WHERE Customer = @Customer AND PrimaryContact = @PrimaryContact";
                connection.Execute(deleteQuery, new { contact.Customer, contact.PrimaryContact });
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 確保是有效的行
            {
                // 取得選中的聯絡人資料
                var selectedContact = (CustomerContact)dataGridView1.Rows[e.RowIndex].DataBoundItem;


                // 打開新表單並將選定的資料傳遞給新表單
                var fromeditcustomercontact = new FormEditCustomerContact(selectedContact);
                if (fromeditcustomercontact.ShowDialog() == DialogResult.OK) 
                {
                    // 成功新增後重新載入聯絡人資料
                    LoadCustomerContacts();
                } ;
            }
            
        }
    }
}
