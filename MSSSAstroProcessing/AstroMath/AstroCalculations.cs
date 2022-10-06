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
        /// Measures star distance using the parallax angle which is the angle that is measured from two separate points to return
        /// a parsec value that describes the distance between the stars.
        /// This method works on nearby stars that have a defined Parallax angle.
        /// </summary>
        /// <param name="a">Paralax angle</param>
        /// <returns>Distance of a start in parsecs</returns>
        public double StarDistance(double a)
        {
            return 1 / a;
        }

        /// <summary>
        /// COnverts celcius values to the main scienctific temperature measurement. Method will take celcius input and convert it to
        /// its kelvin equivalent.
        /// </summary>
        /// <param name="c">Temperature in celcius.</param>
        /// <returns>Temperature in Kelvin</returns>
        public double TempKelvin(double c)
        {
            return c + 273;
        }

        /// <summary>
        /// Describes the distance of the event horizon from the center core of the blackhole. Mass of the blackhole is specified to return
        /// a calculation describing the size of the event horizon.
        /// </summary>
        /// <param name="m">Mass of Blackhole</param>
        /// <returns>Distance of the event horizon from blackhole core.</returns>
        public double EventHorizon(double m)
        {
            double c = 2.9979458 * Math.Pow(10, 8);
            double g = 6.674 * Math.Pow(10, -11);
            double radius = (2 * g * m) / Math.Pow(c, 2);
            return radius * Math.Pow(10, -10);
        }
    }
}