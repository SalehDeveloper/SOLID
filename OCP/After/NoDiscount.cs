namespace OCP.After
{
    public class NoDiscount : Discount
    {
        public override decimal Calculate(decimal amount) => amount;
       
    }
}
