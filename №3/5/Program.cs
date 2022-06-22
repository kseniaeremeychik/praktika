public class Multitude<T>
{
    private List<T> _list;
    Multitude() 
    { 
        _list = new List<T>();
    }
    public Multitude(params T[] args)
        : this()
    {
        _list.AddRange(args);
    }
    public Multitude(IEnumerable<T> mas)
        : this()
    {
        _list.AddRange(mas);
    }
    public void Add(T elem)
    {
        _list.Add(elem);
    }
    public void Delete(T elem)
    {
        _list.Remove(elem);
    }
    public Multitude<T> Intersect(Multitude<T> Source)
    {
        return new Multitude<T>(_list.Intersect(Source._list));
    }
    public Multitude<T> Union(Multitude<T> Source)
    {
        return new Multitude<T>(_list.Union(Source._list));
    }
    public Multitude<T> Except(Multitude<T> Source)
    {
        return new Multitude<T>(_list.Except(Source._list));
    }
    public override string ToString()
    {
        return string.Join(",", _list);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Multitude<int> _mt1 = new Multitude<int>(1, 2, 3, 4, 5);
        Console.WriteLine("Множество 1: {0}", _mt1);
        Multitude<int> _mt2 = new Multitude<int>(4, 5, 6, 7, 8);
        Console.WriteLine("Множество 2: {0}", _mt2);
        Console.WriteLine("Пересечение множеств: {0}", _mt1.Intersect(_mt2));
        _mt2.Add(9);
        Console.WriteLine("Множество 2 после добавления элемента: {0}", _mt2);
        Console.WriteLine("Объединение множеств: {0}", _mt1.Union(_mt2));
        _mt1.Delete(1);
        Console.WriteLine("Множество 1 после удаления элемента: {0}", _mt1);
        Console.WriteLine("Разность множеств: {0}", _mt1.Except(_mt2));
    }
}