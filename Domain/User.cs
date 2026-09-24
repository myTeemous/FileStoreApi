using Microsoft.AspNetCore.Identity;

namespace FileStoreApi.Domain
{
    public class User : IdentityUser
    {
        public DateTime CreatedAt { get; set; }

        public ICollection<FileMetadata> Files { get; set; } = [];
    }
}
