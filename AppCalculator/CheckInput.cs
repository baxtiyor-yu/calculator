﻿using System.Text.RegularExpressions;

namespace AppCalculator
{
    internal class CheckInput
    {
        const string CHECKERS = "0123456789.+-*/()";
        const string CHECKOPERATORS = ".+-*/(";
        internal static string Checker()
        {   
            ConsoleKeyInfo key;
            string _val = "";
            bool stopWhile = false;
            Console.CursorVisible = true;
            Console.Write("Enter your value: ");    

            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    if (CHECKERS.Contains(key.KeyChar.ToString()))
                    { 
                        _val += key.KeyChar;

                        if (key.KeyChar == ')' && !IsBalanced(_val))
                        {
                            _val = _val.Substring(0, (_val.Length - 1));
                        }
                        else if (_val.Length>1 && SequenceSigns(_val))
                        {
                            _val = _val.Substring(0, (_val.Length - 1));
                        }
                        else
                        {
                            Console.Write(key.KeyChar);
                        }
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    //check if at least two operands exists
                    if (LessThanTwoOperands(_val))
                    {
                        return "Error. Less than two operands";
                    }

                    if (CHECKOPERATORS.Contains(_val.Last()))
                    {
                        return "Error. Expression shouldn't end with .+-*/( characters";                        
                    }

                    if (!IsFullBalanced(_val))
                    {
                        return "Error. Unbalanced parentheses count";
                    }
                    
                    stopWhile = true;                    
                }
            } while (!stopWhile);

            Console.WriteLine();
            return _val;
        }
        private static bool LessThanTwoOperands(string _val)
        {
            //string pattern = @"\b\d+";
            string pattern = @"\b\d+\.*\d*";
            Regex rg = new Regex(pattern);
            MatchCollection matchedItem = rg.Matches(_val);
            if (matchedItem.Count < 2)
            {
                return true;
            }
            return false;
        }
        private static bool SequenceSigns(string _val)
        {
            string pattern = @"[*/+-.][*/+-.)]|[\d.][(]|[(][*/]|[.][0-9]*[.]";
            Regex rg = new Regex(pattern);
            Match matchedItem1 = rg.Match(_val);
            if (matchedItem1.Success)
            {
                return true;
            }
            return false;
        }

        public static bool IsBalanced(string _val)
        {
            bool flag = true;
            int count = 0;

            for (int i = 0; i < _val.Length; i++)
            {
                if (_val[i] == '(')
                {
                    count++;
                }
                if (_val[i] == ')')
                {
                    count--;
                }                                
            }
            if (count < 0)
            {
                flag = false;
            }
            return flag;
        }

        public static bool IsFullBalanced(string _val)
        {
            bool flag = true;
            int count = 0;

            for (int i = 0; i < _val.Length; i++)
            {
                if (_val[i] == '(')
                {
                    count++;
                }
                if (_val[i] == ')')
                {
                    count--;
                }
            }
            if (count != 0)
            {
                flag = false;
            }
            return flag;
        }
    }
}
