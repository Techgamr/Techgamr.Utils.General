using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Techgamr.Utils.General
{
    public class ReflectionUtil
    {
        public static AssemblyMode GetAssemblyMode(Assembly assembly) =>
            assembly.GetCustomAttributes(false).OfType<DebuggableAttribute>().Any(da => da.IsJITTrackingEnabled)
                ? AssemblyMode.Debug
                : AssemblyMode.Release;

        public static string? GetAssemblyVersion(Assembly assembly) => assembly.GetName().Version?.ToString();
        
        public static FileVersionInfo GetAssemblyFileVersionInfo(Assembly assembly) => FileVersionInfo.GetVersionInfo(assembly.Location);

        public static AssemblyMode EngineAssemblyMode { get; set; }
    }
}
