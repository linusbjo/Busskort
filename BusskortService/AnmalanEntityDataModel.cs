﻿namespace BusskortService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AnmalanEntityDataModel : DbContext
    {
        public AnmalanEntityDataModel()
            : base("name=AnmalanEntityDataModel")
        {
        }

        public virtual DbSet<Anmälan> Anmälan { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anmälan>()
                .Property(e => e.Skola)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.Förnamn)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.Efternamn)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.barnFörnamn)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.barnEfternamn)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.E_post)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.Ort)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.Beviljad)
                .IsUnicode(false);

            modelBuilder.Entity<Anmälan>()
                .Property(e => e.Motivering)
                .IsUnicode(false);

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
