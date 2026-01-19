namespace Calculator.Spec;

public class SumSpecification
{
    [Fact]
    public void SumOfTwoNumbers_ShouldReturnCorrect_Sum()
    {
        // Arrange
        var a = 2;
        var b = 2;
        var expectedResult = 4;
        var calculator = new Calculator();

        // Act
        var result = calculator.Sum(a, b);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
