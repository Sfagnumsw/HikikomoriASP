using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperClass
{
    public class Config // перенос конфига в модель из Json файла, чтобы было проще подключать
    {
        public static string ConnectionString { get; set; }
        public static string ProjectName { get; set; }
        public static string ShortCompanyName { get; set; }
        public static string CompanyName { get; set; }
        public static string Email { get; set; }
    }
}
