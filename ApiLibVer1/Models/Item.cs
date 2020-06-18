using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLib.Models
{
    public enum ItemStatus
    {
        Dostępny,
        Zarezerwowany,
        Wypożyczony
    }

    public enum ItemType
    {
        Book,
        AudioCD,
        DVD
    }

    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public ItemType ItemType { get; set; }
        public ItemStatus ItemStatus { set; get; }

        [ForeignKey("Owner")]
        public int UserId { get; set; }
    }
}

