using System;

namespace TaskCar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car carAuto1 = new Car();
            carAuto1.AskData();
            Car carAuto2 = new Car();
            carAuto2.AskData();
            carAuto1.Accelerate(40);
            carAuto2.Accelerate(40);
            carAuto1.Brake(90);
            carAuto2.Brake(90);

            carAuto1.ShowCarInfo();
            carAuto2.ShowCarInfo();

        }
    }
}
