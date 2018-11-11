using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace yetki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 f1=(Form1)Application .OpenForms ["Form1"];
        private void Form2_Load(object sender, EventArgs e)
        {
            if (f1.yetki == "0") 
            {
                button1.Hide();
                button3.Hide();
                button4.Hide();
            }
            if (f1.yetki == "1") 
            {
                button2.Hide();
                button3.Hide();
                button4.Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


    }
}
