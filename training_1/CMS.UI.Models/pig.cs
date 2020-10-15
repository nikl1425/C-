using System;

namespace training_1.CMS.UI.Models
{
    public class pig : Animal
    {
        public void pigSound()
        {
            Console.WriteLine("Pig Sound");
        }
        
        //We can also overwrite the sound

        public override void animalSound()
        {
            Console.WriteLine("WEE WEE");
        }
    }
}