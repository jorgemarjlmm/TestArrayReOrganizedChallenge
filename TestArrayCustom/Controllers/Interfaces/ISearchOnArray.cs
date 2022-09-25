using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayCustom.Controllers.Interfaces
{
    public interface ISearchOnArray
    {
        string FindNameByPosition(string[] arrayNames, int position);
    }
}
