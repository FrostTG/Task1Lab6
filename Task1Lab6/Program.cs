using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split(' '); //разбиваем на слова (разделитель пробел)         
            int n = 0, max = 0;            
            for (int i = 0; i < stringArray.Length; i++) //определяет из скольких букв состоит слово
            {
                if (stringArray.Length > max) //по каждой букве в слове повторяет цикл, тем самым узнаем длину слова
                {
                    max = stringArray[i].Length; //самая большая длина останется
                    n = i;
                }
                
            }
            Console.Write("Самое длинное слово {0}",stringArray[n]); //добавляет слово состоящее из n букв
            Console.ReadKey();
            


        }
    }
}
