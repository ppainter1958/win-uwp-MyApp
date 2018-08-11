using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    [DataContract]
    public class HPIDUserInfo
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserInfoID { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string AuthorizeURI { get; set; }
        [DataMember]
        public string AuthorizeCall { get; set; }
        [DataMember]
        public string TokenURI { get; set; }
        [DataMember]
        public string GrantType { get; set; }
        [DataMember]
        public string RedirectURI { get; set; }
        [DataMember]
        public string ResponseType { get; set; }
        [DataMember]
        public string ClientID { get; set; }
        [DataMember]
        public string ClientSecret { get; set; }
        [DataMember]
        public string UserB64 { get; set; }
        [DataMember]
        public string Scope { get; set; }
        [DataMember]
        public string Prompt { get; set; }
        [DataMember]
        public string Nonce { get; set; }
        [DataMember]
        public string State { get; set; }


    }
}
