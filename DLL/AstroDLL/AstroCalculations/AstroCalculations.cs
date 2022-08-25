namespace AstroMath
{
    public class AstroCalculations
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Observed Wavelength</param>
        /// <param name="b">Rest Wavelength</param>
        /// <returns>Velocity in </returns>
        public double CalcStarVelocity(double a, double b)
        {
            double c = 2.9979458 * Math.Pow(10, 8);
            return c * (a - b) / b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Paralax angle</param>
        /// <returns>Distance of a start in parsecs</returns>
        public double CalcStarDistance(double a)
        {
            return 1 / a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public double CalcKelvin(double c)
        {
            return c + 273;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public double CalcEventHorizon(double m)
        {
            double c = 2.9979458 * Math.Pow(10, 8);
            double g = 6.674 * Math.Pow(10, -11);
            double radius = (2 * g * m) / Math.Pow(c, 2);
            return radius * Math.Pow(10, -10);
        }
    }
}