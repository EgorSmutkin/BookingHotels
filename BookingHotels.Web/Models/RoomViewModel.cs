﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookingHotels.BLL.DTO;
using BookingHotels.DAL.Enums;


namespace BookingHotels.Web.Models
{
    public class RoomViewModel
    {
        public Guid ID { get; set; }
        public Guid HotelID { get; set; }
        public int RoomNumber { get; set; }
        public RoomType RoomType { get; set; }
    }
}