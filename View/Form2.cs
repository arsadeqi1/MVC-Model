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
    public partial class Form2 : Form
    {
        public UserInfo UserInfowww { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtFName.Text = UserInfowww.FirstName;
            this.txtLName.Text = UserInfowww.LastName;
            this.txtEmail.Text = UserInfowww.Email;
        }
    }
}
