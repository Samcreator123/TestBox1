using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleTestBox.IQueryableAndIEnumerable
{
    public class IEnumerableExample : IEnumerator<int>
    {
        private int _start = 1;
        private int _end = 100;
        private int _current = 1;
        public IEnumerableExample(int start = 1, int end = 100)
        {
            _start = start;
            _end = end;
            this.Reset();
        }

        public int Current => this._current;

        object IEnumerator.Current => this._current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (_current <= _end) _current++;

            return (_current <= _end);
        }

        public void Reset()
        {
            _current = 0;
        }
    }
}
