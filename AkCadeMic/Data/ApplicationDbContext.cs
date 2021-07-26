using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AkCadeMic.Models;

namespace AkCadeMic.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        public DbSet<Thread> Threads { get; set; }
        public DbSet<ThreadS> ThreadsS { get; set; }
        public DbSet<ThreadH> ThreadsH { get; set; }
        public DbSet<ThreadO> ThreadsO { get; set; }
        public DbSet<ThreadJ> ThreadsJ { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<ReplyS> RepliesS { get; set; }
        public DbSet<ReplyH> RepliesH { get; set; }
        public DbSet<ReplyO> RepliesO { get; set; }
    }
}