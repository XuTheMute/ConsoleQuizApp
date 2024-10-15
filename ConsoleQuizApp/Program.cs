namespace ConsoleQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> questions = new List<QuizQuestion>();

            questions.Add(new QuizQuestion("On which continent would you find the world’s largest desert?", "Antarctica"));
            questions.Add(new QuizQuestion("Who wrote the play \"Romeo and Juliet\"?", "William Shakespeare"));
            questions.Add(new QuizQuestion("What is the capital of Japan?", "Tokyo"));
            questions.Add(new QuizQuestion("What is the chemical symbol for gold?", "Au"));
            questions.Add(new QuizQuestion("Who painted the Mona Lisa?", "Leonardo da Vinci"));
            questions.Add(new QuizQuestion("What is the main ingredient in guacamole?", "Avocado"));
            questions.Add(new QuizQuestion("Who developed the theory of relativity?", "Albert Einstein"));
            questions.Add(new QuizQuestion("What is the currency of the United Kingdom?", "Pound sterling"));
            questions.Add(new QuizQuestion("What is the square root of 64?", "8"));
            questions.Add(new QuizQuestion("What is the smallest prime number?", "2"));

            int score = 0;

            foreach (QuizQuestion question in questions) {
                Console.WriteLine(question.Question);
                string userAnswer = Console.ReadLine();

                if (userAnswer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    score++;
                    Console.WriteLine("Your answer is correct.");
                }
                else
                {
                    Console.WriteLine($"The right answer is {question.Answer}");
                }
            }

            Console.WriteLine($"You are right answered on {score} questions of {questions.Count}. You get {score} points.");


        }

        private class QuizQuestion
        {
            public string Question { get; set; }
            public string Answer { get; set; }

            public QuizQuestion(string question, string answer)
            {
                Question = question;
                Answer = answer;
            }

        }
    }

    
}
