using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class SingerService : ISingerService
    {
        private readonly ISingerRepository _singerRepository;

        public SingerService(ISingerRepository singerRepository)
        {
            _singerRepository = singerRepository;
        }
        public SingerViewModel GetSingers()
        {
            return new SingerViewModel()
            {
                Singers = _singerRepository.GetSingers()
            };
        }
    }
}
