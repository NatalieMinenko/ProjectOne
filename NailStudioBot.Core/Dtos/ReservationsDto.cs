using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.Core.Dtos
{
    public class ReservationsDto
    {
        public int? Id { get; set; }

        public DateTime? StartDateTime { get; set; }

        public decimal? Sum { get; set; }

        public int? ClientId { get; set; }

        public int? StatusId { get; set; }

        public bool? IsAction { get; set; }

    }
}
