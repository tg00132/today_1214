using adressTest0218;
using adressTest0218.control;
using MaterialSkin.Controls;
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
    partial class Update : MaterialForm
    {
        
        public Update()
        {
            InitializeComponent();
        }
        StudentHandler sc;
        public Update(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }


        private void showList()
        {
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                List<Student> addrList = sc.getList();
                uplist.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        addrList[i].Name,
                        addrList[i].Tel,
                        addrList[i].Address,
                        addrList[i].Email
                    }));
            }
            setRowColor(uplist, Color.White, Color.LightGray);
            int index = uplist.Items.Count - 1;
            if (index == -1) return;
            //listView.Items[index].Selected = true;
            uplist.Items[index].Focused = true;
            uplist.EnsureVisible(index);
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            int n = uplist.SelectedItems[0].Index;
            uplist.Items[n].SubItems[1].Text = addName.Text;
            uplist.Items[n].SubItems[2].Text = addTel.Text;
            uplist.Items[n].SubItems[3].Text = addAddress.Text;
            uplist.Items[n].SubItems[4].Text = addEmail.Text;
            MessageBox.Show("수정되었습니다.");

        }

        private void Update_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void uplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uplist.SelectedItems.Count != 0)
            {
                int n = uplist.SelectedItems[0].Index;
                string name = uplist.Items[n].SubItems[1].Text;
                string tel = uplist.Items[n].SubItems[2].Text;
                string addr = uplist.Items[n].SubItems[3].Text;
                string email = uplist.Items[n].SubItems[4].Text;
                Console.WriteLine("이름: {0}", name);
                Console.WriteLine("이름: {0}", tel);
                Console.WriteLine("이름: {0}", addr);
                Console.WriteLine("이름: {0}", email);
                Console.WriteLine("---------------------------");
                upName.Text = name;
                upTel.Text = tel;
                upAddr.Text = addr;
                upEmail.Text = email;
            }
        }

        private void upCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
