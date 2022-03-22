using System;

class WeighingMachine
{
    public int Precision { get; }
    public double Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            else
                _weight = value;
        }
    }
    public double _weight { get; set; }

    public double TareAdjustment { get; set; } = 5;

    public string DisplayWeight
    {
        get
        {
            return (Weight - TareAdjustment).ToString($"N{Precision}") + " kg";
        }
        set
        {

        }
    }
    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

}
