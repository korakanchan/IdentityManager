﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Thinktecture.IdentityManager
{
    public interface IIdentityManagerService
    {
        Task<IdentityManagerMetadata> GetMetadataAsync();
        
        Task<IdentityManagerResult<CreateResult>> CreateUserAsync(IEnumerable<UserClaim> properties);
        Task<IdentityManagerResult> DeleteUserAsync(string subject);
        
        Task<IdentityManagerResult<QueryResult>> QueryUsersAsync(string filter, int start, int count);
        Task<IdentityManagerResult<UserDetail>> GetUserAsync(string subject);

        Task<IdentityManagerResult> SetPropertyAsync(string subject, string type, string value);
        
        Task<IdentityManagerResult> AddClaimAsync(string subject, string type, string value);
        Task<IdentityManagerResult> RemoveClaimAsync(string subject, string type, string value);
    }
}
