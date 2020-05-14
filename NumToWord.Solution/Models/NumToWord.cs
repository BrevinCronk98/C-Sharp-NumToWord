using System;

namespace NumToWord
{
    public class NumToWord
    {
        public static string Word {get; set;}
        Dictionary<int, string> onesValues = new Dicitionary<int, string>();
        Dictionary<int, string> tensValues = new Dicitionary<int, string>();
        public static void FillDictionaries()
        {
            onesValues.Add({0, "Zero"}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"},{15, "Fifteen"}, {16, "sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"});
            tensValues.Add({0, "Zero"}, {1, "Ten"}, {2, "Twenty"}, {3, "Thirty"}, {4, "Forty"}, {5,"Fifty"},{6,"Sixty"}. {7,"Seventy"}. {8, "Eighty"}, {9, "Ninety"});
        }

    }

}