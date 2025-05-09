# 🎯 Composite DesignPattern Sample in C#

This project demonstrates the **Composite Design Pattern** using a menu system as an example.

## 📌 What is the Composite Pattern?

The Composite Pattern is a structural design pattern that allows you to compose objects into tree structures to represent part-whole hierarchies. It lets clients treat individual objects and compositions uniformly.


## 🧩 Classes

### `MenuComponent` (Abstract)

- Defines a common interface for all menu elements.
- Methods: `Add()`, `Remove()`, `Display()`.

### `MenuItem` (Leaf)

- Represents a single item.
- Overrides `Display()` to print its name.

### `Menu` (Composite)

- Represents a collection of `MenuComponent` items.
- Overrides `Add()`, `Remove()`, and `Display()`.

---

### 🛠️ Technologies Used
 
C#
 
.NET Framework 7.0

### 🤝 Contributing
 
Feel free to fork the repository, submit pull requests, or open issues for improvements and discussions.
