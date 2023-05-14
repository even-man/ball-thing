using System;
using System.Threading.Tasks;

int WIDTH = 80;
int HEIGHT = 40;
int REFRESH_SPEED = 1000;

// main method functionality

Canvas Canvas = new Canvas(WIDTH, HEIGHT);
bool GameLoop = true;

while (GameLoop)
{
    Thread.Sleep(REFRESH_SPEED);
    Canvas.DrawCanvas();

}
Console.ReadLine();

