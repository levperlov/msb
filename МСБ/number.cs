using System;

namespace МСБ
{
    internal class number
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public number(string value, string name)
        {
            Value = Convert.ToInt32(value);
            Name = name;
        }
    }
}
