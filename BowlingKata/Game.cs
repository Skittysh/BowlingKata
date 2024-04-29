namespace BowlingKata;

public class Game
{
    private int gameScore = 0;
    private int turn = 0;
    private List<int> pinList = new List<int>();

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
        int tempTurn = 0;
        int halfTurn = 0;
        int round = 0;
        int strikeAmount = 0;

        foreach (var pin in pinList)
        {
            if (tempTurn != 10 && tempTurn != 11)
            {
                gameScore += pin;
            }

            if (tempTurn != 10 && tempTurn != 11 && tempTurn != 12)
            {
                if (isStrike(pin) && halfTurn != 1)
                {
                    halfTurn++;
                    strikeAmount += 2;
                }

                
                if (round != 1 && round != 0 && strikeAmount == 0 && !isStrike(pinList[round-2])&&  isSpare(pinList[round - 1], pinList[round - 2]))
                {
                    gameScore += pin;
                }

                if (round != 0 && strikeAmount > 0 && isStrike(pinList[round - 1]))
                {
                    gameScore += pin;
                    strikeAmount--;
                }

                if (round != 1 && round != 0 && strikeAmount > 0 && isStrike(pinList[round - 2]))
                {
                    gameScore += pin;
                    strikeAmount--;
                }

                
            }

            if (tempTurn == 10 || tempTurn == 11 || tempTurn == 12)
            {
                gameScore += pin;
                
            }

            halfTurn++;
            round++;
            if (halfTurn == 2)
            {
                halfTurn = 0;
                tempTurn++;
            }
        }


        pinList.Clear();
        return gameScore;
    }


    public void roll(int pins)
    {
        pinList.Add(pins);
    }


    public void roll(int[] pins)
    {
        foreach (var pin in pins)
        {
            roll(pin);
        }
    }
}