
using System.Xml.Linq;

namespace Homework06.App
{
    class Car
    {
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }


        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }



        public int CalculateSpeed()
        {
            if (Driver == null)
            {
                return 0;
            }
            else
            {
                return Speed * Driver.Skill;
            }
        }
    }
    

}

