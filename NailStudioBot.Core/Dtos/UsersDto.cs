using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.Core.Dtos
{
    public class UsersDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        
        public int? UserCount { get; set; }
    }
}
