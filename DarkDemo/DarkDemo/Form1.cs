using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_Counter_Cheker.Hide(); Panel_Profile_Log.Hide(); Panel_NBR.Hide();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Profile_Log_Click(object sender, EventArgs e)
        {
            blue.Top = Profile_Log.Top;
            blue.Height = Profile_Log.Height;

            if (blue.Top == Profile_Log.Top)
            {

            }
            
        }

        private void NBR_Click(object sender, EventArgs e)
        {
            blue.Height = NBR.Height;
            blue.Top = NBR.Top;

            if (blue.Top == NBR.Top)
            {
                Panel_NBR.Visible = true;
            }

        }

        private void Counter_Click(object sender, EventArgs e)
        {
            blue.Height = Counter.Height;
            blue.Top = Counter.Top;
            panel_Counter_Cheker.Show();
        }

    }
}
