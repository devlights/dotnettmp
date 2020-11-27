using System;

namespace RecordType
{
    internal record Rec 
    {
        internal string Key;
        internal string Value;

        internal Rec(string key, string value) => (Key, Value) = (key, value);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rec = new Rec("key1", "value1");
            Console.WriteLine($"{rec.Key}\t{rec.Value}");
        }
    }
}
