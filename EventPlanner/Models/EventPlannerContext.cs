using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Models
{
    public partial class EventPlannerContext : DbContext
    {
        public EventPlannerContext()
        {
        }

        public EventPlannerContext(DbContextOptions<EventPlannerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EventType> EventTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=EventPlanner;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EventType");

                entity.Property(e => e.EventTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EventTypeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
