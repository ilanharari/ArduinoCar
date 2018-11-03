using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3


{
    public partial class Form1 : Form
    {

        class Problem
        {
            //private variables
            private int correctIndex;
            private string Question;
            private string[] Answers = new string[4];

            //accesor
            public int getCorrectIndex() { return correctIndex; }
            public string getQuestion() { return Question; }
            public string[] getAnswers() { return Answers; }

            //mutator
            public void setQuestion(string Q) { Question = Q; }
            public void setAnswers(string[] A) { Answers = A; }
            public void setIndex(int i) { correctIndex = i; }

            //constructor
            public Problem(string Q, string[] A, int a_ind)
            {
                Question = Q;
                A = Answers;
                correctIndex = a_ind;
            }

            //== operator overload
            public static bool operator ==(Problem obj, int x)
            {
                if (obj.correctIndex == x)
                    return true;
                else
                    return false;
            }

            //!= operator overload
            public static bool operator !=(Problem obj, int x)
            {
                if (obj.correctIndex != x)
                    return true;
                else
                    return false;
            }

        }

        Problem[] probArr = new Problem[15];

        string[] Questions = new string[15]
            {"Book is to Reading as Fork is to:",
             "Which one of the five is least like the other four?",
             "Which one of the five choices makes the best comparison PEACH is to HCAEP as 46251 is to:",
             "If you rearrange the letters CIFAIPC you would have the name of a(n):",
             "The day before the day before yesterday is three days after Saturday. What day is it today?",
             "Which of the following was best known for composing operettas?",
             "Basic solutions have a ph level of: below 7 or above 7?",
             "Boat is to water therefore Plane is to ____",
             "Library is to book as book is to",
             "A baguette is to be cut into 10 equal pieces. How many cuts does the baker need to make?",
             "What is a flock of crows known as?",
             "What is the most Likely day that a heart attack will occur?",
             "What did the Romans use to brush their teeth?",
             "Approximately how many miles of blood vessels are in the human body, if laid out end to end?",
             "What is the only mammal that can't jump?"};

        string[,] Answers = new string[15, 4]
            {
            {"Drawing", "Writing", "Stirring", "Eating"},
            {"Dog","Mouse","Lion","Snake"},
            {"25641","15264","12654","51462"},
            {"City","Animal","Ocean","River"},
            {"Monday","Tuesday","Thursday","Friday"},
            {"Johann Strauss II","Richard Wagner","Wolfgang Mozart","George Handel"},
            {"Above 7", "Below 7", "Only at 7", "Basic solutions do not exist"},
            {"Fly","Sky","Float","Air"},
            {"Binding","Copy","Page","Cover"},
            {"8","9","10","11"},
            {"Gathering", "Goth", "Murder", "Carrier"},
            {"Monday", "Wednesday","Tuesday", "Thursday"},
            {"Urine","Toothpaste","Ash","soil"},
            {"40miles","500miles","5,000miles","60,000miles"},
            {"Mice", "Elephant", "Platypus", "Kangaroo"},};

        int[] correctIndex = new int[15]{3,3,1,2,3,0,0,3,2,1,2,0,0,3,1 };

            public Form1()
            {
                InitializeComponent();
                for (int i = 0; i < 15; i++)
                {
                    string[] tempArr = new string[4];
                    for (int a = 0; a < 3; a++)
                    {
                        tempArr[a] = Answers[i, a];
                    }
                    probArr[i].setQuestion(Questions[i]);
                    probArr[i].setAnswers(tempArr);
                    probArr[i].setIndex(correctIndex[i]);
                }

            }
    

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //IDEA: have a 2x2 array with q's and CORRECT answers, and then compare string 

        private void button1_Click1(object sender, EventArgs e)
        {
            //increment the arrays for quentions and answers (array[i + 1])
            
            //change the literal text in each q/a text box
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
