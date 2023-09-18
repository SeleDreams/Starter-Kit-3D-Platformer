using Stride.Engine;

namespace Starter_Kit_3D_Platformer
{
    class Starter_Kit_3D_PlatformerApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
