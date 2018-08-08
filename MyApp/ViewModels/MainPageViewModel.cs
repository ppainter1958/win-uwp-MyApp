using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.System;
using Windows.Networking;
using Windows.Foundation.Collections;
using System.Threading.Tasks;
using MyApp.Models;


namespace MyApp.ViewModels
{
    public class MainPageViewModel  : NotificationBase<MainPageModel>
    {
        public string LabelUserInfo = "User Info:";
        public string LabelHostNames = "HostNames:";
        public string LabelProfileName = "NetworkAdapter Profile:";
        public string LabelCurrentTimeZone = "Current Timezone:";
        public string LabelOSVersion = "OS Major.Minor.Build.Revision:";
        public string LabelDeviceFamily = "Device Family:";
        public string UserInfo
        {
            get { return This.UserInfo; }
            set { SetProperty(This.UserInfo, value, () => This.UserInfo = value); }
        }

        public ObservableCollection<string> HostNames { get => MainPageModel.HostNames; }
        public string ProfileName => MainPageModel.ProfileName;
        public int HostNamesCount => MainPageModel.HostNames.Count;
        public string TZDisplayName => MainPageModel.TZDisplayName;
        public string OSVerion  => MainPageModel.OSVersion; 
        public String DeviceFamily => MainPageModel.DeviceFamily; 

        public MainPageModel MainPageModel { get ; set; }
        public MainPageViewModel()
        {
            this.MainPageModel = new MainPageModel();
        }

        public async Task<string>  GetUserInfoAsync()
        {
            IReadOnlyList<User> users = await User.FindAllAsync();
            User user = users[0];
            // Build a list of all the properties we want.
            String[] desiredProperties = new String[]
            {
                        KnownUserProperties.FirstName,
                        KnownUserProperties.LastName,
                        KnownUserProperties.DomainName,
            };
            // Issue a bulk query for all of the properties.
            IPropertySet values = await user.GetPropertiesAsync(desiredProperties);
            return (string)values[KnownUserProperties.FirstName] + " " + (string)values[KnownUserProperties.LastName] + " " + (string)values[KnownUserProperties.DomainName];
        }
    }
}
