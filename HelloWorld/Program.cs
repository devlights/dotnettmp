using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static async Task Main()
        {
            await foreach (var c in GenMessage())
            {
                Console.Write(c);
            }

            Console.WriteLine("");
        }

        static async IAsyncEnumerable<char> GenMessage()
        {
            var rnd = new Random();
            foreach (var c in "HelloWorld")
            {
                await Task.Delay(TimeSpan.FromMilliseconds(rnd.Next(50)));
                yield return c;
            }

            yield break;
        }
    }
}