using System;
namespace C_Sharp_Intermediate_By_Mosh.AssociationBetweenClasses_03.Inheritance
{
    public class Presentationobject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to the clipboard.");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}
