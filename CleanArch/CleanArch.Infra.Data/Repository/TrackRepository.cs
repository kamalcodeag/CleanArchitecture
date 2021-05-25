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
    public class TrackRepository : ITrackRepository
    {
        private readonly ChannelDBContext _channelDBContext;
        public TrackRepository(ChannelDBContext channelDBContext)
        {
            _channelDBContext = channelDBContext;
        }
        public IEnumerable<Track> GetTracks()
        {
            throw new NotImplementedException();
        }
    }
}
