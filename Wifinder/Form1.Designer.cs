namespace Wifinder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.listwifi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btntest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.control = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbdatetime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textessid = new System.Windows.Forms.TextBox();
            this.textfind = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnfind2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Essıd : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pass : ";
            // 
            // textpass
            // 
            this.textpass.BackColor = System.Drawing.SystemColors.Control;
            this.textpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textpass.Location = new System.Drawing.Point(50, 126);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(170, 22);
            this.textpass.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textpass, "Wifi ağının şifresi.");
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.Transparent;
            this.btnconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconnect.ForeColor = System.Drawing.Color.Black;
            this.btnconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnconnect.Image")));
            this.btnconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconnect.Location = new System.Drawing.Point(48, 152);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(82, 23);
            this.btnconnect.TabIndex = 2;
            this.btnconnect.Text = "Bağlan   ";
            this.toolTip1.SetToolTip(this.btnconnect, "Belirlenmiş ağ kapsama alındayda bağlanmayı sağlar.");
            this.btnconnect.UseVisualStyleBackColor = false;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            this.btnconnect.MouseLeave += new System.EventHandler(this.btnconnect_MouseLeave);
            this.btnconnect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnconnect_MouseMove);
            // 
            // listwifi
            // 
            this.listwifi.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listwifi.BackColor = System.Drawing.SystemColors.Control;
            this.listwifi.BackgroundImageTiled = true;
            this.listwifi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listwifi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listwifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listwifi.ForeColor = System.Drawing.Color.Black;
            this.listwifi.FullRowSelect = true;
            this.listwifi.GridLines = true;
            this.listwifi.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listwifi.Location = new System.Drawing.Point(0, 251);
            this.listwifi.Name = "listwifi";
            this.listwifi.Size = new System.Drawing.Size(297, 242);
            this.listwifi.TabIndex = 10;
            this.toolTip1.SetToolTip(this.listwifi, "Wifi ağlarının barındırıldığı alan.");
            this.listwifi.UseCompatibleStateImageBehavior = false;
            this.listwifi.View = System.Windows.Forms.View.Details;
            this.listwifi.SelectedIndexChanged += new System.EventHandler(this.listwifi_SelectedIndexChanged);
            this.listwifi.DoubleClick += new System.EventHandler(this.listwifi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra";
            this.columnHeader1.Width = 32;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Essid";
            this.columnHeader2.Width = 123;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "tarih";
            this.columnHeader4.Width = 0;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefresh.ForeColor = System.Drawing.Color.Black;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrefresh.Location = new System.Drawing.Point(229, 203);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(66, 23);
            this.btnrefresh.TabIndex = 9;
            this.btnrefresh.Text = "Tazele     ";
            this.toolTip1.SetToolTip(this.btnrefresh, "Listeleme bölümünü yeniler.");
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            this.btnrefresh.MouseLeave += new System.EventHandler(this.btnrefresh_MouseLeave);
            this.btnrefresh.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnrefresh_MouseMove);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Transparent;
            this.btnfind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.ForeColor = System.Drawing.Color.Black;
            this.btnfind.Image = ((System.Drawing.Image)(resources.GetObject("btnfind.Image")));
            this.btnfind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfind.Location = new System.Drawing.Point(225, 98);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(68, 50);
            this.btnfind.TabIndex = 5;
            this.btnfind.Text = "Tara";
            this.btnfind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnfind, "Kapsama alanındaki wifi ağlarını taramanızı sağlar.");
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            this.btnfind.MouseLeave += new System.EventHandler(this.btnfind_MouseLeave);
            this.btnfind.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnfind_MouseMove);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.Location = new System.Drawing.Point(157, 203);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 23);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Sil   ";
            this.toolTip1.SetToolTip(this.btndelete, "Kayıt edilmiş ağı siler.");
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            this.btndelete.MouseLeave += new System.EventHandler(this.btndelete_MouseLeave);
            this.btndelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndelete_MouseMove);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.Location = new System.Drawing.Point(2, 203);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(77, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Güncelle   ";
            this.toolTip1.SetToolTip(this.btnupdate, "Daha önceden kayıt edilmiş bir ağı güncelleminizi sağlar.");
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            this.btnupdate.MouseLeave += new System.EventHandler(this.btnupdate_MouseLeave);
            this.btnupdate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnupdate_MouseMove);
            // 
            // btntest
            // 
            this.btntest.BackColor = System.Drawing.Color.Transparent;
            this.btntest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntest.ForeColor = System.Drawing.Color.Black;
            this.btntest.Image = ((System.Drawing.Image)(resources.GetObject("btntest.Image")));
            this.btntest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntest.Location = new System.Drawing.Point(85, 203);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(66, 23);
            this.btntest.TabIndex = 7;
            this.btntest.Text = "Test  ";
            this.toolTip1.SetToolTip(this.btntest, "Belirlenen ağın kapsama alanında olduğunu test eder.");
            this.btntest.UseVisualStyleBackColor = false;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            this.btntest.MouseLeave += new System.EventHandler(this.btntest_MouseLeave);
            this.btntest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btntest_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 91);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "WİFİNDER");
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.Image")));
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclear.Location = new System.Drawing.Point(225, 152);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(68, 23);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Temizle   ";
            this.toolTip1.SetToolTip(this.btnclear, "Wifi adı ve şifresi bölümlerini temizler.");
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.button1_Click);
            this.btnclear.MouseLeave += new System.EventHandler(this.btnclear_MouseLeave);
            this.btnclear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnclear_MouseMove);
            // 
            // control
            // 
            this.control.Enabled = true;
            this.control.Interval = 10;
            this.control.Tick += new System.EventHandler(this.control_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bağlanıyor...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbdatetime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbtotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 30);
            this.panel1.TabIndex = 15;
            // 
            // lbdatetime
            // 
            this.lbdatetime.AutoSize = true;
            this.lbdatetime.Location = new System.Drawing.Point(35, 9);
            this.lbdatetime.Name = "lbdatetime";
            this.lbdatetime.Size = new System.Drawing.Size(124, 13);
            this.lbdatetime.TabIndex = 21;
            this.lbdatetime.Text = "Powered By DeadSound";
            this.toolTip1.SetToolTip(this.lbdatetime, "Ağın kayıt tarihini gösterir.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tarih :  ";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Location = new System.Drawing.Point(263, 9);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(19, 13);
            this.lbtotal.TabIndex = 19;
            this.lbtotal.Text = "00";
            this.toolTip1.SetToolTip(this.lbtotal, "Kayıtlı ağların toplamını gösterir.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Toplam : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sıra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Essid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 2000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HighlightText;
            // 
            // textessid
            // 
            this.textessid.BackColor = System.Drawing.SystemColors.Control;
            this.textessid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textessid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textessid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textessid.Location = new System.Drawing.Point(50, 100);
            this.textessid.Name = "textessid";
            this.textessid.Size = new System.Drawing.Size(170, 22);
            this.textessid.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textessid, "Wifi ağının adı.");
            // 
            // textfind
            // 
            this.textfind.BackColor = System.Drawing.SystemColors.Control;
            this.textfind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textfind.ForeColor = System.Drawing.Color.Gray;
            this.textfind.Location = new System.Drawing.Point(4, 496);
            this.textfind.Name = "textfind";
            this.textfind.Size = new System.Drawing.Size(199, 22);
            this.textfind.TabIndex = 19;
            this.textfind.Text = "Ara : Essid";
            this.toolTip1.SetToolTip(this.textfind, "Ağları filitreler.");
            this.textfind.Click += new System.EventHandler(this.textfind_Click);
            this.textfind.Leave += new System.EventHandler(this.textfind_Leave);
            this.textfind.MouseLeave += new System.EventHandler(this.textfind_MouseLeave);
            this.textfind.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textfind_MouseMove);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.Location = new System.Drawing.Point(136, 152);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Kaydet  ";
            this.toolTip1.SetToolTip(this.btnsave, "Belirlenen ağı kayıt altına alır.");
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            this.btnsave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnsave_MouseMove);
            // 
            // btnfind2
            // 
            this.btnfind2.BackColor = System.Drawing.Color.Transparent;
            this.btnfind2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfind2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind2.ForeColor = System.Drawing.Color.Black;
            this.btnfind2.Image = ((System.Drawing.Image)(resources.GetObject("btnfind2.Image")));
            this.btnfind2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfind2.Location = new System.Drawing.Point(210, 494);
            this.btnfind2.Name = "btnfind2";
            this.btnfind2.Size = new System.Drawing.Size(85, 25);
            this.btnfind2.TabIndex = 20;
            this.btnfind2.Text = "Araştır   ";
            this.toolTip1.SetToolTip(this.btnfind2, "Belirlediğiniz verilerle ağları filitreler.");
            this.btnfind2.UseVisualStyleBackColor = false;
            this.btnfind2.Click += new System.EventHandler(this.btnfind2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(297, 552);
            this.Controls.Add(this.btnfind2);
            this.Controls.Add(this.textfind);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.listwifi);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textessid);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wifinder v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.ListView listwifi;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer control;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbdatetime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textfind;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnfind2;
        public System.Windows.Forms.TextBox textpass;
        public System.Windows.Forms.TextBox textessid;
    }
}

