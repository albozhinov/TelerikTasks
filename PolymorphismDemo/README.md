# Refactor Registration Service

## Description
The RegistrationService is a simple class that accepts input from the console input and tries to create a new user. <br>
It won't register the user anywhere - this is just a demo class. <br>
The User class validates the parameters passed to it and throws Argument Exceptions in case of failure. <br>

Once your shiny application is shipped to the customers all hell will break loose. <br>
Even the best software will fail eventually. The only way to troubleshoot the problem is to save a description somewhere *(file, database, etc.)* <br>
This process is known as **Logging**.

The RegistrationService can be configured to log either to a file or to the console. *(Logging to the console is fine during development)* <br>
All the logging functionality is written in a `switch` stamement and is a bit problematic.
- The **cohesion** is low - the service registers users AND logs exceptions
- The **coupling** is tight - the service has a dependency on `System.IO` to write in files
- The Service is not **extensible** - new functionality such as logging to a database cannot be added without recompiling the service.

Your task is to refactor the service by using the magic of Polymorphism to address the issues.

## Guidelines
1. Your are provided with an `ILogger` interface which defines a simple `Log` method.
    - Create a 'ConsoleLogger` class that implements the interface
    - Create a 'FileLogger` class that implements the interface

2. Currently, the service accepts the magic string `whereToLog` to determine the logging target
    - Think of a way to make the constructor accept either `ConsoleLogger` or `FileLogger` or any other future implementation
    - Think of a way to remove the switch and use the provided `ILogger` implementation
