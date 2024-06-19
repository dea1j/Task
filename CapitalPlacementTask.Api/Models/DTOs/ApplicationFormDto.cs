using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Api.Models.DTOs
{
    public class ApplicationFormDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public PersonalInfoDto PersonalInformation { get; set; }
        public List<QuestionDto> Questions { get; set; }
    }
}