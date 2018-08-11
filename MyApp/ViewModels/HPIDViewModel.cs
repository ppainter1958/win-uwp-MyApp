using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class HPIDViewModel
    {
        private HPIDModel HPIDModel { get; set; }

        public string HPIDUserInfoID { get; set; }
        public HPIDViewModel ()
        {
            HPIDModel = new HPIDModel();
            HPIDUserInfoID = "UserInfoID01";
        }
    }
}
