using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Api.Models
{
    public class ApplicationSubmission
    {
        public string Id { get; set; }
        public Dictionary<string, object> ApplicationData { get; set; }
    }
}