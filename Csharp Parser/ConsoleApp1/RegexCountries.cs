using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexCountries : ParserBase
    {
        public RegexCountries(string fileLocation = @"E:\Big movie files\countries.list", string newFileName = @"..\..\..\testfiles\editedcountry.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(.*)(\([0-9,?,/,A-Z]{4,11}\))(.({.*})|())\s((\(.*\))|())\s+((\{.*\})\t*(.*)|(.*))";
            this.substitution = "$1¤$2¤$6$7¤$10¤$11$12";
            this.startLine = "MOVIEORSHOWNAME¤DATE¤TYPE¤SUSPENDED¤COUNTRY";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
