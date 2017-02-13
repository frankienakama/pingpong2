using Xunit;
using System.Collections.Generic;

namespace PingPongApp
{
  public class PingPongTest
  {

// Not Fives or Threes or Fifteens
    [Fact]
    public void Rules_MultiplesOfTen_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.Rules(15));
    }
    // Anti-test not Fives or Threes
    [Fact]
    public void Rules_MultiplesOfFour_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(false, testPingPong.Rules(4));
    }
// Threes
    [Fact]
    public void Rules_NumberThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.Rules(3));
    }
    // Anti-test Threes
    [Fact]
    public void Rules_NumberFour_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(false, testPingPong.Rules(7));
    }

// Fives
    [Fact]
    public void Rules_MultiplesOfFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.Rules(15));
    }
    //Anti-test Fives
    [Fact]
    public void Rules_MultiplesOfFive_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(false, testPingPong.Rules(11));
    }
//Fifteens
    [Fact]
    public void Rules_MultiplesOfFifteen_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(true, testPingPong.Rules(30));
    }
    //Anti-test Fifteens
    [Fact]
    public void Rules_MultiplesOfFifteen_False()
    {
      PingPong testPingPong = new PingPong();
      Assert.Equal(false, testPingPong.Rules(32));
    }

//Counting function
// threes
    [Fact]
    public void CountList_ListofThrees_ReturnsNewList()
    {
      PingPong testPingPong = new PingPong();
      //Arrange
      List<string> newList = testPingPong.CountList(3);

      //Act
      List<string> testList = new List<string>{ "1", "2", "ping" };

      //Assert
      Assert.Equal(newList,testList);
    }
    // Fives
    [Fact]
    public void CountList_ListofFives_ReturnsNewList()
    {
      PingPong testPingPong = new PingPong();
      //Arrange
      List<string> newList = testPingPong.CountList(5);

      //Act
      List<string> testList = new List<string>{ "1", "2", "ping", "4", "pong" };

      //Assert
      Assert.Equal(newList,testList);
    }
    // Fifteens
    [Fact]
    public void CountList_ListofFifteens_ReturnsNewList()
    {
      PingPong testPingPong = new PingPong();
      //Arrange
      List<string> newList = testPingPong.CountList(15);

      //Act
      List<string> testList = new List<string>{ "1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping pong" };

      //Assert
      Assert.Equal(newList,testList);
    }
  }
}
