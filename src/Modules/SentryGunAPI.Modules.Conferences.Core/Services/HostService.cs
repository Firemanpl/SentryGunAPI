using SentryGunAPI.Modules.Conferences.Core.DTO;
using SentryGunAPI.Modules.Conferences.Core.Entities;
using SentryGunAPI.Modules.Conferences.Core.Repositories;

namespace SentryGunAPI.Modules.Conferences.Core.Services;

internal class HostService : IHostService
{
    private readonly IHostRepository _hostRepository;

    public HostService(IHostRepository hostRepository)
    {
        _hostRepository = hostRepository;
    }
    public Task AddAsync(HostDetailsDto dto)
    {
        dto.Id = Guid.NewGuid();
        await _hostRepository.AddAsync(new Host
        {
            Id = dto.Id,
            Name = dto.
        });
    }

    public Task<HostDetailsDto> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<HostDto>> BrowseAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(HostDetailsDto dto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}