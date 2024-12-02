# Design Patterns - Bridge

This repository showcases an implementation of the Bridge design pattern in C#. The code demonstrates how to decouple abstraction from its implementation, allowing the two to vary independently. This pattern is useful for enhancing flexibility and scalability when creating systems that need to support multiple variations of an abstraction and its implementation.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Bridge design pattern is a structural pattern that separates an abstraction from its implementation, allowing the two to evolve independently. This is particularly beneficial when the abstraction and its implementation need to be extended or modified separately, promoting flexibility and scalability.

## Implementation Overview
This repository provides a C# implementation of the Bridge design pattern. Key components of the code include:

- **IDrawing Interface**: Defines the contract for drawing implementations.
- **Circle and Square Classes**: Concrete implementations of the `IDrawing` interface that render shapes.
- **Shape Class**: Abstract class that uses the bridge pattern to decouple the drawing implementation from the shape abstraction.
- **CircleShape and SquareShape Classes**: Concrete classes that extend `Shape` and use the `IDrawing` implementation for rendering.
- **Program Class**: Demonstrates how to use the `Shape` and `IDrawing` classes to render different shapes.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Bridge.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Bridge
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Bridge pattern in action.
3. Modify the `CircleShape` or `SquareShape` classes to customize the demonstration or add other shape types and drawing implementations.

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

