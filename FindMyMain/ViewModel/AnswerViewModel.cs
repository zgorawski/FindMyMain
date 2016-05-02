using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.ViewModel
{
    public class AnswerViewModel
    {
        public string Error { get; set; }
        public bool IsMain { get; set; }
        public string Answer { get; set; }
    }
}