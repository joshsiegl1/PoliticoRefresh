using PoliticoRefresh.Editor.Core; 
internal class Program
{
    /// <summary>
    /// The main entry point for the application. 
    /// This creates an instance of your game and calls its run() method
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        using var game = new PoliticoRefreshGame();
        game.Run(); 
    }
}