using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    
    class RegexMoviesParser : ParserBase {

        public RegexMoviesParser(string fileLocation = @"E:\Big movie files\movies.list", string newFileName = @"..\..\..\testfiles\editedmovies.csv") : base(fileLocation, newFileName){
            this.pattern = @"^(?![\""])(.*).(\([0-9,?,/,A-Z]{4,11}\)).((\([a-z,A-Z,?]{1,}\))|(.*)).*([0-9,?]{4})";
            this.substitution = "$1¤$2¤$4¤$5¤$6";
            this.startLine = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤ENDYEAR";
            this.fileMap = @"..\..\..\testfiles\";
        }
    }
}
