namespace Lesson_16_ii__More_Lists_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            outputLabel = new Label();
            label3 = new Label();
            outputListButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            gradeBox = new TextBox();
            nameBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            addStudentButton = new Button();
            label9 = new Label();
            sortListButton = new Button();
            label10 = new Label();
            outputButton = new Button();
            label11 = new Label();
            readFileButton = new Button();
            label12 = new Label();
            playerOutputButton = new Button();
            instructionButton = new Button();
            label13 = new Label();
            label14 = new Label();
            playerTextBox = new TextBox();
            scoreTextBox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            sortPlayerButton = new Button();
            label18 = new Label();
            saveScoreButton = new Button();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            readScoresButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Green;
            label1.Location = new Point(329, 55);
            label1.Name = "label1";
            label1.Size = new Size(14, 365);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(1, 9);
            label2.Name = "label2";
            label2.Size = new Size(672, 70);
            label2.TabIndex = 1;
            label2.Text = "Today we will see how we can store data in lists that can be saved in external files so we can call upon them after we have closed the application.  ";
            // 
            // outputLabel
            // 
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.Location = new Point(66, 439);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(542, 64);
            outputLabel.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1, 106);
            label3.Name = "label3";
            label3.Size = new Size(204, 66);
            label3.TabIndex = 3;
            label3.Text = "In the global variables, I created a list with students names and grades.  This button will output the list.";
            // 
            // outputListButton
            // 
            outputListButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputListButton.ForeColor = Color.Maroon;
            outputListButton.Location = new Point(229, 106);
            outputListButton.Name = "outputListButton";
            outputListButton.Size = new Size(75, 45);
            outputListButton.TabIndex = 4;
            outputListButton.Text = "Show List";
            outputListButton.UseVisualStyleBackColor = true;
            outputListButton.Click += outputListButton_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1, 184);
            label4.Name = "label4";
            label4.Size = new Size(164, 24);
            label4.TabIndex = 5;
            label4.Text = "Lets add to the list";
            // 
            // label5
            // 
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(1, 66);
            label5.Name = "label5";
            label5.Size = new Size(54, 24);
            label5.TabIndex = 6;
            label5.Text = "DEMO";
            // 
            // label6
            // 
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(349, 66);
            label6.Name = "label6";
            label6.Size = new Size(106, 24);
            label6.TabIndex = 7;
            label6.Text = "You Try";
            // 
            // gradeBox
            // 
            gradeBox.Location = new Point(123, 221);
            gradeBox.Name = "gradeBox";
            gradeBox.Size = new Size(100, 26);
            gradeBox.TabIndex = 8;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 221);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 26);
            nameBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(42, 208);
            label7.Name = "label7";
            label7.Size = new Size(54, 24);
            label7.TabIndex = 10;
            label7.Text = "name";
            // 
            // label8
            // 
            label8.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(151, 208);
            label8.Name = "label8";
            label8.Size = new Size(54, 24);
            label8.TabIndex = 11;
            label8.Text = "grade";
            // 
            // addStudentButton
            // 
            addStudentButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentButton.ForeColor = Color.Maroon;
            addStudentButton.Location = new Point(238, 202);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(75, 45);
            addStudentButton.TabIndex = 12;
            addStudentButton.Text = "Add to List";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1, 264);
            label9.Name = "label9";
            label9.Size = new Size(164, 24);
            label9.TabIndex = 13;
            label9.Text = "Lets sort the list";
            // 
            // sortListButton
            // 
            sortListButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortListButton.ForeColor = Color.Maroon;
            sortListButton.Location = new Point(148, 259);
            sortListButton.Name = "sortListButton";
            sortListButton.Size = new Size(75, 24);
            sortListButton.TabIndex = 14;
            sortListButton.Text = "Sort";
            sortListButton.UseVisualStyleBackColor = true;
            sortListButton.Click += sortListButton_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1, 315);
            label10.Name = "label10";
            label10.Size = new Size(164, 36);
            label10.TabIndex = 15;
            label10.Text = "Output the list to an external file";
            // 
            // outputButton
            // 
            outputButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputButton.ForeColor = Color.Maroon;
            outputButton.Location = new Point(171, 315);
            outputButton.Name = "outputButton";
            outputButton.Size = new Size(104, 24);
            outputButton.TabIndex = 16;
            outputButton.Text = "Save Data";
            outputButton.UseVisualStyleBackColor = true;
            outputButton.Click += outputButton_Click;
            // 
            // label11
            // 
            label11.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1, 368);
            label11.Name = "label11";
            label11.Size = new Size(164, 36);
            label11.TabIndex = 17;
            label11.Text = "Read the File Into Students";
            // 
            // readFileButton
            // 
            readFileButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readFileButton.ForeColor = Color.Maroon;
            readFileButton.Location = new Point(171, 368);
            readFileButton.Name = "readFileButton";
            readFileButton.Size = new Size(104, 24);
            readFileButton.TabIndex = 18;
            readFileButton.Text = "ReadFIle";
            readFileButton.UseVisualStyleBackColor = true;
            readFileButton.Click += readFileButton_Click;
            // 
            // label12
            // 
            label12.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(349, 91);
            label12.Name = "label12";
            label12.Size = new Size(559, 34);
            label12.TabIndex = 19;
            label12.Text = "1 - Create a class Player with properties of Name and Score (very similar to person)";
            // 
            // playerOutputButton
            // 
            playerOutputButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerOutputButton.ForeColor = Color.Maroon;
            playerOutputButton.Location = new Point(914, 91);
            playerOutputButton.Name = "playerOutputButton";
            playerOutputButton.Size = new Size(75, 45);
            playerOutputButton.TabIndex = 20;
            playerOutputButton.Text = "Show List";
            playerOutputButton.UseVisualStyleBackColor = true;
            // 
            // instructionButton
            // 
            instructionButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionButton.ForeColor = Color.Maroon;
            instructionButton.Location = new Point(914, 180);
            instructionButton.Name = "instructionButton";
            instructionButton.Size = new Size(75, 58);
            instructionButton.TabIndex = 21;
            instructionButton.Text = "Add to your list";
            instructionButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(349, 126);
            label13.Name = "label13";
            label13.Size = new Size(559, 46);
            label13.TabIndex = 22;
            label13.Text = "2 - In your globals create a list called gamePlayer and populate the list with two or three names";
            // 
            // label14
            // 
            label14.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(349, 162);
            label14.Name = "label14";
            label14.Size = new Size(640, 26);
            label14.TabIndex = 23;
            label14.Text = "3 - In the code for this button output your list to outputLabel";
            // 
            // playerTextBox
            // 
            playerTextBox.Location = new Point(677, 208);
            playerTextBox.Name = "playerTextBox";
            playerTextBox.Size = new Size(99, 26);
            playerTextBox.TabIndex = 25;
            // 
            // scoreTextBox
            // 
            scoreTextBox.Location = new Point(788, 208);
            scoreTextBox.Name = "scoreTextBox";
            scoreTextBox.Size = new Size(99, 26);
            scoreTextBox.TabIndex = 24;
            // 
            // label15
            // 
            label15.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Green;
            label15.Location = new Point(707, 195);
            label15.Name = "label15";
            label15.Size = new Size(53, 15);
            label15.TabIndex = 26;
            label15.Text = "player";
            // 
            // label16
            // 
            label16.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Green;
            label16.Location = new Point(816, 195);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 27;
            label16.Text = "score";
            // 
            // label17
            // 
            label17.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(349, 202);
            label17.Name = "label17";
            label17.Size = new Size(298, 22);
            label17.TabIndex = 28;
            label17.Text = "4 - Add code to add players to your list";
            // 
            // sortPlayerButton
            // 
            sortPlayerButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortPlayerButton.ForeColor = Color.Maroon;
            sortPlayerButton.Location = new Point(519, 227);
            sortPlayerButton.Name = "sortPlayerButton";
            sortPlayerButton.Size = new Size(75, 24);
            sortPlayerButton.TabIndex = 30;
            sortPlayerButton.Text = "Sort";
            sortPlayerButton.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(349, 228);
            label18.Name = "label18";
            label18.Size = new Size(164, 24);
            label18.TabIndex = 29;
            label18.Text = "5- Lets sort the list";
            // 
            // saveScoreButton
            // 
            saveScoreButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveScoreButton.ForeColor = Color.Maroon;
            saveScoreButton.Location = new Point(661, 278);
            saveScoreButton.Name = "saveScoreButton";
            saveScoreButton.Size = new Size(104, 24);
            saveScoreButton.TabIndex = 32;
            saveScoreButton.Text = "Save Data";
            saveScoreButton.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(349, 259);
            label19.Name = "label19";
            label19.Size = new Size(682, 24);
            label19.TabIndex = 31;
            label19.Text = "6 - Add to globals:  string scoreFilePath = @\"C:\\Users\\....\\score.txt”;  (you need to figure out the file path)";
            // 
            // label20
            // 
            label20.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(349, 315);
            label20.Name = "label20";
            label20.Size = new Size(351, 24);
            label20.TabIndex = 33;
            label20.Text = "8 - Add code to read your file back in";
            // 
            // label21
            // 
            label21.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(349, 283);
            label21.Name = "label21";
            label21.Size = new Size(306, 24);
            label21.TabIndex = 34;
            label21.Text = "7 - Add code to button to save your list";
            // 
            // readScoresButton
            // 
            readScoresButton.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readScoresButton.ForeColor = Color.Maroon;
            readScoresButton.Location = new Point(661, 310);
            readScoresButton.Name = "readScoresButton";
            readScoresButton.Size = new Size(104, 24);
            readScoresButton.TabIndex = 35;
            readScoresButton.Text = "ReadFIle";
            readScoresButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1105, 535);
            Controls.Add(readScoresButton);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(saveScoreButton);
            Controls.Add(label19);
            Controls.Add(sortPlayerButton);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(playerTextBox);
            Controls.Add(scoreTextBox);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(instructionButton);
            Controls.Add(playerOutputButton);
            Controls.Add(label12);
            Controls.Add(readFileButton);
            Controls.Add(label11);
            Controls.Add(outputButton);
            Controls.Add(label10);
            Controls.Add(sortListButton);
            Controls.Add(label9);
            Controls.Add(addStudentButton);
            Controls.Add(nameBox);
            Controls.Add(gradeBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(outputListButton);
            Controls.Add(label3);
            Controls.Add(outputLabel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Lesson 16 2.0 More Lists";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label outputLabel;
        private Label label3;
        private Button outputListButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox gradeBox;
        private TextBox nameBox;
        private Label label7;
        private Label label8;
        private Button addStudentButton;
        private Label label9;
        private Button sortListButton;
        private Label label10;
        private Button outputButton;
        private Label label11;
        private Button readFileButton;
        private Label label12;
        private Button playerOutputButton;
        private Button instructionButton;
        private Label label13;
        private Label label14;
        private TextBox playerTextBox;
        private TextBox scoreTextBox;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button sortPlayerButton;
        private Label label18;
        private Button saveScoreButton;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button readScoresButton;
    }
}
