using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class ChannelDBContext : DbContext
    {
        public ChannelDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Singer> Singers { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}
