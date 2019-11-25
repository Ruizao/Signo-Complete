using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signo_Complete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        signos dn = new signos();

        private void Button1_Click(object sender, EventArgs e)
        {
            dn.recebe = textBox1.Text;
            label2.Text = dn.envia;
        }
    }
}
