using HomeApi.Data.Models;
using HomeApi.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Device в базе 
    /// </summary>
    public interface IDeviceRepository
    {
        Task<Device[]> GetDevices();
        Task<Device> GetDeviceByName(string name);
        Task<Device> GetDeviceById(Guid id);
        Task SaveDevice(Device device, Room room);
        Task UpdateDevice(Device device, Room room, UpdateDeviceQuery query);
        Task DeleteDevice(Device device);
    }
}
