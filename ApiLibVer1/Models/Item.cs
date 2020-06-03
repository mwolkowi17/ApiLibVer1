using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibVer1.Models
{
    public enum ItemStatus
    {
        Zarezerwowany,
        Wypożyczony,
        Dostępny
    }

    public enum ItemType
    {
        Book,
        AudioCD,
        DVD
    }
    public class Item
    {
        public int ItemId { get; set; }
        public ItemType ItemType { get; set; }
        public ItemStatus ItemStatus { set; get; }
        public int OwnerId { get; set; }
    }
}

