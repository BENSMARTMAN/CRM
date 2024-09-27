using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using DocumentFormat.OpenXml.Spreadsheet;

namespace CRM
{
    public partial class Form1 : Form
    {

        private List<CustomerInfo> customerList = new List<CustomerInfo>();
        private List<CustomerContact> contactsList = new List<CustomerContact>();
        private List<CombinedCustomerContact> combinedList = new List<CombinedCustomerContact>();

        // 初始化表單，並且可能需要從資料庫中載入客戶資料
        public Form1()
        {
            InitializeComponent();
            SearchBox.TextChanged += SearchBox_TextChanged;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            LoadCustomerData();
        }

        

        // 從資料庫中載入客戶資料
        private void LoadCustomerData()
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                // 讀取 CustomerInfo 資料
                string queryCustomers = "SELECT * FROM CustomerInfo";
                customerList = connection.Query<CustomerInfo>(queryCustomers).ToList();

                // 讀取 CustomerContacts 資料，僅篩選 IsPrimaryContact 為 'Y'
                string queryContacts = "SELECT Customer, PrimaryContact, Department, JobTitle, Phone, Fax, Email, ContactNote " +
                                       "FROM CustomerContacts WHERE IsPrimaryContact = 'Y'";
                contactsList = connection.Query<CustomerContact>(queryContacts).ToList();
                combinedList = (from customer in customerList
                                join contact in contactsList on customer.Customer equals contact.Customer
                                select new CombinedCustomerContact
                                {
                                    Customer = customer.Customer,
                                    CustName = customer.CustName,
                                    IndustryRemark = customer.IndustryRemark, 
                                    Address = customer.Address,
                                    WebSite = customer.WebSite,
                                    CustStatus = customer.CustStatus,
                                    CSR = customer.CSR,
                                    SME = customer.SME,
                                    SFE = customer.SFE,
                                    GSTNo = customer.GSTNo,
                                    NOE = customer.NOE,
                                    AOC = customer.AOC,
                                    Remark = customer.Remark,
                                    System = customer.System,
                                    SystemRemark = customer.Remark,
                                    PrimaryContact = contact.PrimaryContact,
                                    Department = contact.Department,
                                    JobTitle = contact.JobTitle,
                                    Phone = contact.Phone,
                                    MobilePhone = contact.MobilePhone,
                                    Fax = contact.Fax,
                                    Email = contact.Email,
                                    ContactNote = contact.ContactNote
                                }).ToList();
                


            }
        }

        // 根據 SearchBox 的文字進行篩選
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string filterText = SearchBox.Text.Trim(); // 取得輸入的關鍵字

            // 檢查是否輸入了內容
            if (!string.IsNullOrEmpty(filterText))
            {
                // 根據客戶編號或客戶名稱進行篩選
                var filteredList = combinedList.Where(c =>
                    c.Customer.Contains(filterText, StringComparison.OrdinalIgnoreCase) ||
                    c.CustName.Contains(filterText, StringComparison.OrdinalIgnoreCase)).ToList();

                // 在 UI 中顯示篩選後的結果 (例如，更新 DataGridView)
                UpdateDataGridView(filteredList);
            }
            else
            {
                // 如果文字框為空白，顯示所有客戶
                UpdateDataGridView(combinedList);
                
            }
        }

        // 更新 DataGridView (假設你的 UI 使用 DataGridView 顯示資料)
        private void UpdateDataGridView(List<CombinedCustomerContact> list)
        {
            dataGridView1.DataSource = null;  // 清除現有資料
            dataGridView1.DataSource = list;  // 更新為新的資料來源
            // 設定標題名稱為中文
            dataGridView1.Columns["Customer"].HeaderText = "客戶編號";
            dataGridView1.Columns["CustName"].HeaderText = "客戶名稱";
            dataGridView1.Columns["IndustryRemark"].HeaderText = "產業別";
            dataGridView1.Columns["Address"].HeaderText = "地址";
            dataGridView1.Columns["WebSite"].HeaderText = "網址";
            dataGridView1.Columns["CustStatus"].HeaderText = "客戶狀態";
            dataGridView1.Columns["CSR"].HeaderText = "權責員工";
            dataGridView1.Columns["SME"].HeaderText = "SM維護工程師";
            dataGridView1.Columns["SFE"].HeaderText = "SF維護工程師";
            dataGridView1.Columns["GSTNo"].HeaderText = "統一編號";
            dataGridView1.Columns["NOE"].HeaderText = "員工人數";
            dataGridView1.Columns["AOC"].HeaderText = "資本額 (單位：億)";
            dataGridView1.Columns["Remark"].HeaderText = "備註";
            dataGridView1.Columns["System"].HeaderText = "系統";
            dataGridView1.Columns["SystemRemark"].HeaderText = "系統備註";
            dataGridView1.Columns["PrimaryContact"].HeaderText = "聯絡人";
            dataGridView1.Columns["Department"].HeaderText = "部門";
            dataGridView1.Columns["JobTitle"].HeaderText = "職稱";
            dataGridView1.Columns["Phone"].HeaderText = "電話";
            dataGridView1.Columns["MobilePhone"].HeaderText = "行動電話";
            dataGridView1.Columns["Fax"].HeaderText = "傳真";
            dataGridView1.Columns["Email"].HeaderText = "信箱";
            dataGridView1.Columns["ContactNote"].HeaderText = "聯絡人備註";
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 確保點擊的是有效的資料行而非標題列
            if (e.RowIndex >= 0)
            {
                // 取得被雙擊行的資料
                var selectedCustomer = (CombinedCustomerContact)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // 打開新表單並將選定的資料傳遞給新表單
                Form formupdate = new FormUpdate(selectedCustomer);
                formupdate.ShowDialog();
            }
        }

      

      
    }
}
