using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vigener_Click(object sender, EventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void playfer_Click(object sender, EventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
