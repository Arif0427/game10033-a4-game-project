using System;
using System.Numerics;

namespace MohawkGame2D;

public class Link
{
    Texture2D spritesheet = Graphics.LoadTexture("../../../../assets/graphics/link.png");
    Vector2 position;
    int currentFrame;
    int baseFrame;
    int frameCount;
    int facingDirection;

    public void Update()
    {
        int sprite = 0;

        //Graphics.DrawSubset(spritesheet, 600, 447, 255, 127, 45, 53);
        
    }

}
