﻿using Api_QLKhachSan_N2.Entities;
using System.Collections.Generic;

namespace Api_QLKhachSan_N2.Interface
{
    public interface IOrderRoomRepository
    {
        IEnumerable<OrderRoom> GetAllOrderRooms(int? PageIndex, int? RowPerPage, string? Search);
        string InsertOrderRoom(OrderRoom OrderRoom);
        OrderRoom UpdateOrderRoom(OrderRoom OrderRoom);
    }
}
