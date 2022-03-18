
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string patternMovies = @"^(?![\""])(.*).(\([0-9,?,/,A-Z]{4,11}\)).((\([a-z,A-Z,?]{1,}\))|(.*)).*([0-9,?]{4})";
            //string patternSeries = @"(\"".*\"").*(\([0-9,?,/,A-Z]{4,11}\)).((({.*}) ({.*})|({.*}))|(\t))\t+([0-9,?,-]{4,9})";
            //string substitutionMovies = "$1¤$2¤$4¤$5¤$6";
            //string substitutionSeries = "$1¤$2¤$5$7¤$6¤$9";
            //string startLineMovies = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤ENDYEAR";
            //string startLineSeries = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤RUNTIMEYEAR/ENDYEAR";
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