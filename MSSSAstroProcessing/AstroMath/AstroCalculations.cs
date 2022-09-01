using System;

namespace AstroMath
{
    public class AstroCalculations
    {

        /// <summary>
        /// Measures star velocity using the doppler shift by utilizing changes in objects wavelength.
        /// Takes two input parameters of type double where a is the observed wavelength and b 
        /// is the rest wavelength. A double is returned representing the star velocity. 
        /// </summary>
        /// <param name="a">Observed Wavelength</param>
        /// <param name="b">Rest Wavelength</param>
        /// <returns>Velocity in </returns>
        public double StarVelocity(double a, double b)
        {
            double c = 2.9979458 * Math.Pow(10, 8);
            return c * (a - b) / b;
        }

        /// <summary>
        /// Measures distance of a star using the parallax angle which is the angle measured at two different points
        /// </summary>
        /// <param name="a">Paralax angle</param>
        /// <returns>Distance of a start in parsecs</returns>
        public double StarDistance(double a)
        {
            return 1 / a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public double TempKelvin(double c)
        {
            return c + 273;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public double EventHorizon(double m)
        {
            double c = 2.9979458 * Math.Pow(10, 8);
            double g = 6.674 * Math.Pow(10, -11);
            double radius = (2 * g * m) / Math.Pow(c, 2);
            return radius * Math.Pow(10, -10);
        }
    }
}