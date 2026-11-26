// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        Texture2D stage = Graphics.LoadTexture("../../../../assets/graphics/stage.png");
        Slime slime = new Slime();
        public void Setup()
        {
            Window.SetTitle("Link the Slime Killer");
            Window.SetSize(1600, 900);

            slime.Setup();

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Draw background stage
            Window.ClearBackground(200);
            Graphics.Scale = 0.5f;
            Graphics.Draw(stage, 0, 0);

            Graphics.Scale = 2;
            slime.Update();
            
        }
    }

}
