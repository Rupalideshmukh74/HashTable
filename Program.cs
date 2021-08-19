using System;

namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");
           // Variable
            int key = 0;

            //Paragraph words assign to array
            string paragraphPhrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraph = paragraphPhrase.Split(" ");

            //Object of class MyMapNode
            MyMapNode<int, string> myMapNode = new MyMapNode<int, string>(paragraph.Length);

            //Add 
            foreach (string word in paragraph)
            {
                myMapNode.Add(key, word);
                key++;
            }

            //Display
            Console.WriteLine("frequency of words ");
            Console.WriteLine("-------------------");

            for (key = 0; key < paragraph.Length; key++)
            {
                string value = myMapNode.Get(key);
                Console.WriteLine(key + " - " + value);
            }
        }
    }
}
        
   