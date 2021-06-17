using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForms.Lab1.Ex1
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public nForm()
        {
            InitializeComponent();
        }
     
        public new void Close()
        {
            nclose = true; 
            base.Close();
        }
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose)
            {
                return;
            }
            else
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxClose_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
