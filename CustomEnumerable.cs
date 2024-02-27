using System;
using System.Collections;

namespace Lesson5
{
    public class CustomEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new CustomEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CustomEnumerator();
        }
    }
}

