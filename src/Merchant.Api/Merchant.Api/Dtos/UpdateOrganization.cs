﻿using Merchant.Api.Entities;

namespace Merchant.Api.Dtos;

public class UpdateOrganization
{
    public string? Name { get; set; }
    public IFormFile? ImageUrl { get; set; }
    public EOrganizationStatus Status { get; set; }
    public ICollection<OrganizationUser>? Users { get; set; }
}
