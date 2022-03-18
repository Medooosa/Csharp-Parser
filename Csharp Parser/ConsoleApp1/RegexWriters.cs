using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexWriters : ParserBase
    {
        public RegexWriters(string fileLocation = @"E:\Big movie files\writers.list", string newFileName = @"..\..\..\testfiles\editedwriters.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(^(.*)\t)(.*)(\([0-9,?,/,A-Z]{4,11}\))((.*)((\{.*\})|(\[.*\]))|())( \(([A-Z]{1,3})\)|())(\s+(\(.*\))|())";
            this.substitution = "$1¤$3¤$4¤$8¤$12¤$15";
            this.startLine = "ACTOR¤MOVIEORSHOWNAMESTARTYEAR¤ATTRIBUTE¤COMMENT";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
