using BARANGAY.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARANGAY
{
    public partial class FormBRIC : Form
    {
        public FormBRIC()
        {
            InitializeComponent();
            UCPI uc = new UCPI();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            UCPI uc = new UCPI();
            addUserControl(uc); 
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            UCUP uc = new UCUP();
            addUserControl(uc);
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            UCDC uc = new UCDC();
            addUserControl(uc);
        }
    }
}
