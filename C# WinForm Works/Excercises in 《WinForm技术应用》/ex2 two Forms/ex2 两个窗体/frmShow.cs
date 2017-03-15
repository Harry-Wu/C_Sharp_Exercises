using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_two_Forms
{
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
        }

        public void SetInfo(string info)
        {
            this.textMessage.Text = info;
        }
        private void frmShow_Load(object sender, EventArgs e)
        {

        }
    }
}
