using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    public class SingerViewModel
    {
        public IEnumerable<Singer> Singers { get; set; }
    }
}
