using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_CRUD_PABD
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //kondisi jika username dan password benar
            if (textBox_Username.Text == "admin" && textBox_Password.Text == "admin123")
            {
                //pindah ke form beranda
                new FormBeranda().Show();
                this.Hide();
            }

            //kondisi jika username salah dan password benar
            else if (textBox_Username.Text != "admin" && textBox_Password.Text == "admin123")
            {
                //display messagebox 
                MessageBox.Show("Username yang anda masukkan salah !");

                //membersihkan kolom username 
                textBox_Username.Clear();

                //menaruh kursor ke kolom username setelah dibersihkan
                textBox_Username.Focus();
            }

            //kondisi jika username benar dan password salah
            else if (textBox_Username.Text == "admin" && textBox_Password.Text != "admin123")
            {
                //display messagebox 
                MessageBox.Show("Password yang anda masukkan salah !");

                //membersihkan kolom password 
                textBox_Password.Clear();

                //menaruh kursor ke kolom password setelah dibersihkan
                textBox_Password.Focus();
            }

            //kondisi jika keduanya salah
            else
            {
                //display messagebox 
                MessageBox.Show("Username dan Password yang anda masukkan salah !");

                //membersihkan kolom username
                textBox_Username.Clear();

                //membersihkan kolom password 
                textBox_Password.Clear();

                //menaruh kursor ke kolom username setelah dibersihkan
                textBox_Username.Focus();
            }
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }
    }
}
