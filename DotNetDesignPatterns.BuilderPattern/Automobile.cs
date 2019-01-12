using System;
using System.Collections.Generic;

namespace DotNetDesignPatterns.BuilderPattern
{
    public class Automobile
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public List<string> ShowParts()
        {
            return _parts;
        }
    }
}