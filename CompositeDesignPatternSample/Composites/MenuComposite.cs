using CompositeDesignPatternSample.Components;

namespace CompositeDesignPatternSample.Composites;

public class MenuComposite : MenuComponent
{
    #region Field
    private readonly List<MenuComponent> items;
    private readonly string _name;
    #endregion

    public MenuComposite(string name)
    {
        _name = name;
        items = new List<MenuComponent>();
    }

    public override void Add(MenuComponent component)
    {
        items.Add(component);
    }

    public override void Remove(MenuComponent component)
    {
        items.Remove(component);
    }

    public override void Display(int depth = 0)
    {
        Console.WriteLine(_name);

        foreach (MenuComponent component in items)
        {
            component.Display(depth + 1);
        }
    }
}
