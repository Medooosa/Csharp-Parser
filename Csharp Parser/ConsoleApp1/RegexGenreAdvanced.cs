using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexGenreAdvanced : ParserBase
    {
        public RegexGenreAdvanced(string fileLocation = @"E:\Big movie files\genres.list", string newFileName = @"..\..\..\testfiles\editedgenresA.csv") : base(fileLocation, newFileName)
        {
            this.pattern = @"(.*)(\([0-9,?,/,A-Z]{4,11}\))(.*)((\(..?\))|(\{\{SUSPENDED\}\}))([\s]+)(.*)";
            this.substitution = "$1¤$2¤$3$5¤$6¤$8";
            this.startLine = "MOVIEORSHOWNAME¤DATE¤TYPE¤SUSPENDED¤GENRE";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
