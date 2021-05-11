using AdaYazilimTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaYazilimTest.Helper
{
    public static class ReservationHelper
    {
        public static YerlesimAyrinti SetCustomerToVagon(this Vagonlar vagon,ref int passangerCount, bool isFlexiable)
        {
            YerlesimAyrinti yerlesim = new YerlesimAyrinti(vagon.Ad);
            int bosluksayisi = Convert.ToInt16(vagon.Kapasite * 0.70) - vagon.DoluKoltukAdet;
            if (bosluksayisi <= 0)
                return null;
            if (bosluksayisi - passangerCount < 0 && !isFlexiable)
                return null;
            while (bosluksayisi >0 && passangerCount != 0)
            {
                bosluksayisi--;
                passangerCount--;
                yerlesim.KisiSayisi++;
            }
            return yerlesim;
        }
    }
}