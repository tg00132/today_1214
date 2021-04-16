using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> textlist = new List<string>();
            textlist.Add("밀크5천");
            textlist.Add("리플5천");
            textlist.Add("오브스5천");
            textlist.Add("폴리메쓰5천");

            label1.Text = " ";
            label1.Text = textlist[new Random().Next(textlist.Count)];
        }
    }
}
