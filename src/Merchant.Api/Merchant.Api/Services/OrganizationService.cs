﻿using Mapster;
using Merchant.Api.Dtos;
using Merchant.Api.Repositories;

namespace Merchant.Api.Services;

public class OrganizationService : IOrganizationService
{
    private readonly IOrganizationRepository _organizationRepository;

    public OrganizationService(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }

    public Task<OrganizationDto> CreateOrganizationAsync(CreateOrganizationDto createOrganization)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrganizationAsync(Guid organizationId)
    {
        throw new NotImplementedException();
    }

    public Task<OrganizationDto> GetOrganizationByIdAsync(Guid organizationId)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrganizationDto>> GetOrganizationsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<OrganizationDto> UpdateOrganizationAsync(Guid organizationId, UpdateOrganizationDto updateOrganization)
    {
        var organization = await _organizationRepository.GetOrganizationByIdAsync(organizationId);
        if (organization is null)
            return null;

        var updatedOrganization = updateOrganization.Adapt<OrganizationDto>();

        return updatedOrganization;
    }
}
