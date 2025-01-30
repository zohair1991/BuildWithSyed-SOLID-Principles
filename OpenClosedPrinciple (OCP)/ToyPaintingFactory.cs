using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildWithSyed_OCP
{
    /*  
        ✅ Closed for Modification – We don't need to change ToyPainter when adding new colors.
        ✅ Open for Extension – We can add new colors by just creating a new class (e.g., YellowColor).
        This approach follows OCP because we can extend the painting system without modifying existing code. 🚀
    */

    public class ToyPaintingFactory
    {
        public ToyPaintingFactory() { }

        public abstract class PaintMyToy()
        {
            public abstract void PaintToy(string toy);
        }

        public class BlackToyPainter : PaintMyToy
        {
            public override void PaintToy(string toy)
            {
                Console.WriteLine($"{toy} has been painted Black.");
            }
        }

        public class RedToyPainter : PaintMyToy
        {
            public override void PaintToy(string toy)
            {
                Console.WriteLine($"{toy} has been painted Red.");
            }
        }
    }
}
