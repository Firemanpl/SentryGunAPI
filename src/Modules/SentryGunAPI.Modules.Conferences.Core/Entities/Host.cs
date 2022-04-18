using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace SentryGunAPI.Modules.Conferences.Core.Entities;

public class Host
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Device> Devices { get; set; }
}