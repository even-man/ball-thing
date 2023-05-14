public class Canvas
{   
    public int Width { get; set; }
    public int Height { get; set; }
    public Ball ball {get; set; }

    public Canvas(int Width, int Height)
    {
        this.Width = Width;
        this.Height = Height;
        ball = new Ball(Width, Height);
    }

    public void DrawCanvas()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.Green;

        ball.RenderBall();

        // write top of canvas
        for (int i = 0; i < Width; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write("-");
        }
        
        // write left of canvas
        for (int i = 0; i < Height; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("*");
        }

        // write bottom of canvas
        for (int i = 1; i < Width; i++)
        {
            Console.SetCursorPosition(i, Height - 1);
            Console.Write("-");
        }

        // write right of canvas
        for (int i = 0; i < Height; i++)
        {
            Console.SetCursorPosition(Width, i);
            Console.Write("*");
        }

        ball.UpdatePosition(ball.X, ball.Y);
        Console.ResetColor();
        Console.WriteLine();

    }
}