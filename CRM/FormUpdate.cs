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
        private CustomerInfo _selectedCustomer;
        public FormUpdate(CustomerInfo selectedCustomer)
        {
            InitializeComponent();
            _selectedCustomer = selectedCustomer;
            LoadCustomerDetails();
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

        private void FormUpdate_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
        private void UpdateCustomerInDatabase(CustomerInfo selectedCustomer)
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
    }
}
