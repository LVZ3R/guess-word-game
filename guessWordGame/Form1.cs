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
    public partial class Form1 : Form
    {
        //два динамічних масиви питань та відповідей
        public List<string> questionsArray = new List<string>();
        public List<string> answersArray = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        class Task
        {
            private string answer;
            private string quest;

            //конструктор без параметрів
            Task ()
            {
                this.answer = "";
                this.quest = "";

                throw new Exception("Був викликаний пустий конструктор. Відсутні дані для відображення.");
            }

            //конструктор з параметрами
            //викликається у випадку, якщо лінь створювати масив питань і відповідей
            Task (string newQuestion, string questAnswer)
            {
                this.answer = questAnswer;
                this.quest = newQuestion;
            }

            //конструктор з параметрами
            //передаються два індекси - індекс запитання з масиву питань і індекс відповіді на це питання
            Task (int questID, int answerID)
            {
                   
            }
        }
    }
}
