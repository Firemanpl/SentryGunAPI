using SentryGunAPI.Modules.Conferences.Core.DTO;

namespace SentryGunAPI.Modules.Conferences.Core.Services;

internal interface IHostService
{
    Task AddAsync(HostDetailsDto dto);
    Task<HostDetailsDto> GetAsync(Guid id);
    Task<IReadOnlyList<HostDto>> BrowseAsync();
    Task UpdateAsync(HostDetailsDto dto);
    Task DeleteAsync(Guid id);
}