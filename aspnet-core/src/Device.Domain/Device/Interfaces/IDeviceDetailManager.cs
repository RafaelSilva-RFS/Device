using System.Threading.Tasks;

namespace Device.Domain.Device.Interfaces
{
    public interface IDeviceDetailManager
    {
        Task<float> CountAllDevicesUsageAsync();
    }
}
