using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.Core.InputModels
{
    public class ServicesInputModel
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
