using AdaYazilimTest.Helper;
using AdaYazilimTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdaYazilimTest.Controllers
{
    public class RezervController : ApiController
    {
        [HttpPost]
        public IHttpActionResult MakeReservation(ReservationRequest reservationRequest)
        {
            ReservationResponse reservationResponse = new ReservationResponse();
            int passangerCount = reservationRequest.RezervasyonYapilacakKisiSayisi;
            bool isFlexiable = reservationRequest.KisilerFarkliVagonlaraYerlestirilebilir;
            foreach (var item in reservationRequest.Tren.Vagonlar)
                if (passangerCount > 0)
                    reservationResponse.AddYerlesim(item.SetCustomerToVagon(ref passangerCount, true));
                else
                    break;
            reservationResponse.CheckReservationResponse(passangerCount>0);
            return Ok(reservationResponse);
        }
   
    }
}
