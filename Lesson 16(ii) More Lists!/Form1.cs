/*
 * Using 2D lists and Reading/Writing to Text Files
 * December 12 2025
 */
using System;
using System.Collections.Generic;
using System.IO;
namespace Lesson_16_ii__More_Lists_
{
    public partial class Form1 : Form

    {
        //Creating a file path for the text file
        string filePath = @"C:\Users\cmsto\Documents\ICS3U\Lessons\arrayslesson\grades.txt";//CHANGE THIS FOR YOURSELF!
        //My grades will get listed in students
        // I make a class called "PERSON".  Person will have properties (I decide this) of Name and Grade.
        List<Person> students = new List<Person>
    {
        new Person { Name = "Ferd", Grade = 65 },
        new Person { Name = "Dref", Grade= 84 },
        new Person { Name = "Ferdette", Grade= 75 }
    };

        // Make your list here of gamePlayers
        public Form1()
        {
            InitializeComponent();
        }
        //creating Person with Name and Grade properties. 
        class Person
        {
            public string Name { get; set; }
            public int Grade { get; set; }
        }
        // create your Player class here with properties of Name and Score
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputListButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            for (int i = 0; i < students.Count; i++)
            {
                outputLabel.Text += students[i].Name + " " + students[i].Grade + "      ";
            }

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            string name = nameBox.Text;
            int grade = int.Parse(gradeBox.Text);

            students.Add(new Person { Name = name, Grade = grade });
            for (int i = 0; i < students.Count; i++)
            {
                outputLabel.Text += students[i].Name + " " + students[i].Grade + "      ";
            }
        }

        private void sortListButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            students.Sort((p1, p2) => p2.Grade.CompareTo(p1.Grade));
            for (int i = 0; i < students.Count; i++)
            {
                outputLabel.Text += students[i].Name + " " + students[i].Grade + "      ";
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, ""); // clear file first

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    writer.WriteLine(students[i].Name);
                    writer.WriteLine(students[i].Grade);
                }
            }

            outputLabel.Text = "Students saved to file!";
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            
            students.Clear();//clear list before adding items read from file
            
            string[] lines = File.ReadAllLines(filePath);
            string name;
            int grade;
            for (int i = 0; i < lines.Length; i = i + 2)
            {
                name = lines[i];
                grade = Convert.ToInt16(lines[i + 1]);
                students.Add(new Person { Name = name, Grade = grade });
            }

        }
    }
}
