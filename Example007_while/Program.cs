﻿Console.Clear();
int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;
int count = 0;
int x=xa, y=xb;

//Console.SetCursorPosition (xa, ya);
//Console.WriteLine("*");

//Console.SetCursorPosition (xb, yb);
//Console.WriteLine("*");

//Console.SetCursorPosition (xc, yc);
//Console.WriteLine("*");

while (count<10000)
{
    int param = new Random().Next(0,3);
    if (param == 0)
        {
            x = (x+xa)/2;
            y = (y+ya)/2;
        }
    if (param == 1)
        {
            x = (x+xb)/2;
            y = (y+yb)/2;
        }
    if (param == 2)
        {
            x = (x+xc)/2;
            y = (y+yc)/2;
        }
Console.SetCursorPosition (x, y);
Console.WriteLine("*");
count++;
}