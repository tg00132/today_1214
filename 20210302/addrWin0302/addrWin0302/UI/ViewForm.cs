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
     partial class ViewForm : MaterialForm
    {
        StudentHandler sc;
        public ViewForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void initListView()
        {            
            for (int i=0; i<sc.getList().Count; i++)
            {
                listView.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(), sc.getList()[i].Name,
                    sc.getList()[i].Tel,
                        sc.getList()[i].Address,
                        sc.getList()[i].Email

                }));

            }


            
        }
        private void showList()
        {
            int cnt = sc.getList().Count;
            for(int i=0; i < cnt; i++)
            {
                List<Student> addrList = sc.getList();
                listView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        addrList[i].Name,
                        addrList[i].Tel,
                        addrList[i].Address,
                        addrList[i].Email
                    }));
            }
            setRowColor(listView, Color.White, Color.LightGray);
            int index = listView.Items.Count - 1;
            if (index == -1) return;
            
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach(ListViewItem item in list.Items)
            {
                if((item.Index %2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }



        private void ViewForm_Load(object sender, EventArgs e)
        {
            
            showList();
            showGridView();
        }

        private void cxFlatButton1_Click(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count !=0)
            {
                int n = listView.SelectedItems[0].Index;
                string name = listView.Items[n].SubItems[1].Text;
                string tel = listView.Items[n].SubItems[2].Text;
                string addr = listView.Items[n].SubItems[3].Text;
                string email = listView.Items[n].SubItems[4].Text;
                Console.WriteLine("이름: {0}",name);
                Console.WriteLine("이름: {0}", tel);
                Console.WriteLine("이름: {0}", addr);
                Console.WriteLine("이름: {0}", email);
                Console.WriteLine("---------------------------");
                listView.Items.RemoveAt(n);
            }
        }

        private void showGridView()
        {
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                
                gridView.Rows.Add(new string[]
                    {
                        (i + 1).ToString(), sc.getList()[i].Name,
                        sc.getList()[i].Tel,
                        sc.getList()[i].Address,
                        sc.getList()[i].Email
                    }
                    );                
            }
            int count = gridView.Rows.Count - 1;
            if (count == 0) return;
            gridView.FirstDisplayedScrollingRowIndex = count;
            gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];
        }
        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Method intentionally left empty.
        }
    }
}
