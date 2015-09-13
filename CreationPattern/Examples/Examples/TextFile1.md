Object Pool Pattern
When it is necessary to work with a large number of objects that are particularly expensive to instantiate and each object is only needed for a short period of time, the performance of an entire application may be adversely affected. An object pool design pattern may be deemed desirable in cases such as these.
The object pool design pattern creates a set of objects that may be reused. When a new object is needed, it is requested from the pool. If a previously prepared object is available it is returned immediately, avoiding the instantiation cost. If no objects are present in the pool, a new item is created and returned. When the object has been used and is no longer needed, it is returned to the pool, allowing it to be used again in the future without repeating the computationally expensive instantiation process. It is important to note that once an object has been used and returned, existing references will become invalid.
In some object pools the resources are limited so a maximum number of objects is specified. If this number is reached and a new item is requested, an exception may be thrown, or the thread will be blocked until an object is released back into the pool.
The object pool design pattern is used in several places in the standard classes of the .NET framework. One example is the .NET Framework Data Provider for SQL Server. As SQL Server database connections can be slow to create, a pool of connections is maintained. When you close a connection it does not actually relinquish the link to SQL Server. Instead, the connection is held in a pool from which it can be retrieved when requesting a new connection. This substantially increases the speed of making connections.

http://1.bp.blogspot.com/-Ngx619EgkC4/UXUbBO0y43I/AAAAAAAAAf4/HQmRoM3bNVw/s1600/objectpool.png

Factory Design Pattern

The factory method pattern should not be confused with the more general notion of factories and factory methods. The factory method pattern is the best-known use of factories and factory methods, but not all uses of factory methods are examples of the factory method pattern – only when inheritance is involved (a class implementing an interface, or derived class, implements a factory method) is it an example of the factory method pattern[]. More basic uses of factories are not examples of the factory method pattern, and may instead be referred to as the factory pattern or a simple factory; these are discussed at factory.
The Factory method lets a class defer instantiation to subclasses. 
Creating an object often requires complex processes not appropriate to include within a composing object. The object's creation may lead to a significant duplication of code, may require information not accessible to the composing object, may not provide a sufficient level of abstraction, or may otherwise not be part of the composing object's concerns. The factory method design pattern handles these problems by defining a separate method for creating the objects, which subclasses can then override to specify the derived type of product that will be created.
The factory method pattern relies on inheritance, as object creation
http://www.dofactory.com/images/diagrams/net/factory.gif

Builder Pattern

The builder pattern is an object creation software design pattern. Unlike the abstract factory pattern and the factory method pattern whose intention is to enable polymorphism, the intention of the builder pattern is to find a solution to the telescoping constructor anti-pattern[citation needed]. The telescoping constructor anti-pattern occurs when the increase of object constructor parameter combination leads to an exponential list of constructors. Instead of using numerous constructors, the builder pattern uses another object, a builder that receives each initialization parameter step by step and then returns the resulting constructed object at once.
The builder pattern has another benefit. It can be used for objects that contain flat data (html code, SQL query, X.509 certificate...), that is to say, data that can't be easily edited. This type of data cannot be edited step by step and must be edited at once. The best way to construct such an object is to use a builder class
Builder often builds a Composite. Often, designs start out using Factory Method (less complicated, more customizable, subclasses proliferate) and evolve toward Abstract Factory, Prototype, or Builder (more flexible, more complex) as the designer discovers where more flexibility is needed. Sometimes creational patterns are complementary: Builder can use one of the other patterns to implement which components are built. Builders are good candidates for a fluent interface.

https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Builder_UML_class_diagram.svg/500px-Builder_UML_class_diagram.svg.png


