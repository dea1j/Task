using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CapitalPlacementTask.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly ILogger<QuestionController> _logger;

    public QuestionController(ILogger<QuestionController> logger)
    {
        _logger = logger;
    }

}
