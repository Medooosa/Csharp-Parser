using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1{

    public class RegexSeriesParser : ParserBase{

        public RegexSeriesParser(string fileLocation = @"E:\Big movie files\movies.list", string newFileName = @"..\..\..\testfiles\editedseries.csv") : base(fileLocation, newFileName) {
            this.pattern = @"(\"".*\"").*(\([0-9,?,/,A-Z]{4,11}\)).((({.*}) ({.*})|({.*}))|(\t))\t+([0-9,?,-]{4,9})";
            this.substitution = "$1¤$2¤$5$7¤$6¤$9";
            this.startLine = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤RUNTIMEYEAR/ENDYEAR";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
