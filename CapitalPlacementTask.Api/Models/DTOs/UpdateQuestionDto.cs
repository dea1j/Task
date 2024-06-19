using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Api.Models.DTOs
{
    public class UpdateQuestionDto : QuestionDto
    {
        public string Id { get; set; }
    }
}