using AstroMath;

namespace MSSSAstroServer
{
    internal class AstroServer : IAstroContract
    {
        AstroCalculations astro = new AstroCalculations();

        public double EventHorizon(double a)
        {
            return astro.EventHorizon(a);
        }

        public double TempKelvin(double a)
        {
            return astro.TempKelvin(a);
        }

        public double StarDistance(double a)
        {
            return astro.StarDistance(a);
        }

        public double StarVelocity(double a, double b)
        {
            return astro.StarVelocity(a, b);
        }
    }
}
