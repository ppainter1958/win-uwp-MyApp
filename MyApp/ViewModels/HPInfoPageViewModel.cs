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

namespace MyApp.ViewModels
{
    public class HPInfoPageViewModel
    {
        public string LabelFullName = "Full Name:";
        public string FullName { get; set; }

        public HPInfoPageViewModel()
        {
            FullName = "Not Available";
        }
        public string GetFullName()
        {
            try
            {
                Task<string> task = UserInfoHelper.GetFullNameAsync();
                FullName = task.Result;
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
