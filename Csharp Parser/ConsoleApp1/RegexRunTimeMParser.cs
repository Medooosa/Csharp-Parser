using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexRunTimeMParser
    {
        private string pattern = @"^(?![\""])(.*)(\([0-9,?,/,A-Z]{4,11}\))(\s(\([A-Z]{1,2}\))|\s*([0-9]+)|)(\s({.*})|)(\t+(([a-z,A-Z, ]+):(\d+))|\t+(\d+))(\s(\(.*\))|)";
        private string substitution = "$1¤$2¤$4¤$7¤$10¤$11$12¤$14";
        private string startLine = "TITLE¤STARTYEAR¤ATTRIBUTE¤NOTE¤COUNTRYTIME¤TIMEINMINUTES¤COMMENTS";
        private string fileLocation;
        private string fileName;
        private string fileMap = @"..\..\..\testfiles\";
        public RegexRunTimeMParser(string fileLocation = @"E:\Big movie files\running-times.list", string newFileName = @"..\..\..\testfiles\editedMruntime.csv")
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
        public void SetFileName(string fileName) { this.fileName = fileMap + fileName + "csv"; }

    }
}
