
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
            //    new RegexCountriesSeries(),
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
               new RegexActress(),
               new RegexActors(),
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
