namespace FileStoreApi.Domain
{
    public class FileMetadata
    {
        public Guid Id { get; set; }

        // Ownership
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;

        // User-facing information
        public string FileName { get; set; } = null!;
        public string ContentType { get; set; } = null!;
        public long Size { get; set; }

        // Azure Blob information
        public string BlobContainer { get; set; } = null!;
        public string BlobName { get; set; } = null!;

        // Metadata
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
