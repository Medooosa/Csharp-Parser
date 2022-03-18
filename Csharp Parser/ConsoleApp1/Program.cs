
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexLocationMovies RLM = new RegexLocationMovies();
            RLM.RunParser();
        }
    }
}
//foreach (Match m in Regex.Matches(lineInput, pattern, options))
//{
//    result = m.Value + '\n';
//    result = regexPattern.Replace(result, substitution);
//    result = Regex.Replace(result, @"\t+", "");
//    File.AppendAllText(@"..\..\..\testfiles\editedmovies.csv", result);
//}