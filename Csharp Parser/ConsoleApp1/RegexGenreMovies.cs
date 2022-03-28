using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexGenreMovies : ParserBase
    {
        public RegexGenreMovies(string fileLocation = @"E:\Big movie files\genres.list", string newFileName = @"..\..\..\testfiles\editedgenresMovies.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"^(?![\""])(.*) (\([0-9,?,/,A-Z]{4,11}\))( (\([A-Z]{1,3}\)) ({.*})| (\([A-Z]{1,3}\))| ({.*})|)\t+(.*)";
            this.substitution = "$1¤$2¤$4$6¤$5$7¤$8";
            this.startLine = "TITLE¤DATEYEAR¤TYPE¤SUSPENDED¤GENRE";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
