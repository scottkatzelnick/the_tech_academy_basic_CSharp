using System;

namespace MathMethods
{
    internal class Operations
    {
        public static float SelfLimit(float userInt)
        {
            float firstHalf = userInt / 2;
            float secondHalf = (userInt + firstHalf) / 2;
            float thirdHalf = (userInt + secondHalf) / 2;
            float fourthHalf = (userInt + thirdHalf) / 2;

            return fourthHalf;
        }

        public static float PowerHour(float userInt)
        {
            float power = userInt * userInt;
            return power;
        }

        public static float TimeFlies(float userInt)
        {
            float second = DateTime.Now.Second;
            float newTime = userInt + second;
            return newTime;
        }
    }
}
