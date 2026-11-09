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
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.Highlight;
            btnSubmit.Cursor = Cursors.NoMoveHoriz;
            btnSubmit.FlatAppearance.BorderColor = Color.Yellow;
            btnSubmit.FlatAppearance.BorderSize = 12;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.ForeColor = Color.Red;
            btnSubmit.Location = new Point(595, 140);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 216);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "awesome button";
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
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(439, 23);
            txtAnswer.TabIndex = 3;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(841, 61);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(426, 50);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "ENTER YOUR ANSWER";
            lblMessage.Click += lblMessage_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(1321, 418);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(75, 23);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // btnTheme
            // 
            btnTheme.Location = new Point(868, 114);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(371, 194);
            btnTheme.TabIndex = 6;
            btnTheme.Text = "change theme :D";
            btnTheme.UseVisualStyleBackColor = true;
            btnTheme.Click += btnTheme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1396, 444);
            Controls.Add(btnTheme);
            Controls.Add(btnRestart);
            Controls.Add(lblMessage);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
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
    }
}
