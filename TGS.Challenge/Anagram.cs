using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) ||  string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException();
            }

            Regex regex = new Regex("[^a-z]", RegexOptions.IgnoreCase);
            word1 = new string(regex.Replace(word1, string.Empty).ToLower().ToCharArray().Distinct().ToArray());
            word2 = new string(regex.Replace(word2,string.Empty).ToLower().ToCharArray().Distinct().ToArray());

            return word1.Length < word2.Length 
                        ? word1.All(word2.Contains) 
                        : word2.All(word1.Contains);
        }       
    }
}
