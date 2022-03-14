
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string pattern = @"^(?![\""])(.*).(\([0-9,?,/,A-Z]{4,11}\)).((\([a-z,A-Z,?]{1,}\))|(.*)).*([0-9,?]{4})";
            string substitution = "$1 $2 $4$5 $6";
            string movieTestFile = @"E:\Big movie files\Csharp-Parser\Csharp Parser\ConsoleApp1\Moviestestfile.txt";
            //string[] lines = System.IO.File.ReadAllLines(movieTestFile);
            string lineInput = File.ReadAllText(movieTestFile);
            RegexOptions options = RegexOptions.Multiline;
            Regex regex = new Regex(pattern, options);
            string result = regex.Replace(lineInput, substitution);
            //foreach (Match m in Regex.Matches(lineInput, pattern, options))
            //{
            //    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            //}
            //Console.WriteLine(Environment.CurrentDirectory);
            File.AppendAllText(@"..\..\..\testfiles\editedmovies.csv", result);
        }
    }
}
