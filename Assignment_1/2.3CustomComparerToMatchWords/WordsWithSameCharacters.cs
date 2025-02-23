using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._2._3CustomComparerToMatchWords
{
    public class WordsWithSameCharacters : IEqualityComparer<string>
    {
        public bool Equals(string? word_1, string? word_2)
        {
            bool isBothStringsEqual = true;
            foreach(char ch in word_1)
            {
                isBothStringsEqual &= (word_2?.IndexOf(ch) != -1);
            }

            //Console.WriteLine($"word(1) => {word_1} -- word(2) => {word_2} => does they have same characters? {isBothStringsEqual}");

            return isBothStringsEqual;
        }

        public int GetHashCode(string obj) 
        {
            //Console.WriteLine($"Hashcode of: {obj}");
            // NOTE: The grouping algorithm (and I think all LINQ methods) using an equality comparer always first compares hash codes and only executes Equals if two hash codes are equal.
            // so return always 0 -> to be same for all.
            return 0;
        }
    }
}
