﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestArrayCustom.Controllers.Interfaces;
using TestArrayCustom.Controllers.Request;

namespace TestArrayCustom.Controllers.BL
{
    public class ArrayFunctions : IReorganizedArray, ISearchOnArray
    {
        //This method recive 2 parameters, the parameter name this parameter array is used for search on itself the position that is in the second parameter.
        //I validate that the position is in range on the array lenght.
        public string FindNameByPosition(string[] arrayNames, int position)
        {
            position = position - 1;
            string result = "";
            int length = arrayNames.Length - 1;

            if (position <= length && position > -1)
            {
                result = arrayNames[position];
            }
            else
            {
                result = "Position not found on array Names";
            }

            return result;
        }

        //I create this method to traverse the array the positions and take the value postion by position and the value is sent
        //to the method FindNameByPosition and after I get the name I save it on a list of string , after I traverse the array
        //and save the names on list of strings I convert the List of strings on array of strings.
        public string[] ReorganizedArrayNames(ReorganizedArrayRequest reorganizedArrayRequest)
        {
            string[] result = new string[reorganizedArrayRequest.order.Length];
            List<string> lstResult = new List<string>();
            string name;

            foreach (var pos in reorganizedArrayRequest.order)
            {
                name = FindNameByPosition(reorganizedArrayRequest.names, pos);
                lstResult.Add(name);
            }

            result = lstResult.ToArray();

            return result;
        }
    }
}