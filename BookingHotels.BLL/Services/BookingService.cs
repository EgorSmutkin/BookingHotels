﻿using BookingHotels.BLL.DTO;
using BookingHotels.Domain.Entities;
using BookingHotels.Domain.Interfaces;
using BookingHotels.BLL.Interfaces;
using AutoMapper;

namespace BookingHotels.BLL.Services
{
    public class BookingService : IBookingService
    {
        // IUnitOfWork object communicates with DAL 
        private IUnitOfWork _unitOfWork { get; set; }

        // Use DI to pass implementation of IUnitOfWork
        public BookingService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        // Get bookingDto from Web, create booking and save to db
        public void CreateBooking(BookingDTO bookingDto)
        {
             Booking booking = Mapper.Map<BookingDTO, Booking>(bookingDto);
            _unitOfWork.Bookings.Create(booking);
            _unitOfWork.Save();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}