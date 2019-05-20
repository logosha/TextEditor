using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class File
    {
        public File()
        {
        }

        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] FileBody { get; set; }
    }
}
