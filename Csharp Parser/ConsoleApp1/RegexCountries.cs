using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexCountries : ParserBase
    {
        public RegexCountries(string fileLocation = @"E:\Big movie files\countries.list", string newFileName = @"..\..\..\testfiles\editedcountry.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(\""(.*)\""|(.*))\s+(\([0-9,?,/,A-Z]{4,11}\))(.({.*})|())\s((\(.*\))|())(\s*)((\{.*\})\t*(.*)|(.*))";
            this.substitution = "$2$3¤$4¤$6$9¤$13¤$14$15"; //denk ik?
            this.startLine = "MOVIEORSHOWNAME¤DATE¤TYPE¤SUSPENDED¤COUNTRY";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
