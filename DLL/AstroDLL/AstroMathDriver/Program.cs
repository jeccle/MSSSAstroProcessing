using AstroMath;

AstroCalculations library = new AstroCalculations();
Console.WriteLine(library.CalcStarVelocity(500.1, 500.0));
Console.WriteLine(library.CalcStarDistance(0.547));
Console.WriteLine(library.CalcKelvin(27));
Console.WriteLine(library.CalcEventHorizon(8.2 * Math.Pow(10, 36)));

