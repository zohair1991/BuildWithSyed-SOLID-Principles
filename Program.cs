using BuildWithSyed_OCP;
using BuildWithSyed_SRP;
using static BuildWithSyed_OCP.ToyPaintingFactory;

namespace BuildWithSyed_Solid_Principles
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Single Responsibility Principle
            /*  SINGLE RESPONSIBILITY PRINCIPLE */
            //ToyMaker toyMaker = new ToyMaker();
            //ToyPacker toyPacker = new ToyPacker();
            //ToyDeliveryService toyDelivery = new ToyDeliveryService();

            //toyMaker.MakeAToy();
            //toyPacker.PackMyToy();
            //toyDelivery.DeliverMyToy();

            /*  SINGLE RESPONSIBILITY PRINCIPLE */
            #endregion

            #region Open Closed Principle

            /*  OPEN CLOSED PRINCIPLE */
            PaintMyToy blackPainter = new BlackToyPainter();
            blackPainter.PaintToy("Car");

            PaintMyToy redPainter = new RedToyPainter();
            redPainter.PaintToy("Bus");
            /*  OPEN CLOSED PRINCIPLE */

            #endregion
        }
    }
}
