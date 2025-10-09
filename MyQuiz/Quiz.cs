using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuiz
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta; // Change text color to dark magenta
                Console.Write("  ");   // Indentation for better readability
                Console.Write(i + 1);   // Display answer number (1-based index)
                Console.ResetColor(); // Reset to default color
                Console.WriteLine($". {question.Answers[i]}");  // Display answer text
            }
        }
    }
}
