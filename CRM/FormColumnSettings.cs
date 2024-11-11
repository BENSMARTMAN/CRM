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
    public partial class FormColumnSettings : Form
    {
        public FormColumnSettings()
        {
            InitializeComponent();
        }


        // 從資料庫載入欄位配置
        private void LoadColumnConfiguration(string configName)
        {
            using (var connection = DatabaseHelper.GetDatabaseConnection())
            {
                string selectQuery = "SELECT * FROM ColumnConfigurations WHERE ConfigName = @ConfigName";
                var columnConfig = connection.QueryFirstOrDefault<ColumnConfiguration>(selectQuery, new { ConfigName = configName });

                if (columnConfig != null)
                {
                    SetColumnVisibility(columnConfig);
                }
            }
        }

        // 獲取已選欄位的可見性
        private Dictionary<string, bool> GetColumnVisibility()
        {
            var visibility = new Dictionary<string, bool>();
            foreach (var item in checkedListBox.Items)
            {
                string columnName = item.ToString();
                visibility[columnName] = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(columnName));
            }
            return visibility;
        }

        // 設置欄位的可見性
        private void SetColumnVisibility(ColumnConfiguration config)
        {
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("客戶編號"), config.Customer);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("客戶名稱"), config.CustName);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("產業別"), config.IndustryRemark);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("地址"), config.Address);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("網址"), config.WebSite);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("客戶狀態"), config.CustStatus);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("權責員工"), config.CSR);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("SM維護工程師"), config.SME);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("SF維護工程師"), config.SFE);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("統一編號"), config.GSTNo);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("員工人數"), config.NOE);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("資本額 (單位：億)"), config.AOC);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("備註"), config.Remark);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("系統"), config.System);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("系統備註"), config.SystemRemark);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("主要聯絡人"), config.PrimaryContact);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("部門"), config.Department);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("職稱"), config.JobTitle);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("電話"), config.Phone);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("行動電話"), config.MobilePhone);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("傳真"), config.Fax);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("Email"), config.Email);
            checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf("聯絡人備註"), config.ContactNote);
        }

        // 按鈕事件處理
        private void btnSelectAll_Click(object sender, EventArgs e) => SetAllChecked(true);
        private void btnDeselectAll_Click(object sender, EventArgs e) => SetAllChecked(false);

        private void SetAllChecked(bool isChecked)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, isChecked);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfigName.Text))
            {
                MessageBox.Show("請輸入欄位組合名稱", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string configName = txtConfigName.Text;

            try
            {
                using (var connection = DatabaseHelper.GetDatabaseConnection())
                {
                    // 檢查資料庫中是否已經存在相同的配置名稱
                    string checkQuery = "SELECT COUNT(*) FROM ColumnConfigurations WHERE ConfigName = @ConfigName";
                    int existingConfigCount = connection.ExecuteScalar<int>(checkQuery, new { ConfigName = configName });

                    if (existingConfigCount > 0)
                    {
                        MessageBox.Show("已有相同名稱的組合，請使用其他名稱。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 如果沒有重複，則進行插入操作
                    string insertQuery = @"
    INSERT INTO ColumnConfigurations (ConfigName, Customer, CustName, IndustryRemark, Address, WebSite, CustStatus, 
        CSR, SME, SFE, GSTNo, NOE, AOC, Remark, System, SystemRemark, PrimaryContact, Department, JobTitle, 
        Phone, MobilePhone, Fax, Email, ContactNote)
    VALUES (@ConfigName, @Customer, @CustName, @IndustryRemark, @Address, @WebSite, @CustStatus, @CSR, @SME, @SFE, 
        @GSTNo, @NOE, @AOC, @Remark, @System, @SystemRemark, @PrimaryContact, @Department, @JobTitle, @Phone, 
        @MobilePhone, @Fax, @Email, @ContactNote)";

                    var columnVisibility = GetColumnVisibility();

                    // 確保 GetColumnVisibility() 返回正確的 Dictionary
                    if (columnVisibility == null)
                    {
                        MessageBox.Show("欄位顯示設定錯誤，請檢查 GetColumnVisibility 方法", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 執行插入操作
                    connection.Execute(insertQuery, new
                    {
                        ConfigName = configName,
                        Customer = columnVisibility["客戶編號"],
                        CustName = columnVisibility["客戶名稱"],
                        IndustryRemark = columnVisibility["產業別"],
                        Address = columnVisibility["地址"],
                        WebSite = columnVisibility["網址"],
                        CustStatus = columnVisibility["客戶狀態"],
                        CSR = columnVisibility["權責員工"],
                        SME = columnVisibility["SM維護工程師"],
                        SFE = columnVisibility["SF維護工程師"],
                        GSTNo = columnVisibility["統一編號"],
                        NOE = columnVisibility["員工人數"],
                        AOC = columnVisibility["資本額 (單位：億)"],
                        Remark = columnVisibility["備註"],
                        System = columnVisibility["系統"],
                        SystemRemark = columnVisibility["系統備註"],
                        PrimaryContact = columnVisibility["主要聯絡人"],
                        Department = columnVisibility["部門"],
                        JobTitle = columnVisibility["職稱"],
                        Phone = columnVisibility["電話"],
                        MobilePhone = columnVisibility["行動電話"],
                        Fax = columnVisibility["傳真"],
                        Email = columnVisibility["Email"],
                        ContactNote = columnVisibility["聯絡人備註"]
                    });

                    // 更新 ListBox 中的項目
                    if (!listBoxConfigNames.Items.Contains(configName))
                    {
                        listBoxConfigNames.Items.Add(configName);
                    }

                    MessageBox.Show("配置已儲存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // 輸出詳細錯誤訊息
                MessageBox.Show($"儲存配置時發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxConfigNames_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxConfigNames.SelectedItem == null) return;

            string configName = listBoxConfigNames.SelectedItem.ToString();
            LoadColumnConfiguration(configName);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 == null)
            {
                MessageBox.Show("無法找到主頁面 (Form1) 的實例。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedColumns = new List<string>();
            foreach (var item in checkedListBox.CheckedItems)
            {
                selectedColumns.Add(item.ToString());
            }

            form1.UpdateDataGridViewColumns(selectedColumns);
            this.Close(); // 關閉設定視窗
        }
        private void FormColumnSettings_Load(object sender, EventArgs e)
        {
            LoadConfigNames();
        }

        private void LoadConfigNames()
        {
            try
            {
                using (var connection = DatabaseHelper.GetDatabaseConnection())
                {
                    // 查詢所有已儲存的配置名稱
                    string query = "SELECT ConfigName FROM ColumnConfigurations";
                    var configNames = connection.Query<string>(query);

                    // 清除 listBox 中的現有項目，並新增新查詢到的項目
                    listBoxConfigNames.Items.Clear();
                    foreach (var name in configNames)
                    {
                        listBoxConfigNames.Items.Add(name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入配置名稱時發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // 確認使用者是否有選取要刪除的組合名稱
            if (listBoxConfigNames.SelectedItem == null)
            {
                MessageBox.Show("請選取要刪除的組合名稱。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 獲取選取的配置名稱
            string configName = listBoxConfigNames.SelectedItem.ToString();

            // 確認是否刪除
            DialogResult result = MessageBox.Show($"確定要刪除組合 '{configName}' 嗎？", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var connection = DatabaseHelper.GetDatabaseConnection())
                    {
                        // 從資料庫中刪除選取的配置名稱
                        string deleteQuery = "DELETE FROM ColumnConfigurations WHERE ConfigName = @ConfigName";
                        connection.Execute(deleteQuery, new { ConfigName = configName });
                    }

                    // 從 listBox 中移除刪除的組合名稱
                    listBoxConfigNames.Items.Remove(configName);

                    MessageBox.Show("組合已刪除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"刪除組合時發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
