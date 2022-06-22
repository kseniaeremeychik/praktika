try
{
    Product st = new Product() {
    ProduceName = "Tovar",
    Category = "Krutoi",
    Price = 100,
    };
    st.Print();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

class Produce
{
    public string ProduceName { get; set; }
    public string Category { get; set; }

    public void Print()
    {
        Console.WriteLine("Продукт создан");
    }
}

class Toy : Product
{
    public string ToyName { get; set; }

    public void Print()
    {
        Console.WriteLine("Игрушка создана");
    }

}

class MilkProduce : Produce
{
    public string Milk { get; set; }

    public void Print()
    {
        Console.WriteLine("Молочный продукт создан");
    }

}

class Product : Produce
{
    public int Price { get; set; }

    public void Print()
    {
        Console.WriteLine("Товар создан");
    }
}