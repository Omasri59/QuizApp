using System;

namespace QuizApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Question q1 = new Question() { question = "What is the capital of China?", answer = "Beijing"};
            ChoiceQuestion q2 = new ChoiceQuestion() {question = "What is the population of the Netherlands?"};
            q2.addChoice("12 Million", false);
            q2.addChoice("17 Million", true);
            q2.addChoice("35 Million", false);
            q2.addChoice("7 Million", false);



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
