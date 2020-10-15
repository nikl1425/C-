using training_1.CMS.UI.Models;

namespace CMS.UI.Models.obj
{
    
    // Car inherit vehicle
    public class Car : Vehicle

    {
        private int year;
        private string model;
        public string color;

        //How access private fields with getter/setter.
        //Hint: they light up when used.
        public string Model
        {
            get { return model;}
            set { model = value; }
        }
        
        //Constructor
        public Car(string model, int year, string color)
        {
            this.model = model;
            this.year = year;
            this.color = color;
        }
    }
}