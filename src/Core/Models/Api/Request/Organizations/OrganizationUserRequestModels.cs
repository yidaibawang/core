﻿using Bit.Core.Models.Table;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bit.Core.Models.Api
{
    public class OrganizationUserInviteRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Enums.OrganizationUserType? Type { get; set; }
        public bool AccessAll { get; set; }
        public IEnumerable<SelectionReadOnlyRequestModel> Collections { get; set; }
    }

    public class OrganizationUserAcceptRequestModel
    {
        [Required]
        public string Token { get; set; }
    }

    public class OrganizationUserConfirmRequestModel
    {
        [Required]
        public string Key { get; set; }
    }

    public class OrganizationUserUpdateRequestModel
    {
        [Required]
        public Enums.OrganizationUserType? Type { get; set; }
        public bool AccessAll { get; set; }
        public IEnumerable<SelectionReadOnlyRequestModel> Collections { get; set; }

        public OrganizationUser ToOrganizationUser(OrganizationUser existingUser)
        {
            existingUser.Type = Type.Value;
            existingUser.AccessAll = AccessAll;
            return existingUser;
        }
    }

    public class OrganizationUserUpdateGroupsRequestModel
    {
        [Required]
        public IEnumerable<string> GroupIds { get; set; }
    }
}
