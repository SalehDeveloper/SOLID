SOLID Principles in C# (.NET Core)

This repository demonstrates the five SOLID principles using practical examples written in C# with .NET Core. Each principle is implemented in a separate project for clarity.

📌 What are SOLID Principles?

SOLID is an acronym for five design principles intended to make software designs more understandable, flexible, and maintainable.

🧱 Principles

1. Single Responsibility Principle (SRP)

A class should have only one reason to change.

✅ Meaning: Each class should only have one job or responsibility. If a class is handling more than one thing (e.g., logic + saving to DB), it violates SRP.

📁 project: /SRP

2. Open/Closed Principle (OCP)

Software entities should be open for extension but closed for modification.

✅ Meaning: You should be able to add new features by extending classes, not by changing existing code.

📁 project: /OCP
3. Liskov Substitution Principle (LSP)

Objects of a superclass should be replaceable with objects of its subclasses without breaking the application.

✅ Meaning: A subclass should behave in such a way that it can stand in for its parent without errors or unexpected behavior.

📁 project: /LSP

4. Interface Segregation Principle (ISP)

Clients should not be forced to depend on interfaces they do not use.

✅ Meaning: Keep interfaces small and focused. It's better to have multiple small, role-specific interfaces than one large general-purpose interface.

📁 project: /ISP

5. Dependency Inversion Principle (DIP)

High-level modules should not depend on low-level modules. Both should depend on abstractions.

✅ Meaning: Depend on interfaces, not on concrete implementations. This keeps components loosely coupled and easier to test and maintain.

📁 project: /DIP

🧠 How to Run the Solution

Clone this repository:

git clone https://github.com/yourusername/solid-principles-demo.git

Open the solution in Visual Studio or VS Code.

Explore each folder to see the specific examples.

🤝 Contributing

Feel free to fork this repo, improve the examples, and submit a pull request.

📫 Contact

Ahmad Saleh📧 ahmadsalehdev.22@gmail.com🔗 linkedin.com/in/salehdeveloper

Happy Coding! 🚀
