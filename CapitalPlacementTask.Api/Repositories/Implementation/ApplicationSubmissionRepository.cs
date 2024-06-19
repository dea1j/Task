using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models;
using CapitalPlacementTask.Api.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;

namespace CapitalPlacementTask.Api.Repositories.Implementation
{
    public class ApplicationSubmissionRepository : IApplicationSubmissionRepository
    {
        private readonly Container _container;
        public ApplicationSubmissionRepository(CosmosClient cosmosClient)
        {
            _container = cosmosClient.GetContainer("CapitalPlacementDb", "applicationSubmissions");
        }
        public async Task AddSubmissionAsync(ApplicationSubmission submission)
        {
            await _container.CreateItemAsync(submission, new PartitionKey(submission.Id));
        }
    }
}