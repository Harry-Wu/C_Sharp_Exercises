using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_2_Choose_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (listCandidate.Items.Count > 0)
            {
                listChoose.Items.Add(listCandidate.SelectedItem);
                listCandidate.Items.Remove(listCandidate.SelectedItem);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listChoose.Items.Count > 0)
            {
                listCandidate.Items.Add(listChoose.SelectedItem);
                listChoose.Items.Remove(listChoose.SelectedItem);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (listChoose.Items.Count > 1)
            {
                MessageBox.Show("只能选择一位候选人！", "警告", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }
            else
            {
            MessageBox.Show(listChoose.Items[0].ToString());
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            Form2Rename form2 = new Form2Rename(this);
            form2.Show();
            
        }

        //设置更名覆盖的方法
        public void SetName(string name)
        {
            //int pos = listCandidate.Items.IndexOf(listCandidate.SelectedItems.ToString()); //这样获取不到索引值
            int pos = listCandidate.SelectedIndex;
            if (pos != -1) listCandidate.Items[pos] = name;
            //MessageBox.Show(Convert.ToString(pos));
            //listCandidate.Items[0] = name;
        }
    }
}
