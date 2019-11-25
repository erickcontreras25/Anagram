using System;
using System.Collections;

namespace AnagramsKata
{
    public class Anagrams
    {
        public string string1 { get; set; }
        public string string2 { get; set; }

        public bool respuesta;

        public Anagrams()
        {
            
        }

        public Anagrams(string value1, string value2)
        {
            char[] ch1 = value1.ToLower().ToCharArray();
            char[] ch2 = value2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string1 = new string(ch1);
            string2 = new string(ch2);

            if(string1 == string2){
                respuesta = true;
            }else {
                respuesta = false;
            }

            
        }
    }
}