using Microsoft.Xna.Framework.Content;

namespace jogo;

public static class Globals
{
    public static float Time { get; set; }
    public static ContentManager Content { get; set; }
    public static SpriteBatch SpriteBatch { get; set; }
    public static Point WindowSize { get; set; }
    public static GraphicsDeviceManager Graphics { get; set; }
    public static SpriteFont Font { get; set; }

    public static void Update(GameTime gt)
    {
        Time = (float)gt.ElapsedGameTime.TotalSeconds;
    }
}