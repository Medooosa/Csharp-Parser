using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexRunTimeSParser
    {
        private string pattern = @"(\"".*\"").(\([0-9,?,/,A-Z]{4,11}\)).(({.*}) ({.*})|({.*})|(\t{2}))\t*((([a-z,A-Z, ]+):(\d+))|(\d+))(\t(\(.*\))|())";
        private string substitution = "$1¤$2¤$4$6¤$5¤$10¤$11¤$14";
        private string startLine = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤COUNTRYTIME¤TIMEINMINUTES¤COMMENTS";
        private string fileLocation;
        private string fileName;
        private string fileMap = @"..\..\..\testfiles\";
        public RegexRunTimeSParser(string fileLocation = @"E:\Big movie files\running-times.list", string newFileName = @"..\..\..\testfiles\editedSruntime.csv")
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
