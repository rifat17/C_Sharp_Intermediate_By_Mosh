using System;
namespace C_Sharp_Intermediate_By_Mosh.Classes_02.Properties
{
    public class Person
    {
        //public Person02(DateTime birthdate )
        //{
        //    Birthdate = birthdate;
        //}
        public DateTime Birthdate { get; set; }
        //public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                int years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
