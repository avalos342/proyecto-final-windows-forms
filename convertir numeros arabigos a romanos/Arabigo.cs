﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertir_numeros_arabigos_a_romanos
{
    class Arabigo
    {
        public int Simplerconverter(string number)
        {
            number = number.ToUpper();
            int result = 0;
            foreach (char letter in number)
            {
                result += LetterToNumber(letter);
            }
            if (number.Contains("IV") || number.Contains("IX"))
                result -= 2;
            if (number.Contains("XL") || number.Contains("XC"))
                result -= 20;
            if (number.Contains("CD") || number.Contains("CM"))
                result -= 200;

            return result;
        }
        public int LetterToNumber(char letter)
        {
            switch (letter)
            {
                case 'M':
                    {
                        return 1000;
                    }
                case 'D':
                    {
                        return 500;
                    }
                case 'C':
                    {
                        return 100;
                    }
                case 'L':
                    {
                        return 50;
                    }
                case 'X':
                    {
                        return 10;
                    }
                case 'V':
                    {
                        return 5;
                    }
                case 'I':
                    {
                        return 1;
                    }
                default:
                    {
                        throw new ArgumentException("Caracter Invalido");

                    }
            }
        }
    }
}
