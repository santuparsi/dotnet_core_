using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandsOnEFDBFirst.Entities
{
    public partial class TrainingContext : DbContext
    {
        public TrainingContext()
        {
        }

        public TrainingContext(DbContextOptions<TrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookMaster> BookMasters { get; set; }
        public virtual DbSet<BookTransaction> BookTransactions { get; set; }
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual DbSet<DesigMaster> DesigMasters { get; set; }
        public virtual DbSet<First> Firsts { get; set; }
        public virtual DbSet<Second> Seconds { get; set; }
        public virtual DbSet<StaffMaster> StaffMasters { get; set; }
        public virtual DbSet<StudentMark> StudentMarks { get; set; }
        public virtual DbSet<StudentMaster> StudentMasters { get; set; }
        public virtual DbSet<Tabl1> Tabl1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=Training;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BookMaster>(entity =>
            {
                entity.HasKey(e => e.BookCode)
                    .HasName("PK__Book_Mas__BC2BA8A75D2217FA");

                entity.ToTable("Book_Master");

                entity.Property(e => e.BookCode)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("Book_code");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BookCategory)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("book_category");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Book_name");

                entity.Property(e => e.PubYear).HasColumnName("pub_year");
            });

            modelBuilder.Entity<BookTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Book_Transaction");

                entity.Property(e => e.ActualReturnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Actual_Return_date");

                entity.Property(e => e.BookCode)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("Book_code");

                entity.Property(e => e.ExpReturnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Exp_Return_date");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Issue_date");

                entity.Property(e => e.StaffCode)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("Staff_code");

                entity.Property(e => e.StudCode)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("Stud_code");

                entity.HasOne(d => d.BookCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.BookCode)
                    .HasConstraintName("FK__Book_Tran__Book___45F365D3");

                entity.HasOne(d => d.StaffCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StaffCode)
                    .HasConstraintName("FK__Book_Tran__Staff__47DBAE45");

                entity.HasOne(d => d.StudCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StudCode)
                    .HasConstraintName("FK__Book_Tran__Stud___46E78A0C");
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.HasKey(e => e.DeptCode)
                    .HasName("PK__Departme__B5AD70E9B6826B63");

                entity.ToTable("Department_master");

                entity.HasIndex(e => e.DeptName, "UQ__Departme__B744FF0F602F8E9E")
                    .IsUnique();

                entity.Property(e => e.DeptCode)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Dept_code");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Name");
            });

            modelBuilder.Entity<DesigMaster>(entity =>
            {
                entity.HasKey(e => e.DesignCode)
                    .HasName("PK__Desig_ma__C6271B67E78EDF62");

                entity.ToTable("Desig_master");

                entity.HasIndex(e => e.DesignName, "UQ__Desig_ma__E07C1CF594CA63B3")
                    .IsUnique();

                entity.Property(e => e.DesignCode)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("Design_Code");

                entity.Property(e => e.DesignName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Design_Name");
            });

            modelBuilder.Entity<First>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("First");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Second>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Second");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StaffMaster>(entity =>
            {
                entity.HasKey(e => e.StaffCode)
                    .HasName("PK__Staff_Ma__5FB09B0E771BD7D0");

                entity.ToTable("Staff_Master");

                entity.Property(e => e.StaffCode)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("Staff_Code");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Dept_Code");

                entity.Property(e => e.DesCode)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("Des_Code");

                entity.Property(e => e.Hiredate).HasColumnType("datetime");

                entity.Property(e => e.MgrCode)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("Mgr_code");

                entity.Property(e => e.Salary).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.StaffDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Staff_dob");

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Staff_Name");

                entity.HasOne(d => d.DeptCodeNavigation)
                    .WithMany(p => p.StaffMasters)
                    .HasForeignKey(d => d.DeptCode)
                    .HasConstraintName("FK__Staff_Mas__Dept___4222D4EF");

                entity.HasOne(d => d.DesCodeNavigation)
                    .WithMany(p => p.StaffMasters)
                    .HasForeignKey(d => d.DesCode)
                    .HasConstraintName("FK__Staff_Mas__Des_C__412EB0B6");
            });

            modelBuilder.Entity<StudentMark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student_Marks");

                entity.Property(e => e.StudCode)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("Stud_Code");

                entity.Property(e => e.StudYear).HasColumnName("Stud_Year");

                entity.Property(e => e.Subject1).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Subject2).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Subject3).HasColumnType("numeric(3, 0)");

                entity.HasOne(d => d.StudCodeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StudCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Student_M__Stud___3E52440B");
            });

            modelBuilder.Entity<StudentMaster>(entity =>
            {
                entity.HasKey(e => e.StudCode)
                    .HasName("PK__Student___67F2A964002549E9");

                entity.ToTable("Student_master");

                entity.Property(e => e.StudCode)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("Stud_Code");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("Dept_Code");

                entity.Property(e => e.StudDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Stud_Dob");

                entity.Property(e => e.StudName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Stud_Name");

                entity.HasOne(d => d.DeptCodeNavigation)
                    .WithMany(p => p.StudentMasters)
                    .HasForeignKey(d => d.DeptCode)
                    .HasConstraintName("FK__Student_m__Dept___3C69FB99");
            });

            modelBuilder.Entity<Tabl1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tabl1");

                entity.Property(e => e.Col1)
                    .HasColumnType("date")
                    .HasColumnName("col1");

                entity.Property(e => e.Col2)
                    .HasColumnType("datetime")
                    .HasColumnName("col2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
