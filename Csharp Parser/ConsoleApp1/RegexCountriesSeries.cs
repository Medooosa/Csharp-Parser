using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexCountriesSeries : ParserBase
    {
        public RegexCountriesSeries(string fileLocation = @"E:\Big movie files\countries.list", string newFileName = @"..\..\..\testfiles\editedcountrySeries.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"\""(.*)\"" (\([0-9,?,/,A-Z]{4,11}\))(.({.*}) ({.*})| ({{SUSPENDED}})| ({.*})|)\t+(.*)";
            this.substitution = "$1¤$2¤$4$7¤$5$6¤$8";
            this.startLine = "NAME¤DATEYEAR¤SERIETITLE¤SUSPENDED¤COUNTRY";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
