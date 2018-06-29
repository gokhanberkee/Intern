namespace StajProje
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblSoyİsim = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblTCKNO = new System.Windows.Forms.Label();
            this.txtboxİsim = new System.Windows.Forms.TextBox();
            this.txtboxSoyİsim = new System.Windows.Forms.TextBox();
            this.txtboxYas = new System.Windows.Forms.TextBox();
            this.txtboxTCKNO = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblTCKNOUyarı = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtboxMail = new System.Windows.Forms.TextBox();
            this.cmbMail = new System.Windows.Forms.ComboBox();
            this.lblMailUyarı = new System.Windows.Forms.Label();
            this.cmbTCKNOBul = new System.Windows.Forms.ComboBox();
            this.btnTCKNOBul = new System.Windows.Forms.Button();
            this.lblTCKNOSec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grdSonuc = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(254, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(39, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "label1";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblİsim
            // 
            this.lblİsim.BackColor = System.Drawing.Color.Transparent;
            this.lblİsim.Location = new System.Drawing.Point(-5, 16);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblİsim.Size = new System.Drawing.Size(61, 17);
            this.lblİsim.TabIndex = 1;
            this.lblİsim.Text = "label2";
            // 
            // lblSoyİsim
            // 
            this.lblSoyİsim.AutoSize = true;
            this.lblSoyİsim.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyİsim.Location = new System.Drawing.Point(214, 14);
            this.lblSoyİsim.Name = "lblSoyİsim";
            this.lblSoyİsim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSoyİsim.Size = new System.Drawing.Size(35, 13);
            this.lblSoyİsim.TabIndex = 2;
            this.lblSoyİsim.Text = "label3";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Transparent;
            this.lblYas.Location = new System.Drawing.Point(21, 56);
            this.lblYas.Name = "lblYas";
            this.lblYas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYas.Size = new System.Drawing.Size(35, 13);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "label4";
            // 
            // lblTCKNO
            // 
            this.lblTCKNO.AutoSize = true;
            this.lblTCKNO.BackColor = System.Drawing.Color.Transparent;
            this.lblTCKNO.Location = new System.Drawing.Point(21, 93);
            this.lblTCKNO.Name = "lblTCKNO";
            this.lblTCKNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTCKNO.Size = new System.Drawing.Size(35, 13);
            this.lblTCKNO.TabIndex = 4;
            this.lblTCKNO.Text = "label5";
            // 
            // txtboxİsim
            // 
            this.txtboxİsim.Location = new System.Drawing.Point(91, 13);
            this.txtboxİsim.Name = "txtboxİsim";
            this.txtboxİsim.Size = new System.Drawing.Size(100, 20);
            this.txtboxİsim.TabIndex = 5;
            this.txtboxİsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtboxSoyİsim
            // 
            this.txtboxSoyİsim.Location = new System.Drawing.Point(278, 13);
            this.txtboxSoyİsim.Name = "txtboxSoyİsim";
            this.txtboxSoyİsim.Size = new System.Drawing.Size(100, 20);
            this.txtboxSoyİsim.TabIndex = 6;
            this.txtboxSoyİsim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtboxYas
            // 
            this.txtboxYas.Location = new System.Drawing.Point(91, 51);
            this.txtboxYas.Name = "txtboxYas";
            this.txtboxYas.Size = new System.Drawing.Size(100, 20);
            this.txtboxYas.TabIndex = 7;
            this.txtboxYas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtboxTCKNO
            // 
            this.txtboxTCKNO.Location = new System.Drawing.Point(91, 90);
            this.txtboxTCKNO.Name = "txtboxTCKNO";
            this.txtboxTCKNO.Size = new System.Drawing.Size(100, 20);
            this.txtboxTCKNO.TabIndex = 8;
            this.txtboxTCKNO.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtboxTCKNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(195, 258);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 11;
            this.btnGonder.Text = "button1";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnTemizle.Location = new System.Drawing.Point(93, 258);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "button2";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTCKNOUyarı
            // 
            this.lblTCKNOUyarı.AutoSize = true;
            this.lblTCKNOUyarı.BackColor = System.Drawing.Color.Transparent;
            this.lblTCKNOUyarı.Location = new System.Drawing.Point(209, 94);
            this.lblTCKNOUyarı.Name = "lblTCKNOUyarı";
            this.lblTCKNOUyarı.Size = new System.Drawing.Size(35, 13);
            this.lblTCKNOUyarı.TabIndex = 14;
            this.lblTCKNOUyarı.Text = "label8";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(91, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Location = new System.Drawing.Point(21, 154);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCinsiyet.Size = new System.Drawing.Size(35, 13);
            this.lblCinsiyet.TabIndex = 16;
            this.lblCinsiyet.Text = "label9";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(91, 148);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbCinsiyet.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::StajProje.Properties.Resources.pict11;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Location = new System.Drawing.Point(21, 198);
            this.lblMail.Name = "lblMail";
            this.lblMail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMail.Size = new System.Drawing.Size(41, 13);
            this.lblMail.TabIndex = 19;
            this.lblMail.Text = "label10";
            // 
            // txtboxMail
            // 
            this.txtboxMail.Location = new System.Drawing.Point(91, 195);
            this.txtboxMail.Name = "txtboxMail";
            this.txtboxMail.Size = new System.Drawing.Size(100, 20);
            this.txtboxMail.TabIndex = 20;
            // 
            // cmbMail
            // 
            this.cmbMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMail.FormattingEnabled = true;
            this.cmbMail.Location = new System.Drawing.Point(212, 195);
            this.cmbMail.Name = "cmbMail";
            this.cmbMail.Size = new System.Drawing.Size(121, 21);
            this.cmbMail.TabIndex = 21;
            this.cmbMail.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblMailUyarı
            // 
            this.lblMailUyarı.AutoSize = true;
            this.lblMailUyarı.BackColor = System.Drawing.Color.Transparent;
            this.lblMailUyarı.Location = new System.Drawing.Point(96, 228);
            this.lblMailUyarı.Name = "lblMailUyarı";
            this.lblMailUyarı.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMailUyarı.Size = new System.Drawing.Size(41, 13);
            this.lblMailUyarı.TabIndex = 22;
            this.lblMailUyarı.Text = "label11";
            // 
            // cmbTCKNOBul
            // 
            this.cmbTCKNOBul.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTCKNOBul.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbTCKNOBul.FormattingEnabled = true;
            this.cmbTCKNOBul.Location = new System.Drawing.Point(14, 49);
            this.cmbTCKNOBul.Name = "cmbTCKNOBul";
            this.cmbTCKNOBul.Size = new System.Drawing.Size(121, 21);
            this.cmbTCKNOBul.TabIndex = 26;
            // 
            // btnTCKNOBul
            // 
            this.btnTCKNOBul.Location = new System.Drawing.Point(159, 48);
            this.btnTCKNOBul.Name = "btnTCKNOBul";
            this.btnTCKNOBul.Size = new System.Drawing.Size(75, 23);
            this.btnTCKNOBul.TabIndex = 27;
            this.btnTCKNOBul.Text = "tcBul_button";
            this.btnTCKNOBul.UseVisualStyleBackColor = true;
            this.btnTCKNOBul.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTCKNOSec
            // 
            this.lblTCKNOSec.AutoSize = true;
            this.lblTCKNOSec.BackColor = System.Drawing.Color.Transparent;
            this.lblTCKNOSec.Location = new System.Drawing.Point(59, 15);
            this.lblTCKNOSec.Name = "lblTCKNOSec";
            this.lblTCKNOSec.Size = new System.Drawing.Size(35, 13);
            this.lblTCKNOSec.TabIndex = 35;
            this.lblTCKNOSec.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtboxİsim);
            this.panel1.Controls.Add(this.lblİsim);
            this.panel1.Controls.Add(this.txtboxSoyİsim);
            this.panel1.Controls.Add(this.lblSoyİsim);
            this.panel1.Controls.Add(this.txtboxYas);
            this.panel1.Controls.Add(this.lblYas);
            this.panel1.Controls.Add(this.txtboxTCKNO);
            this.panel1.Controls.Add(this.lblTCKNOUyarı);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.lblTCKNO);
            this.panel1.Controls.Add(this.lblMailUyarı);
            this.panel1.Controls.Add(this.btnGonder);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.cmbCinsiyet);
            this.panel1.Controls.Add(this.cmbMail);
            this.panel1.Controls.Add(this.lblCinsiyet);
            this.panel1.Controls.Add(this.txtboxMail);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 294);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTCKNOSec);
            this.panel2.Controls.Add(this.cmbTCKNOBul);
            this.panel2.Controls.Add(this.btnTCKNOBul);
            this.panel2.Location = new System.Drawing.Point(493, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 133);
            this.panel2.TabIndex = 36;
            // 
            // grdSonuc
            // 
            this.grdSonuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grdSonuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdSonuc.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.grdSonuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSonuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSonuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdSonuc.GridColor = System.Drawing.Color.Red;
            this.grdSonuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdSonuc.Location = new System.Drawing.Point(23, 399);
            this.grdSonuc.Name = "grdSonuc";
            this.grdSonuc.ReadOnly = true;
            this.grdSonuc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdSonuc.Size = new System.Drawing.Size(765, 210);
            this.grdSonuc.TabIndex = 37;
            this.grdSonuc.Visible = false;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(StajProje.Person);
            // 
            // personListBindingSource
            // 
            this.personListBindingSource.DataSource = typeof(StajProje.PersonList);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(StajProje.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StajProje.Properties.Resources.BackImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.grdSonuc);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label lblSoyİsim;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblTCKNO;
        private System.Windows.Forms.TextBox txtboxİsim;
        private System.Windows.Forms.TextBox txtboxSoyİsim;
        private System.Windows.Forms.TextBox txtboxYas;
        private System.Windows.Forms.TextBox txtboxTCKNO;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblTCKNOUyarı;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtboxMail;
        private System.Windows.Forms.ComboBox cmbMail;
        private System.Windows.Forms.Label lblMailUyarı;
        private System.Windows.Forms.Button btnTCKNOBul;
        private System.Windows.Forms.ComboBox cmbTCKNOBul;
        private System.Windows.Forms.Label lblTCKNOSec;
        private System.Windows.Forms.BindingSource personListBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView grdSonuc;
    }
}

