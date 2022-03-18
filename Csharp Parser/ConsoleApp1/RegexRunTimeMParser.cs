using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1{

    class RegexRunTimeMParser : ParserBase{

        public RegexRunTimeMParser(string fileLocation = @"E:\Big movie files\running-times.list", string newFileName = @"..\..\..\testfiles\editedMruntime.csv") : base(fileLocation, newFileName){
            this.pattern = @"^(?![\""])(.*)(\([0-9,?,/,A-Z]{4,11}\))(\s(\([A-Z]{1,2}\))|\s*([0-9]+)|)(\s({.*})|)(\t+(([a-z,A-Z, ]+):(\d+))|\t+(\d+))(\s(\(.*\))|)";
            this.substitution = "$1¤$2¤$4¤$7¤$10¤$11$12¤$14";
            this.startLine = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤COUNTRYTIME¤TIMEINMINUTES¤COMMENTS";
            this.fileMap = @"..\..\..\testfiles\";
        }

    }
}
