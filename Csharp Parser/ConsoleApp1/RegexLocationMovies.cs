using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {

    class RegexLocationMovies : ParserBase {

        public RegexLocationMovies(string fileLocation = @"E:\Big movie files\locations.list", string newFileName = @"..\..\..\testfiles\editedMlocations.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"^(?![\""])(.*) (\([0-9,?,/,A-Z]{4,11}\)).((\([A-Z]{1,2}\))|(\([A-Z]{1,2}\)) |)(({.*})|)\t+((.+)\t(\(.*\))|(.+))";
            this.substitution = "$1¤$2¤$4$5¤$7¤$9$11¤$10";
            this.startLine = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤LOCATION¤COMMENTS";
            this.fileMap = @"..\..\..\testfiles\";
        }
        
    }
}
