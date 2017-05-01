using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShiftPerformance.Models
{
    public class FormItems
    {
        public List<FormItem> frmElements { get; set; }
        public int Score { get; set; }
        public DateTime TimeStamp { get; set; }
        public string SecretKey { get; set; }
    }
    public class FormItem
    {
        public string QuestionText { get; set; }
        public string QuestionSummary { get; set; }
        public List<string> Options { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public decimal ScoreWeight { get; set; }
        public string Name { get; set; }
        public string isRequired { get; set; }
        public bool isCommentSupported { get; set; }
        public string Comment { get; set; }
    }
}