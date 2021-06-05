using Xunit;
using XUnitSample;
public class ProgramTest
{
  [Theory]
  [InlineData(3)]
  [InlineData(5)]
  [InlineData(6)]
  public void MyFirstTheory(int myNumber)
  {
    Assert.True(Program.IsOdd(myNumber));
  }
  [Fact]
  public void PassingAddTest()
  {
    Assert.Equal(3, Program.Add(1, 2));
  }

  [Fact]
  public void FailingTest()
  {
    Assert.NotEqual(5, Program.Add(1, 2));
  }
}