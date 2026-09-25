using FileStoreApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace FileStoreApi.Infrastructure.Database
{
    public class FileStoreApiDbContext : DbContext
    {
        public FileStoreApiDbContext(DbContextOptions<FileStoreApiDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<FileMetadata> Files { get; set; }

        public DbSet<Folder> Folders { get; set; }
    }
}
