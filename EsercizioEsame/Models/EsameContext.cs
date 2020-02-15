namespace EsercizioEsame.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EsameContext : DbContext
    {
        public EsameContext()
            : base("name=Exam")
        {
        }

        public virtual DbSet<Anagrafica> Anagraficas { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anagrafica>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Anagrafica)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
