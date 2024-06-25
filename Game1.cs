using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using FontStashSharp;
namespace MinecraftSteveTeaches;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private FontSystem _fontSystem;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        _graphics.IsFullScreen = true;
        _graphics.PreferredBackBufferWidth = 1920;  // Width of the window
        _graphics.PreferredBackBufferHeight = 1080; // Height of the window

        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
        Window.Title = "Minecraft: Steve Teaches";
        _graphics.ApplyChanges();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        _fontSystem = new FontSystem();
        _fontSystem.AddFont(TitleContainer.OpenStream($"{Content.RootDirectory}/Fonts/Minecraft.ttf"));
    }

    protected override void Update(GameTime gameTime)
    {

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
