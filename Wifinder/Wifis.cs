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
    public partial class Wifis : Form
    {
        public Wifis()
        {
            InitializeComponent();
        }
        string essid = "";
        string sifreleme = "";
        string tür = "";
        string macaddress="";
        string kanal = "";
        string band = "";
        string device = "";
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            WlanClient client = new WlanClient();
            try
            {
                foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
                {
                    Wlan.WlanAvailableNetwork[] networkss = wlanIface.GetAvailableNetworkList(0);
                    foreach (Wlan.WlanAvailableNetwork networkk in networkss)
                    {


                        sifreleme = networkk.dot11DefaultCipherAlgorithm.ToString();
                        tür = networkk.dot11DefaultAuthAlgorithm.ToString();


                    }
                }
            }
            catch { }
            try
            {
                foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
                {



                    Wlan.WlanBssEntry[] wlanBssEntries = wlanIface.GetNetworkBssList();
                    Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                    foreach (Wlan.WlanBssEntry network in wlanBssEntries)
                    {
                        int rss = network.rssi;
                        byte[] macAddr = network.dot11Bssid;
                        string tMac = "";
                        for (int i = 0; i < macAddr.Length; i++)
                        {
                            if (i > 1)
                            {
                                tMac += ":" + macAddr[i].ToString("x2").PadLeft(2, '0').ToUpper();
                            }
                            if (i < 1)
                            {
                                tMac += macAddr[i].ToString("x2").PadLeft(2, '0').ToUpper();
                            }
                            
                            band = network.chCenterFrequency.ToString();
                            band = band.Remove(2, 5);
                           
                        }

                        Wlan.Dot11Ssid ssid = network.dot11Ssid;
                        string networkname = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);

                        if (networkname == "")
                        {
                            ////////////////////////////////////////////////////////////////////////////////////////
                            ListViewItem itemler = new ListViewItem("* Gizli Ağ");
                            if (network.linkQuality <= 15)
                            {
                                itemler.ImageIndex = 0;
                            }
                            if (network.linkQuality > 15 && network.linkQuality <= 45)
                            {
                                itemler.ImageIndex = 1;
                            }
                            if (network.linkQuality > 45 && network.linkQuality <= 60)
                            {
                                itemler.ImageIndex = 2;
                            }
                            if (network.linkQuality > 60 && network.linkQuality <= 80)
                            {
                                itemler.ImageIndex = 3;
                            }
                            if (network.linkQuality > 80 && network.linkQuality <= 100)
                            {
                                itemler.ImageIndex = 4;
                            }
                            itemler.SubItems.Add(tMac);
                            itemler.SubItems.Add("2");
                            itemler.SubItems.Add(tür);
                            itemler.SubItems.Add(sifreleme);
                            itemler.SubItems.Add(network.dot11BssType.ToString());
                            itemler.SubItems.Add(rss.ToString() + " dbm");
                            itemler.SubItems.Add(network.linkQuality + " %");
                            itemler.SubItems.Add(band+" Ghz");
                            itemler.SubItems.Add(device);
                            listView1.Items.Add(itemler);
                            //////////////////////////////////////////////////////////////////////////////////////
                        }
                        else
                        {
                            //////////////////////////////////////////////////////////////////////////////////////
                            ListViewItem itemler = new ListViewItem(networkname);

                            if (network.linkQuality <= 15)
                            {
                                itemler.ImageIndex = 0;
                            }
                            if (network.linkQuality > 15 && network.linkQuality <= 45)
                            {
                                itemler.ImageIndex = 1;
                            }
                            if (network.linkQuality > 45 && network.linkQuality <= 60)
                            {
                                itemler.ImageIndex = 2;
                            }
                            if (network.linkQuality > 60 && network.linkQuality <= 80)
                            {
                                itemler.ImageIndex = 3;
                            }
                            if (network.linkQuality > 80 && network.linkQuality <= 100)
                            {
                                itemler.ImageIndex = 4;
                            }
                            itemler.SubItems.Add(tMac);
                            itemler.SubItems.Add(kanal);
                            itemler.SubItems.Add(tür);
                            itemler.SubItems.Add(sifreleme);
                            itemler.SubItems.Add(network.dot11BssType.ToString());
                            itemler.SubItems.Add(rss.ToString() + " dbm");
                            itemler.SubItems.Add(network.linkQuality + " %");
                            itemler.SubItems.Add(band+" Ghz");                            listView1.Items.Add(itemler);
                            //////////////////////////////////////////////////////////////////////////////////////
                        }

                    }
                }
            }
            catch { }

        }
        private void Wifis_Load(object sender, EventArgs e)
        {
            foreach (NetworkInterface id in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (id.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {

                    if (id.Name == "")
                    {
                        MessageBox.Show("Yüklü bir kablosuz ağ kartı bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        comboBox1.Items.Add(id.Name);
                        comboBox1.Text = comboBox1.Items[0].ToString();
                    }
                }
            }
     

        }

        private void control_Tick(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
            }
            lbcount.Text = listView1.Items.Count.ToString();
            if (essid != "")
            {
                textBox1.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                button3.Enabled = false;
            }
            if (checkBox1.Checked == true)
            {
                groupBox2.Enabled = false;
                automatic.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = true;
                automatic.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (NetworkInterface id in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (id.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    comboBox1.Items.Add(id.Name);
                    comboBox1.Text = comboBox1.Items[0].ToString();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            essid = listView1.SelectedItems[0].SubItems[0].Text;
            macaddress = listView1.SelectedItems[0].SubItems[1].Text;
           // textBox1.Text = essid;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect baglan = new connect();
            baglan.Show();
           
           
        }
        

        private void automatic_Tick(object sender, EventArgs e)
        {
       
            WlanClient client = new WlanClient();
           
            try
            {
                foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
                {
                   listView1.Items.Clear();
                        ///////////////////////////////////////////////////////////////////////////////////////
                        Wlan.WlanBssEntry[] wlanBssEntries = wlanIface.GetNetworkBssList();
                        Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                        foreach (Wlan.WlanBssEntry network in wlanBssEntries)
                        {

                            foreach (Wlan.WlanAvailableNetwork networkk in networks)
                            {
                                sifreleme = networkk.dot11DefaultCipherAlgorithm.ToString();
                                tür = networkk.dot11DefaultAuthAlgorithm.ToString();
                            }
                            int rss = network.rssi;
                            byte[] macAddr = network.dot11Bssid;
                            string tMac = "";
                            for (int i = 0; i < macAddr.Length; i++)
                            {
                                if (i > 1)
                                {
                                    tMac += ":" + macAddr[i].ToString("x2").PadLeft(2, '0').ToUpper();
                                }
                                if (i < 1)
                                {
                                    tMac += macAddr[i].ToString("x2").PadLeft(2, '0').ToUpper();
                                }

                            }
                            Wlan.Dot11Ssid ssid = network.dot11Ssid;
                            string networkname = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
                            ///////////////////////////////////////////////////////////////////////////////////
                           
                                if (networkname == "")
                                {
                                    ////////////////////////////////////////////////////////////////////////////////////////

                                    ListViewItem itemler = new ListViewItem("* Gizli Ağ");
                                    if (network.linkQuality <= 15)
                                    {
                                        itemler.ImageIndex = 0;
                                    }
                                    if (network.linkQuality > 15 && network.linkQuality <= 45)
                                    {
                                        itemler.ImageIndex = 1;
                                    }
                                    if (network.linkQuality > 45 && network.linkQuality <= 60)
                                    {
                                        itemler.ImageIndex = 2;
                                    }
                                    if (network.linkQuality > 60 && network.linkQuality <= 80)
                                    {
                                        itemler.ImageIndex = 3;
                                    }
                                    if (network.linkQuality > 80 && network.linkQuality <= 100)
                                    {
                                        itemler.ImageIndex = 4;
                                    }
                                    itemler.SubItems.Add(tMac);
                                    itemler.SubItems.Add("2");
                                    itemler.SubItems.Add(tür);
                                    itemler.SubItems.Add(sifreleme);
                                    itemler.SubItems.Add(network.dot11BssType.ToString());
                                    itemler.SubItems.Add(rss.ToString() + " dbm");
                                    itemler.SubItems.Add(network.linkQuality + " %");
                                    listView1.Items.Add(itemler);
                                  
                                    //////////////////////////////////////////////////////////////////////////////////////
                                }
                                else
                                {

                                    //////////////////////////////////////////////////////////////////////////////////////
                                    ListViewItem itemler = new ListViewItem(networkname);

                                    if (network.linkQuality <= 15)
                                    {
                                        itemler.ImageIndex = 0;
                                    }
                                    if (network.linkQuality > 15 && network.linkQuality <= 45)
                                    {
                                        itemler.ImageIndex = 1;
                                    }
                                    if (network.linkQuality > 45 && network.linkQuality <= 60)
                                    {
                                        itemler.ImageIndex = 2;
                                    }
                                    if (network.linkQuality > 60 && network.linkQuality <= 80)
                                    {
                                        itemler.ImageIndex = 3;
                                    }
                                    if (network.linkQuality > 80 && network.linkQuality <= 100)
                                    {
                                        itemler.ImageIndex = 4;
                                    }
                                    itemler.SubItems.Add(tMac);
                                    itemler.SubItems.Add("2");
                                    itemler.SubItems.Add(tür);
                                    itemler.SubItems.Add(sifreleme);
                                    itemler.SubItems.Add(network.dot11BssType.ToString());
                                    itemler.SubItems.Add(rss.ToString() + " dbm");
                                    itemler.SubItems.Add(network.linkQuality + " %");
                                    listView1.Items.Add(itemler);
                                    
                                    //////////////////////////////////////////////////////////////////////////////////////
                                }
                            }
                        }
                    }
                
            
            catch { }
        }

        private void Wifis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
        }
    }
}
