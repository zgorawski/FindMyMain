using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FindMyMain.Model
{
    public class Mastery
    {
        public long championId { get; set; }
        public int championLevel { get; set; }
        public string highestGrade { get; set; }
    }
}