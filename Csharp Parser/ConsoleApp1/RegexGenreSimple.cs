using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexGenreSimple : ParserBase
    {
        public RegexGenreSimple(string fileLocation = @"E:\Big movie files\genres.list", string newFileName = @"..\..\..\testfiles\editedgenresS.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(.*)(\([0-9,?,/,A-Z]{4,11}\))(.({.*})|())\t+(.*)";
            this.substitution = "$1¤$2¤$6";
            this.startLine = "MOVIEORSHOWNAME¤DATE¤GENRE";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
