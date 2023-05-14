
public class Ball
{
    public int X { get; set; }
    public int Y {get; set; }
    public bool TravRight {get; set; } = true;
    public bool TravUp {get; set; } = true;
    public int CanvasWidth {get; set; }
    public int CanvasHeight {get; set; }

    public Ball(int CanvasWidth, int CanvasHeight)
    {
        X = 20;
        Y = 20;
        this.CanvasWidth = CanvasWidth;
        this.CanvasHeight = CanvasHeight;
        TravRight = true;
        TravUp = true;
    }

    public void RenderBall()
    {
        Console.SetCursorPosition(X, Y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("0");
        Console.ResetColor();
    }

    public void UpdatePosition(int posX, int posY)
    {
        int movement = DegreeOfTravel();
        // travelling right and down
        // hits: bottom >> goes to right and up
        if (TravRight && !TravUp && posY >= CanvasHeight)
        {
            TravRight = true;
            TravUp = true;
            // movement = DegreeOfTravel();
        }

        // hits: right >> goes to left and down
        else if (TravRight && !TravUp && posX >= CanvasWidth)
        {
            TravRight = false;
            TravUp = false;
            // movement = DegreeOfTravel();
        }

        // travelling left and down
        // hits: bottom >> goes left and up
        else if (!TravRight && !TravUp && posY >= CanvasHeight - 1)
        {
            TravRight = false;
            TravUp = true;
            // movement = DegreeOfTravel();
        }

        // hits: left >> goes right and down
        else if (!TravRight && !TravUp && posX <= 0)
        {
            TravRight = true;
            TravUp = false;
            // movement = DegreeOfTravel();
        }

        // travelling up and right
        // hits: top >> goes down and right
        else if (TravUp && TravRight && posY <= 0)
        {
            TravUp = false;
            TravRight = true;
            // movement = DegreeOfTravel();
        }
        
        // hits: right >> goes up and left
        else if (TravUp && TravRight && posX >= CanvasWidth)
        {
            TravUp = true;
            TravRight = false;
            // movement = DegreeOfTravel();
        }

        // travelling up and left
        // hits: top >> goes down and left
        else if (TravUp && !TravRight && posY <= 0)
        {
            TravUp = false;
            TravRight = false;
            // movement = DegreeOfTravel();
        }

        // hits: left >> goes up and right
        else if (TravUp && !TravRight && (posX <= 2))
        {
            TravUp = true;
            TravRight = true;
            // movement = DegreeOfTravel();
        }
        // else {
        //     movement = 2;
        // }

        //set DegreeOfTravel

        //check for direction conditions and update positions accordingly
        if (TravRight && !TravUp)
        {
            X += movement;
            Y += 1;
        }
        else if (!TravRight && !TravUp)
        {
            X -= movement;
            Y += 1;
        }
        else if (TravUp && TravRight)
        {
            X += movement;
            Y -= 1;
        }
        else if (TravUp && !TravRight)
        {
            X -= movement;
            Y -= 1;
        }
        
    }

    private int DegreeOfTravel()
    {
        Random r = new Random();
        int rInt = r.Next(1, 3);
        return rInt;
    }

}