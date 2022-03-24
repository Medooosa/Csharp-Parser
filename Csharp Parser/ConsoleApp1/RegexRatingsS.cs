using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexRatingsS : ParserBase
    {
        public RegexRatingsS(string fileLocation = @"E:\Big movie files\ratings.list", string newFileName = @"..\..\..\testfiles\editedratingS.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"([0-9,+,.,*]{10})\s+([0-9]+)\s+([0-9,.]{3,4})\s{2}\""(.*)\"" (\([0-9,/,A-Z]{4,11}\))( ({.*})|)";
            this.substitution = "$4¤$5¤$7¤$2¤$3";
            this.startLine = "TITLE¤STARTYEAR¤TITLESERIES¤TOTALVOTECOUNT¤RATING";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
