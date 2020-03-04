using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Principal;
using System.Diagnostics;
namespace Wifinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process yeniprogress = new Process();
        OleDbConnection baglan=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\data\\data.mdb");
        OleDbCommand komut = new OleDbCommand();
        string essid="";
        string pass="";
        string sira = "";
        private void wifinder_list()
        {
            listwifi.Items.Clear();
            baglan.Open();
            OleDbCommand cek = new OleDbCommand("Select *From wıfı",baglan);
            OleDbDataReader oku = cek.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem item = new ListViewItem();
                
                item.Text = oku["sira"].ToString();
                item.SubItems.Add(oku["essıd"].ToString());
                item.SubItems.Add(oku["pass"].ToString());
                item.SubItems.Add(oku["datetıme"].ToString());
                listwifi.Items.Add(item);
            }
            baglan.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            control.Enabled = true;
            control.Start();
           

           
            wifinder_list();

         
        }

     
        private void listwifi_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listwifi_DoubleClick(object sender, EventArgs e)
        {
           
                textessid.Text = listwifi.SelectedItems[0].SubItems[1].Text;
                essid = listwifi.SelectedItems[0].SubItems[1].Text;
                textpass.Text = listwifi.SelectedItems[0].SubItems[2].Text;
                pass = listwifi.SelectedItems[0].SubItems[2].Text;
                lbdatetime.Text = listwifi.SelectedItems[0].SubItems[3].Text;
               sira = listwifi.SelectedItems[0].SubItems[0].Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textpass.Text = "";
            textessid.Text = "";
            sira = "";
            essid = "";
            pass = "";
        }

        private void btnconnect_MouseMove(object sender, MouseEventArgs e)
        {
            btnconnect.ForeColor = Color.OliveDrab;
            
        }

        private void control_Tick(object sender, EventArgs e)
        {
            if (textfind.Text == "Ara : Essid" || textfind.Text=="")
            {
                btnfind2.Enabled = false;
            }
            else
            {
                btnfind2.Enabled = true;
            }
            lbtotal.Text = listwifi.Items.Count.ToString();
            if (textessid.TextLength >= 3 && textpass.TextLength > 6)
            {
                btnsave.Enabled = true;
                btnconnect.Enabled = true;
              //  btndelete.Enabled = true;
                btntest.Enabled = true;
              //  btnupdate.Enabled = true;
            }
            else
            {

                btnsave.Enabled = false;
                btnconnect.Enabled = false;
              //  btndelete.Enabled = false;
                btntest.Enabled = false;
               // btnupdate.Enabled = false;
            }
            if (textessid.Text != "" || textpass.Text != "")
            {
                btnclear.Enabled = true;
            }
            else
            {
                btnclear.Enabled = false;
            }
            if (essid != "" && pass != "")
            {
                if (textessid.Text==essid  && textpass.Text==pass)
                {
                    btndelete.Enabled = true;
                }
            }
            else
            {
                btndelete.Enabled = false;
            }
            if (textessid.TextLength>=3 && textessid.Text!=essid && essid != "" || textpass.TextLength>6 && textpass.Text!=pass && pass != "")
            {
                btnupdate.Enabled = true;
            }
            else
            {
                btnupdate.Enabled = false;
            }
            
        
        }

        private void btnconnect_MouseLeave(object sender, EventArgs e)
        {
            btnconnect.ForeColor = Color.Black;
        }

        private void btnsave_MouseMove(object sender, MouseEventArgs e)
        {
            btnsave.ForeColor = Color.DarkSlateGray;
        }

        private void btnsave_MouseLeave(object sender, EventArgs e)
        {
            btnsave.ForeColor = Color.Black;
        }

        private void btnfind_MouseMove(object sender, MouseEventArgs e)
        {
            btnfind.ForeColor = Color.SteelBlue;
        }

        private void btnfind_MouseLeave(object sender, EventArgs e)
        {
            btnfind.ForeColor = Color.Black;
        }

        private void btnclear_MouseMove(object sender, MouseEventArgs e)
        {
            btnclear.ForeColor = Color.SteelBlue;
        }

        private void btnclear_MouseLeave(object sender, EventArgs e)
        {
            btnclear.ForeColor = Color.Black;
        }

        private void btnupdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnupdate.ForeColor = Color.OliveDrab;
        }

        private void btnupdate_MouseLeave(object sender, EventArgs e)
        {
            btnupdate.ForeColor = Color.Black;
        }

        private void btntest_MouseMove(object sender, MouseEventArgs e)
        {
            btntest.ForeColor = Color.Olive;
        }

        private void btntest_MouseLeave(object sender, EventArgs e)
        {
            btntest.ForeColor = Color.Black;
        }

        private void btndelete_MouseMove(object sender, MouseEventArgs e)
        {
            btndelete.ForeColor = Color.Maroon;
        }

        private void btndelete_MouseLeave(object sender, EventArgs e)
        {
            btndelete.ForeColor = Color.Black;
        }

        private void btnrefresh_MouseMove(object sender, MouseEventArgs e)
        {
            btnrefresh.ForeColor = Color.OliveDrab;
        }

        private void btnrefresh_MouseLeave(object sender, EventArgs e)
        {
            btnrefresh.ForeColor = Color.Black;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult güncelleme = new DialogResult();
            güncelleme = MessageBox.Show("" + essid + " adlı kaydı güncellemek istediğinize emin misiniz ?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (güncelleme == DialogResult.Yes)
            {
                try
                {
                baglan.Open();
                OleDbCommand sill = new OleDbCommand("update wıfı set essıd='" + textessid.Text + "',pass='" + textpass.Text + "',datetıme=" + DateTime.Now.ToString() + "'where sira = '" + sira + "')", baglan);
                sill.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Güncelleme işlemi başarılı...", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (güncelleme == DialogResult.No)
            { }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            wifinder_list();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult kaydet = new DialogResult();
            kaydet = MessageBox.Show("Yeni bir ağı kayıt etmek istediğinizden emin misiniz ?", "KAYIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kaydet==DialogResult.Yes)
            {
                try
                {
                   
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("Insert Into wıfı (essıd,pass,datetıme) values ('" + textessid.Text.ToString() + "','" + textpass.Text.ToString() + "','" + DateTime.Now.ToString() + "')", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Kayıt işlemi başarılı...", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnclear.PerformClick();
                    wifinder_list();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (kaydet == DialogResult.No)
            { }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show(""+essid+" adlı ağı silmek istediğinizden emin misiniz ?", "SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                try
                {
                   
                    baglan.Open();
                    OleDbCommand silme = new OleDbCommand("delete from wıfı where sira = "+sira+"",baglan);
                    silme.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Silme işlemi başarılı...", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnclear.PerformClick();
                    wifinder_list();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (sil == DialogResult.No)
                { }
            }
        }

        private void btnfind2_Click(object sender, EventArgs e)
        {
            listwifi.Items.Clear();
            baglan.Open();
            OleDbCommand arastir = new OleDbCommand("select *from wıfı where essıd like '%" + textfind.Text + "%'", baglan);
            OleDbDataReader bul = arastir.ExecuteReader();
            while (bul.Read())
            {
                ListViewItem itemler = new ListViewItem();
                itemler.Text = bul["sira"].ToString();
                itemler.SubItems.Add(bul["essıd"].ToString());
                itemler.SubItems.Add(bul["pass"].ToString());
                itemler.SubItems.Add(bul["datetıme"].ToString());
                listwifi.Items.Add(itemler);

            }
            baglan.Close();
        }

        private void textfind_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void textfind_MouseLeave(object sender, EventArgs e)
        {

           
        }

        private void textfind_Click(object sender, EventArgs e)
        {
            if (textfind.Text == "Ara : Essid")
            {
                textfind.Font = new Font("Microsoft Sand Serif", 10, FontStyle.Regular);
                textfind.ForeColor = Color.Black;
                textfind.Text = "";
            }
            else
            { }
            }

        private void textfind_Leave(object sender, EventArgs e)
        {
            if (textfind.Text == "")
            {
                  textfind.Font = new Font("Microsoft Sand Serif", 10, FontStyle.Italic);
                  textfind.Text = "Ara : Essid";
                  textfind.ForeColor = Color.Gray;
                
            }
            else
            {
             
               
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
        

        }

        private void btntest_Click(object sender, EventArgs e)
        {

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            Wifis tara = new Wifis();
            tara.Show();
            this.Hide();
        }


        
    }
}
