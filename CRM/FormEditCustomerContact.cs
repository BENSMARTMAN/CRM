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
    public partial class FormEditCustomerContact : Form
    {
        private CustomerContact _selectedContact;

        public FormEditCustomerContact(CustomerContact selectedContact)
        {
            InitializeComponent();
            _selectedContact = selectedContact;
            LoadContactDetails();
        }

        private void LoadContactDetails()
        {
            textBoxCustomer.Text = _selectedContact.Customer;   // 顯示公司代碼
            textBoxCustomer.ReadOnly = true;

            textBoxCustName.Text = _selectedContact.CustName;   // 顯示公司名稱
            textBoxCustName.ReadOnly = true;

            textBoxPrimaryContact.Text = _selectedContact.PrimaryContact; // 聯絡人
            textBoxDepartment.Text = _selectedContact.Department;         // 部門
            textBoxJobTitle.Text = _selectedContact.JobTitle;             // 職稱
            textBoxPhone.Text = _selectedContact.Phone;                   // 電話
            textBoxFax.Text = _selectedContact.Fax;                       // 傳真
            textBoxMobilePhone.Text = _selectedContact.MobilePhone;       // 行動電話
            textBoxEmail.Text = _selectedContact.Email;                   // Email
            // 設定 RichTextBox 的 ContactNote
            richTextBoxContactNote.Text = _selectedContact.ContactNote;
            // 設定 IsPrimaryContact ComboBox
            comboBoxIsPrimaryContact.SelectedItem = _selectedContact.IsPrimaryContact.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 儲存原本的 PrimaryContact，確保資料庫更新時使用
            string originalPrimaryContact = _selectedContact.PrimaryContact;
            // 檢查 IsPrimaryContact 的變更
            char newIsPrimaryContact = comboBoxIsPrimaryContact.SelectedItem.ToString()[0];

            // 只有當 IsPrimaryContact 有改變時才進行檢查
            if (newIsPrimaryContact != _selectedContact.IsPrimaryContact)
            {
                // 檢查同公司是否有其他主要聯絡人
                if (newIsPrimaryContact == 'Y')
                {
                    // 檢查是否存在其他主要聯絡人
                    if (IsOtherPrimaryContactExists(_selectedContact.Customer))
                    {
                        var result = MessageBox.Show("同公司已有其他主要聯絡人，是否替換？", "確認", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            // 如果用戶選擇替換，則將原主要聯絡人設為 'N'
                            SetPreviousPrimaryContactToNo(_selectedContact.Customer);
                        }
                        else
                        {
                            return; // 如果用戶選擇不替換，則返回
                        }
                    }
                }
                else if (newIsPrimaryContact == 'N' && !IsOtherPrimaryContactExists(_selectedContact.Customer))
                {
                    MessageBox.Show("已無主要負責人，請先將其他負責人設為主要負責人，才可以存檔。");
                    return; // 如果沒有其他主要聯絡人，則返回
                }
            }

            // 更新 _selectedContact 物件中的資料
            _selectedContact.PrimaryContact = textBoxPrimaryContact.Text;
            _selectedContact.Department = textBoxDepartment.Text;
            _selectedContact.JobTitle = textBoxJobTitle.Text;
            _selectedContact.Phone = textBoxPhone.Text;
            _selectedContact.Fax = textBoxFax.Text;
            _selectedContact.MobilePhone = textBoxMobilePhone.Text;
            _selectedContact.Email = textBoxEmail.Text;
            _selectedContact.ContactNote = richTextBoxContactNote.Text; // 更新 ContactNote
            _selectedContact.IsPrimaryContact = newIsPrimaryContact; // 更新為新的主要聯絡人狀態

            // 更新資料庫
            UpdateContactInDatabase(_selectedContact, originalPrimaryContact);
            MessageBox.Show("聯絡人資料已更新");
            DialogResult = DialogResult.OK;
            Close();
        }
        private bool IsOtherPrimaryContactExists(string customer)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "SELECT COUNT(*) FROM CustomerContacts WHERE Customer = @Customer AND IsPrimaryContact = 'Y'";
                int count = connection.QuerySingle<int>(query, new { Customer = customer });
                return count > 0; // 如果有其他主要聯絡人則返回 true
            }
        }

        // 設置同公司的其他主要聯絡人為 'N'
        private void SetPreviousPrimaryContactToNo(string customer)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "UPDATE CustomerContacts SET IsPrimaryContact = 'N' WHERE IsPrimaryContact = 'Y' AND Customer = @Customer";
                connection.Execute(query, new { Customer = customer });
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // 更新資料庫中的聯絡人資訊
        private void UpdateContactInDatabase(CustomerContact contact, string originalPrimaryContact)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string query = "UPDATE CustomerContacts SET PrimaryContact = @PrimaryContact, Department = @Department, " +
                               "JobTitle = @JobTitle, Phone = @Phone, Fax = @Fax, MobilePhone = @MobilePhone, " +
                               "Email = @Email, ContactNote = @ContactNote, IsPrimaryContact = @IsPrimaryContact " +
                               "WHERE Customer = @Customer AND PrimaryContact = @OriginalPrimaryContact";

                connection.Execute(query, new
                {
                    contact.PrimaryContact,
                    contact.Department,
                    contact.JobTitle,
                    contact.Phone,
                    contact.Fax,
                    contact.MobilePhone,
                    contact.Email,
                    contact.ContactNote,
                    IsPrimaryContact = contact.IsPrimaryContact,
                    OriginalPrimaryContact = originalPrimaryContact, // 確保只更新選定的聯絡人
                    Customer = contact.Customer // 傳遞 Customer 作為查詢條件
                }); // 使用 Dapper 進行更新操作
            }
        }

    }
}
