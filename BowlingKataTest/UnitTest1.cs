using BowlingKata;

namespace BowlingKataTest;

public class BowlingTests
{
    [Fact]
    public void TestOneRoll()
    {
        var game = new Game();
        game.roll(5);
        Assert.Equal(5, game.score());
    }

    [Fact]
    public void TestAFewRolls()
    {
        var game = new Game();
        game.roll(6);
        game.roll(3);
        game.roll(4);
        game.roll(4);
        Assert.Equal(17, game.score());
    }

    [Fact]
    public void TestSpare()
    {
        var game = new Game();
        int[] roller = new int[21];   
        roller = new[] {6,2,4,6,5,4};
        game.roll(roller);
        Assert.Equal(32, game.score());
    }
    
    [Fact]
    public void TestStrike()
    {
        var game = new Game();
        int[] roller = new int[21];   
        roller = new[] {4,5,10,5,4,10,0,4};
        game.roll(roller);
        Assert.Equal(55, game.score());
    }
    
    [Fact]
    public void FullGame()
    {
        var game = new Game();
        int[] roller = new int[21];   
        roller = new[] {10,0,10,10,0,10,10,6,4,0,6,4,6,10,5,5,10};
        game.roll(roller);
        Assert.Equal(176, game.score());
    }
}