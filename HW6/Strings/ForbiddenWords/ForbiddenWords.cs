﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            var strBuild = new StringBuilder(text);
            string[] words = word.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                strBuild.Replace(words[i], new string('*', words[i].Length));
            }
            Console.WriteLine(strBuild.ToString());
        }
    }
}
