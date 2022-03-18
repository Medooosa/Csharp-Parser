using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1{
    
    class RegexRunTimeSParser : ParserBase{
        public RegexRunTimeSParser(string fileLocation = @"E:\Big movie files\running-times.list", string newFileName = @"..\..\..\testfiles\editedSruntime.csv") : base(fileLocation, newFileName){
            this.pattern = @"(\"".*\"").(\([0-9,?,/,A-Z]{4,11}\)).(({.*}) ({.*})|({.*})|(\t{2}))\t*((([a-z,A-Z, ]+):(\d+))|(\d+))(\t(\(.*\))|())";
            this.substitution = "$1¤$2¤$4$6¤$5¤$10¤$11¤$14";
            this.startLine = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤COUNTRYTIME¤TIMEINMINUTES¤COMMENTS";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
