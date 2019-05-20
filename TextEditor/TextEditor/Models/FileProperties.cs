using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class FileProperties
    {
        public FileProperties()
        {
        }

        [Key]
        public int Id { get; set; }
        public string FileName { get; set; }
    }
}