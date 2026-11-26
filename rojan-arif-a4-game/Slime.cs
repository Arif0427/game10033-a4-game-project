using System;
using System.Numerics;

namespace MohawkGame2D;

public class Slime
{
    Texture2D sprite = Graphics.LoadTexture("../../../../assets/graphics/slime.png");
    Vector2 position;
    Vector2 velocity;

    public void Setup()
    {
        position = Random.Vector2(1200, 500);
        


    }

    public void Update()
    {
        // GRAVITY
        // This defines the direction to "pull" objects in
        Vector2 gravity = new Vector2(0, 9.81f);
        // Each frame, add proportion of gravity to velocity of eye
        velocity += gravity * Time.DeltaTime;
        // Add velocity to position each frame
        position += velocity;

        // CONSTRAIN TO SCREEN
        bool isCollidingTop = (position.Y) < 0;
        bool isCollidingBottom = (position.Y) > 500;
        bool isCollidingLeft = (position.X) < 0;
        bool isCollidingRight = (position.X) > Window.Width;

        // VERTICAL
        // BOTTOM
        if (isCollidingBottom == true)
        {
            // Reposition to be touching bottom edge
            position.Y = 500;
            // Invert velocity on Y axis
            velocity.Y = -velocity.Y;
        }
        // TOP
        if (isCollidingTop == true)
        {
            position.Y = 0;
            velocity.Y = -velocity.Y;
        }

        // HORIZONTAL
        // LEFT
        if (isCollidingLeft == true)
        {
            position.X = 0;
            velocity.X = -velocity.X;
        }
        // RIGHT
        if (isCollidingRight == true)
        {
            position.X = Window.Width;
            velocity.X = -velocity.X;
        }

        Graphics.Draw(sprite, position);

    }

}
