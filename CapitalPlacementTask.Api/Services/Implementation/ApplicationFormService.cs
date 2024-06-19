using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CapitalPlacementTask.Api.Models;
using CapitalPlacementTask.Api.Models.DTOs;
using CapitalPlacementTask.Api.Repositories.Interfaces;
using CapitalPlacementTask.Api.Services.Interfaces;

namespace CapitalPlacementTask.Api.Services.Implementation
{
    public class ApplicationFormService : IApplicationFormService
    {
        private readonly IApplicationFormRepository _applicationFormRepository;
        private readonly IMapper _mapper;

        public ApplicationFormService(IApplicationFormRepository applicationFormRepository, IMapper mapper)
        {
            _applicationFormRepository = applicationFormRepository;
            _mapper = mapper;
        }
        
        public async Task AddApplicationFormAsync(CreateApplicationFormDto applicationFormDto)
        {
            var applicationForm = _mapper.Map<ApplicationForm>(applicationFormDto);
            await _applicationFormRepository.AddApplicationFormAsync(applicationForm);
        }

        public async Task DeleteApplicationFormAsync(string id)
        {
            await _applicationFormRepository.DeleteApplicationFormAsync(id);
        }

        public async Task<IEnumerable<ApplicationFormDto>> GetAllApplicationFormsAsync()
        {
            var applicationForms = await _applicationFormRepository.GetAllApplicationFormsAsync();
            return _mapper.Map<IEnumerable<ApplicationFormDto>>(applicationForms);
        }

        public async Task<ApplicationFormDto> GetApplicationFormByIdAsync(string id)
        {
            var applicationForm = await _applicationFormRepository.GetApplicationFormByIdAsync(id);
            return _mapper.Map<ApplicationFormDto>(applicationForm);
        }

        public async Task UpdateApplicationFormAsync(UpdateApplicationFormDto applicationFormDto)
        {
            var applicationForm = _mapper.Map<ApplicationForm>(applicationFormDto);
            await _applicationFormRepository.UpdateApplicationFormAsync(applicationForm);
        }
    }
}