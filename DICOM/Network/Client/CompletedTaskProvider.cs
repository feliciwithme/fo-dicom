using System.Threading.Tasks;

namespace Dicom.Network.Client
{
    // Remove this class when Fellow Oak DICOM is completely upgraded to .NET Standard 2.0 or higher
    internal static class CompletedTaskProvider
    {
#if NETSTANDARD
        public static readonly Task CompletedTask = Task.CompletedTask;
#else
        public static readonly Task CompletedTask = Task.FromResult(false);
#endif
    }
}
