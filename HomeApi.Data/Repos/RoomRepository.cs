﻿using HomeApi.Data.Models;
using HomeApi.Data.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Репозиторий для операций с объектами типа "Room" в базе
    /// </summary>
    public class RoomRepository : IRoomRepository
    {
        private readonly HomeApiContext _context;

        public RoomRepository(HomeApiContext context)
        {
            _context = context;
        }

        /// <summary>
        ///  Найти комнату по имени
        /// </summary>
        public async Task<Room> GetRoomByName(string name)
        {
            return await _context.Rooms.Where(r => r.Name == name).FirstOrDefaultAsync();
        }

        /// <summary>
        ///  Добавить новую комнату
        /// </summary>
        public async Task AddRoom(Room room)
        {
            var entry = _context.Entry(room);
            if (entry.State == EntityState.Detached)
                await _context.Rooms.AddAsync(room);

            await _context.SaveChangesAsync();
        }
        public async Task UpdateRoom(Room room, UpdateRoomQuery updateRoomQuery)
        {
            room.Area = updateRoomQuery.Area;
            room.GasConnected = updateRoomQuery.GasConnected;
            room.Voltage = updateRoomQuery.Voltage;

            _context.Update(room);

            await _context.SaveChangesAsync();
        }
    }
}
