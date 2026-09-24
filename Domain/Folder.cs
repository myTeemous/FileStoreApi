namespace FileStoreApi.Domain
{
    public class Folder
    {
        public Guid Id { get; set; }

        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;

        public string Name { get; set; } = null!;

        public Guid? ParentFolderId { get; set; }
        public Folder? ParentFolder { get; set; }

        public ICollection<Folder> Children { get; set; } = [];
        public ICollection<FileMetadata> Files { get; set; } = [];

        public DateTime CreatedAt { get; set; }
    }
}
