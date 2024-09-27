using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CombinedCustomerContact
    {
        public string Customer { get; set; } = ""; // 客戶編號
        public string CustName { get; set; } = ""; // 客戶名稱
        public string IndustryRemark { get; set; } = ""; // 產業別
        public string Address { get; set; } = ""; // 地址
        public string WebSite { get; set; } = ""; // 網址
        public string CustStatus { get; set; } = ""; // 客戶狀態
        public string CSR { get; set; } = ""; // 權責員工
        public string SME { get; set; } = ""; // SM 維護工程師
        public string SFE { get; set; } = ""; // SF 維護工程師
        public string GSTNo { get; set; } = ""; // 統一編號
        public int NOE { get; set; } // 員工人數
        public decimal AOC { get; set; } // 資本額 (單位：億)
        public string Remark { get; set; } = ""; // 備註
        public string System { get; set; } = ""; // 系統
        public string SystemRemark { get; set; } = ""; // 系統備註
        public string PrimaryContact { get; set; } = "";  // 聯絡人
        public string Department { get; set; } = "";      // 部門
        public string JobTitle { get; set; } = "";       // 職稱
        public string Phone { get; set; } = "";          // 電話
        public string Fax { get; set; } = "";           // 傳真
        public string MobilePhone { get; set; } = "";   // 行動電話
        public string Email { get; set; } = "";          // Email
        public string ContactNote { get; set; } = "";    // 聯絡人備註
    }
}
