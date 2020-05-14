using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NumToWord
{
    public class NumToWord
    {
        public static string Word {get; set;}
        static Dictionary<string, string> onesValues = new Dictionary<string, string>();
        static Dictionary<string, string> tensValues = new Dictionary<string, string>();

        public static void FillDictionaries()
        {
            onesValues = new Dictionary<string, string>(){{"0", ""}, {"1", "One "}, {"2", "Two "}, {"3", "Three "}, {"4", "Four "}, {"5", "Five "}, {"6", "Six "}, {"7", "Seven "}, {"8", "Eight "}, {"9", "Nine "}, {"10", "Ten "}, {"11", "Eleven "}, {"12", "Twelve "}, {"13", "Thirteen "}, {"14", "Fourteen "},{"15", "Fifteen "}, {"16", "Sixteen "}, {"17", "Seventeen "}, {"18", "Eighteen "}, {"19", "Nineteen "}};
            tensValues = new Dictionary<string, string>(){{"0", ""}, {"1", "Ten"}, {"2", "Twenty "}, {"3", "Thirty "}, {"4", "Forty "}, {"5","Fifty "},{"6","Sixty "}, {"7","Seventy "}, {"8", "Eighty "}, {"9", "Ninety "}};
        }
        public static string NumberToWord(int number)
        {
            if (number == 0)
            {
                Word = "Zero";
            }
            else if(number > 0 && number <20)
            {
              Word = onesValues[number.ToString()];
            }
            else if (number < 0)
            {
                Word = "Negative " + NumberToWord(Math.Abs(number));
            }

            else if (number > 0 && number >= 20)
            {   
                StringBuilder tempWords = new StringBuilder();
                string numString = number.ToString();
                string newString = String.Concat(numString.Reverse());
                for (int i=0; i < numString.Length; i++)
                {   decimal iCalc = (i/3);
                    decimal numFamily = Math.Floor(iCalc);
                        if (i%3 == 0 && numFamily == 0) // i = 0, 3, 6, 9
                            {
                                tempWords.Insert(0, onesValues[(newString[i].ToString())]);
                            }
                        else if (i%3 == 0 && numFamily == 1)
                            {
                            tempWords.Insert(0, onesValues[(newString[i].ToString())] + "Thousand ");
                            }
                        else if (i%3 == 0 && numFamily == 2)
                        {
                            tempWords.Insert(0, onesValues[(newString[i].ToString())] + "Million ");
                        }
                        else if (i%3 == 0 && numFamily == 3)
                        {
                            tempWords.Insert(0, onesValues[(newString[i].ToString())] + "Billion ");
                        }
                        else if (i%3 == 1) // i = 1, 4, 7, 10
                            {
                                tempWords.Insert(0, tensValues[(newString[i].ToString())]);
                            }
                        else if ((i%3 == 2 && int.Parse((newString[i]).ToString()) !=0) && (i%3 == 2 && int.Parse((newString[(i - 1)]).ToString()) == 0) && (i%3 == 2 && int.Parse((newString[(i - 2)]).ToString()) == 0))
                            {
                               tempWords.Insert(0, onesValues[(newString[i].ToString())]+ "Hundred ");
                            }
                        else if (i%3 == 2 && int.Parse((newString[i]).ToString()) != 0) //  i = 2, 5, 8, 11
                            {
                                tempWords.Insert(0, onesValues[(newString[i].ToString())]+ "Hundred and ");
                            }  
                    }
                
                Word = tempWords.ToString();
                }
                return Word;
            }
      }
  }
