using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View
{
    public partial class Form1 : Form
    {
        public UserInfo UserInfoxxx { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            UserInfoxxx.FirstName = txtFName.Text;
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            UserInfoxxx.LastName = txtLName.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            UserInfoxxx.Email = txtEmail.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
