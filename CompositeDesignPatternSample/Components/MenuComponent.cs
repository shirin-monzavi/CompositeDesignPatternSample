namespace CompositeDesignPatternSample.Components;

public abstract class MenuComponent
{
    public virtual void Add(MenuComponent component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(MenuComponent component)
    {
        throw new NotImplementedException();
    }

    public virtual void Display(int depth = 0)
    {
        throw new NotImplementedException();
    }
}
