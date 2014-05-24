using System;
using System.Windows.Forms;
using TestDataBase.CapaLogica;

namespace TestDataBase.CapaVista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            TestCl oTestCl=new TestCl();
            oTestCl.Test(Convert.ToInt32(txtSno.Text), Convert.ToInt32(txtEid.Text), txtDate1.Value, txtDate2.Value,
                Convert.ToInt32(txtSid.Text),chkAcepto.Checked);
            if (oTestCl.IsError)
            {
                MessageBox.Show("Error", "Error");
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            TestCl oTestCl = new TestCl();
            dtgInfo.DataSource= oTestCl.GetInfo().Tables[0];
            if (oTestCl.IsError)
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            TestCl oTestCl = new TestCl();
            oTestCl.Eliminar_Test(Convert.ToInt32(txtSno.Text));
            if (oTestCl.IsError)
            {
                MessageBox.Show("Error", "Error");
            }

            dtgInfo.DataSource = oTestCl.GetInfo().Tables[0];
        }


        
    }
}
