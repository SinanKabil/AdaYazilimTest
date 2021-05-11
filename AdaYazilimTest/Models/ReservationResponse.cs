using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaYazilimTest.Models
{
    public class ReservationResponse
    {
        public bool RezervasyonYapilabilir { get; set; }
        public List<YerlesimAyrinti> YerlesimAyrinti { get; set; } = new List<YerlesimAyrinti>();

        public void AddYerlesim(YerlesimAyrinti yerlesim)
        {
            if (yerlesim != null)
                YerlesimAyrinti.Add(yerlesim);
        }
        public void CheckReservationResponse(bool yolcuKaldiMi)
        {
            if (yolcuKaldiMi)
                NoReservation();
            else
                RezervasyonYapilabilir = true;
        }
        public void NoReservation()
        {
            RezervasyonYapilabilir = false;
            YerlesimAyrinti = new List<YerlesimAyrinti>();
        }
    }

    public class YerlesimAyrinti
    {
        public string VagonAdi { get; set; }
        public int KisiSayisi { get; set; }

        public YerlesimAyrinti(string vagonAdi)
        {
            VagonAdi = vagonAdi;
        }
    }
}
