﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _21._102_Zotochkina_02.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Attestation> Attestation { get; set; }
        public DbSet<Criteria> Criteria { get; set; }
        public DbSet<Discipline> Discipline { get; set; }
        public DbSet<DisciplineTeachers> DisciplineTeachers { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Speciality> Speciality { get; set; }
        public DbSet<StatusStudent> StatusStudent { get; set; }
        public DbSet<StatusTeacher> StatusTeacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentResult> StudentResult { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<TypeAttestation> TypeAttestation { get; set; }
        public DbSet<Vedomosti> Vedomosti { get; set; }
    }
}
