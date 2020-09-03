﻿using DatingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Value> Values { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Photo> Photos { set; get; }
        public DbSet<Like> Likes { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Like>()
                 .HasKey(k => new { k.LikerId, k.LikeeId });

            builder.Entity<Like>()
               .HasOne(u => u.Likee)
               .WithMany(u => u.Likers)
               .HasForeignKey(u => u.LikeeId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Like>()
               .HasOne(u => u.Liker)
               .WithMany(u => u.Likees)
               .HasForeignKey(u => u.LikerId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
