using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace CRM
{
    public partial class FormNewCustomer : Form
    {
        public FormNewCustomer()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 取得輸入的客戶編號、名稱和主要聯絡人
            string customerCode = textBoxCustomer.Text.Trim();
            string customerName = textBoxCustName.Text.Trim();
            string primaryContact = textBoxPrimaryContact.Text.Trim();

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

            // 執行儲存邏輯
            SaveNewCustomer(noe, aoc, primaryContact);
        }
        // 檢查客戶是否已存在的方法
        private bool CustomerExists(string customerCode, string customerName)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "SELECT COUNT(1) FROM CustomerInfo WHERE Customer = @Customer OR CustName = @CustName";
                int count = connection.ExecuteScalar<int>(query, new { Customer = customerCode, CustName = customerName });
                return count > 0;
            }
        }
        // 儲存新客戶的方法
        private void SaveNewCustomer(int noe, decimal aoc, string primaryContact)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                // 插入客戶資料
                string insertCustomerQuery = @"INSERT INTO CustomerInfo (Customer, CustName, IndustryRemark, Address, WebSite, CustStatus, CSR, SME, SFE, GSTNo, NOE, AOC, Remark, System, SystemRemark)
                                               VALUES (@Customer, @CustName, @IndustryRemark, @Address, @WebSite, @CustStatus, @CSR, @SME, @SFE, @GSTNo, @NOE, @AOC, @Remark, @System, @SystemRemark)";

                var newCustomer = new CustomerInfo
                {
                    Customer = textBoxCustomer.Text.Trim(),
                    CustName = textBoxCustName.Text.Trim(),
                    IndustryRemark = textBoxIndustryRemark.Text.Trim(),
                    Address = textBoxAddress.Text.Trim(),
                    WebSite = textBoxWebSite.Text.Trim(),
                    CustStatus = comboBoxCustStatus.Text,
                    CSR = comboBoxCSR.Text.Trim(),
                    SME = comboBoxSME.Text.Trim(),
                    SFE = comboBoxSFE.Text.Trim(),
                    GSTNo = textBoxGSTNo.Text.Trim(),
                    NOE = noe,
                    AOC = aoc,
                    Remark = richTextBoxRemark.Text.Trim(),
                    System = textBoxSystem.Text.Trim(),
                    SystemRemark = textBoxSystemRemark.Text.Trim()
                };

                // 插入主要聯絡人資料
                string insertContactQuery = @"INSERT INTO CustomerContacts (Customer, CustName, PrimaryContact, Department, JobTitle, Phone, Fax, MobilePhone, Email, ContactNote, IsPrimaryContact)
                                              VALUES (@Customer, @CustName, @PrimaryContact, @Department, @JobTitle, @Phone, @Fax, @MobilePhone, @Email, @ContactNote, 'Y')";

                var newContact = new CustomerContact
                {
                    Customer = textBoxCustomer.Text.Trim(),
                    CustName = textBoxCustName.Text.Trim(),
                    PrimaryContact = textBoxPrimaryContact.Text.Trim(),
                    Department = textBoxDepartment.Text.Trim(),
                    JobTitle = textBoxJobTitle.Text.Trim(),
                    Phone = textBoxPhone.Text.Trim(),
                    Fax = textBoxFax.Text.Trim(),
                    MobilePhone = textBoxMobilePhone.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    ContactNote = richTextBoxContactNote.Text.Trim(),
                    IsPrimaryContact = 'Y' // 設置為主要聯絡人
                };

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        connection.Execute(insertCustomerQuery, newCustomer, transaction: transaction);
                        connection.Execute(insertContactQuery, newContact, transaction: transaction);
                        transaction.Commit();
                        MessageBox.Show("客戶資料已成功新增", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("儲存過程中發生錯誤，請稍後再試。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
