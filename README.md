# The Singleton Design Pattern
The Singleton design pattern ensures an object is created only once. This is achieved by use of a private constructor in the singleton class to prevent initialisation of a new object by way of using the *new* operator. Access to the singleton instance is achieved via a public static method. The instance itself is created when the public method is first called, and held in memory as a static variable.

## Example
This example demonstrates the use of the Singleton design pattern by creating a NumberGenerator class which creates a single instance of a Random number generator object, which can be used many times without creating another Random object.

## UML
![View UML diagram](uml.png)

