using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerContact
    {
        public string Customer { get; set; }      // 客戶編號
        public string CustName { get; set; }       // 客戶名稱
        public string PrimaryContact { get; set; }  // 聯絡人
        public string Department { get; set; }      // 部門
        public string JobTitle { get; set; }        // 職稱
        public string Phone { get; set; }           // 電話
        public string Fax { get; set; }             // 傳真
        public string MobilePhone { get; set; }     // 行動電話
        public string Email { get; set; }           // Email
        public string ContactNote { get; set; }     // 聯絡人備註
        public char IsPrimaryContact { get; set; }  // 是否為主要聯絡人
    }
}
