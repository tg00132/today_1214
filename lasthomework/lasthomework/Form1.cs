using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lasthomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
        }

        private void buttonseller_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonseller.Height;
            panelLeft.Top = buttonseller.Top;
        }

        private void buttonCalender_Click(object sender, EventArgs e)
        {
            panelLeft.Top = buttonCalender.Top;
            panelLeft.Height = buttonCalender.Height;
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTask.Height;
            panelLeft.Top = buttonTask.Top;
        }
    }
}
