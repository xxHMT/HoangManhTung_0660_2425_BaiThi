using HoangManhTung_0660_2425_BaiThi.Models;
using Microsoft.EntityFrameworkCore;

namespace HoangManhTung_0660_2425_BaiThi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {}
        
    }
}