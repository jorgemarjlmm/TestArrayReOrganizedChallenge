using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestArrayChallange
{
    [TestClass]
    public class UnitTestArray
    {
        [TestMethod]
        public void TestMethodArrayActionsFindName()
        {
            TestArrayCustom.Controllers.BL.ArrayFunctions arrayFctions = new TestArrayCustom.Controllers.BL.ArrayFunctions();
            string[] names = { "Sonia Maria Wood Dempster", "Laruen Ana Eagles Beneke" };
            int order = 1;
            Console.WriteLine(String.Join("\n", arrayFctions.FindNameByPosition(names, order)));
        }

        [TestMethod]
        public void TestMethodArrayActionsReorganizedArrayNames()
        {
            TestArrayCustom.Controllers.BL.ArrayFunctions arrayFctions = new TestArrayCustom.Controllers.BL.ArrayFunctions();
            string[] names = { "Sonia Maria Wood Dempster", "Laruen Ana Eagles Beneke" };
            int[] order = { 4, 1, 2, 3 };
            TestArrayCustom.Controllers.Request.ReorganizedArrayRequest request = new TestArrayCustom.Controllers.Request.ReorganizedArrayRequest();
            request.names = names;
            request.order = order;
            Console.WriteLine(String.Join("\n", arrayFctions.ReorganizedArrayNames(request)));
        }        
    }
}