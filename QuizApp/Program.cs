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
            Question q3 = new Question() { question = "What is the square root of 64?", answer = "8", difficulty = 3, category = "Science"};
            ChoiceQuestion q4 = new ChoiceQuestion() { question = "Which company made the IPhone?", difficulty = 1, category = "Economy"};
            ChoiceQuestion q5 = new ChoiceQuestion() { question = "The Netherlands was founded in 1845", difficulty = 2, category = "History" };
            Question q6 = new Question() { question = "What is the gravitational acceleration on earth?", answer = "9.81", difficulty = 3, category = "Science"};

            q2.addChoice("12 Million", false);
            q2.addChoice("17 Million", true);
            q2.addChoice("35 Million", false);
            q2.addChoice("7 Million", false);

            q4.addChoice("Google", false);
            q4.addChoice("Tesla", false);
            q4.addChoice("Pear", false);
            q4.addChoice("Apple", true);

            q5.addChoice("True", false);
            q5.addChoice("False", true);

            List<Question> questions = new List<Question>();
            questions.Add(q1);
            questions.Add(q2);
            questions.Add(q3);
            questions.Add(q4);
            questions.Add(q5);
            questions.Add(q6);

            var orderedByDifficulty = questions.OrderBy(x => x.difficulty)
                                                .GroupBy(x => x.difficulty);
            var orderedByCategory = questions.OrderBy(x => x.category)
                                                .GroupBy(x => x.category);

            Console.WriteLine(orderedByDifficulty);

            presentQuestion(q1);
            presentChoiceQuestion(q2);
            presentQuestion(q3);
            presentChoiceQuestion(q4);
            presentChoiceQuestion(q5);
            presentQuestion(q6);

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
