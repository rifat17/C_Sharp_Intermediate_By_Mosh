using System;
namespace C_Sharp_Intermediate_By_Mosh.TestAbility
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; internal set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; internal set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }


    }
}
