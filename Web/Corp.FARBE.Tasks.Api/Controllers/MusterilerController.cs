using Corp.FARBE.Tasks.Queries.Messages;
using Corp.FARBE.Tasks.Queries.Projections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Corp.FARBE.Tasks.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "GET, POST, OPTIONS")]
    [RoutePrefix("api/Musteriler")]
    public class MusterilerController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetMusteriler()
        {
            //throw new NotImplementedException("To do");

            // #01 get the result from projection
            MusteriLoadResponse responseObject = MusteriProjections.GetAllMusteri();

            // #02 send back 200 OK with response
            return Ok(responseObject);
        }

    }
}
