namespace MyQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                            "What is the capital of France?", // Question text
                            new string[] { "Berlin", "Madrid", "Paris", "Rome" }, // Possible answers
                            2 // Index of the correct answer (0-based index
                            )
            };

            Quiz quiz = new Quiz(questions);
            quiz.DisplayQuestion(questions[0]);
            Console.ReadLine();
        }
    }
}
