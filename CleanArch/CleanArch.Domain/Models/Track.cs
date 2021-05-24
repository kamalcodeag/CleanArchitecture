using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Track
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string LyricsByLine { get; set; }
        public decimal Size { get; set; }
        public Singer Singer { get; set; }
    }
}
