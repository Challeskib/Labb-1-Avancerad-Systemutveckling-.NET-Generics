﻿using System.Collections;

namespace Labb_1___Generics
{
    internal class BoxEnumerator : IEnumerator<Box>
    {

        public Box Current
        {
            get { return _currentBox; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        private BoxCollection _boxes;
        private int _currentIndex;
        private Box _currentBox;

        public BoxEnumerator(BoxCollection students)
        {
            _boxes = students;
            _currentIndex = -1;
            _currentBox = default(Box);
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (++_currentIndex >= _boxes.Count)
            {
                return false;
            }
            else
            {
                _currentBox = _boxes[_currentIndex];
            }

            return true;
        }

        public void Reset()
        {
        }

        
    }
}