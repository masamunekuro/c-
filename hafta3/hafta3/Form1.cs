using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hafta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak, toplamhak;
        private void button1_Click(object sender, EventArgs e)
        {
            toplamhak = 3;
            if (txtNick.Text == "ahy" && txtPass.Text == "123")
            {
                MessageBox.Show("giriş başarılı");
            }
            else
            {
                hak++;
                şifre.Visible = true;
                MessageBox.Show("toplam "+(toplamhak-hak)+" hakkınız kaldı");
                if (hak == 3)
                {
                    Application.Exit();
                }
            }
        }
    }
}
