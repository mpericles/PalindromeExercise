using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    //internal mean it is only available in this file
    {
            public bool IsPalindrome(string word)
            {
                string WordInReverse = string.Empty;
            //foreach (char c in word.Reverse())
            for(int i  = word.Length-1; i >= 0; i--) 
            {
                WordInReverse += word[i];
            }
            if (word == WordInReverse)
            {
                return true;
            }
            else
            { 
                return false; 
            }
            
            }
    }

}

