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

        Texture2D linkWalk = Graphics.LoadTexture("../../../../assets/graphics/link.png");


        public void Setup()
        {
            Window.SetTitle("Link the Slime Killer");
            Window.SetSize(1200, 800);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Draw basic background and level
            Window.ClearBackground(135, 205, 235);
            Draw.SetLineSize(0);
            Draw.SetFillColor(125);
            Draw.Rectangle(0, 500, 1200, 300);

            Graphics.Draw(linkWalk, 0, 0);
        }
    }

}
