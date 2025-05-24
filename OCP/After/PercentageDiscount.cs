namespace OCP.After
{
    public class PercentageDiscount : Discount
    {
        public override decimal Calculate(decimal amount) => amount * 0.5m;
            
             
    }
}
