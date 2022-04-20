﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFStudentAccomodation.Models
{
    [Table("Room")]
    public partial class Room
    {
        public Room()
        {
            Leasings = new HashSet<Leasing>();
        }

        [Key]
        public int PlaceNo { get; set; }
        public int RentPerSemester { get; set; }
        public bool Occupied { get; set; }
        public int RoomNo { get; set; }
        public int? DormitoryNo { get; set; }
        public int? AppartNo { get; set; }

        [ForeignKey(nameof(AppartNo))]
        [InverseProperty(nameof(Appartment.Rooms))]
        public virtual Appartment AppartNoNavigation { get; set; }
        [ForeignKey(nameof(DormitoryNo))]
        [InverseProperty(nameof(Dormitory.Rooms))]
        public virtual Dormitory DormitoryNoNavigation { get; set; }
        [InverseProperty(nameof(Leasing.PlaceNoNavigation))]
        public virtual ICollection<Leasing> Leasings { get; set; }
    }
}