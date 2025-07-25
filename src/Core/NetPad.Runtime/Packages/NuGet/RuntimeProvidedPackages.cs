namespace NetPad.Packages.NuGet;

/// <summary>
/// Contains a pre-determined list of NuGet packages that are provided by the run-time, and
/// therefore should not be restored from an extensions dependency list.
/// </summary>
internal static class RuntimeProvidedPackages
{
    /// <summary>
    /// Checks whether the set of known runtime packages contains the given package ID.
    /// </summary>
    /// <param name="packageId">The package ID.</param>
    /// <returns>True if the package is provided by the framework, otherwise false.</returns>
    public static bool IsPackageProvidedByRuntime(string packageId)
    {
        return _providedPackages.Contains(packageId);
    }

    /// <summary>
    /// This list comes from the package overrides for the .NET SDK,
    /// at https://github.com/dotnet/sdk/blob/v3.1.201/src/Tasks/Common/targets/Microsoft.NET.DefaultPackageConflictOverrides.targets.
    /// If the executing binaries ever change to a newer version, this project must update as well, and refresh this list.
    /// </summary>
    private static readonly ISet<string> _providedPackages = new HashSet<string>
    {
        "Microsoft.CSharp",
        "Microsoft.Win32.Primitives",
        "Microsoft.Win32.Registry",
        "runtime.debian.8-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.fedora.23-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.fedora.24-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.opensuse.13.2-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.opensuse.42.1-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.osx.10.10-x64.runtime.native.System.Security.Cryptography.Apple",
        "runtime.osx.10.10-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.rhel.7-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.ubuntu.14.04-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.ubuntu.16.04-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "runtime.ubuntu.16.10-x64.runtime.native.System.Security.Cryptography.OpenSsl",
        "System.AppContext",
        "System.Buffers",
        "System.Collections",
        "System.Collections.Concurrent",
        "System.Collections.Immutable",
        "System.Collections.NonGeneric",
        "System.Collections.Specialized",
        "System.ComponentModel",
        "System.ComponentModel.EventBasedAsync",
        "System.ComponentModel.Primitives",
        "System.ComponentModel.TypeConverter",
        "System.Console",
        "System.Data.Common",
        "System.Diagnostics.Contracts",
        "System.Diagnostics.Debug",
        "System.Diagnostics.DiagnosticSource",
        "System.Diagnostics.FileVersionInfo",
        "System.Diagnostics.Process",
        "System.Diagnostics.StackTrace",
        "System.Diagnostics.TextWriterTraceListener",
        "System.Diagnostics.Tools",
        "System.Diagnostics.TraceSource",
        "System.Diagnostics.Tracing",
        "System.Dynamic.Runtime",
        "System.Globalization",
        "System.Globalization.Calendars",
        "System.Globalization.Extensions",
        "System.IO",
        "System.IO.Compression",
        "System.IO.Compression.ZipFile",
        "System.IO.FileSystem",
        "System.IO.FileSystem.AccessControl",
        "System.IO.FileSystem.DriveInfo",
        "System.IO.FileSystem.Primitives",
        "System.IO.FileSystem.Watcher",
        "System.IO.IsolatedStorage",
        "System.IO.MemoryMappedFiles",
        "System.IO.Pipes",
        "System.IO.UnmanagedMemoryStream",
        "System.Linq",
        "System.Linq.Expressions",
        "System.Linq.Queryable",
        "System.Net.Http",
        "System.Net.NameResolution",
        "System.Net.Primitives",
        "System.Net.Requests",
        "System.Net.Security",
        "System.Net.Sockets",
        "System.Net.WebHeaderCollection",
        "System.ObjectModel",
        "System.Private.DataContractSerialization",
        "System.Reflection",
        "System.Reflection.Emit",
        "System.Reflection.Emit.ILGeneration",
        "System.Reflection.Emit.Lightweight",
        "System.Reflection.Extensions",
        "System.Reflection.Metadata",
        "System.Reflection.Primitives",
        "System.Reflection.TypeExtensions",
        "System.Resources.ResourceManager",
        "System.Runtime",
        "System.Runtime.Extensions",
        "System.Runtime.Handles",
        "System.Runtime.InteropServices",
        "System.Runtime.InteropServices.RuntimeInformation",
        "System.Runtime.Loader",
        "System.Runtime.Numerics",
        "System.Runtime.Serialization.Formatters",
        "System.Runtime.Serialization.Json",
        "System.Runtime.Serialization.Primitives",
        "System.Security.AccessControl",
        "System.Security.Claims",
        "System.Security.Cryptography.Algorithms",
        "System.Security.Cryptography.Cng",
        "System.Security.Cryptography.Csp",
        "System.Security.Cryptography.Encoding",
        "System.Security.Cryptography.OpenSsl",
        "System.Security.Cryptography.Primitives",
        "System.Security.Cryptography.X509Certificates",
        "System.Security.Cryptography.Xml",
        "System.Security.Principal",
        "System.Security.Principal.Windows",
        "System.Text.Encoding",
        "System.Text.Encoding.Extensions",
        "System.Text.RegularExpressions",
        "System.Threading",
        "System.Threading.Overlapped",
        "System.Threading.Tasks",
        "System.Threading.Tasks.Extensions",
        "System.Threading.Tasks.Parallel",
        "System.Threading.Thread",
        "System.Threading.ThreadPool",
        "System.Threading.Timer",
        "System.ValueTuple",
        "System.Xml.ReaderWriter",
        "System.Xml.XDocument",
        "System.Xml.XmlDocument",
        "System.Xml.XmlSerializer",
        "System.Xml.XPath",
        "System.Xml.XPath.XDocument"
    };
}
