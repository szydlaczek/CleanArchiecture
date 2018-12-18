using Exchange.Domain.Entities;
using Exchange.Persistence;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exchange.Infrastructure.Identity
{
    public sealed class RoleStore : Store<Role>, IRoleStore<Role>
    {
        
        public RoleStore(ExchangeDbContext context) : base(context)
        {
            
        }
        public async Task<IdentityResult> CreateAsync(Role role, CancellationToken cancellationToken)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return await Task.FromResult(IdentityResult.Success);
        }

        public Task<IdentityResult> DeleteAsync(Role role, CancellationToken cancellationToken)
        {
            _context.Roles.Remove(role);
            _context.SaveChangesAsync();
            return Task.FromResult(IdentityResult.Success);
        }

        public Task<Role> FindByIdAsync(string roleId, CancellationToken cancellationToken)
            => Task.FromResult(_context.Roles.Where(r=>r.Id==roleId).FirstOrDefault());

        public Task<Role> FindByNameAsync(string roleName, CancellationToken cancellationToken)
            => Task.FromResult(_context.Roles.Where(r => string.Equals(r.Name, roleName, StringComparison.OrdinalIgnoreCase)).First());

        public Task<string> GetNormalizedRoleNameAsync(Role role, CancellationToken cancellationToken)
            => Task.FromResult(role.Name);

        public Task<string> GetRoleIdAsync(Role role, CancellationToken cancellationToken)
            => Task.FromResult(role.Id);

        public Task<string> GetRoleNameAsync(Role role, CancellationToken cancellationToken)
            => Task.FromResult(role.Name);

        public Task SetNormalizedRoleNameAsync(Role role, string normalizedName, CancellationToken cancellationToken)
        {
            role.Name = normalizedName;
            return Task.CompletedTask;
        }

        public Task SetRoleNameAsync(Role role, string roleName, CancellationToken cancellationToken)
        {
            role.Name = roleName;
            return Task.CompletedTask;
        }

        public Task<IdentityResult> UpdateAsync(Role role, CancellationToken cancellationToken)
        {
            // In-memory store, nothing to do here
            return Task.FromResult(IdentityResult.Success);
        }

        public void Dispose()
        {
            //Nothing to do
        }
    }
}
