﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TS.Domain
{
    public class LongestSentance : ILongestSentance
    {
        public int GetLongestSentance(string s)
        {
            int count = 0;
            string[] sentences = s.Split(new string[] { "!.?" }, StringSplitOptions.None);
            var longestSentence = sentences.Where(sentence => sentence.Trim().Length == sentences.Max(m => m.Trim().Length)).First();

            for(int i = 0; i < sentences.Length; i++)
            {
                string temporary = sentences[i].Trim();
                string[] words = temporary.Split(' ');

                int len = words.Length;
                if(len > count)
                {
                    count = len;
                }
            }

            return count;

        }
    }
}
