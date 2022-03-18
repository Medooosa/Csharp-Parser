
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternMovies = @"^(?![\""])(.*).(\([0-9,?,/,A-Z]{4,11}\)).((\([a-z,A-Z,?]{1,}\))|(.*)).*([0-9,?]{4})";
            string patternSeries = @"(\"".*\"").*(\([0-9,?,/,A-Z]{4,11}\)).((({.*}) ({.*})|({.*}))|(\t))\t+([0-9,?,-]{4,9})";
            string substitutionMovies = "$1¤$2¤$4¤$5¤$6";
            string substitutionSeries = "$1¤$2¤$5$7¤$6¤$9";
            string movieTestFile = @"E:\Big movie files\Csharp-Parser\Csharp Parser\ConsoleApp1\Moviestestfile.txt";
            string movieActorFile = @"E:\Big movie files\movies.list";
            string startLineMovies = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤ENDYEAR";
            string startLineSeries = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤RUNTIMEYEAR/ENDYEAR";
            string editedMoviesCsv = @"..\..\..\testfiles\editedmovies.csv";
            string editedSeriesCsv = @"..\..\..\testfiles\editedseries.csv";
            RegexLocationMovies RLM = new RegexLocationMovies();
            StreamReader sr = new StreamReader(RLM.GetFileLocation, System.Text.Encoding.GetEncoding(28591));
            StreamWriter sw = new StreamWriter(editedSeriesCsv);

            sw.WriteLine(startLineSeries);

            RegexOptions options = RegexOptions.Singleline;
            Regex regexPattern = new Regex(patternSeries, options);


            string result = string.Empty, line;
            while ((line = sr.ReadLine()) != null)
            {
                Match m = Regex.Match(line, patternSeries, options);
                if (m.Success)
                {
                    result = m.Value;
                    result = regexPattern.Replace(result, substitutionSeries);
                    result = Regex.Replace(result, @"\t+", ""); //om files tabs te removen
                    sw.WriteLine(result);
                }
            }
            sr.Close();
            sw.Close();
            //BiographiesActorList BAL = new BiographiesActorList(@"E:\Big movie files\biographies.list");
            //BAL.RunParser();
            //Console.WriteLine(Environment.CurrentDirectory);
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