namespace SentryGunAPI.Modules.Conferences.Core.Entities;

public class Configuration
{
    public Guid Id { get; set; }
    public Guid DeviceId { get; set; }
    public Device Device { get; set; }
    public string CamLocation { get; set; }
    public string TypeofWeapon { get; set; }
    public string TargetObject { get; set; }
    public string FireMode { get; set; }
    public bool StartStopFire { get; set; }
    
}