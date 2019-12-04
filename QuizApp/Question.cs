using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    class Question
    {
        public string question { get; set; }

        public string answer { get; set; }

        public Question()
        {
            question = "";
            answer = "";
        }

        public bool checkAnswer(string response)
        {
            return response.Equals(answer);
        }

        public void display()
        {
            Console.WriteLine(question);
        }

    }
}

