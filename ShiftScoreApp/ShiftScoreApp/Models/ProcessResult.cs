using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShiftPerformance.Models
{
    public class ProcessResult
    {
        public string Message { get; set; }
        public string RedirectUrl { get; set; }
        public string ActionName { get; set; }
        public DataModelSummary dataModelSummary { get; set; }
    }

    public class DataModelSummary
    {
        public string TotalScore { get; set; }
        public string date { get; set; }
        public string Shift { get; set; }
        public string ManagerName { get; set; }
        public int RunningAverage { get; set; }
        public string AllComments { get; set; }
        public List<DataModelSummaryLines> lstDataModelSummary { get; set; }
    }
    public class DataModelSummaryLines
    {
        public string Question { get; set; }
        public string Response { get; set; }
        public int ScoreWeight { get; set; }
    }
}