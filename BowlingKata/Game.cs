using System.Diagnostics;

namespace BowlingKata;

public class Game
{
    private int turn = 0;
    private List<int> pinList = new();
    public Game()
    {
        fullList();
    }
    private void fullList()
    {
        for (int i = 0; i <=21; i++)
        {
            pinList.Add(0);
        }
    }

    private bool isSpare(int pin1, int pin2)
    {
        if ((pin1 + pin2) == 10)
        {
            return true;
        }

        return false;
    }

    private bool isStrike(int pin1)
    {
        if (pin1 == 10) 
        {
            return true;
        }

        return false;
    }

    public int score()
    {
        int indexPin = 0;
        int gameScore = 0;
        for (int index = 0; index < 10; index++)
        {
           
            if (isStrike(pinList[indexPin]))
            {
                gameScore += pinList[indexPin];
                gameScore += pinList[indexPin+1] + pinList[indexPin+2];
                indexPin++;
            }
            else if (isSpare(pinList[indexPin], pinList[indexPin + 1]))
            {
                gameScore += pinList[indexPin] + pinList[indexPin + 1];
                gameScore += pinList[indexPin+2];
                indexPin+=2;
            }
            else
            {
                gameScore += pinList[indexPin];
                gameScore += pinList[indexPin+1];
                indexPin += 2;
            }
        }
        return gameScore;
    }

    public void roll(int pins)
    {
        pinList[turn] = pins;
        turn++;
    }


    public void roll(int[] pins)
    {
        foreach (var pin in pins)
        {
            roll(pin);
        }
    }
}