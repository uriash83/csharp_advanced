namespace CourseAdv.Generics
{

    // where T : Product - ograniczenie do klasy product albo jej subklasses
    public class DiscountProduct<TProduct> where TProduct : Product
    {
        public string CalculateDiscount(TProduct product)
        {
            return product.Title;
        }

        public void Add(TProduct value)
        {

        }
    }
}
