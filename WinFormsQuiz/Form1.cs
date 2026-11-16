using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace WinFormsQuiz
{
    public partial class Form1 : Form
    {

        //array of questions and answers
        string[,] questions = new string[6, 2];

        //track question
        int currentQuestion = 0;

        //track correct answers
        int correct = 0;

        //creating the darkness bool
        bool isDark = false;

        //startup method, runs automatically upon loading
        public Form1()
        {
            InitializeComponent();

            //call new LoadQuestions() method to populate quiz data
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            //populate array
            questions[0, 0] = "What's the capital of Japan?";
            questions[0, 1] = "Tokyo";
            questions[1, 0] = "Bogos?";
            questions[1, 1] = "Binted";
            questions[2, 0] = "What time is it?";
            questions[2, 1] = "Time to get a watch";
            questions[3, 0] = "What is 3+3?";
            questions[3, 1] = "6";
            questions[4, 0] = "Are you sure?";
            questions[4, 1] = "No...";
            questions[5, 0] = "Why not?";
            questions[5, 1] = "I don't know";

            //show 1st question on label
            lblQuestion.Text = questions[0, 0];
        }

        /*
         * [summary] give feedback on answer
         * [param name] "text" feedback to show
         * [param name] "colour" text colour for feedback
        */

        private void ShowFeedback(string text, Color colour)
        {
            lblMessage.Text = text;
            lblMessage.ForeColor = colour;
        }

        /// <summary>
        /// Get percentage
        /// </summary>
        /// <param name="correct"></param>
        /// <param name="total"></param>
        /// <return>
        /// int
        /// </return>

        private int GetPercentScore(int correct, int total)
        {
            total = questions.GetLength(0);
            int percent = (correct / total) * 100;
            return percent;
        }

        private string GetGrade(int percent)
        {
            if (percent >= 90)
            {
                return ("A");
            }

            else if (percent >= 80)
            {
                return ("B");
            }

            else if (percent >= 70)
            {
                return ("C");
            }
            else if (percent >= 60)
            {
                return ("D");
            }
            else
            {
                return ("F");
            }
        }

        private void FinishQuiz()
        {
            MessageBox.Show($"Quiz over nerdddddd. You got {GetGrade}");
            lblMessage.Text = ($"You got {GetPercentScore}%");
            lblMessage.ForeColor = Color.LightCoral;
            btnSubmit.Enabled = false;
        }


        //so i was getting errors if i changed the name of the button here but it's btnSubmit and it even works elsewhere so i dont know what was happening
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("oh you clicked me");
            if (txtAnswer.Text == (questions[currentQuestion, 1]).ToLower())
            {
                ShowFeedback("Correct", Color.DarkViolet);
                correct++;
            }
            else
            {
                ShowFeedback("Wrong", Color.Firebrick);
            }

            //increment question
            currentQuestion++;

            //are there more questions?

            if (currentQuestion < questions.GetLength(0))
            {
                lblQuestion.Text = questions[currentQuestion, 0];
            }

            else
            {
                FinishQuiz();
            }

            //clear line
            txtAnswer.Text = "";
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;
            correct = 0;
            lblMessage.Text = "Restarting the quiz";
            lblQuestion.Text = questions[0, 0];
            btnSubmit.Enabled = true;
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (isDark == false)
            {
                isDark = true;
                //background colour
                BackColor = Color.Black;

                //Restart button colour change
                btnRestart.BackColor = Color.DimGray;
                btnRestart.ForeColor = Color.White;

                //Theme button colour change
                btnTheme.BackColor = Color.DimGray;
                btnTheme.ForeColor = Color.White;

                //question text colour
                lblQuestion.ForeColor = Color.White;
                lblQuestion.BackColor = Color.DimGray;

                //feedback text initial colour
                lblMessage.ForeColor = Color.White;
                lblMessage.BackColor = Color.DimGray;

                //submit button colour change
                btnSubmit.BackColor = Color.DimGray;
                btnSubmit.ForeColor = Color.White;

                //answer field colour change
                txtAnswer.BackColor = Color.DimGray;
                txtAnswer.ForeColor = Color.White;

            }

            else
            {
                isDark = false;

                //background colour
                BackColor = Color.White;

                //Restart button colour change
                btnRestart.BackColor = Color.White;
                btnRestart.ForeColor = Color.Black;

                //Theme button colour change
                btnTheme.BackColor = Color.White;
                btnTheme.ForeColor = Color.Black;

                //question text colour
                lblQuestion.ForeColor = Color.Black;
                lblQuestion.BackColor = Color.White;

                //feedback text initial colour
                lblMessage.ForeColor = Color.Black;
                lblMessage.BackColor= Color.White;

                //submit button colour change
                btnSubmit.ForeColor = Color.Black;
                btnSubmit.BackColor= Color.White;

                //answer field colour change
                txtAnswer.BackColor = Color.White;
                txtAnswer.ForeColor = Color.Black;

            }
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
