namespace SkillTrackerDataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SkillTrackerContext : DbContext
    {
        public SkillTrackerContext()
            : base("name=SkillTrackerContext")
        {
        }

        public virtual DbSet<Associate> Associates { get; set; }
        public virtual DbSet<AssociateSkill> AssociateSkills { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Associate>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Associate>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Associate>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Associate>()
                .Property(e => e.Pic)
                .IsUnicode(false);

            modelBuilder.Entity<Associate>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<Associate>()
                .Property(e => e.Strength)
                .IsUnicode(false);

            modelBuilder.Entity<Associate>()
                .Property(e => e.Weakness)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Skill_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Associate>()
               .HasMany(e => e.AssociateSkills)
               .WithRequired(e => e.Associate)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skill>()
                .HasMany(e => e.AssociateSkills)
                .WithRequired(e => e.Skill)
                .WillCascadeOnDelete(false);
        }
    }
}
