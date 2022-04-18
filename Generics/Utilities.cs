namespace CourseAdv.Generics
{
    //constraint for generics
    // where T : IComparable - ograniczenie do wszystkiego co zaimplementowao interfejs
    // where T : Product - ograniczenie do klasy product albo jej subklasses
    // where T : struct - ograniczenie do value type
    // where T : class - ograniczenie do reference type
    // where T : new() - ograniczenie do klasy ktora ma konstruktor domyslny
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a , int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

    }
}
