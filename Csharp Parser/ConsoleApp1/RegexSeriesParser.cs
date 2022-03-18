using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RegexSeriesParser
    {
        private string pattern = @"(\"".*\"").*(\([0-9,?,/,A-Z]{4,11}\)).((({.*}) ({.*})|({.*}))|(\t))\t+([0-9,?,-]{4,9})";
        private string substitution = "$1¤$2¤$5$7¤$6¤$9";
        private string startLine = "TITLE¤STARTYEAR¤TITLESERIES¤NOTE¤RUNTIMEYEAR/ENDYEAR";
        private string fileLocation;
        private string fileName;
        private string fileMap = @"..\..\..\testfiles\";
        public RegexSeriesParser(string fileLocation = @"E:\Big movie files\movies.list", string newFileName = @"..\..\..\testfiles\editedseries.csv")
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
