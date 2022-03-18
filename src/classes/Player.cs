using System;

public class Player
{
    public int RollDie()
    {
        Random random = new();
        int dice = random.Next(1, 18);
        return dice;
    }


    public double GenerateSpellStrength()
    {
        Random random = new();
        double dice = random.Next(0, 100);
        return dice;
    }
}
