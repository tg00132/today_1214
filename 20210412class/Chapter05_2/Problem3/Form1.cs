using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem3
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
                                              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> sList = new List<string>();
            sList.Add("1번");
            sList.Add("2번");
            sList.Add("3번");
            sList.Add("4번");
            sList.Add("5번");
            label1.Text = (sList[r.Next(0, sList.Count)]);

        }
    }
}
