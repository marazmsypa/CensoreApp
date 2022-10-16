using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoreLibrary
{
    public class CensoreString
    {
        /// <summary>
        /// метод цензурирования редиски. Одна буква слова редиска заменяется звездочкой
        /// </summary>
        
        public string Censore(string textString)
        {
            string lowerTextString = textString.ToLower();
            while (lowerTextString.Contains("редиска"))
            {
                int censorIndex = lowerTextString.IndexOf("редиска");
                textString = textString.Remove(censorIndex, 7);
                textString = textString.Insert(censorIndex, "*******");
                lowerTextString = lowerTextString.Remove(censorIndex, 7);
                lowerTextString = lowerTextString.Insert(censorIndex, "*******");

            }                                             
            return textString;
        }
        /// <summary>
        /// Метод цензурирования любого слова
        /// </summary>
        
        public string CensoreWithEntry(string textString, string censoreString)
        {
            string lowerTextString = textString.ToLower();
            censoreString.ToLower();
            while (lowerTextString.Contains(censoreString))
            {
                int censorIndex = lowerTextString.IndexOf(censoreString);
                lowerTextString = lowerTextString.Remove(censorIndex, censoreString.Length);
                textString = textString.Remove(censorIndex, censoreString.Length);
                string starString = "";
                for (int i = 0; i < censoreString.Length; i++)
                {
                    starString += "*";
                }
                lowerTextString = lowerTextString.Insert(censorIndex, starString);
                textString = textString.Insert(censorIndex, starString);
            }                                     
            return textString;
        }

    }
}
