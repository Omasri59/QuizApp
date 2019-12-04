using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    class ChoiceQuestion : Question
    {
        private List<string> choices;
        int sizeOfList;
        Question q;
        public ChoiceQuestion()
        {
            choices = new List<string>();
            q = new Question();
        }

        public void addChoice(string choice, bool correct)
        {
            choices.Add(choice);
            if (correct)
            {
                sizeOfList = choices.Count;
                string choiceString = "" + sizeOfList;
                answer = choiceString;
            }
        }

        public void Display()
        {
            base.display();

            for (int i = 0; i < choices.Count; i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine(choiceNumber + ": " + choices[i]);
            }
        }
    }
}
