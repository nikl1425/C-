using System.Dynamic;

namespace CMS.UI.Models
{
    public class course
    {
        //FIELDS
        public string courseName;
        public int courseECTS; 
        public string RandomString;
        
        //Constructor. Way faster to add values to course in program.cs
        public course(string courseName, int courseEcts)
        {
            this.courseName = courseName;
            this.courseECTS = courseEcts;
        }
// how to make a property variable
        public string getRandomString
        {
            set { RandomString = value; }
            get { return RandomString;}
        }
// faster way to express the code above:
        public string getRandomStringTwo
        {
            get;
            set;
        
        }
    }
}