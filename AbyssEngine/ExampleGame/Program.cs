using System;
using AbyssEngine.Backend;

namespace AbyssEngine.ExampleGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using Engine game = new Engine(new ExampleGameEntryPoint());
            game.Run();
        }
    }
}
