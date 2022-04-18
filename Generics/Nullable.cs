﻿namespace CourseAdv.Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
                
        }
        public Nullable(T value)
        {
            this._value = value;
        }

        public bool HasValue// to jest property
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;
            return default(T);// to jest defaultowa wartosc dla kazdego typu
        }
    }
}
