using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexCountriesMovies : ParserBase
    {
        public RegexCountriesMovies(string fileLocation = @"E:\Big movie files\countries.list", string newFileName = @"..\..\..\testfiles\editedcountryMovies.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"^(?![\""])(.*) (\([0-9,?,/,A-Z]{4,11}\))( (\([A-Z]{1,3}\)) ({.*})| (\([A-Z]{1,3}\))| ({.*})|)\t+(.*)";
            this.substitution = "$1¤$2¤$4$6¤$5$7¤$8";
            this.startLine = "TITLE¤DATEYEAR¤TYPE¤SUSPENDED¤COUNTRY";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
