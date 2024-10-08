﻿using System;
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

        public string? Phone { get; set; }

        public string? Mail { get; set; }

        public int? RoleId { get; set; }

        public int? MasterTypeId { get; set; }
        
        public int? UserCount { get; set; }
    }
}
