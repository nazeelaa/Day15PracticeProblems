using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day15HashTable_UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Program. \n");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            hash.Add("0", "Paranoids");
            hash.Add("1", "ara");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "delibertely");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            string hash17 = hash.Get("17");
            hash.Remove("17");

            Console.WriteLine("\n **" + hash17 + "**  is been removed");
        }
    }
}
