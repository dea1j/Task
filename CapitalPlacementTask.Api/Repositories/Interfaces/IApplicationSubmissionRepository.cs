using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models;

namespace CapitalPlacementTask.Api.Repositories.Interfaces
{
    public interface IApplicationSubmissionRepository
    {
        Task AddSubmissionAsync(ApplicationSubmission submission);
    }
}