using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;

public class AppDbcontext:DbContext
{
	public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options)
	{
	}
	public DbSet<SlideItem> SlideItems { get; set; } 
	public DbSet<SlideText> SlideTexts { get; set; } 
}
