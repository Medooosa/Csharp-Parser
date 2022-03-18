using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    
    class RegexLocationSeries : ParserBase {

        public RegexLocationSeries(string fileLocation = @"E:\Big movie files\locations.list", string newFileName = @"..\..\..\testfiles\editedSlocations.csv") : base(fileLocation, newFileName) {
            this.pattern = @"(\"".*\"").(\([0-9,?,/,A-Z]{4,11}\)).(({.*}) ({.*})|({.*})|\t)\t+((.+)\t(\(.*\))|(.+))";
            this.substitution = "$1¤$2¤$4$6¤$5¤$8$10¤$9";
            this.startLine = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤LOCATION¤COMMENTS";
            this.fileMap = @"..\..\..\testfiles\";
        }

    }
}
