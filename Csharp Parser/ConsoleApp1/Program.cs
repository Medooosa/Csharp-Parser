
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParserBase[] parsers = {
            //    new BiographiesAListParser(),
            //    new BussinessMListParser(),
            //    new RegexCountries(),
            //    new RegexGenreAdvanced(),
            //    new RegexGenreSimple(),
            //    new RegexLocationMovies(),
            //    new RegexLocationSeries(),
            //    new RegexMoviesParser(),
            //    new RegexRatingsS(),
            //    new RegexRatingsM(),
            //    new RegexRunTimeMParser(),
            //    new RegexRunTimeSParser(),
            //    new RegexSeriesParser(),
            //    new RegexWriters(),
            //    new RegexActors(),
            //    new RegexActress()
            //};
            ParserBase[] parsers = {
                new BiographiesAListParser(),
            };
            foreach (var parser in parsers)
            {
                parser.RunParser();
                Console.WriteLine(parser.GetFileName + " is done");
            }
            //RegexLocationMovies RLM = new RegexLocationMovies();
            //RLM.RunParser();
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