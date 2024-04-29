using BowlingKata;

namespace BowlingKataTest;

public class BowlingTests
{
    [Fact]
    public void TestOneRoll()
    {
        var game = new Game();
        game.roll(0);
        Assert.Equal(0, game.score());
    }

    [Fact]
    public void Test2()
    {
        var game = new Game();
        game.roll(7);
        game.roll(3);
        game.roll(4);
        game.roll(4);
        Assert.Equal(22, game.score());
    }

    [Fact]
    public void Test3()
    {
        var game = new Game();
        int[] dupa = new int[5];
        dupa = new[] { 1, 2, 3, 4, 5 };

        game.roll(dupa);
        Assert.Equal(15, game.score());
    }

    [Fact]
    public void AllSpares()
    {
        var game = new Game();
        int[] dupa = new int[21];   
        dupa = new[] {2,8,2,8,2,8,2,8};
        game.roll(dupa);
        Assert.Equal(120, game.score());
    }
    
    [Fact]
    public void AllSparesHalf()
    {
        var game = new Game();
        int[] dupa = new int[21];   
        dupa = new[] {6,0,7,2,10,0,5};
        game.roll(dupa);
        Assert.Equal(14, game.score());
    }
    
    [Fact]
    public void AllSparesHallf()
    {
        var game = new Game();
        int[] dupa = new int[21];   
        dupa = new[] {0,10,0,10,10,0,0,10,6,4,10,0,6,4,0};
        game.roll(dupa);
        Assert.Equal(14, game.score());
    }
    
    [Fact]
    public void SomeStrikes()
    {
        var game = new Game();
        int[] dupa = new int[21];   
        dupa = new[] {10,10,10,10,10,10,10,10,10,10,10,10};
        game.roll(dupa);
        Assert.Equal(52, game.score());
    }
    
    [Fact]
    public void AllStrikes()
    {
        var game = new Game();
        int[] dupa = new int[21];   
        dupa = new[] {2,3,10,10,10,2,3,2,3,0,10,10,0,0,0,0};
        game.roll(dupa);
        Assert.Equal(300, game.score());
    }
    
    [Fact]
    public void AllStrikesFull()
    {
        var game = new Game();
        int[] dupa = new int[21];   
        dupa = new[] {10,0,2,1,5,10,3,7,0,10,0,10,0,9,9,1,10,0,9};
        game.roll(dupa);
        Assert.Equal(300, game.score());
    }
    
}