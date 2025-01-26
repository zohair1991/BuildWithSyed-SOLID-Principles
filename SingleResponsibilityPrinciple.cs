namespace BuildWithSyed_Solid_Principles
{
    /* !!!!!!!!!!!!!!!!!!!!!!!!!! SINGLE RESPONSIBILITY PRINCIPLE IS Refactored HERE !!!!!!!!!!!!!!!!!!!!!!!!!! 
                 The SRP states that a class should have only one reason to change.In this case:
                 If the logic for toy creation changes, the class ToyMaker will need to change.
                 If the packing process changes, the class will ToyPacker need to change.
                 If the delivery method changes, the class will ToyDeliveryService need to change. 
      */
    public class ToyMaker
    {
        public void MakeAToy()
        {
            Console.WriteLine("Toy has been created");
        }
        public void MakeAMetalToy()
        {
            Console.WriteLine("Toy has been created");
        }
    }

    public class ToyPacker
    {
        public void PackMyToy()
        {
            Console.WriteLine("Toy has been packed");
        }
    }

    public class ToyDeliveryService
    {
        public void DeliverMyToy()
        {
            Console.WriteLine("Toy has been delivered");
        }

        public void DeliverMyToyToOffice()
        {
            Console.WriteLine("Toy has been delivered");
        }
    }
}
