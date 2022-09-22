// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//generics e.g. list
//callback 
//Events Sender => Reciever
Product p = new Product();
void printData()
{
    Console.WriteLine("MessageBox displayed");
}
p.function += printData;
p.eventHandler += new GenericsDelegeates.Sub1().EventHandler;
p.eventHandler += new GenericsDelegeates.Sub2().EventHandler;
p.addProduct(printData);
