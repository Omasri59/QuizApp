using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Question q1 = new Question() { question = "What is the capital of China?", answer = "Beijing", difficulty = 2, category = "Geography"};
            ChoiceQuestion q2 = new ChoiceQuestion() { question = "What is the population of the Netherlands?", difficulty = 1, category = "Geography"};
            q2.addChoice("12 Million", false);
            q2.addChoice("17 Million", true);
            q2.addChoice("35 Million", false);
            q2.addChoice("7 Million", false);

            List<Question> questions = new List<Question>();
            questions.Add(q1);
            questions.Add(q2);

            var groupedByDifficulty = questions.GroupBy(x => x.difficulty);
            var groupedByCategory = questions.GroupBy(x => x.category);

            presentQuestion(q1);
            presentChoiceQuestion(q2);

        }

        public static void presentQuestion(Question q)
        { 
            q.display();
            Console.WriteLine("Your answer: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(response));
        }

        public static void presentChoiceQuestion(ChoiceQuestion cq)
        {
            cq.Display();
            Console.WriteLine("Your answer: ");
            string response = Console.ReadLine();
            Console.WriteLine(cq.checkAnswer(response));
        }
    }
}
