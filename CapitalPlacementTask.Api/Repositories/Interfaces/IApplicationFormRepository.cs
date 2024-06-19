using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models;

namespace CapitalPlacementTask.Api.Repositories.Interfaces
{
    public interface IApplicationFormRepository
    {
        Task<IEnumerable<ApplicationForm>> GetAllApplicationFormsAsync();
        Task<ApplicationForm> GetApplicationFormByIdAsync(string id);
        Task AddApplicationFormAsync(ApplicationForm applicationForm);
        Task UpdateApplicationFormAsync(ApplicationForm applicationForm);
        Task DeleteApplicationFormAsync(string id);
    }
}