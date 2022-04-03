global using UAssetAPI;
global using UAssetAPI.PropertyTypes;
global using UAssetAPI.StructTypes;
global using static Globals;

namespace BlueFireRando;

internal static class Startup
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Randomiser());
    }
}