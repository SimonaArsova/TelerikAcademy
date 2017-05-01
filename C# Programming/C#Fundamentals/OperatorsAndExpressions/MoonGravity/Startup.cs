using System;

namespace MoonGravity
{
    class Startup
    {
        static void Main()
        {
            float weight = float.Parse(Console.ReadLine());
            if (weight > 0.0f && weight < 1000.0f)
            {
                float moonWeight = weight * 17 / 100;
                Console.WriteLine(moonWeight.ToString("0.000"));
            }
        }
    }
}
