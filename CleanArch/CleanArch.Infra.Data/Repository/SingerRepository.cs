using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class SingerRepository : ISingerRepository
    {
        private readonly ChannelDBContext _channelDBContext;
        public SingerRepository(ChannelDBContext channelDBContext)
        {
            _channelDBContext = channelDBContext;
        }
        public IEnumerable<Singer> GetSingers()
        {
            throw new NotImplementedException();
        }
    }
}
