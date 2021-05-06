namespace RecipeBook
{
    public interface IMeasure
    {
        Measurement Measurement { get; set; }
        double Quantity { get; set; }
    }
}