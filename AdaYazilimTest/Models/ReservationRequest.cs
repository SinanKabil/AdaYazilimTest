using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaYazilimTest.Models
{
    public class Vagonlar
    {
        public string Ad { get; set; }
        public int Kapasite { get; set; }
        public int DoluKoltukAdet { get; set; }
    }

    public class Tren
    {
        public string Ad { get; set; }
        public List<Vagonlar> Vagonlar { get; set; }
    }

    public class ReservationRequest
    {
        public Tren Tren { get; set; }
        public int RezervasyonYapilacakKisiSayisi { get; set; }
        public bool KisilerFarkliVagonlaraYerlestirilebilir { get; set; }
    }
}