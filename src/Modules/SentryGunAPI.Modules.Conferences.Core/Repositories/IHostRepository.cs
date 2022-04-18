using SentryGunAPI.Modules.Conferences.Core.Entities;

namespace SentryGunAPI.Modules.Conferences.Core.Repositories;

internal interface IHostRepository
{
    Task<Host> GetAsync(Guid id);
    Task<IReadOnlyList<Host>> BrowseAsync();
    Task AddAsync();
    Task UpdateAsync(Host host);
    Task DeleteAsync(Guid id);
}