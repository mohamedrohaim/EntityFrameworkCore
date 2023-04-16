using EFCore.Configrations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace EFCore
{
    public class ApplicationDbContextOld //: DbContext
    {
       /* protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer("Server=.;Database=EFCore;Integrated Security=true");*/


        // fluent api way
       // protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            #region MyRegion
            // * add to database this way similar to use DbSet<table>tableName
            // modelBuilder.Entity<AuditEntry>();
            //new BlogEntityTypeConfigration().Configure(modelBuilder.Entity<Blog>());
            // * Exclude from migration
            //modelBuilder.Entity<Blog>().ToTable("Blogs",b=>b.ExcludeFromMigrations());
            // * change table name
            //modelBuilder.Entity<Blog>().ToTable("Blogs");
            // * change schma
            //modelBuilder.Entity<Blog>().ToTable("Blogs",schema:"blogging");
            // * change default schma
            // modelBuilder.HasDefaultSchema("blogging");
            // * maping to view in database
            //modelBuilder.Entity<Blog>().ToView("NameOf View");
            // * Exclude AddedOnly from migration
            //modelBuilder.Entity<Blog>().Ignore(b=>b.AddedOn);    

            // * change property name in database 
            //modelBuilder.Entity<Blog>().Property(p=>p.Url).HasColumnName("BlogUrl");

            // *set primary key and change the name
            //modelBuilder.Entity<Book>().HasKey(x => x.Id).HasName("pk_Book");

            // *set composite 

            //modelBuilder.Entity<Book>().HasKey(b=>new{b.Name,b.Author});
            // *set composite 
            // * to make id Identity
            // modelBuilder.Entity<Blog>().Property(p=>p.Rating).HasDefaultValue(2);
            // modelBuilder.Entity<Blog>().Property(p=>p.CreatedOn).HasDefaultValueSql("GETDATE()");

            // * computed columns
            // modelBuilder.Entity<Author>().Property(p=>p.DisplayName).HasComputedColumnSql("[FirstName]+' '+[LastName]");
            // * to make id Identity
            // modelBuilder.Entity<Categoty>().Property(p=>p.Id).ValueGeneratedOnAdd(); 
            #endregion

            #region Relations

            //* add forignkey parent is Blog
            /*  modelBuilder.Entity<Blog>().HasOne(b => b.BlogImage).WithOne(i => i.Blog)
                  .HasPrincipalKey<BlogImage>(b => b.BlogForiegnKey);*/

            // *one to many 
            //modelBuilder.Entity<Blog>().HasMany(B => B.posts).WithOne();
            //modelBuilder.Entity<Post>().HasOne<Blog>().WithMany().HasForeignKey(b=>b.Id);

            // * how to change forigen key name
            /* modelBuilder.Entity<Post>().HasOne<Blog>().WithMany()
                 .HasForeignKey(b => b.Id)
                 .HasConstraintName("FK_Posts_Test");*/


            // * change principle key
            /* modelBuilder.Entity<RecordSales>()
                 .HasOne(s => s.Car)
                 .WithMany(c=>c.SalesHistory)
                 .HasForeignKey(s=>s.CarLicensePlate)
                 .HasPrincipalKey(c=>c.LicensePlate);*/
            // * make principle nad forigen key composite 
            /*modelBuilder.Entity<RecordSales>()
                 .HasOne(s => s.Car)
                 .WithMany(c => c.SalesHistory)
                 .HasForeignKey(s => new { s.CarLicensePlate, s.CarState })
                 .HasPrincipalKey(c => new { c.LicensePlate, c.State });*/


            // *one to many 
            /* modelBuilder.Entity<Post>()
                 .HasMany(p => p.Tags)
                 .WithMany(t => t.posts)
                 .UsingEntity(j => j.ToTable("PostTagsTest"));  */

            /* add this line if you used third table */

            /* modelBuilder.Entity<Post>()
                     .HasMany(p => p.Tags)
                     .WithMany(t => t.posts)
                     .UsingEntity<PostTag>( j=>j
                     .HasOne(pt=>pt.Tag)
                     .WithMany(t=>t.PostTags)
                     .HasForeignKey(pt=>pt.TagId),
                     j=>j
                     .HasOne(pt=>pt.post)
                     .WithMany(p => p.PostTags)
                     .HasForeignKey(pt=>pt.PostId),
                     j => {
                         j.Property(pt => pt.AddedOn).HasComputedColumnSql("GETDATE()");
                         j.HasKey(pt => new{pt.PostId,pt.TagId});

                     }
                     );*/
            // *another way (indirect  many to many relashinship) >>> Dont Forget to remove Icollections
            /*   modelBuilder.Entity<PostTag>()
                        .HasKey(t => new { t.PostId, t.TagId }); // composite key
               modelBuilder.Entity<PostTag>().HasOne(pt => pt.post)
                   .WithMany(p => p.PostTags)
                   .HasForeignKey(p=>p.PostId);

                modelBuilder.Entity<PostTag>().HasOne(pt => pt.Tag)
                   .WithMany(p => p.PostTags)
                   .HasForeignKey(p => p.TagId);*/


            #endregion


        //}
       // public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts{ get; set; }


        #region DpSets
        /* public DbSet<Blog> Blogs { get; set; }
        //public DbSet<BlogImage> BlogImages { get; set; }
        /*public DbSet<Blog> Blogs   { get; set; } 
        public DbSet<Author> Authors   { get; set; } 
        public DbSet<Categoty> Categoties  { get; set; }        
        //public DbSet<Post> Posts   { get; set; } 

       */

        //public DbSet<Car> Cars { get; set; }
        //  public DbSet<Post> posts { get; set; }
        //public DbSet<Tag> Tags { get; set; } 

        #endregion




    }


    }



    /*public class Blog
    {
        public int Id { get; set; }
        [Required, MaxLength(1000)]
        public string Url { get; set; }

        public List<Post> posts { get; set; }
        //one to one relashinship
        //public BlogImage BlogImage { get; set; }
    }*/



/*
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public int BlogId { get; set; }

        //public ICollection<Tag> Tags { get; set; }

        //[ForeignKey(nameof(BlogId))]
         add this line if you used third table 

        //public List<PostTag> PostTags { get; set; }
         

    }*/

    public class Tag
    {
        public string TagId { get; set; }
       // public ICollection<Post> posts { get; set; }
        /* add this line if you used third table */

        public List<PostTag> PostTags { get; set; }
    } 
    // another way in many to many relation to add htird table
    public class PostTag
    {
        public int PostId { get; set; }
        //public Post post { get; set; } 
        public string TagId { get; set; }
        public Tag Tag { get; set; }

        public DateTime AddedOn { get; set; }
        
    } 

    




    /*public class BlogImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required, MaxLength(250)]

        public string Caption { get; set; }
        public int BlogForiegnKey { get; set; }
        public Blog Blog { get; set; }
    }*/



    public class Car
    {
        public int CarId { get; set; }
        public string State { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public List<RecordSales> SalesHistory { get; set; }

    }
    public class RecordSales
    {
        [Key] 
        public int RecoedSalesId { get; set; }
        public DateTime DateSold { get; set; }
        public decimal Price { get; set;}

        public string CarLicensePlate { get; set; }
        public string CarState { get; set; }

        public Car Car { get; set; }
    }

