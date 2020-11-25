using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonusarakOgren.Models
{
    public class SoruCevapModel
    {
        public SoruCevapModel()
        {
            Question = new List<string>();
            Answer = new List<string>();
            True = new List<string>();
        }
        public List<string> Question { get; set; }
        public List<string> Answer { get; set; }
        public List<string> True { get; set; }
    }
}