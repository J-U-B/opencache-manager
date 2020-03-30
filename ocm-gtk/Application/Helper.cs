using System;
using System.IO;
using System.Diagnostics;

namespace ocmgtk
{
    static class Helper {
        /*
        <summary>
        Launch a URL. For YEARS this was done by Process.Start in a
        cross-platform way, but Microsoft chose to break that,
        so now every .NET app has to write its own custom code for it,
        with special code for each platform.
        https://github.com/dotnet/corefx/issues/10361
        
        Inspired by: https://github.com/KSP-CKAN/CKAN/pull/2958
        </summary>

        <param name="url">URL to launch</param>
        <returns>
            true if launched, false otherwise
        </returns>
        */
        public static bool ProcessStartURL(string url)
        { 
            OperatingSystem os = Environment.OSVersion;
            PlatformID     pid = os.Platform;
            try {
                switch (pid)
                {
                    case PlatformID.Unix:
                        Process.Start("xdg-open", $"\"{url}\"");
                        break;
                    case PlatformID.MacOSX:
                        Process.Start("open", $"\"{url}\"");
                        break;
                    default:
                        // Windows: Try the old way
                        Process.Start(new ProcessStartInfo(url)
                        {
                            UseShellExecute = true, Verb = "open"
                        });
                        break;
                }
                return true;
            }
            catch (Exception exc)
            {
                System.Console.WriteLine($"Exception for URL {url}", exc);
            }
            return false;
        }
    }
}
