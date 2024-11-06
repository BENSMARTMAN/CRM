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
            // 取得輸入的客戶編號和客戶名稱
            string customerCode = textBoxCustomer.Text.Trim();
            string customerName = textBoxCustName.Text.Trim();

            // 檢查客戶編號和名稱是否為必填
            if (string.IsNullOrEmpty(customerCode) || string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("請填寫公司代碼和公司名稱。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查 NOE（員工人數）是否為有效的數字
            if (!int.TryParse(textBoxNOE.Text, out int noe))
            {
                MessageBox.Show("員工人數必須為有效的整數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查 AOC（資本額）是否為有效的數字
            if (!decimal.TryParse(textBoxAOC.Text, out decimal aoc))
            {
                MessageBox.Show("資本額必須為有效的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 檢查客戶編號和名稱是否已存在於資料庫
            if (CustomerExists(customerCode, customerName))
            {
                MessageBox.Show("公司代碼或該公司名稱已存在，請輸入其他代碼。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 執行儲存邏輯
            SaveNewCustomer(noe, aoc);
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
        private void SaveNewCustomer(int noe, decimal aoc)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string insertQuery = @"INSERT INTO CustomerInfo (Customer, CustName, IndustryRemark, Address, WebSite, CustStatus, CSR, SME, SFE, GSTNo, NOE, AOC, Remark, System, SystemRemark)
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

                connection.Execute(insertQuery, newCustomer);
                MessageBox.Show("客戶已成功新增", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 關閉視窗或清空表單
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
