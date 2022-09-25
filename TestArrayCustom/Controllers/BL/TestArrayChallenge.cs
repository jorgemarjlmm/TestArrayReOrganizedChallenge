using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestArrayCustom.Controllers.Interfaces;
using Newtonsoft.Json;
using TestArrayCustom.Controllers.Response;
using TestArrayCustom.Controllers.Request;

namespace TestArrayCustom.Controllers.BL
{
    public class TestArrayChallenge
    {
        public readonly IReorganizedArray _reorganizedArray;

        public TestArrayChallenge(IReorganizedArray reorganizedArray)
        {
            _reorganizedArray = reorganizedArray;
        }

        public string ReorganizedArray(ReorganizedArrayRequest reorganizedArrayRequest)
        {            
            ReorganizedArrayResponse reorganizedArrayResponse = new ReorganizedArrayResponse();
            reorganizedArrayResponse.reorganizedname = _reorganizedArray.ReorganizedArrayNames(reorganizedArrayRequest);

            var result = JsonConvert.SerializeObject(reorganizedArrayResponse); 


            return result;            
        }

    }
}