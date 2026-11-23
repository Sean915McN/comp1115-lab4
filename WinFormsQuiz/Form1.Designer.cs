namespace WinFormsQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            lblMessage = new Label();
            btnRestart = new Button();
            btnTheme = new Button();
            lblTimer = new Label();
            txtTimeLimit = new TextBox();
            btnSetTimeLimit = new Button();
            btnCounter = new Button();
            txtCounter = new TextBox();
            lblCounter = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.White;
            btnSubmit.Cursor = Cursors.NoMoveHoriz;
            btnSubmit.FlatAppearance.BorderColor = Color.Yellow;
            btnSubmit.FlatAppearance.BorderSize = 12;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(679, 51);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(122, 41);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(56, 64);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(174, 17);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "What it the capital of Japan?";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(234, 61);
            txtAnswer.MaxLength = 21;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(439, 23);
            txtAnswer.TabIndex = 3;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(807, 42);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(426, 50);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "ENTER YOUR ANSWER";
            lblMessage.Click += lblMessage_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(1262, 391);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(122, 41);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnTheme
            // 
            btnTheme.Location = new Point(12, 391);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(122, 41);
            btnTheme.TabIndex = 6;
            btnTheme.Text = "toggle theme";
            btnTheme.UseVisualStyleBackColor = true;
            btnTheme.Click += btnTheme_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(679, 146);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(64, 15);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "Time Limit";
            lblTimer.Click += txtTimer_Click;
            // 
            // txtTimeLimit
            // 
            txtTimeLimit.Location = new Point(665, 164);
            txtTimeLimit.Name = "txtTimeLimit";
            txtTimeLimit.Size = new Size(100, 23);
            txtTimeLimit.TabIndex = 8;
            // 
            // btnSetTimeLimit
            // 
            btnSetTimeLimit.Location = new Point(679, 193);
            btnSetTimeLimit.Name = "btnSetTimeLimit";
            btnSetTimeLimit.Size = new Size(75, 23);
            btnSetTimeLimit.TabIndex = 9;
            btnSetTimeLimit.Text = "Set";
            btnSetTimeLimit.UseVisualStyleBackColor = true;
            btnSetTimeLimit.Click += btnSetTimeLimit_Click;
            // 
            // btnCounter
            // 
            btnCounter.Location = new Point(315, 219);
            btnCounter.Name = "btnCounter";
            btnCounter.Size = new Size(75, 23);
            btnCounter.TabIndex = 10;
            btnCounter.Text = "Start Quiz";
            btnCounter.UseVisualStyleBackColor = true;
            btnCounter.Click += btnCounter_Click;
            // 
            // txtCounter
            // 
            txtCounter.Location = new Point(301, 190);
            txtCounter.MaxLength = 1;
            txtCounter.Name = "txtCounter";
            txtCounter.Size = new Size(100, 23);
            txtCounter.TabIndex = 11;
            txtCounter.TextChanged += txtCounter_TextChanged;
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.Location = new Point(301, 146);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(108, 15);
            lblCounter.TabIndex = 12;
            lblCounter.Text = "Set Total Questions";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Green;
            pictureBox1.Location = new Point(218, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 147);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1396, 444);
            Controls.Add(lblCounter);
            Controls.Add(txtCounter);
            Controls.Add(btnCounter);
            Controls.Add(btnSetTimeLimit);
            Controls.Add(txtTimeLimit);
            Controls.Add(lblTimer);
            Controls.Add(btnTheme);
            Controls.Add(btnRestart);
            Controls.Add(lblMessage);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(btnSubmit);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblQuestion;
        private TextBox txtAnswer;
        private Label lblMessage;
        private Button btnRestart;
        private Button btnTheme;
        private Label lblTimer;
        private TextBox txtTimeLimit;
        private Button btnSetTimeLimit;
        private Button btnCounter;
        private TextBox txtCounter;
        private Label lblCounter;
        private PictureBox pictureBox1;
    }
}
