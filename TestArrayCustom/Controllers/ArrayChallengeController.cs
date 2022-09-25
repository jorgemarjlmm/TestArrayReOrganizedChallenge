using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestArrayCustom.Controllers.BL;
using TestArrayCustom.Controllers.Request;

namespace TestArrayCustom.Controllers
{
    public class ArrayChallengeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ArrayReorganized([FromBody]ReorganizedArrayRequest reorganizedArrayRequest)
        {
            string result;

            if (reorganizedArrayRequest != null && reorganizedArrayRequest.names.Length > 0 && reorganizedArrayRequest.order.Length > 0)
            {
                TestArrayChallenge testArrayChallenge = new TestArrayChallenge(new ArrayFunctions());

                result = testArrayChallenge.ReorganizedArray(reorganizedArrayRequest);
            }
            else
            {
                result = "The request is incorrect";
            }

            return Ok(result);
        }
    }
}
