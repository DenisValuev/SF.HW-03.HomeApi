using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении устройства
    /// </summary>
    public class UpdateRoomQuery
    {
        public string Name { get; }
        public int Area { get; }
        public bool GasConnected { get; }
        public int Voltage { get; }

        public UpdateRoomQuery(string Name = null, int Area = 0, bool GasConnected = false, int Voltage = 0)
        {
            this.Name = Name;
            this.Area = Area;
            this.GasConnected = GasConnected;
            this.Voltage = Voltage;
        }
    }
}
