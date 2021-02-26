﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace EFCoreHotel_RazorPages.Models
{
    [Table("Room")]
    public partial class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        [Column("Room_No")]
        public int RoomNo { get; set; }
        [Key]
        [Column("Hotel_No")]
        public int HotelNo { get; set; }
        [StringLength(1)]
        [Required(ErrorMessage = "This field is required")]
        public string Types { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public double? Price { get; set; }

        [ForeignKey(nameof(HotelNo))]
        [InverseProperty(nameof(Hotel.Rooms))]
        public virtual Hotel HotelNoNavigation { get; set; }
        [InverseProperty(nameof(Booking.Room))]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}