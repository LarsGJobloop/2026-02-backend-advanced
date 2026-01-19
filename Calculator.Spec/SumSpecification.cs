namespace Calculator.Spec;

public class SumSpecification
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(10, 10, 20)]
    [InlineData(0, 0, 0)]
    [InlineData(-10, 10, 0)]
    [InlineData(100, 100, 200)]
    public void SumOfTwoNumbers_ShouldReturnCorrect_Sum(int a, int b, int expectedResult)
    {
        // Arrange
        var calculator = new Utilities.Calculator();

        // Act
        var result = calculator.Sum(a, b);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
