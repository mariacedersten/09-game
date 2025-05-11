using Raylib_cs;

namespace game;

class Program
{
    public static void Main()
    {
        Raylib.InitWindow(800, 480, "Hello World");
        Raylib.SetTargetFPS(30);
        float textY = 0.0f;


        while (Raylib.WindowShouldClose() == false)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Red);

            Raylib.DrawText("Merry Christmas!", 200, (int)textY, 50, Color.White);
            Raylib.DrawCircle(50, 50, 20, Color.White);
            Raylib.DrawCircle(50, 95, 30, Color.White);
            Raylib.DrawCircle(50, 155, 40, Color.White);

            Raylib.EndDrawing();

            textY += 60.0f * Raylib.GetFrameTime();
            if (textY > Raylib.GetScreenHeight())
            {
                textY = 0;
            }

        }

        Raylib.CloseWindow();
    }
}