﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eks
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EksEntities1 : DbContext
    {
        public EksEntities1()
            : base("name=EksEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<main> main { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<Registr> Registr { get; set; }
    }
}