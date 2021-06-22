using System;
using System.Windows.Forms;

namespace ITMO.WinForms.Lab3.Ex1.LibUserControls
{
    public partial class WinTimer : UserControl
    {
        public WinTimer()
        {
            InitializeComponent();
        }
        public bool TimeEnabled
        {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
