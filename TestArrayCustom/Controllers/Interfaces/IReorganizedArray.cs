using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestArrayCustom.Controllers.Request;

namespace TestArrayCustom.Controllers.Interfaces
{
    public interface IReorganizedArray
    {
        string[] ReorganizedArrayNames(ReorganizedArrayRequest reorganizedArrayRequest);
    }
}
