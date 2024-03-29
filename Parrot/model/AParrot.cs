using System;

namespace Parrot
{
    public abstract class AbstractParrot(int numberOfCoconuts, double voltage, bool isNailed) : IParrot
    {
        protected readonly bool isNailed = isNailed;
        protected readonly int numberOfCoconuts = numberOfCoconuts;
        protected readonly double voltage = voltage;

        public abstract double GetSpeed();

        public abstract string GetCry();

        protected static double GetBaseSpeed(double voltage) => Math.Min(24.0, voltage * BaseSpeed);

        protected static double LoadFactor => 9.0;

        protected static double BaseSpeed => 12.0;
    }
}