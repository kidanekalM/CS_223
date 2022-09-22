using System;

public class Product
{
    public delegate void functionAgreement();
    /// <summary>
    /// Create event handler
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void CustomEventHandler(object sender, EventArgs e);
    public CustomEventHandler eventHandler;
    public functionAgreement function;
    public void addProduct(functionAgreement e)
    {
        Console.WriteLine("Before");
        e();
        Console.WriteLine("After");
        Console.WriteLine("Concated");
        function();
        if (eventHandler != null)
        {
            eventHandler(this, EventArgs.Empty);
        }
    }
}
