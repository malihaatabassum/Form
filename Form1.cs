using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginClicked(object sender, EventArgs e)
        {

            string user = Name.Text;
            string pass = password.Text;
            string output = String.Format("Name : {0}\nPass : {1}", user, pass);
            if (user.Equals("Maliha") && pass.Equals("19-39429-1"))
            {
                new Form2().Show();

            }
            else
            {
                MessageBox.Show("Invalid Id", "Login again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}