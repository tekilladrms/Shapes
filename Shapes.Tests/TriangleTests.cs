using System;

namespace Shapes.Tests;

public class TriangleTests
{
    [Fact]
    public void GetArea_ShouldThrowException_WhenParametersAreIncorrect()
    {
        Assert.Throws<ArgumentException>(() => Triangle.GetArea(1.0, 1.0, 3.0));
    }

    [Fact]
    public void GetArea_ShouldThrowException_WhenNumberOfParametersLessThanThree()
    {
        Assert.Throws<ArgumentException>(() => Triangle.GetArea(1.0, 3.0));
       
    }

    [Fact]
    public void GetArea_ShouldThrowException_WhenNumberOfParametersMoreThanThree()
    {
        Assert.Throws<ArgumentException>(() => Triangle.GetArea(1.0, 1.0, 3.0, 0));
    }

    [Fact]
    public void IsValid_ShouldReturnFalse_WhenRuleOfCreationTriangleIsNotWorking()
    {
        Assert.False(Triangle.IsValid(1.0, 1.0, 3.0));
    }

    [Fact]
    public void IsValid_ShouldReturnTrue_WhenRuleOfCreationTriangleIsWorking()
    {
        Assert.True(Triangle.IsValid(3.0, 3.0, 5.0));
    }

    [Fact]
    public void GetArea_ShouldReturnResult_WhenAllParametersAreCorrect()
    {
        var result = Triangle.GetArea(3.0, 3.0, 5.0);
        Assert.Equal(4.15, result);
    }
}