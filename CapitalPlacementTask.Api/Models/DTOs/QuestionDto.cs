using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Api.Models.DTOs
{
    public class QuestionDto
    {
        public string Type { get; set; }
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public bool EnableOtherOption { get; set; }
        public int MaxChoicesAllowed { get; set; } 
    }
}