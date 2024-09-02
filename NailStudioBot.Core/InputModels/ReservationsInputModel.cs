﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.Core.InputModels
{
    public class ReservationsInputModel
    {
        public DateTime StartDateTime { get; set; }
        public decimal Sum { get; set; }
        public int ClientId { get; set; }
        public int StatusId { get; set; }
        public bool IsAction { get; set; }
    }
}
