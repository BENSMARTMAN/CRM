using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class ColumnConfiguration
    {
        public string ConfigName { get; set; }        // 配置名稱，用來識別不同的設定集

        // 這些屬性對應到每個欄位的顯示設定（1: 顯示, 0: 隱藏）
        public bool Customer { get; set; }
        public bool CustName { get; set; }
        public bool IndustryRemark { get; set; }
        public bool Address { get; set; }
        public bool WebSite { get; set; }
        public bool CustStatus { get; set; }
        public bool CSR { get; set; }
        public bool SME { get; set; }
        public bool SFE { get; set; }
        public bool GSTNo { get; set; }
        public bool NOE { get; set; }
        public bool AOC { get; set; }
        public bool Remark { get; set; }
        public bool System { get; set; }
        public bool SystemRemark { get; set; }
        public bool PrimaryContact { get; set; }
        public bool Department { get; set; }
        public bool JobTitle { get; set; }
        public bool Phone { get; set; }
        public bool MobilePhone { get; set; }
        public bool Fax { get; set; }
        public bool Email { get; set; }
        public bool ContactNote { get; set; }
    }
}
