using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibVer1.Models
{
    public enum RecordStatus
    {
        Zakonczone      //wypisać wszystkie możliwe statusy (etapy całego procesu: rezerwacja, wypożyczenie, odbiór, zwrot, potwierdzenie odbioru nieuszkodzonego przedmiotu, zakończenie).
    }
    public class Record
    {
        public int RecordId { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public RecordStatus RecordStatus { get; set; }
        public DateTime DateTime { get; set; }
    }
}
