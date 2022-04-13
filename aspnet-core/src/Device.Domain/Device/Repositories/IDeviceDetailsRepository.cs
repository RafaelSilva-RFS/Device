using System.Threading.Tasks;

namespace Device.Domain.Device.Repositories
{
    public interface IDeviceDetailsRepository
    {
        Task<float> CountAllDevicesUsageAsync();
    }
}
