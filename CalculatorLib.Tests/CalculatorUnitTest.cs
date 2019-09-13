using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CalculatorLib;
using CalculatorLib.Tests;

namespace NUnit.Tests
{
    namespace CalculatorLib.Tests
    {
        [TestClass]
        public class CalculatorUnitTest //test suit name
        {
            Calculate calculate;
            
            Moq.Mock<LoggerContractsLib.ILogger> _mockWrapper;

          [SetUp] //This functions will be executed each time before execution of each test Method.
            public void TestSetUp()
            {
                calculate = new Calculate();
                Moq.Mock<LoggerContractsLib.ILogger> _mockWrapper = new Moq.Mock<LoggerContractsLib.ILogger>();
                calculate.logger = _mockWrapper.Object;
            }
            //should have void return type and zero arguement
            [TestMethod]
            public void Given_valid_arguements_when_Add_invoke_Then_Valid_Result_Asserted()
            {
               
                calculate.Addition(10, 20);
                calculate.Addition(10, 20);
                calculate.Addition(10, 20);
                calculate.Addition(10, 20);

                _mockWrapper.Verify(fakeNeighbour => fakeNeighbour.write("Add method Invoked"), Moq.Times.Exactly(4));

            }
            [TestMethod]
            public void Given_valid_arguements_when_Div_invoke_Then_Valid_Result_Asserted()
            {
                //code under test
                //Inject dependeny - Fake dependency as a stub object
                calculate.Div(20, 10);
              
                _mockWrapper.Verify(fakeNeighbour => fakeNeighbour.write(""),Moq.Times.Exactly(1));

            }
            [TestMethod]
            [ExpectedException(typeof(DivideByZeroException))]
            public void Given_Denominator_Zero_when_Div_invoke_Then_Divide_By_Zero_Exception_Asserted()
            {
                calculate.Div(20, 0);

            }

        }
    }
}
