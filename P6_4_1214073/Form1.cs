using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace P6_4_1214073
{
    public partial class Form1 : Form
    {
        private object epWarning;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cbJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbnama_Leave(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {
            if (txtnama.Text == "")
            {
                epWar.SetError(txtnama, " Nama Harus di Isi");
                epEr.SetError(txtnama, "");
                epcor.SetError(txtnama, "");
            }
            else
            {
                if ((txtnama.Text).All(Char.IsLetter))
                {
                    epWar.SetError(txtnama, "");
                    epEr.SetError(txtnama, "");
                    epcor.SetError(txtnama, "Benar");
                }
                else
                {
                    epcor.SetError(txtnama, "Inputan hanya boleh huruf!");
                    epWar.SetError(txtnama, "");
                    epcor.SetError(txtnama, "");
                }
            }
        }

        private void txttelpon_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttelpon_Leave(object sender, EventArgs e)
        {
            if (txttelpon.Text == "")
            {
                epWar.SetError(txttelpon, "Textbox Umur tidak boleh kosong!");
                epEr.SetError(txttelpon, "");
                epcor.SetError(txttelpon, "");
            }
            else
            {
                if (txttelpon.Text == "")
                {
                    epWar.SetError(txttelpon, "Textbox Umur tidak boleh kosong!");
                    epEr.SetError(txttelpon, "");
                    epcor.SetError(txttelpon, "");
                }
                else
                    if ((txttelpon.Text).All(char.IsNumber))
                {
                    epcor.SetError(txttelpon, "Betul!");
                    epWar.SetError(txttelpon, "");
                    epEr.SetError(txttelpon, "");
                }
                else
                {
                    epcor.SetError(txttelpon, "");
                    epWar.SetError(txttelpon, "");
                    epEr.SetError(txttelpon, "Inputan hanya boleh Angka!");
                }
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                epWar.SetError(txtemail, "Textbox Email tidak boleh kosong!");
                epEr.SetError(txtemail, "");
                epcor.SetError(txtemail, "");
            }
            else
            {
                if (Regex.IsMatch(txtemail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWar.SetError(txtemail, "");
                    epEr.SetError(txtemail, "");
                    epcor.SetError(txtemail, "Betul!");
                }
                else
                {
                    epEr.SetError(txtemail, "Format email salah!\nContoh: a@b.c ");
                    epWar.SetError(txtemail, "");
                    epcor.SetError(txtemail, "");
                }
            }
        }

        private void tbtinggi_Leave(object sender, EventArgs e)
        {
            {
                if (tbtinggi.Text == "")
                {
                    epWar.SetError(tbtinggi, "Textbox Gunung tidak boleh kosong!");
                    epEr.SetError(tbtinggi, "");
                    epcor.SetError(tbtinggi, "");
                }
                else
                {
                    if ((tbtinggi.Text).All(Char.IsNumber))
                    {
                        epWar.SetError(tbtinggi, "");
                        epEr.SetError(tbtinggi, "");
                        epcor.SetError(tbtinggi, "Betul!");

                    }
                    else
                    {
                        epcor.SetError(tbtinggi, "");
                        epEr.SetError(tbtinggi, "Inputan hanya boleh Angka!");
                        epWar.SetError(tbtinggi, "");
                    }
                }
                if (tbtinggi.Text == "")
                {
                    epWar.SetError(tbtinggi, "Inputan hanya boleh Angka!");
                    epcor.SetError(tbtinggi, "");
                    epEr.SetError(tbtinggi, "");
                }
            }
        }
        private void tbberat_Leave(object sender, EventArgs e)
        {
            int tinggi = int.Parse(tbtinggi.Text);
            int berat = int.Parse(tbberat.Text);


            if (tbberat.Text == "")
            {
                epWar.SetError(tbberat, "Textbox Gunung tidak boleh kosong!");
                epEr.SetError(tbberat, "");
                epcor.SetError(tbberat, "");
            }
            else
            {
                if ((tbberat.Text).All(Char.IsNumber))
                {
                    epcor.SetError(tbberat, "Betul!");
                    epWar.SetError(tbberat, "");
                    epEr.SetError(tbberat, "");
                }
                else
                {
                    epcor.SetError(tbberat, "");
                    epEr.SetError(tbberat, "Inputan hanya boleh Angka!");
                    epWar.SetError(tbberat, "");
                }

            }

            if (tinggi > berat)
            {
                epWar.SetError(tbberat, "Betul!");
                epcor.SetError(tbberat, "");
                epEr.SetError(tbberat, "");

                epWar.SetError(tbberat, "");
                epEr.SetError(tbberat, "");
                epcor.SetError(tbberat, "Betul!");
            }
            else
            {
                epWar.SetError(tbberat, "Salah!");
                epcor.SetError(tbberat, "");
                epEr.SetError(tbberat, "");

                epWar.SetError(tbberat, "");
                epEr.SetError(tbberat, "");
                epcor.SetError(tbberat, "Salah!");
            }
        }

        private void txtalamat_Leave(object sender, EventArgs e)
        {
            if (txtalamat.Text == "")
            {
                epWar.SetError(txtalamat, " Alamat tidak boleh kosong!");
                epEr.SetError(txtalamat, "");
                epcor.SetError(txtalamat, "");
            }
            else
            {
                if ((txtalamat.Text).All(Char.IsUpper))
                {
                    epWar.SetError(txtalamat, "");
                    epEr.SetError(txtalamat, "");
                    epcor.SetError(txtalamat, "Betul");
                }
                else
                {
                    epEr.SetError(txtalamat, "Inputan hanya boleh huruf kapital!");
                    epWar.SetError(txtalamat, "");
                    epcor.SetError(txtalamat, "");
                }
            }
        }

        private void Hobi_Leave(object sender, EventArgs e)
        {
            if (Hobi.Text == "")
            {
                epWar.SetError(Hobi, "Hobi harus di isi tidak boleh kosong!");
                epEr.SetError(Hobi, "");
                epcor.SetError(Hobi, "");
            }
            else
            {
                if (Hobi.Text.Length <= 20)
                {
                    epWar.SetError(Hobi, "");
                    epEr.SetError(Hobi, "");
                    epcor.SetError(Hobi, "Betul!");
                }
                else
                {
                    epEr.SetError(Hobi, "Inputan tidak boleh lebih dari 20!");
                    epWar.SetError(Hobi, "");
                    epcor.SetError(Hobi, "");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnama.Text == "")
            {
                MessageBox.Show("Masukkan nama anda", "Warning!",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttelpon.Text == "")
            {
                MessageBox.Show("Masukkan Nomor Telpon Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("Harus email anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbtinggi.Text == "")
            {
                MessageBox.Show("Harus memasukan tinggi anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbberat.Text == "")
            {
                MessageBox.Show("Harus memasukan berat anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtalamat.Text == "")
            {
                MessageBox.Show("Harus memasukan alamat", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthobi.Text == "")
            {
                MessageBox.Show("Harus memasukan Hobi", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show
                ("Nama : " + txtnama.Text +
                "\nUmur : " + txttelpon.Text +
                "\nEmail : " + txtemail.Text +
                "\nPosisi : " + cbJabatan.Text +
                "\nTinggi : " + tbtinggi.Text +
                "\nBerat : " + tbberat.Text +
                "\nAlamat : " + txtalamat.Text +
                "\nHobi: " + txthobi.Text,
                "Calon Pegawai PT Pamapersada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txthobi_Leave(object sender, EventArgs e)
        {

            if (txthobi.Text == "")
            {
                epWar.SetError(txthobi, "Hobi harus di isi tidak boleh kosong!");
                epEr.SetError(txthobi, "");
                epcor.SetError(txthobi, "");
            }
            else
            {
                if (txthobi.Text.Length <= 20)
                {
                    epWar.SetError(txthobi, "");
                    epEr.SetError(txthobi, "");
                    epcor.SetError(txthobi, "Betul!");
                }
                else
                {
                    epEr.SetError(txthobi, "Inputan tidak boleh lebih dari 20!");
                    epWar.SetError(txthobi, "");
                    epcor.SetError(txthobi, "");
                }
            }
        }
    }
}
    
 

   
    