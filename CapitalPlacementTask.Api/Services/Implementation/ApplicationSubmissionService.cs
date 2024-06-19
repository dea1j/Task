using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models;
using CapitalPlacementTask.Api.Repositories.Interfaces;
using CapitalPlacementTask.Api.Services.Interfaces;

namespace CapitalPlacementTask.Api.Services.Implementation
{
    public class ApplicationSubmissionService : IApplicationSubmissionService
    {
        private readonly IApplicationSubmissionRepository _submissionRepository;

        public ApplicationSubmissionService(IApplicationSubmissionRepository submissionRepository)
        {
            _submissionRepository = submissionRepository;
        }
        public async Task AddSubmissionAsync(ApplicationSubmission submission)
        {
            await _submissionRepository.AddSubmissionAsync(submission);
        }
    }
}