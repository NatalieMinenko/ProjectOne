using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailStudioBot.Core.OutPutModels
{
    public class ServicesOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
