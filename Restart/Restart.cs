/*
 * Created by SharpDevelop.
 * User: Petko
 * Date: 05.06.2017
 * Time: 17:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

// The following code will execute the shutdown command from the shell:

using System.Diagnostics;

static class Shutdown
{
    /// <summary>
    /// Windows restart
    /// </summary>
    public static void Restart()
    {
        StartShutDown("-f -r -t 5", " -c \"Computer will Restart in 5 seconds. !!!\"");
    }

    /// <summary>
    /// Log off.
    /// </summary>
    public static void LogOff()
    {
        StartShutDown("-l");
    }

    /// <summary>
    ///  Shutting Down Windows 
    /// </summary>
    public static void Shut()
    {
        StartShutDown("-f -s -t 5", " -c \"Computer will shut down in 5 seconds. !!!\"");
    }

    private static void StartShutDown(string param,string text = "")
    {
        var proc = new ProcessStartInfo();
        proc.FileName = "cmd";
        proc.WindowStyle = ProcessWindowStyle.Hidden;
        proc.Arguments = "/C shutdown " + param + text;
        Process.Start(proc);
    }
}