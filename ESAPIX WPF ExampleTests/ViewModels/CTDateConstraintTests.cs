using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void ConstraintCTDateTest()
        {

            //arrange
            //var ctDate = DateTime.Now.AddDays(-59);
            var ctDate = DateTime.Now.AddDays(-61);

            // act
            var constraint = new CTDateConstraint();
            var actual = constraint.ConstraintCTDate(ctDate).ResultType;

            //assert
            //var expected = ResultType.PASSED;
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }
    }
}