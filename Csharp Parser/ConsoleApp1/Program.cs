
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
            string substitution = "$1¤$2¤$4¤$5¤$6";
            string movieTestFile = @"E:\Big movie files\Csharp-Parser\Csharp Parser\ConsoleApp1\Moviestestfile.txt";
            string movieFile = @"E:\Big movie files\movies.list";
            StreamReader sr = new StreamReader(movieFile,System.Text.Encoding.GetEncoding(28591));
            StreamWriter sw = new StreamWriter(@"..\..\..\testfiles\editedmovies2.csv");
            sw.WriteLine("TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤ENDYEAR");
            RegexOptions options = RegexOptions.Singleline;
            Regex regexPattern = new Regex(pattern, options);
            string result = string.Empty;
            string line;
            while ((line = sr.ReadLine()) != null )
            {
                Match m = Regex.Match(line, pattern, options);
                if (m.Success)
                {
                    result = m.Value;
                    result = regexPattern.Replace(result, substitution);
                    result = Regex.Replace(result, @"\t+", ""); //om files te editen.
                    sw.WriteLine(result);
                }               
            }
            sr.Close();
            sw.Close();
            //foreach (Match m in Regex.Matches(lineInput, pattern, options))
            //{
            //    result = m.Value + '\n';
            //    result = regexPattern.Replace(result, substitution);
            //    result = Regex.Replace(result, @"\t+", "");
            //    File.AppendAllText(@"..\..\..\testfiles\editedmovies.csv", result);
            //}
            //result = regexPattern.Replace(result, substitution);
            //result = Regex.Replace(result, @"\t+", ""); //om files te editen.
            //Console.WriteLine(Environment.CurrentDirectory);
        }
    }
}
