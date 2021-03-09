using adressTest0218;
using adressTest0218.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addrWin0302.UI
{
     partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        StudentHandler sc;
        public DeleteForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            List<Student> addrList = sc.getList();
            for(int i = 0; i<addrList.Count; i++)
            {
                if(addrList[i].Name.Equals(deleteIdTextBox.Text))
                {
                    addrList.RemoveAt(i--);
                }
            }
            Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
