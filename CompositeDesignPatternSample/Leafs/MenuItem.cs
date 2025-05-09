using CompositeDesignPatternSample.Components;

namespace CompositeDesignPatternSample.Leafs;

public class MenuItem : MenuComponent
{
    #region Field
    private readonly string _name;
    #endregion

    public MenuItem(string name)
    {
        _name = name;
    }

    public override void Display(int depth = 0)
    {
        Console.WriteLine($"{new string('-', depth) + _name}");
    }
}
