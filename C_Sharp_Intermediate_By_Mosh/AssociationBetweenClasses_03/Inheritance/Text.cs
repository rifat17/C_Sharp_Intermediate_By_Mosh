using System;

namespace C_Sharp_Intermediate_By_Mosh.AssociationBetweenClasses_03.Inheritance
{
    public class Text : Presentationobject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
