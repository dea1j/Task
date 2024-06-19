using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models.DTOs;
using CapitalPlacementTask.Api.Services;
using CapitalPlacementTask.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CapitalPlacementTask.Api.Controllers
{
    [Route("[controller]")]
    public class ApplicationFormController : ControllerBase
    {
        private readonly IApplicationFormService _applicationFormService;
        public ApplicationFormController(IApplicationFormService applicationFormService)
        {
             _applicationFormService = applicationFormService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationFormDto>>> GetAllApplicationForms()
        {
            var applicationForms = await _applicationFormService.GetAllApplicationFormsAsync();
            return Ok(applicationForms);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationFormDto>> GetApplicationFormById(string id)
        {
            var applicationForm = await _applicationFormService.GetApplicationFormByIdAsync(id);
            if (applicationForm == null) return NotFound();
            return Ok(applicationForm);
        }

        [HttpPost]
        public async Task<IActionResult> CreateApplicationForm([FromBody] CreateApplicationFormDto createAppDto)
        {
            await _applicationFormService.AddApplicationFormAsync(createAppDto);
            return CreatedAtAction(nameof(GetApplicationFormById), new { id = createAppDto.Id }, createAppDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApplicationForm(string id, [FromBody] UpdateApplicationFormDto dto)
        {
            await _applicationFormService.UpdateApplicationFormAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationForm(string id)
        {
            await _applicationFormService.DeleteApplicationFormAsync(id);
            return NoContent();
        }
    }
}