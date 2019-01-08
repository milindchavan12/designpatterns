# Design Patterns

## Creational Patterns
Creational design patterns provide various object creation mechanisms, which increase flexibility and reuse of existing code.

### 1. Factory Method
Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

![alt text](https://refactoring.guru/images/patterns/diagrams/factory-method/structure.png)

### 2. Abstract Factory
Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

![alt text](https://refactoring.guru/images/patterns/diagrams/abstract-factory/structure.png)

### 3. Builder Pattern
Separate the construction of a complex object from its representation so that the same construction process can create different representations.

![alt text](https://refactoring.guru/images/patterns/diagrams/builder/structure.png)

### 4. Prototype
Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

![alt text](https://refactoring.guru/images/patterns/diagrams/prototype/structure.png)

### 5. Singleton
Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

![alt text](https://refactoring.guru/images/patterns/diagrams/singleton/structure.png)

## Structural Design Patterns

### 6. Adaptor Pattern
Adapter pattern works as a bridge between two incompatible interfaces. 

![alt text](https://refactoring.guru/images/patterns/diagrams/adapter/structure-object-adapter.png)

### 7. Bridge Patterns
Decouple an abstraction from its implementation so that the two can vary independently. A Standard car and Sports car acceleration example.

![alt text](https://refactoring.guru/images/patterns/diagrams/bridge/structure-en.png)

### 8. Composite
Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.

![alt text](https://refactoring.guru/images/patterns/diagrams/composite/structure.png)

### 9. Decorator
Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors

### 10. Facade
Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

### 11. Flyweight
Flyweight is a structural design pattern that lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

### 12. Proxy
Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

## Behavioral Design Patterns

### 13. Chain of Responsibility
Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

![alt text](https://refactoring.guru/images/patterns/diagrams/chain-of-responsibility/structure.png)

### 14. Command 
Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you parameterize methods with different requests, delay or queue a request’s execution, and support undoable operations.

### 15. Iterator 
is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).

### 16. Mediator 
is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

### 17. Memento 
is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.

### 18. Observer 
is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

### 19. State 
is a behavioral design pattern that lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.

### 20. Strategy 
is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

### 21. Template Method 
is a behavioral design pattern that defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.

### 22. Visitor 
is a behavioral design pattern that lets you separate algorithms from the objects on which they operate.
