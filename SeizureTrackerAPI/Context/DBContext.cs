using Microsoft.EntityFrameworkCore;
using SeizureTrackerAPI.Models;

namespace SeizureTrackerAPI.Context;

public class DBContext(DbContextOptions<DBContext> options) : DbContext(options)
{
    public DbSet<Caregiver> Caregivers { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Seizure> Seizures { get; set; }
    public DbSet<CaregiverPatientLink> CaregiverPatientLinks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        _ = modelBuilder.Entity<CaregiverPatientLink>()
            .HasKey(link => link.LinkID);

        _ = modelBuilder.Entity<CaregiverPatientLink>()
            .HasOne(link => link.Caregiver)
            .WithMany(c => c.CaregiverLinks)
            .HasForeignKey(link => link.CaregiverID)
            .OnDelete(DeleteBehavior.Cascade);

        _ = modelBuilder.Entity<CaregiverPatientLink>()
            .HasOne(link => link.Patient)
            .WithMany(p => p.PatientLinks)
            .HasForeignKey(link => link.PatientID)
            .OnDelete(DeleteBehavior.Cascade);

        _ = modelBuilder.Entity<CaregiverPatientLink>()
            .HasIndex(link => new { link.CaregiverID, link.PatientID })
            .IsUnique();

        // One-to-many: Patient → Seizures
        _ = modelBuilder.Entity<Seizure>()
            .HasOne(s => s.Patient)
            .WithMany(p => p.Seizures)
            .HasForeignKey(s => s.PatientID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

