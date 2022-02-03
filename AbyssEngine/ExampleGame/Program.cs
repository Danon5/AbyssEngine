using System;
using AbyssEngine.Backend;
using AbyssEngine.GameContent;

namespace AbyssEngine
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
