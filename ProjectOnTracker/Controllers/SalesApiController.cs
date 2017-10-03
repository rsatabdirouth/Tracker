using ProjectOnTracker.Models;
using ProjectOnTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace ProjectOnTracker.Controllers
{
   // [Queryable]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SalesApiController : ApiController
    {
        SalesContext _db = new SalesContext();
        [HttpGet]
        public IHttpActionResult getBuyer()
        {
            var product = _db.product.ToList();
            var website = _db.website.ToList();
            var Buyer = _db.buyerinformation.ToList();
            var buyerdesignation = _db.designation.ToList();
            var status = _db.buyerstatus.ToList();
            var source = _db.buyersource.ToList();
            var Communicationmedium = _db.communicationmedium.ToList();
            var communicationinformation = _db.communicationinfo.ToList();
            var TransferTo = _db.transferredto.ToList();
            var Priority = _db.buyerpriority.ToList();
            var SalesData = new SalesData() {
                BuyerInfo=Buyer,
                product=product,
                web=website,
                Designation=buyerdesignation,
                Status=status,
                Source=source,
                CommunicationMedium=Communicationmedium,
                communicationChain=communicationinformation,
                TransferredTo=TransferTo,
                Priority=Priority,

            };
         
               return Ok(SalesData);
        }

    }
}
