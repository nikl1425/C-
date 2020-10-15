using System;

namespace training_1.CMS.UI.Models
{
    public class JetPlane : AbstractAirplane, IAmAPlane 
    {
        public override void MotorStart()
        {
            Console.WriteLine("motor-startet");
        }
        
        //Implementet interface methods from our interface "iAmAPlane"

        public void Wing()
        {
            Console.WriteLine("i have wings");
        }
    }
}