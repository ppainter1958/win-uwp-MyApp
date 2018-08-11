using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace MyApp.Models
{
    public class HPIDModel
    {
        private List<HPIDUserInfo> ListHPIDUserInfo { get; set; }

        public HPIDModel()
        {
            ListHPIDUserInfo = new List<HPIDUserInfo>();
            HPIDUserInfo oHPIDUI = new HPIDUserInfo()
            {
                UserInfoID = "Test UserInfoID",
                Status = "Test Status",
                AuthorizeURI = "Testing 1 2 3"
            };
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(HPIDUserInfo));
            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, oHPIDUI);
            msObj.Position = 0;

            StreamReader sr = new StreamReader(msObj);
            string json = sr.ReadToEnd();
            sr.DiscardBufferedData();
            msObj.Dispose();

        }

    }
}
