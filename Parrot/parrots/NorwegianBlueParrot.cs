using System;
using System.Collections.Generic;

namespace Parrot
{
    public class NorwegianBlueParrot(int numberOfCoconuts, double voltage, bool isNailed) : AbstractParrot(numberOfCoconuts, voltage, isNailed)
    {
        override public double GetSpeed() => isNailed ? 0 : GetBaseSpeed(voltage);

        override public string GetCry() => voltage > 0 ? "Bzzzzzz" : "...";
    }
}