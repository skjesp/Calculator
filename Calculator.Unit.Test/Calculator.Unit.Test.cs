using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//some Comment
namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        [Test]
        public void Add_Add4and2_return6() //Bemærk navngivningen
        {
            var uut = new Calculator();
            Assert.That(6,Is.EqualTo(uut.Add(4,2)));
        }

        [Test]
        public void Subtract_Sub8and3_return5()
        {
            var uut = new Calculator();
            Assert.That(5,Is.EqualTo(uut.Subtract(8,3)));
        }

        [Test]
        public void Multiply_Mul5and5_return25()
        {
            var uut = new Calculator();
            Assert.That(25,Is.EqualTo(uut.Multiply(5,5)));
        }

        [Test]
        public void Power_pow3and4_return81()
        {
            var uut = new Calculator();
            Assert.That(81,Is.EqualTo(uut.Power(3,4)));
        }
    }
}
