using System;
using System.Collections.Generic;
using System.IO;

namespace jumper
{
    public class Dictionary{
        public string hiddenword;
        List<char> answer = new List<char>();
        public List<char> guess = new List<char>();

        public HiddenWord(){
            
        }

        public string pullWord(){
            List<string> lines = new List<string>(File.ReadLines("dictionary.txt"));
            Random rand = new Random();
            int randomIndex = rand.Next(0, lines.Count);
            string chosenWord = lines[randomIndex];
            return chosenWord;
        }

       

