using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndWords
{
    public class NumbersAndWords
    {
        public string Corvert(long val)
        {
            string result = "";
            string value = NumbersAndWords.Reverse(val.ToString());
            char[] numstr = value.ToCharArray();
            for (int i = 0; i < numstr.Length; i++)
            {
                bool isControl = false;
                if (numstr.Length != 1) 
                    isControl = numstr[1] == '1' ? true : false;

                if (i == 0 && !isControl)
                {
                    switch (numstr[i])
                    {
                        case '0': result += numstr.Length == 1 ? "ноль" : ""; break;
                        case '1': result += "один"; break;
                        case '2': result += "два"; break;
                        case '3': result += "три"; break;
                        case '4': result += "четыре"; break;
                        case '5': result += "пять"; break;
                        case '6': result += "шесть"; break;
                        case '7': result += "семь"; break;
                        case '8': result += "восемь"; break;
                        case '9': result += "девять"; break;
                    }
                }
               
                if (i == 0 && isControl)
                {
                    switch (numstr[i])
                    {
                        case '0': result += numstr.Length == 1 ? "ноль" : ""; break;
                        case '1': result += "один"; break;
                        case '2': result += "две"; break;
                        case '3': result += "три"; break;
                        case '4': result += "четыр"; break;
                        case '5': result += "пят"; break;
                        case '6': result += "шест"; break;
                        case '7': result += "сем"; break;
                        case '8': result += "восем"; break;
                        case '9': result += "девят"; break;
                    }
                }
               
                if (i == 1)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result += numstr[0] == '0' ? "десять" : "надцать"; break;
                        case '2': result = result.Insert(0, "двадцать "); break;
                        case '3': result = result.Insert(0, "тридцать "); break;
                        case '4': result = result.Insert(0, "сорок "); break;
                        case '5': result = result.Insert(0, "пятьдесят "); break;
                        case '6': result = result.Insert(0, "шестьдесят "); break;
                        case '7': result = result.Insert(0, "семьдесят "); break;
                        case '8': result = result.Insert(0, "восемьдесят "); break;
                        case '9': result = result.Insert(0, "девяносто "); break;
                    }

                }

                if (i == 2)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Insert(0, "сто "); break;
                        case '2': result = result.Insert(0, "двести "); break;
                        case '3': result = result.Insert(0, "триста "); break;
                        case '4': result = result.Insert(0, "четыреста "); break;
                        case '5': result = result.Insert(0, "пятьсот "); break;
                        case '6': result = result.Insert(0, "шестьсот "); break;
                        case '7': result = result.Insert(0, "семьсот "); break;
                        case '8': result = result.Insert(0, "восемьсот "); break;
                        case '9': result = result.Insert(0, "девятьсот "); break;
                    }
                }

                isControl = false;
                if (numstr.Length > 4)
                    isControl = numstr[4] == '1' ? true : false;

                if (i == 3 && !isControl)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Insert(0, "одна тысяча "); break;
                        case '2': result = result.Insert(0, "две тысячи "); break;
                        case '3': result = result.Insert(0, "три тысячи "); break;
                        case '4': result = result.Insert(0, "четыре тысячи "); break;
                        case '5': result = result.Insert(0, "пять тысяч "); break;
                        case '6': result = result.Insert(0, "шесть тысяч "); break;
                        case '7': result = result.Insert(0, "семь тысяч "); break;
                        case '8': result = result.Insert(0, "восемь тысяч "); break;
                        case '9': result = result.Insert(0, "девять тысяч "); break;
                    }
                }
               
                if (i == 3 && isControl)
                    {
                        switch (numstr[i])
                        {
                            case '0': result += ""; break;
                            case '1': result = result.Insert(0, "один "); break;
                            case '2': result = result.Insert(0, "две "); break;
                            case '3': result = result.Insert(0, "три "); break;
                            case '4': result = result.Insert(0, "четыр "); break;
                            case '5': result = result.Insert(0, "пят "); break;
                            case '6': result = result.Insert(0, "шест "); break;
                            case '7': result = result.Insert(0, "сем "); break;
                            case '8': result = result.Insert(0, "восем "); break;
                            case '9': result = result.Insert(0, "девят "); break;
                        }
                    }
            
                if (i == 4)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = numstr[3] == '0' ? result.Insert(0, "десять тысяч ") : result.Insert(result.IndexOf(' '), "надцать тысяч"); break;
                        case '2': result = result.Contains("тысяч") ? result.Insert(0, "двадцать ") : result.Insert(0, "двадцать тысяч "); break;
                        case '3': result = result.Contains("тысяч") ? result.Insert(0, "тридцать ") : result.Insert(0, "тридцать тысяч "); break;
                        case '4': result = result.Contains("тысяч") ? result.Insert(0, "сорок ") : result.Insert(0, "сорок тысяч "); break;
                        case '5': result = result.Contains("тысяч") ? result.Insert(0, "пятьдесят ") : result.Insert(0, "пятьдесят тысяч "); break;
                        case '6': result = result.Contains("тысяч") ? result.Insert(0, "шестьдесят ") : result.Insert(0, "шестьдесят тысяч "); break;
                        case '7': result = result.Contains("тысяч") ? result.Insert(0, "семьдесят ") : result.Insert(0, "семьдесят тысяч "); break;
                        case '8': result = result.Contains("тысяч") ? result.Insert(0, "восемьдесят ") : result.Insert(0, "восемьдесят тысяч "); break;
                        case '9': result = result.Contains("тысяч") ? result.Insert(0, "девяносто ") : result.Insert(0, "девяносто тысяч "); break;
                    }
                }

                if (i == 5)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Contains("тысяч") ? result.Insert(0, "сто ") : result.Insert(0, "сто тысяч "); break;
                        case '2': result = result.Contains("тысяч") ? result.Insert(0, "двести ") : result.Insert(0, "двести тысяч "); break;
                        case '3': result = result.Contains("тысяч") ? result.Insert(0, "тристо ") : result.Insert(0, "тристо тысяч "); break;
                        case '4': result = result.Contains("тысяч") ? result.Insert(0, "четыресто ") : result.Insert(0, "четыресто тысяч "); break;
                        case '5': result = result.Contains("тысяч") ? result.Insert(0, "пятьсот ") : result.Insert(0, "пятьсот тысяч "); break;
                        case '6': result = result.Contains("тысяч") ? result.Insert(0, "шестьсот ") : result.Insert(0, "шестьсот тысяч "); break;
                        case '7': result = result.Contains("тысяч") ? result.Insert(0, "семьсот ") : result.Insert(0, "семьсот тысяч "); break;
                        case '8': result = result.Contains("тысяч") ? result.Insert(0, "восемьсот ") : result.Insert(0, "восемьсот тысяч "); break;
                        case '9': result = result.Contains("тысяч") ? result.Insert(0, "девятьсот ") : result.Insert(0, "девятьсот тысяч "); break;
                    }
                }

                isControl = false;
                if (numstr.Length > 7)
                    isControl = numstr[7] == '1' ? true : false;

                if (i == 6 && !isControl)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Insert(0, "один миллион "); break;
                        case '2': result = result.Insert(0, "два миллиона "); break;
                        case '3': result = result.Insert(0, "три миллиона "); break;
                        case '4': result = result.Insert(0, "четыре миллиона "); break;
                        case '5': result = result.Insert(0, "пять миллионов "); break;
                        case '6': result = result.Insert(0, "шесть миллионов "); break;
                        case '7': result = result.Insert(0, "семь миллионов "); break;
                        case '8': result = result.Insert(0, "восемь миллионов "); break;
                        case '9': result = result.Insert(0, "девять миллионов "); break;
                    }
                }

                if (i == 6 && isControl)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Insert(0, "один "); break;
                        case '2': result = result.Insert(0, "две "); break;
                        case '3': result = result.Insert(0, "три "); break;
                        case '4': result = result.Insert(0, "четыр "); break;
                        case '5': result = result.Insert(0, "пят "); break;
                        case '6': result = result.Insert(0, "шест "); break;
                        case '7': result = result.Insert(0, "сем "); break;
                        case '8': result = result.Insert(0, "восем "); break;
                        case '9': result = result.Insert(0, "девят "); break;
                    }
                }

                if (i == 7)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = numstr[6] == '0' ? result.Insert(0, "десять миллионов ") : result.Insert(result.IndexOf(' '), "надцать миллионов"); break;
                        case '2': result = result.Contains("миллион") ? result.Insert(0, "двадцать ") : result.Insert(0, "двадцать миллионов "); break;
                        case '3': result = result.Contains("миллион") ? result.Insert(0, "тридцать ") : result.Insert(0, "тридцать миллионов "); break;
                        case '4': result = result.Contains("миллион") ? result.Insert(0, "сорок ") : result.Insert(0, "сорок миллионов "); break;
                        case '5': result = result.Contains("миллион") ? result.Insert(0, "пятьдесят ") : result.Insert(0, "пятьдесят миллионов "); break;
                        case '6': result = result.Contains("миллион") ? result.Insert(0, "шестьдесят ") : result.Insert(0, "шестьдесят миллионов "); break;
                        case '7': result = result.Contains("миллион") ? result.Insert(0, "семьдесят ") : result.Insert(0, "семьдесят миллионов "); break;
                        case '8': result = result.Contains("миллион") ? result.Insert(0, "восемьдесят ") : result.Insert(0, "восемьдесят миллионов "); break;
                        case '9': result = result.Contains("миллион") ? result.Insert(0, "девяносто ") : result.Insert(0, "девяносто миллионов "); break;
                    }
                }

                if (i == 8)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Contains("миллион") ? result.Insert(0, "сто ") : result.Insert(0, "сто миллионов "); break;
                        case '2': result = result.Contains("миллион") ? result.Insert(0, "двести ") : result.Insert(0, "двести миллионов "); break;
                        case '3': result = result.Contains("миллион") ? result.Insert(0, "тристо ") : result.Insert(0, "тристо миллионов "); break;
                        case '4': result = result.Contains("миллион") ? result.Insert(0, "четыресто ") : result.Insert(0, "четыресто миллионов "); break;
                        case '5': result = result.Contains("миллион") ? result.Insert(0, "пятьсот ") : result.Insert(0, "пятьсот миллионов "); break;
                        case '6': result = result.Contains("миллион") ? result.Insert(0, "шестьсот ") : result.Insert(0, "шестьсот миллионов "); break;
                        case '7': result = result.Contains("миллион") ? result.Insert(0, "семьсот ") : result.Insert(0, "семьсот миллионов "); break;
                        case '8': result = result.Contains("миллион") ? result.Insert(0, "восемьсот ") : result.Insert(0, "восемьсот миллионов "); break;
                        case '9': result = result.Contains("миллион") ? result.Insert(0, "девятьсот ") : result.Insert(0, "девятьсот миллионов "); break;
                    }
                }

                isControl = false;
                if (numstr.Length > 10)
                    isControl = numstr[10] == '1' ? true : false;

                if (i == 9 && !isControl)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Insert(0, "один миллиард "); break;
                        case '2': result = result.Insert(0, "два миллиарда "); break;
                        case '3': result = result.Insert(0, "три миллиарда "); break;
                        case '4': result = result.Insert(0, "четыре миллиарда "); break;
                        case '5': result = result.Insert(0, "пять миллиардов "); break;
                        case '6': result = result.Insert(0, "шесть миллиардов "); break;
                        case '7': result = result.Insert(0, "семь миллиардов "); break;
                        case '8': result = result.Insert(0, "восемь миллиардов "); break;
                        case '9': result = result.Insert(0, "девять миллиардов "); break;
                    }
                }

                if (i == 9 && isControl)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Insert(0, "один "); break;
                        case '2': result = result.Insert(0, "две "); break;
                        case '3': result = result.Insert(0, "три "); break;
                        case '4': result = result.Insert(0, "четыр "); break;
                        case '5': result = result.Insert(0, "пят "); break;
                        case '6': result = result.Insert(0, "шест "); break;
                        case '7': result = result.Insert(0, "сем "); break;
                        case '8': result = result.Insert(0, "восем "); break;
                        case '9': result = result.Insert(0, "девят "); break;
                    }
                }

                if (i == 10)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = numstr[9] == '0' ? result.Insert(0, "десять миллионов ") : result.Insert(result.IndexOf(' '), "надцать миллиардов"); break;
                        case '2': result = result.Contains("миллиард") ? result.Insert(0, "двадцать ") : result.Insert(0, "двадцать миллиардов "); break;
                        case '3': result = result.Contains("миллиард") ? result.Insert(0, "тридцать ") : result.Insert(0, "тридцать миллиардов "); break;
                        case '4': result = result.Contains("миллиард") ? result.Insert(0, "сорок ") : result.Insert(0, "сорок миллиардов "); break;
                        case '5': result = result.Contains("миллиард") ? result.Insert(0, "пятьдесят ") : result.Insert(0, "пятьдесят миллиардов "); break;
                        case '6': result = result.Contains("миллиард") ? result.Insert(0, "шестьдесят ") : result.Insert(0, "шестьдесят миллиардов "); break;
                        case '7': result = result.Contains("миллиард") ? result.Insert(0, "семьдесят ") : result.Insert(0, "семьдесят миллиардов"); break;
                        case '8': result = result.Contains("миллиард") ? result.Insert(0, "восемьдесят ") : result.Insert(0, "восемьдесят миллиардов "); break;
                        case '9': result = result.Contains("миллиард") ? result.Insert(0, "девяносто ") : result.Insert(0, "девяносто миллиардов "); break;
                    }
                }

                if (i == 11)
                {
                    switch (numstr[i])
                    {
                        case '0': result += ""; break;
                        case '1': result = result.Contains("миллиард") ? result.Insert(0, "сто ") : result.Insert(0, "сто миллиардов "); break;
                        case '2': result = result.Contains("миллиард") ? result.Insert(0, "двести ") : result.Insert(0, "двести миллиардов "); break;
                        case '3': result = result.Contains("миллиард") ? result.Insert(0, "тристо ") : result.Insert(0, "тристо миллиардов "); break;
                        case '4': result = result.Contains("миллиард") ? result.Insert(0, "четыресто ") : result.Insert(0, "четыресто миллиардов "); break;
                        case '5': result = result.Contains("миллиард") ? result.Insert(0, "пятьсот ") : result.Insert(0, "пятьсот миллиардов "); break;
                        case '6': result = result.Contains("миллиард") ? result.Insert(0, "шестьсот ") : result.Insert(0, "шестьсот миллиардов "); break;
                        case '7': result = result.Contains("миллиард") ? result.Insert(0, "семьсот ") : result.Insert(0, "семьсот миллиардов "); break;
                        case '8': result = result.Contains("миллиард") ? result.Insert(0, "восемьсот ") : result.Insert(0, "восемьсот миллиардов "); break;
                        case '9': result = result.Contains("миллиард") ? result.Insert(0, "девятьсот ") : result.Insert(0, "девятьсот миллиардов "); break;
                    }
                }
            }
            Console.WriteLine(result);
            return result;  
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
    
    
    
