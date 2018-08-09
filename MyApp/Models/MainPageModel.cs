using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.Networking;
using Windows.Networking.Connectivity;

namespace MyApp.Models
{
    public class MainPageModel
    {
        private ObservableCollection<string> _CollectionHostNameString;

        public string UserInfo { get; set; }
        public ObservableCollection<string> HostNames { get => _CollectionHostNameString; }
        public string ProfileName => NetworkInformation.GetInternetConnectionProfile()?.ProfileName;
        public string TZDisplayName => TimeZoneInfo.Local.DisplayName;
        public string OSVersion { get; set; }
        public String DeviceFamily { get; set; }

        public MainPageModel()
        {
            _CollectionHostNameString = new ObservableCollection<string>();
            IReadOnlyList<Windows.Networking.HostName> listHostName = NetworkInformation.GetHostNames();     // Capture all current HostNames for my machine
            foreach (HostName hn in listHostName) { _CollectionHostNameString.Add(hn.CanonicalName); }

            Windows.System.Profile.AnalyticsVersionInfo versioninfo = Windows.System.Profile.AnalyticsInfo.VersionInfo;
            string deviceFamilyVersion = versioninfo.DeviceFamilyVersion;
            ulong version = ulong.Parse(deviceFamilyVersion);
            ulong major = (version & 0xFFFF000000000000L) >> 48;
            ulong minor = (version & 0x0000FFFF00000000L) >> 32;
            ulong build = (version & 0x00000000FFFF0000L) >> 16;
            ulong revision = (version & 0x000000000000FFFFL);
            var osVersion = $"{major}.{minor}.{build}.{revision}";
            OSVersion = osVersion.ToString();
            DeviceFamily = versioninfo.DeviceFamily;

        }

    }
}
