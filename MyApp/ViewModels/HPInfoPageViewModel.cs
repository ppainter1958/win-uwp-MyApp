using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.System;
using Windows.Networking;
using Windows.Foundation.Collections;
using System.Threading.Tasks;
using Hp.Bridge.Client.SDKs.UserInfoSDK;
using Hp.Bridge.Client.Exceptions;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class HPInfoPageViewModel : NotificationBase<HPInfoPageModel>
    {
        public string LabelFullName = "Full Name:";
        public string FullName
        {
            get { return This.FullName; }
            set { SetProperty(This.FullName, value, () => This.FullName = value); }
        }

        private HPInfoPageModel HPInfoPageModel { get; set; }

        public HPInfoPageViewModel()
        {
            HPInfoPageModel = new HPInfoPageModel();
        }
        public async Task<string> GetFullName()
        {
            try
            {
                string fullName = await UserInfoHelper.GetFullNameAsync();
                FullName = fullName;
            } 
            catch (Hp.Bridge.Client.Exceptions.HsaClientException e)
            {
                // This was expected
                FullName = "HsaClientException: " + e.Message;
            }
            catch (System.AggregateException e) when  (e.InnerException is Hp.Bridge.Client.Exceptions.HsaClientException)
            {
                // This is what happened
                FullName = "AggregateException->HsaClientException: " + e.InnerException.Message;
            }
            catch (Exception e)
            {
                FullName = e.GetType().ToString() + ": " + e.Message;
            }
            return FullName;
        }
    }
}
