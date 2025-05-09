using CompositeDesignPatternSample.Components;
using CompositeDesignPatternSample.Composites;
using CompositeDesignPatternSample.Leafs;

MenuComponent mainMenu = new MenuComposite("MainMenu");

MenuComponent file = new MenuComposite("File");
file.Add(new MenuItem("Open"));
file.Add(new MenuItem("New"));

MenuComponent edit = new MenuComposite("Edit");
edit.Add(new MenuItem("Copy"));
edit.Add(new MenuItem("Paste"));

mainMenu.Add(file);
mainMenu.Add(edit);

mainMenu.Display();
