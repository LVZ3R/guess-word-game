using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessWordGame
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private void addUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            this.Close();
            main.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
