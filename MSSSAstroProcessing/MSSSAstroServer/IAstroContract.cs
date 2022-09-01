using System.ServiceModel;

namespace MSSSAstroServer
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double a, double b);

        [OperationContract]
        double StarDistance(double a);

        [OperationContract]
        double TempKelvin(double a);

        [OperationContract]
        double EventHorizon(double a);

    }
}
