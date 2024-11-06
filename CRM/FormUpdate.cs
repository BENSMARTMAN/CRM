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
            textBoxCustStatus.Text = _selectedCustomer.CustStatus;
            textBoxCSR.Text = _selectedCustomer.CSR;
            textBoxSME.Text = _selectedCustomer.SME;
            textBoxSFE.Text = _selectedCustomer.SFE;
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
            // 更新 _selectedCustomer 物件中的值
            _selectedCustomer.CustName = textBoxCustName.Text;
            _selectedCustomer.Customer = textBoxCustomer.Text;
            _selectedCustomer.IndustryRemark = textBoxIndustryRemark.Text;
            _selectedCustomer.Address = textBoxAddress.Text;
            _selectedCustomer.WebSite = textBoxWebSite.Text;
            _selectedCustomer.AOC = decimal.TryParse(textBoxAOC.Text, out decimal aoc) ? aoc : 0;
            _selectedCustomer.CustStatus = textBoxCustStatus.Text;
            _selectedCustomer.CSR = textBoxCSR.Text;
            _selectedCustomer.SME = textBoxSME.Text;
            _selectedCustomer.SFE = textBoxSFE.Text;
            _selectedCustomer.GSTNo = textBoxGSTNo.Text;
            _selectedCustomer.NOE = int.TryParse(textBoxNOE.Text, out int noe) ? noe : 0;
            _selectedCustomer.Remark = richTextBoxRemark.Text;  // 使用 RichTextBox 更新 Remark
            _selectedCustomer.System = textBoxSystem.Text;
            _selectedCustomer.SystemRemark = textBoxSystemRemark.Text;

            // 這裡可以呼叫更新資料庫的函式，將資料寫回資料庫
            UpdateCustomerInDatabase(_selectedCustomer);

            MessageBox.Show("資料已更新");
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
