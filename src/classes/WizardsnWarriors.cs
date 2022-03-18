using System;
public abstract class Character
{
    public bool isPrepared;
    public string characterType;
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }
    public abstract int DamagePoints(Character target);
    public virtual bool Vulnerable()
    {
        if (isPrepared == false && characterType == "Wizard")
            return true;
        else
            return false;
    }
    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}
class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }
    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;
        else
            return 6;
    }
}
class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
    }
    public override int DamagePoints(Character target)
    {
        if (isPrepared == true)
            return 12;
        else
            return 3;
    }
    public void PrepareSpell()
    {
        isPrepared = true;
    }
}
