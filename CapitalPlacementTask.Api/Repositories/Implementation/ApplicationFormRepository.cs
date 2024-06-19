using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models;
using CapitalPlacementTask.Api.Repositories.Interfaces;
using Microsoft.Azure.Cosmos;

namespace CapitalPlacementTask.Api.Repositories.Implementation
{
    public class ApplicationFormRepository : IApplicationFormRepository
    {
        private readonly Container _container;

        public ApplicationFormRepository(CosmosClient cosmosClient)
        {
            _container = cosmosClient.GetContainer("CapitalPlacementDb", "applicationForms");
        }

        public async Task AddApplicationFormAsync(ApplicationForm applicationForm)
        {
            await _container.CreateItemAsync(applicationForm, new PartitionKey(applicationForm.Id));
        }

        public async Task DeleteApplicationFormAsync(string id)
        {
            await _container.DeleteItemAsync<ApplicationForm>(id, new PartitionKey(id));
        }

        public async Task<IEnumerable<ApplicationForm>> GetAllApplicationFormsAsync()
        {
            var query = _container.GetItemQueryIterator<ApplicationForm>();
            var results = new List<ApplicationForm>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task<ApplicationForm> GetApplicationFormByIdAsync(string id)
        {
            try
            {
                var response = await _container.ReadItemAsync<ApplicationForm>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task UpdateApplicationFormAsync(ApplicationForm applicationForm)
        {
            await _container.UpsertItemAsync(applicationForm, new PartitionKey(applicationForm.Id));
        }
    }
}