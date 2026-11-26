using System;
using System.Numerics;

namespace MohawkGame2D;

public class Slime
{
    Texture2D sprite = Graphics.LoadTexture("../../../../assets/graphics/slime.png");

    public void Update()
    {
        Graphics.Draw(sprite, 600, 500);
    }

}
