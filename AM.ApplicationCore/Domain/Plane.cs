﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane
    {



        //public Plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    PlaneType = pt;
        //    Capacity = capacity;
        //    ManufactureDate = date;

        //}
        public int PlaneId { get; set; }

        public PlaneType PlaneType { get; set; }

        public DateTime ManufactureDate { get; set; }
       [ Range(1, int.MaxValue, ErrorMessage = "la capacite doit etre positif")]
        public int Capacity { get; set; }

        public  IList<Flight> Flights { get; set; }
        public String AirLineLogo { get; set; }

        public override string ToString()
        {
            return "PlaneType: " + PlaneType + " ManufactureDate: " + ManufactureDate + " Capacity: " + Capacity;
        }
    }
}
