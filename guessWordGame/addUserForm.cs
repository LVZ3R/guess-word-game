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
            main.Enabled = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginBox.Text == "")
                    throw new Exception("Ви не задали логін!");
                if (passwordBox.Text == "")
                    throw new Exception("Вкажіть пароль!");
                if (fNameBox.Text == "")
                    throw new Exception("Вкажіть ім'я!");
                if (lNameBox.Text == "")
                    throw new Exception("Вкажіть прізвище!");

                Form1 main = this.Owner as Form1;
                User newUser = new User(
                    main.users.getSize(), emailBox.Text, fNameBox.Text,
                    lNameBox.Text, true, Convert.ToInt32(yearOfBirthBox.Value),
                    loginBox.Text, passwordBox.Text, 0);
                main.users.add(newUser);
                
                //тут будуть очищатись текстові поля
                //прапорці для статі не працюють у зв'язку з тим
                //що хочу придумати більш оптимальний код ніж просто перевірити if-ом
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
