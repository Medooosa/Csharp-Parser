using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexMoviesParser
    {
        private string pattern = @"^(?![\""])(.*).(\([0-9,?,/,A-Z]{4,11}\)).((\([a-z,A-Z,?]{1,}\))|(.*)).*([0-9,?]{4})";
        private string substitution = "$1¤$2¤$4¤$5¤$6";
        private string startLine = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤ENDYEAR";
        private string fileLocation;
        private string fileName;
        private string fileMap = @"..\..\..\testfiles\";
        public RegexMoviesParser(string fileLocation = @"E:\Big movie files\movies.list", string newFileName = @"..\..\..\testfiles\editedmovies.csv")
        {
            this.fileLocation = fileLocation;
            fileName = fileMap + newFileName + ".csv";
        }
        public string GetPattern { get { return pattern; } }
        public string GetSubsitution { get { return substitution; } }
        public string GetStartLine { get { return startLine; } }
        public string GetFileLocation { get { return fileLocation; } }
        public string GetFileName { get { return fileName; } }
        public void SetFileLocation(string fileLocation) { this.fileLocation = fileLocation; }
        public void SetFileName(string fileName) { this.fileName = fileMap + fileName + "csv";  }
    }
}
