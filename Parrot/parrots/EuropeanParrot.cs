namespace Parrot
{
    public class EuropeanParrot(int numberOfCoconuts, double voltage, bool isNailed) : AbstractParrot(numberOfCoconuts, voltage, isNailed)
    {
        override public double GetSpeed() => BaseSpeed;

        override public string GetCry() => "Sqoork!";
    }
}