namespace BuildWithSyed_Solid_Principles
{
    /* !!!!!!!!!!!!!!!!!!!!!!!!!! SINGLE RESPONSIBILITY PRINCIPLE IS Refactored HERE !!!!!!!!!!!!!!!!!!!!!!!!!! 
                 The SRP states that a class should have only one reason to change.In this case:
                 If the logic for toy creation changes, the class will need to change.
                 If the packing process changes, the class will also need to change.
                 If the delivery method changes, the class will again need to change. 
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

    public class ProgramViolated
    {
        static void Main(string[] args)
        {
            //We have a separated class created, for each type of service
            ToyMaker toyMaker = new ToyMaker();
            ToyPacker toyPacker = new ToyPacker();
            ToyDeliveryService toyDelivery = new ToyDeliveryService();

            toyMaker.MakeAToy();
            toyPacker.PackMyToy();
            toyDelivery.DeliverMyToy();
        }
    }
}
