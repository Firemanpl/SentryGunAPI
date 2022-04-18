using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SentryGunAPI.Modules.Conferences.Core.Entities;

public class Device
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Location { get; set; }
    public string MacAddress { get; set; }
    public Guid ConfigurationId { get; set; }
    public Configuration Configuration{ get; set; }
}