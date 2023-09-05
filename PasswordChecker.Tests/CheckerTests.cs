using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordChecker.Tests
{
    [TestClass]
    public class CheckerTests
    {
        [TestMethod]
        public void isDigit_digit_1()
        {
            string password = "7";
            int result = 1;

            PaswordChecker.Checker checker = new PaswordChecker.Checker();

            int returned = checker.PasswordCheck(password);

            Assert.AreEqual(result, returned);
        }

        [TestMethod]
        public void isUpper_upperChar_2()
        {
            string password = "7A";
            int result = 2;

            PaswordChecker.Checker checker = new PaswordChecker.Checker();

            int returned = checker.PasswordCheck(password);

            Assert.AreEqual(result, returned);
        }


        [TestMethod]
        public void isSpecChar_specChar_3()
        {
            string password = "7A$";
            int result = 3;

            PaswordChecker.Checker checker = new PaswordChecker.Checker();

            int returned = checker.PasswordCheck(password);

            Assert.AreEqual(result, returned);
        }


        [TestMethod]
        public void isLower_lowerChar_4()
        {
            string password = "7A$d";
            int result = 4;

            PaswordChecker.Checker checker = new PaswordChecker.Checker();

            int returned = checker.PasswordCheck(password);

            Assert.AreEqual(result, returned);
        }


        [TestMethod]
        public void isSevenSymbols_sevenSymbols_5()
        {
            string password = "7A$dASx";
            int result = 5;

            PaswordChecker.Checker checker = new PaswordChecker.Checker();

            int returned = checker.PasswordCheck(password);

            Assert.AreEqual(result, returned);
        }


        [TestMethod]
        public void isEmpty_empty_0()
        {
            string password = "";
            int result = 0;

            PaswordChecker.Checker checker = new PaswordChecker.Checker();

            int returned = checker.PasswordCheck(password);

            Assert.AreEqual(result, returned);
        }
    }
}
