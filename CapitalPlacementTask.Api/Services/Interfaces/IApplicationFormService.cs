using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapitalPlacementTask.Api.Models.DTOs;

namespace CapitalPlacementTask.Api.Services.Interfaces
{
    public interface IApplicationFormService
    {
        Task<IEnumerable<ApplicationFormDto>> GetAllApplicationFormsAsync();
        Task<ApplicationFormDto> GetApplicationFormByIdAsync(string id);
        Task AddApplicationFormAsync(CreateApplicationFormDto applicationFormDto);
        Task UpdateApplicationFormAsync(UpdateApplicationFormDto applicationFormDto);
        Task DeleteApplicationFormAsync(string id);
    }
}