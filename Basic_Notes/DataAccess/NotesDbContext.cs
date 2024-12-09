﻿using Basic_Notes.Models;
using Microsoft.EntityFrameworkCore;

namespace Basic_Notes.DataAccess;

public class NotesDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public NotesDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Note> Notes => Set<Note>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("Database"));
    }
}