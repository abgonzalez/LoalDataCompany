using System;
using System.Collections.Generic;
using System.Linq;
namespace LocalDataCompany.Core
{
    public class Input : IInput
    {
        private readonly List<string> _inputItems;

        public List<string> InputItems => _inputItems;

        public List<string> OutputItems { get => _outputItems; set => _outputItems = value; }

        private List<string> _outputItems;

     
        public Input(string[] input)
        {
            foreach (var item in input)
            {
                _inputItems.Add(item);
            }
        }
        
        /// <summary>
        /// Parse
        /// This function :  - Remove contiguos duplicated characters.
        /// - Remove '_' and 4
        /// - Change $ -> £
        /// - Max length =15
        /// </summary>
        /// <returns></returns>
        public List<string> Parse()
        {
            OutputItems = new List<string>();
            string[] charsToRemove = new string[] { "_", "4"};
            foreach (string item in InputItems)
            {
                if( !string.IsNullOrEmpty(item))
                {
                    string ouputItem;
                    ouputItem =removeCharacters(item, charsToRemove);
                    ouputItem = removeDuplicateChars(ouputItem.Replace("$", "£"));
                    if (ouputItem.Length > 15)
                        ouputItem = ouputItem.Substring(0, 15);
                    OutputItems.Add(ouputItem);
                 }
            }
            return OutputItems;
        }
        public string removeCharacters(string item, string[] charsToRemove)
        {
            string result = item;
            foreach (string c in charsToRemove)
            {
                result = result.Replace(c, string.Empty);
            }
           return result;
        }
        public string removeDuplicateChars(string str)
        {

            string newstr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if( i==0)
                { 
                    newstr += str[i];
                }
                else
                {
                    if (newstr[newstr.Length-1]!=str[i])
                        newstr += str[i];
                }
            }

            return newstr;

        }
    }
}
