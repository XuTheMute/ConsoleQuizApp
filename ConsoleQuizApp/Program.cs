using static System.Formats.Asn1.AsnWriter;

namespace ConsoleQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<QuizQuestion> questions = GetQuizQuestions();

            int score = 0;

            foreach (QuizQuestion question in questions) {
                if (AskQuestion(question)) score++;
            }

            Console.WriteLine($"You answered {score} out of {questions.Count} questions correctly.");


        }
        private static List<QuizQuestion> GetQuizQuestions()
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

            return questions;
        }

        private static bool AskQuestion(QuizQuestion question)
        {
            Console.WriteLine(question.Question);
            string userAnswer = Console.ReadLine();

            if (userAnswer.Equals(question.Answer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine("Your answer is correct.");
                return true;
            }
            else
            {
                Console.WriteLine($"The right answer is {question.Answer}");
                return false;
            }
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
