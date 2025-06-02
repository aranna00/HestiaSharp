using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HestiaStore.DTO;

namespace HestiaStore.Entities
{
    [Table("chats")]
    public class Chat : IChat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public required string Id { get; set; }

        [Required]
        public required string Type { get; set; }

        public bool Active { get; set; }

        public string? Filter { get; set; }
    }
}