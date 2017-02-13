using Xunit;
namespace PingPongApp
{
  public class PingPongTest
  {
    [Fact]
    public void DivisibleByThree_MultiplesOfThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.DivisibleByThree(6));
    }
  }
}
