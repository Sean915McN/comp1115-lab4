namespace WinFormsQuiz
{
    public partial class Form1 : Form
    {

        //array of questions and answers
        string[,] questions = new string[3, 2];

        //track question
        int currentQuestion = 0;

        //track correct answers
        int correct = 0;

        //startup method, runs automatically upon loading
        public Form1()
        {
            InitializeComponent();

            //populate array
            questions[0, 0] = "What's the capital of Japan?";
            questions[0, 1] = "Tokyo";
            questions[1, 0] = "Bogos?";
            questions[1, 1] = "Binted";
            questions[2, 0] = "What time is it?";
            questions[2, 1] = "Time to get a watch";

            //show 1st question on label
            lblQuestion.Text = questions[0, 0];
        }

        //so i was getting errors if i changed the name of the button here but it's btnSubmit
        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("oh you clicked me");
            if (txtAnswer.Text == (questions[currentQuestion, 1]))
            {
                lblMessage.Text = "Correct";
                lblMessage.ForeColor = Color.DarkViolet;
                correct++;
            }
            else
            {
                lblMessage.Text = "Wrong";
                lblMessage.ForeColor = Color.Firebrick;
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
                MessageBox.Show($"Quiz over nerdddddd. You got {correct} correct");
                lblQuestion.Text = ($"You got {correct} out of {questions.GetLength(0)}");
                btnSubmit.Enabled = false;
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
    }
}
