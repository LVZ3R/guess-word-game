using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace guessWordGame
{
    public partial class Form1 : Form
    {
        //два динамічних масиви питань та відповідей
        //питанню під індексом 0 повинна відповідати відповідь з масиву відвовідей під індексом (0)
        public List<string> questionsArray = new List<string>();
        public List<string> answersArray = new List<string>();
        Task taskProvide = new Task();

        public Form1()
        {
            InitializeComponent();
            //створення п'яти питань і відповідей для тестування програми
            questionsArray.Add("Столиця України?");
            answersArray.Add("Київ");
            questionsArray.Add("Столиця Росії?");
            answersArray.Add("Москва");
            questionsArray.Add("Столиця Білорусі?");
            answersArray.Add("Мінськ");
            questionsArray.Add("Столиця США?");
            answersArray.Add("Вашингтон");
            questionsArray.Add("Столиця Німеччини?");
            answersArray.Add("Берлін");
        }

        public UsersDaoImpl users = new UsersDaoImpl();

        private void button1_Click(object sender, EventArgs e)
        {
            taskProvide.userAnswer = textBox1.Text;
            if (taskProvide.compareAnswers())
                MessageBox.Show("Відповідь вірна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Відповідь невірна!", "Невдача", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Random rand = new Random();
            int questIndex = rand.Next(0, questionsArray.Count - 1);
            taskProvide.setNewTask(questionsArray[questIndex], answersArray[questIndex]);
            richTextBox1.Text = taskProvide.getTask();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addUserForm child = new addUserForm();
            child.Owner = this;
            this.Enabled = false;
            child.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(users.all(), "Всі користувачі", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public partial class Task
    {
        private string answer;
        private string quest;
        public string userAnswer;

        //конструктор без параметрів
        public Task()
        {
            this.answer = "";
            this.quest = "";
        }

        //конструктор з параметрами
        //викликається у випадку, якщо лінь створювати масив питань і відповідей
        public Task(string newQuestion, string questAnswer)
        {
            this.answer = questAnswer;
            this.quest = newQuestion;
        }

        //конструктор з параметрами
        //передаються два масиви - масив питань і масив відповідей
        public Task(List<string> quests, List<string> answers)
        {
            Random rand = new Random();
            //якщо раптом масиви неоднакового розміру, то за макс. значення рандому беремо кількість елементів меншого розміру
            int minCount = Math.Min(quests.Count, answers.Count);
            //отримуємо з масивів питання і відповідь
            this.quest = quests[rand.Next(0, minCount - 1)];
            this.answer = answers[rand.Next(0, minCount - 1)];
        }

        public bool compareAnswers()
        {
            if (this.answer == userAnswer) return true; else
            return false;
        }

        public string getTask () { return this.quest; }

        public void setNewTask(string newQuest, string newAnswer)
        {
            answer = newAnswer;
            quest = newQuest;
        }
    }

    public class User
    {
        protected int id;
        public String Email { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public bool Gender { get; set; }
        public int BirthYear { get; set; }
        public String Login { get; set; }
        public String PasswordHash { get; set; }
        public int Score { get; set; }

        public User(int _id, String _email, String _firstName,
            String _lastName, bool _gender, int _birthYear,
            String _login, String _passwordHash, int _score)
        {
            id = _id;
            Email = _email;
            FirstName = _firstName;
            LastName = _lastName;
            Gender = _gender;
            Login = _login;

            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(_passwordHash));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }
            PasswordHash = builder.ToString();

            Score = _score;
            BirthYear = _birthYear;
        }

        public String getInfo()
        {
            return Login + ", " + FirstName + " " + LastName +
                ". Age: " + (DateTime.Now.Year - BirthYear) +
                ", Email: " + Email + ". Score: " + Score;
        }
    }

    interface IUserDao
    {
        String all();
        void add(User user);
        void update(int _id, User user);
        String find(String _login, String _password);
    }
    public class UsersDaoImpl : IUserDao
    {
        private List<User> dataList = new List<User>();

        public int getSize()
        {
            return dataList.Count;
        }

        public String all()
        {
            String result = "";
            for (int i = 0; i < dataList.Count; i++)
            {
                result += dataList[i].getInfo() + Environment.NewLine;
            }

            return result;
        }

        public void add(User user)
        {
            dataList.Add(user);
        }

        public void update(int _id, User user)
        {
            if (_id < dataList.Count)
            {
                dataList[_id] = user;
            }
        }

        public String find(String _login, String _password)
        {
            String result = "No results" + Environment.NewLine;

            for (int i = 0; i < dataList.Count; i++)
            {
                if (dataList[i].Login == _login)
                {
                    if(dataList[i].PasswordHash == _password)
                    {
                        result = dataList[i].getInfo() + Environment.NewLine;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
