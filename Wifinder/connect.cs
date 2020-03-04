using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Diagnostics;

namespace Wifinder
{
    public partial class connect : Form
    {
        public connect()
        {
            InitializeComponent();
        }

        private void connect_Load(object sender, EventArgs e)
        {

            

            WlanClient client = new WlanClient();
            //  WlanClient.WlanInterface wlanIface = client.Interfaces.FirstOrDefault();

            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {

                if (wlanIface == null)
                {
                    Console.WriteLine("No Wifi Interface available!");
                    throw new Exception("No Wifi Interface available!");
                }

                // Lists all available networks
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in networks)
                {

                    //  Console.WriteLine("Found network with SSID {0} || Secured : {1}.", GetStringForSSID(network.dot11Ssid),network.securityEnabled);
                }

                string profileName = "AVANTAJ";
                string ssid = profileName;
                byte[] ssidBytes = Encoding.Default.GetBytes(ssid);
                string ssidHex = BitConverter.ToString(ssidBytes);
                ssidHex = ssidHex.Replace("-", "");
                string key = "1a2a3a4a5a";

                string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><hex>{1}</hex><name>{0}</name></SSID></SSIDConfig><connectionType>ESS</connectionType><MSM><security><authEncryption><authentication>open</authentication><encryption>WEP</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>networkKey</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey><keyIndex>0</keyIndex></security></MSM></WLANProfile>", ssid, ssidHex, key);

                try
                {
                    wlanIface.SetProfile(Wlan.WlanProfileFlags.AllUser, profileXml, true);
                    wlanIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, profileName);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error Occured!");
                    //throw;
                }

                int timeout = 3000;
                while (wlanIface.InterfaceState.ToString() == "Connected" && timeout >= 0)
                {
                    label1.Text = "Bağlantı Yapıldı";
                    System.Threading.Thread.Sleep(500);
                    timeout -= 500;
                }

                Console.WriteLine(wlanIface.InterfaceState.ToString() + wlanIface);
                //Console.WriteLine(wlanIface.CurrentConnection.profileName +" "+ wlanIface.InterfaceState.ToString());
            }
        }
    }
}
