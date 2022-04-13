﻿using System.Threading.Tasks;

namespace Device.Application.Contracts.Devices
{
    public interface IDeviceDetailService
    {
        Task<float> CountAllDevicesUsageAsync();
    }
}
