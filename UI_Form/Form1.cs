using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
                    
        }

        public void Button_Profile_Log_Click(object sender, EventArgs e)
        {
            orange.Height = Button_Profile_Log.Height;
            orange.Top = Button_Profile_Log.Top;
        }

        private void Button_Counter_Cheker_Click(object sender, EventArgs e)
        {
            orange.Height = Button_Counter_Cheker.Height;
            orange.Top = Button_Counter_Cheker.Top;
        }

        private void button_NBR_Click(object sender, EventArgs e)
        {
            orange.Height = button_NBR.Height;
            orange.Top = button_NBR.Top;
        }
    }
}
