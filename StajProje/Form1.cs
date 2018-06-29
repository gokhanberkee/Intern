using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;




namespace StajProje
{
    public partial class Form1 : Form
    {
        private static PersonList mPersonList;
        public Form1()
        {
            InitializeComponent();
            cmbCinsiyet.Items.Add("Erkek"); cmbCinsiyet.Items.Add("Kadın"); cmbCinsiyet.Text = "Seçiniz";
            cmbMail.Items.Add("@gmail.com"); cmbMail.Items.Add("@hotmail.com"); cmbMail.Items.Add("Diğer");
            cmbCinsiyet.SelectedIndex = 0;
            cmbMail.SelectedIndex = 0;
        }

        public void writer()
        {
            TextWriter txt = new StreamWriter("C:\\Users\\GökhanBerke\\Desktop\\Staj\\Visual\\StajProje\\veriSeti.txt", true);

            Person toJson = new Person();
            toJson.Name = txtboxİsim.Text;
            toJson.surname = txtboxSoyİsim.Text;
            toJson.age = txtboxYas.Text;
            toJson.TCKNO = txtboxTCKNO.Text;
            toJson.gender = cmbCinsiyet.SelectedItem.ToString();            
            if (cmbMail.SelectedItem.ToString()!="Diğer")
            {
                toJson.mail = txtboxMail.Text + cmbMail.SelectedItem.ToString();
            }
            else
            {                
                toJson.mail = txtboxMail.Text;
            }
            
            
            String jMessage = JsonConvert.SerializeObject(toJson);
            txt.Write(jMessage + System.Environment.NewLine);
            
            txt.Close();
        }
      
        public bool checkTCKNAvailabilty(PersonList personList, string tckn)
        {
            foreach(Person person in personList.personList)
            {
                if (person.TCKNO.Trim().Equals(tckn.Trim()))
                {
                    return false;
                }
            }
            return true;
        }
        private void refreshForm()
        {

            lblBaslik.Text = "Öğrenci Kayıt Sistemi"; lblBaslik.ForeColor = Color.Red; lblBaslik.Font = new Font("Times New Roman", 25, FontStyle.Bold);
            lblİsim.Text = "İsim"; lblİsim.ForeColor = Color.WhiteSmoke; lblİsim.Font = new Font("Arial", 10, FontStyle.Bold);
            lblSoyİsim.Text = "Soy İsim"; lblSoyİsim.ForeColor = Color.WhiteSmoke; lblSoyİsim.Font = new Font("Arial", 10, FontStyle.Bold);
            lblYas.Text = "Yaş"; lblYas.ForeColor = Color.WhiteSmoke; lblYas.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTCKNO.Text = "TCKNO"; lblTCKNO.ForeColor = Color.WhiteSmoke; lblTCKNO.Font = new Font("Arial", 10, FontStyle.Bold);
            btnGonder.Text = "Kaydet";
            btnTemizle.Text = "Temizle";
            lblTCKNOUyarı.Text = "*Zorunlu Alan*"; lblTCKNOUyarı.ForeColor = Color.Red; lblTCKNOUyarı.Font = new Font(lblTCKNOUyarı.Font, FontStyle.Bold);
            txtboxTCKNO.MaxLength = 11;
            checkBox1.Text = "TCKNO Gizle"; checkBox1.ForeColor = Color.White;
            lblCinsiyet.Text = "Cinsiyet"; lblCinsiyet.ForeColor = Color.WhiteSmoke; lblCinsiyet.Font = new Font("Arial", 10, FontStyle.Bold);
            lblMail.Text = "E-mail"; lblMail.ForeColor = Color.WhiteSmoke; lblMail.Font = new Font("Arial", 10, FontStyle.Bold);
            lblMailUyarı.Text = "Lütfen e-mail giriniz."; lblMailUyarı.ForeColor = Color.Red; lblMailUyarı.Font = new Font(lblMailUyarı.Font, FontStyle.Bold); lblMailUyarı.Visible = false;
            btnTCKNOBul.Text = "Listele";
            lblTCKNOSec.Text = "TCKNO ile Bilgi Erişimi"; lblTCKNOSec.ForeColor = Color.WhiteSmoke; lblTCKNOSec.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            PersonList persons = Utility.ReadPersons();
            List<string> oto_tamamlama = new List<string>();
            oto_tamamlama.Add("Hepsi");
            foreach (Person person in persons.personList)
            {
                oto_tamamlama.Add(person.TCKNO);
            }
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (string item in oto_tamamlama)
            {
                collection.Add(item);
            }
            cmbTCKNOBul.DataSource = oto_tamamlama;
            cmbTCKNOBul.AutoCompleteCustomSource = collection;
            cmbTCKNOBul.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTCKNOBul.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            refreshForm();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);            
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);        
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            mPersonList = Utility.ReadPersons();

            
            if (!checkTCKNAvailabilty(mPersonList, txtboxTCKNO.Text))
            {
                MessageBox.Show("Böyle bir TCKNO kayıtlı !");
            }else
            {
                writer();
                refreshForm();
            }
            
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            txtboxİsim.Clear();
            txtboxSoyİsim.Clear();
            txtboxYas.Clear();
            txtboxTCKNO.Clear();
            txtboxMail.Clear();
            cmbCinsiyet.SelectedIndex = 0;
            cmbMail.SelectedIndex = 0;
            lblMailUyarı.Visible = false;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtboxTCKNO.Text == "")
            {
                lblTCKNOUyarı.Visible = true;
            }
            else
            {
                lblTCKNOUyarı.Visible = false;
            }
            

        }       


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtboxTCKNO.PasswordChar = '●';
            }
            else
            {
                txtboxTCKNO.PasswordChar = '\0';
            }
           
        }   

        
               

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMail.SelectedItem.Equals("Diğer")) { 
            txtboxMail.Clear();
            lblMailUyarı.Visible = true;
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            PersonList persons = Utility.ReadPersons();            
            DataTable dtCustomer = new DataTable();
            dtCustomer.Columns.Add("İsim");            
            dtCustomer.Columns.Add("Soy İsim");            
            dtCustomer.Columns.Add("Yaş");            
            dtCustomer.Columns.Add("TCKN");
            dtCustomer.Columns.Add("Cinsiyet");            
            dtCustomer.Columns.Add("E-Mail");        
            foreach (Person person in persons.personList)
            {
                if (cmbTCKNOBul.SelectedItem.Equals("Hepsi"))
                {
                    grdSonuc.Enabled = true;
                    dtCustomer.Rows.Add(person.Name.Trim(),
                                        person.surname.Trim(), 
                                        person.age.Trim(), 
                                        person.TCKNO.Trim(), 
                                        person.gender.Trim(), 
                                        person.mail.Trim());
                    grdSonuc.Visible = true;                 
                              
                }
                grdSonuc.DataSource = dtCustomer;               
              
            }

            foreach(Person person in persons.personList)
            {
                if (cmbTCKNOBul.SelectedItem.Equals(person.TCKNO.Trim()))
                {
                    grdSonuc.Enabled = false;
                    grdSonuc.Rows[0].Cells[0].Value = person.Name.Trim();
                    grdSonuc.Rows[0].Cells[1].Value = person.surname.Trim();
                    grdSonuc.Rows[0].Cells[2].Value = person.age.Trim();
                    grdSonuc.Rows[0].Cells[3].Value = person.TCKNO.Trim();
                    grdSonuc.Rows[0].Cells[4].Value = person.gender.Trim();
                    grdSonuc.Rows[0].Cells[5].Value = person.mail.Trim();
                    grdSonuc.Visible = true;                   
                    break;
                }
            }

        }

        
    }
}
