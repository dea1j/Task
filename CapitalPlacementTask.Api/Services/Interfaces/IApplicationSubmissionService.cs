using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models;

namespace CapitalPlacementTask.Api.Services.Interfaces
{
    public interface IApplicationSubmissionService
    {
        Task AddSubmissionAsync(ApplicationSubmission submission);
    }
}