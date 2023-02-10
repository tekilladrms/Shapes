using System;

namespace Shapes.Net7.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_ShouldThrowException_WhenNumberOfParametersLessThanOne()
        {
            Assert.Throws<ArgumentException>(() => Circle.GetArea());
        }

        [Fact]
        public void GetArea_ShouldThrowException_WhenNumberOfParametersMoreThanOne()
        {
            Assert.Throws<ArgumentException>(() => Circle.GetArea(1, 2));
        }


        [Fact]
        public void GetArea_ShouldReturnResult_WhenParameterIsCorrect()
        {
            var result = Circle.GetArea(2);
            Assert.Equal(12.57, result);
        }
    }
}
