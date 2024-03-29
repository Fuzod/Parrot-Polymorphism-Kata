using System;

namespace Parrot
{
    public class AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed) : AbstractParrot(numberOfCoconuts, voltage, isNailed)
    {
        override public double GetSpeed() => Math.Max(0, BaseSpeed - LoadFactor * numberOfCoconuts);

        override public string GetCry() => "Sqaark!";
    }
}