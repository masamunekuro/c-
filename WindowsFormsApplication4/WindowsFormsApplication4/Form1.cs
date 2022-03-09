using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=1;
            while (i<11)
            {
                listBox1.Items.Add("waga na wa megumin archu wizardo watashi wa");
                i++;
                
            }
            
            //int sayi=Convert.ToInt32(textBox1.Text);
            //int faktoriyel = i ;
            //for(int i=1; i<=i;i++)
            //{
            //    faktoriyel*=i;

                

            //}
            //MessageBox.Show(faktoriyel.ToString());

          
        }
    }
}
