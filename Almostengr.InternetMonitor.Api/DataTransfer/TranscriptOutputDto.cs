using System;

namespace Almostengr.InternetMonitor.Api.DataTransferObjects
{
    public class TranscriptOutputDto
    {
        public string VideoTitle { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmss");
        public string BlogText { get; set; }
        public string VideoText { get; set; }
        public int BlogWords { get; set; }
    }
}