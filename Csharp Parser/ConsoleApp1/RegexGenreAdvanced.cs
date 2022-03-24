using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexGenreAdvanced : ParserBase
    {
        public RegexGenreAdvanced(string fileLocation = @"E:\Big movie files\genres.list", string newFileName = @"..\..\..\testfiles\editedgenresAdvanced.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(\""(.*)\""|(.*))\s+(\([0-9,?,/,A-Z]{4,11}\))(.(({.*}) ({.*}))|({.*})|())\s((\(.*\))|())(\s*)((\{\{SUSPENDED\}\})|(\{.*\})|(.*))(.*)";
            this.substitution = "$2$3¤$4¤$7$17¤$12¤$8$16¤$18$19"; //moet nog anders
            this.startLine = "MOVIEORSHOWNAME¤DATE¤TYPE¤SUSPENDED¤GENRE";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
