﻿namespace DependencyInversionPrincipleIncorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy = new Toy();
            ZincCarbonBattery zincCarbonBattery = new ZincCarbonBattery();
            toy.UseBattery(zincCarbonBattery);

            AlcalineBattery alcalineBattery = new AlcalineBattery();
            //toy.UseBattery(alcalineBattery);

            /*  Want to use alcaline battery?
             *  We get compiler error. Toy class is tightly coupled to ZincCarbonBattery class
             *  We have to make some arrangement in Toy class.
             *  Maybe we might want to add second UseBattery overload method. 
             *  But we have to touch Toy class. This is undesirable.
             */
        }
    }
}
