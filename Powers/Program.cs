int num = 2;
int steps = 0;
int pow = 16;

Console.WriteLine(Power(2, 200, 0));

long Power(long x, long y, int steps)
{
    if (y % 2 == 0)
    {
        steps++;
        long power = Power(x, y / 2, steps);
        return power * power;

    }
    else
    {
        long r = 1;
        for (long i = 0; i < y; i++)
        {
            r *= x;
            steps++;
        }
        return r;
    }
}