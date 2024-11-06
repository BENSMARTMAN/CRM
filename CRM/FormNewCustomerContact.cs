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
    public partial class FormNewCustomerContact : Form
    {
        //private Action LoadCustomerData;
        private string _customer; // 客戶編號
        private string _custName; // 客戶名稱
        public FormNewCustomerContact(string customer, string custName)
        {
            InitializeComponent();
            //this.LoadCustomerData = LoadCustomerData;
            _customer = customer;
            _custName = custName;
            // 設置只讀的 TextBox
            textBoxCustomer.Text = _customer;
            textBoxCustName.Text = _custName;
            textBoxCustomer.ReadOnly = true;
            textBoxCustName.ReadOnly = true;
            comboBoxIsPrimaryContact.SelectedIndex = -1;
        }
        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 確認必要欄位是否有值
            if (string.IsNullOrWhiteSpace(textBoxPrimaryContact.Text) ||
                comboBoxIsPrimaryContact.SelectedItem == null)
            {
                MessageBox.Show("請填寫紅字必要欄位");
                return;
            }

            // 新增聯絡人至資料庫
            if (comboBoxIsPrimaryContact.SelectedItem.ToString() == "Y")
            {
                // 檢查是否已有主要聯絡人
                if (IsPrimaryContactExists())
                {
                    var result = MessageBox.Show("已有其他聯絡人為主要聯絡人，是否要替換?", "確認", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SetPreviousPrimaryContactToNo();
                    }
                    else
                    {
                        return; // 若使用者選擇不替換，則返回
                    }
                }
            }
            // 建立新的 CustomerContact 物件
            var newContact = new CustomerContact
            {
                Customer = _customer,
                CustName = _custName,
                PrimaryContact = textBoxPrimaryContact.Text,
                Department = textBoxDepartment.Text,
                JobTitle = textBoxJobTitle.Text,
                Phone = textBoxPhone.Text,
                Fax = textBoxFax.Text,
                MobilePhone = textBoxMobilePhone.Text,
                Email = textBoxEmail.Text,
                ContactNote = richTextBoxContactNote.Text,
                IsPrimaryContact = comboBoxIsPrimaryContact.SelectedItem.ToString()[0] // 'Y' 或 'N'
            };

            // 儲存到資料庫
            SaveContactToDatabase(newContact);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsPrimaryContactExists()
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                
                string query = "SELECT COUNT(*) FROM CustomerContacts WHERE IsPrimaryContact = 'Y' AND Customer = @Customer";
                return connection.ExecuteScalar<int>(query, new { Customer = _customer }) > 0; // 只檢查同一公司的主要聯絡人
            }
        }
        private void SetPreviousPrimaryContactToNo()
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "UPDATE CustomerContacts SET IsPrimaryContact = 'N' WHERE IsPrimaryContact = 'Y' AND Customer = @Customer";
                connection.Execute(query, new { Customer = _customer });
            }
        }

        private void SaveContactToDatabase(CustomerContact contact)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "INSERT INTO CustomerContacts (Customer, CustName, PrimaryContact, Department, JobTitle, Phone, Fax, MobilePhone, Email, ContactNote, IsPrimaryContact) " +
                               "VALUES (@Customer, @CustName, @PrimaryContact, @Department, @JobTitle, @Phone, @Fax, @MobilePhone, @Email, @ContactNote, @IsPrimaryContact)";
                connection.Execute(query, contact); // 使用 Dapper 或 SqlCommand 執行插入操作
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
