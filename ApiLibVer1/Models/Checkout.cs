using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLibVer1.Models
{
    public enum Status
    {
        Zakonczone      //wypisać wszystkie możliwe statusy (etapy całego procesu: rezerwacja, wypożyczenie, odbiór, zwrot, potwierdzenie odbioru nieuszkodzonego przedmiotu, zakończenie).
    }
    public class Checkout
    {
        public int CheckoutID { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }

        public Status Status { get; set; }
    }
}
