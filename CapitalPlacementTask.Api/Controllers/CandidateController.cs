using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models;
using CapitalPlacementTask.Api.Repositories.Interfaces;
using CapitalPlacementTask.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CapitalPlacementTask.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CandidateController : ControllerBase
{
    private readonly IApplicationFormService _applicationFormService;
    private readonly IApplicationSubmissionService _applicationSubmissionService;

    public CandidateController(IApplicationFormService applicationFormService, 
    IApplicationSubmissionService applicationSubmissionService)
    {
        _applicationFormService = applicationFormService;
        _applicationSubmissionService = applicationSubmissionService;
    }

    [HttpGet("questions/{applicationFormId}")]
    public async Task<IActionResult> GetQuestions(string applicationFormId)
    {
        var applicationForm = await _applicationFormService.GetApplicationFormByIdAsync(applicationFormId);
        if (applicationForm == null) return NotFound();
        return Ok(applicationForm.Questions);
    }

    [HttpPost("submit")]
    public async Task<IActionResult> SubmitApplication([FromBody] Dictionary<string, object> applicationData)
    {
        var submission = new ApplicationSubmission
        {
            Id = Guid.NewGuid().ToString(),
            ApplicationData = applicationData
        };

        await _applicationSubmissionService.AddSubmissionAsync(submission);
        return Ok("Application submitted successfully.");
    }

}
