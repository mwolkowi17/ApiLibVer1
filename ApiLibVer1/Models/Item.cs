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

    public enum Type
    {
        Book,
        AudioCD,
        DVD
    }
    public class Item
    {
        public int ItemID { get; set; }
        public Type Type { get; set; }
        public ItemStatus Status { set; get; }

        public int LibraryId { get; set; }      //LUB public int OwnerId { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }      //wykonawca, reżyser, autor
    }
}

