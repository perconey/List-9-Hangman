﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Logic
{
    class ConsoleKeyboard
    {
        private KeyValuePair<char, bool>[] _keyboardChars = new KeyValuePair<char, bool>[29]
        {
           new KeyValuePair<char, bool>('q', false),//0
           new KeyValuePair<char, bool>('w', false),//1
           new KeyValuePair<char, bool>('e', false),//2
           new KeyValuePair<char, bool>('r', false),//3
           new KeyValuePair<char, bool>('t', false),//4
           new KeyValuePair<char, bool>('y', false),//5
           new KeyValuePair<char, bool>('u', false),//6
           new KeyValuePair<char, bool>('i', false),//7
           new KeyValuePair<char, bool>('o', false),//8
           new KeyValuePair<char, bool>('p', false),//9

           new KeyValuePair<char, bool>('/', false),//10

           new KeyValuePair<char, bool>('a', false),//11
           new KeyValuePair<char, bool>('s', false),//12
           new KeyValuePair<char, bool>('d', false),//13
           new KeyValuePair<char, bool>('f', false),//14
           new KeyValuePair<char, bool>('g', false),//15
           new KeyValuePair<char, bool>('h', false),//16
           new KeyValuePair<char, bool>('j', false),//17
           new KeyValuePair<char, bool>('k', false),//18
           new KeyValuePair<char, bool>('l', false),//19

           new KeyValuePair<char, bool>('/', false),//20

           new KeyValuePair<char, bool>('z', false),//21
           new KeyValuePair<char, bool>('x', false),//22
           new KeyValuePair<char, bool>('c', false),//23
           new KeyValuePair<char, bool>('v', false),//24
           new KeyValuePair<char, bool>('b', false),//25
           new KeyValuePair<char, bool>('n', false),//26
           new KeyValuePair<char, bool>('m', false),//27

           new KeyValuePair<char, bool>('#', false)//28
        };
        private bool _isDisplayed;

        public KeyValuePair<char, bool>[] KeyboardChars { get => _keyboardChars; set => _keyboardChars = value; }

        public bool IsDisplayed { get => _isDisplayed; set => _isDisplayed = value; }

        public void Display()
        {
            int i = 1;
            Console.Write("  ");
            foreach(var element in KeyboardChars)
            {
                if (element.Key != '/' && element.Key != '#')
                {
                    if(element.Value == true)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(element.Key + " ");
                    }
                }
                else
                {
                    if (element.Key == '#')
                    {
                        Console.Write("\n\n");
                    }
                    else
                    {
                        Console.WriteLine();
                        for(int j = 0; j < i + 2; j++)
                        {
                            Console.Write(" ");
                        }
                        i++;
                    }
                }
            };
        }

        public void Reset()
        {
            KeyboardChars = new KeyValuePair<char, bool>[29]
            {
                new KeyValuePair<char, bool>('q', false),//0
           new KeyValuePair<char, bool>('w', false),
           new KeyValuePair<char, bool>('e', false),
           new KeyValuePair<char, bool>('r', false),
           new KeyValuePair<char, bool>('t', false),
           new KeyValuePair<char, bool>('y', false),
           new KeyValuePair<char, bool>('u', false),
           new KeyValuePair<char, bool>('i', false),
           new KeyValuePair<char, bool>('o', false),
           new KeyValuePair<char, bool>('p', false),

           new KeyValuePair<char, bool>('/', false),

           new KeyValuePair<char, bool>('a', false),
           new KeyValuePair<char, bool>('s', false),
           new KeyValuePair<char, bool>('d', false),
           new KeyValuePair<char, bool>('f', false),
           new KeyValuePair<char, bool>('g', false),
           new KeyValuePair<char, bool>('h', false),
           new KeyValuePair<char, bool>('j', false),
           new KeyValuePair<char, bool>('k', false),
           new KeyValuePair<char, bool>('l', false),

           new KeyValuePair<char, bool>('/', false),

           new KeyValuePair<char, bool>('z', false),
           new KeyValuePair<char, bool>('x', false),
           new KeyValuePair<char, bool>('c', false),
           new KeyValuePair<char, bool>('v', false),
           new KeyValuePair<char, bool>('b', false),
           new KeyValuePair<char, bool>('n', false),
           new KeyValuePair<char, bool>('m', false),

           new KeyValuePair<char, bool>('#', false) 
            };
        }
    }
}
