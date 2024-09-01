using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.Core.Dtos
{
    public class ServicesDto
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public int? Duration { get; set; }

        public bool? IsActive { get; set; }

        public string? IsDeleted { get; set; }

    }
}
