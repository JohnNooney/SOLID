# Interface Segregation Principle
This principle states that classes should not be forced to inherit unneeded properties from a contract.


## Program Requirements
* CLI program 
* Generates a catalgoue of furniture
* Outputs the furniture available


## Implementation Details
From an implementation perspective, this program uses multiple interfaces for the furniture so that based on the type of furniture it will implement different interfaces. 

For example the base `IFurniture` interface only has the class properties that are shared between all furniture classes that implement this interface. However additional interfaces can be used in classes that require fabric or material types.
- the `Couch` class implements `IFurniture` and `IFabric`
- whereas the `Table` class implements `IFuriture` and `IMaterial`

The `Table` and `Couch` are both pieces of furniture but they only implement the interfaces relevant to them.

