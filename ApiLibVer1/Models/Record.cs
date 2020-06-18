using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLib.Models
{
    public enum RecordStatus
    {
        Rezerwacja,
        Wypożyczenie,
        Odbiór,
        Zwrot,
        Potwierdzenie,
        Zakonczone
    }

    public class Record
    {
        [Key]
        public int RecordId { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        [ForeignKey("Owner")]
        public int UserId { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }

        public RecordStatus RecordStatus { get; set; }
        public DateTime DateTime { get; set; }
    }
}
