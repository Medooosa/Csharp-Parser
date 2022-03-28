using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexGenreSeries : ParserBase
    {
        public RegexGenreSeries(string fileLocation = @"E:\Big movie files\genres.list", string newFileName = @"..\..\..\testfiles\editedgenresSeries.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"\""(.*)\"" (\([0-9,?,/,A-Z]{4,11}\))(.({.*}) ({.*})| ({{SUSPENDED}})| ({.*})|)\t+(.*)";
            this.substitution = "$1¤$2¤$4$7¤$5$6¤$8";
            this.startLine = "TITLE¤DATEYEAR¤SERIETITLE¤SUSPENDED¤GENRE";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
