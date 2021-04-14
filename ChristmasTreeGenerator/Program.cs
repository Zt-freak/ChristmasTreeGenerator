using System;

namespace ChristmasTreeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToConvert;
            do
            {
                Console.WriteLine("Gimme the word:");
                textToConvert = Console.ReadLine();
                //Add tildes if the text is too short
                if (!string.IsNullOrWhiteSpace(textToConvert) && textToConvert.Length < 9)
                {
                    textToConvert += new string('~', 9 - textToConvert.Length);
                }
                //Determine the length of the part of the tree with needles
                int treeNeedleLength = Convert.ToInt32(textToConvert.Length * 0.75);

                string[] christmasTreeArray = new string[textToConvert.Length];
                for (int i = 0; i < textToConvert.Length; i++)
                {
                    //Create the tree stem
                    if (i > treeNeedleLength)
                    {
                        christmasTreeArray[i] = new string(textToConvert[i], Convert.ToInt32(treeNeedleLength * 0.5));
                        christmasTreeArray[i] = christmasTreeArray[i].Insert(0, new string(' ', Convert.ToInt32(treeNeedleLength * 0.8)));
                    }
                    //Create the tree needles
                    else
                    {
                        christmasTreeArray[i] = new string(textToConvert[i], i * 2 + 1);
                        christmasTreeArray[i] = christmasTreeArray[i].Insert(0, new string(' ', (treeNeedleLength - i) + 1));
                    }

                    //Make the tree green
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }

                    Console.WriteLine(christmasTreeArray[i]);
                }
                Console.ResetColor();
            }
            while (!string.IsNullOrWhiteSpace(textToConvert));
        }
    }
}
