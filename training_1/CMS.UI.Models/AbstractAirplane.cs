using System;

namespace training_1.CMS.UI.Models
{
    public abstract class AbstractAirplane
    {
        public abstract void MotorStart();

        public void StopMotor()
        {
            Console.WriteLine("Motor-Stop");
        }

    }
}