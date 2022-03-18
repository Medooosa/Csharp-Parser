using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexActress : ParserBase
    {
        public RegexActress(string fileLocation = @"E:\Big movie files\actresses.list", string newFileName = @"..\..\..\testfiles\editedactresses.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(^(.*)\t)(.*)(\([0-9,?,/,A-Z]{4,11}\))((.*)((\{.*\})|(\[.*\]))|())";
            this.substitution = "$2¤$3¤$4¤$6¤$9";
            this.startLine = "ACTORNAME¤MOVIEORSHOWNAME¤STARTYEAR¤EPNAMEORVOICE¤ROLE";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
