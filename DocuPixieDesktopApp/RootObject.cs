using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocuPixieDesktopApp
{
    public class Rootobject
    {
        public ParsedResult[] ParsedResults { get; set; }
        public int OCRExitCode { get; set; }
        public bool IsErroredOnProcessing { get; set; }
        public string ErrorMessage { get; set; }
        public string[] ErrorDetails { get; set; }
        public string ProcessingTimeInMilliseconds { get; set; }
    }

    public class ParsedResult
    {
        public string TextOverlay { get; set; }
        public string ParsedText { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
    }

}
