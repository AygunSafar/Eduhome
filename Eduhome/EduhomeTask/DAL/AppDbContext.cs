﻿using EduhomeTask.Models;
using Microsoft.EntityFrameworkCore;

namespace EduhomeTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet <Notice> Notices{ get; set; }
        public DbSet <Blog> Blogs { get; set; }
        public DbSet <Event> Events { get; set; }
        public DbSet <Bio> Bios { get; set; }
        public DbSet <SocialMedia> SocialMedias { get; set; }

        

    }
} 
