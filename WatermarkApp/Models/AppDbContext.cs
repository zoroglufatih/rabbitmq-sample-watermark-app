﻿using System;
using Microsoft.EntityFrameworkCore;

namespace WatermarkApp.Models
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{ }

		public DbSet<Product> Products { get; set; }
	}
}

