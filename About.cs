using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); //after closing about page, whole app is closed
        }
    }
}
