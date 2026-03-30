using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fans;
namespace NET
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_FA1()
        {
            String s = "0111";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod2_FA1()
        {
            String s = "01011";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod3_FA1()
        {
            String s = "110101011";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod4_FA1()
        {
            String s = "1110111";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod5_FA1()
        {
            String s = "10";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        // Дополнительные тесты для FA1
        [TestMethod]
        public void TestMethod6_FA1()
        {
            String s = "011";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod7_FA1()
        {
            String s = "0";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod8_FA1()
        {
            String s = "111";
            FA1 fa = new FA1();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod9_FA2()
        {
            String s = "0101";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod10_FA2()
        {
            String s = "00110011";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod11_FA2()
        {
            String s = "0001";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod12_FA2()
        {
            String s = "111000";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        // Дополнительные тесты для FA2
        [TestMethod]
        public void TestMethod13_FA2()
        {
            String s = "01";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod14_FA2()
        {
            String s = "0011";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod15_FA2()
        {
            String s = "000111";
            FA2 fa = new FA2();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }

        [TestMethod]
        public void TestMethod16_FA3()
        {
            String s = "00110011";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod17_FA3()
        {
            String s = "0101";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }

        [TestMethod]
        public void TestMethod18_FA3()
        {
            String s = "11";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod19_FA3()
        {
            String s = "1101";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod20_FA3()
        {
            String s = "011";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod21_FA3()
        {
            String s = "101010";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
        
        [TestMethod]
        public void TestMethod22_FA3()
        {
            String s = "111";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == true);
        }
        
        [TestMethod]
        public void TestMethod23_FA3()
        {
            String s = "";
            FA3 fa = new FA3();
            bool? result = fa.Run(s);
            Assert.IsTrue(result == false);
        }
    }
}
