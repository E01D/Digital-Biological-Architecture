Please note that this site is under **active development** and revision.  Concepts presented here are in flux and in rough draft form until they are finalized.  

# Digital Biological Architecture

Software can be engineered and structured in numerous ways, but it does not mean it should.  With over twenty four years of software engineering experience comes the understanding that there are information rules that govern the writing of software, even if they are not currently taught in our computer science classes.  These information rules are taught, though indirectly, when students are taught the natural sciences, especially biochemistry and biology, as these two fields are the study of the most complex computer systems that exist today: the [cell](https://www.youtube.com/watch?v=wJyUtbn0O5Y) and the [mitochondria](https://www.youtube.com/watch?v=RrS2uROUjK4) that power them.  The fact is the information rules are really laws, and these information laws govern how information is structured.  Informaiton laws can be broken, nothing says that you have to program something in a certain way.   But when you are trying to lay down large amounts of code and want to maximize reuse, and minimize entropy (e.g. refactoring of code and technical debt), it is best to bide by these laws.  Unfortunately they are not written down and software developers are still figuring out the best ways to develop software.  The good news is that biology and biochemistry are subject to these same laws and by studying how things are done in the cell we can learn the same lessons that cells have learned over the course of two billion year of evolution.  

These information laws are becoming increasing relevant because software is becoming more biological by the day, and not because software developers are copying the stucture of the cell verbatim, but because they are finding the same problems and looking for similar solutions.  (Explain more here).  

Lately, the formation of cells has started with the invention of the peer to peer systems and blockchain technology.  The concept of full nodes are becoming the foundations of primordial digital life.  (Explain more here and connect) A leap in technology has occured and the concept of a traditonal spoke and wheel business is transforming.  Businesses now need to be architected to exist in a distributed fashion.  The busineses will exist as distributed blockchains.  They come into existance when blockchains are formed, and die when the last node in the blockchain disappears.  

This repository discusses and provides the foundation for the architecture for these new business models.  This [project](https://github.com/E01D/Architecture/wiki) is used to discuss general csharp coding architecuture concepts and how these concepts can be combined to form block chains ecosystems and digital cells that access these ecosystems. 

Becusae this project has to incoroporate so many ideas together, it is also an architectural study that enables programmers to see how various concepts exists together in a cohesive architecture.  This project uses a bunch of small projects to keep ideas well defined and their dependencies well understood.

# Concepts

Below is a series of links to the concepts that are under active research and development.  

* [The Software Information Laws](https://github.com/E01D/Digital-Biological-Architecture/wiki/Information-Rules)
* Digital Biological Architecture
  * Solution Structure
  * Project Structure
  * [Api]() (One through Four Dimensions)
  * Kor
    * Fractal Pattern
      * Kachine (Kal) (Kachine/Machine/Hardware Abstraction Layer)
      * Korlib (Kll) - Kore Language Library (Core Library + Kommon Language Library)
      * Kortime (KLR) - Kore Lanaguge Runtime
      * Kornel - Provides the neccessary logic to host a Kor above it
      * Kompiler - Provides the neccessary tooling to produce the layer
      * Kommon - Common Logic used to provide additional services beyond hosting
    * Kor Types
      * Boot Image (BI)
      * Operating System (OS)
      * Application (App)
      * Plasma / Cell / Virtual Machine (VM) / Blockchain VM / Emulated Boot Image (EBI)
  * Kor Abstract Makeup
    * Kachine - Hardware Abstraction Layer
    * Korlib (Kll) - Kore Language Library (Core Library + Kommon Language Library)
      * Identification - do not need types    
      * Common Language Infrastructure
        * Metadata
          * Typal - Crude
          * Typal - Full
    * Kortime (KLR) - Kore Lanaguge Runtime
    * Kornel
    * Kompiler
    * Kommon - Implemetnation Specific 
  * Kor Implementation Specific Makeup
    * Kor - Boot Image
      * Kachine - Hardware Abstraction Layer
    * Kor - Operating System
      * Kachine - Boot Image provided Hardware Abstraction Layer
    * Kor - App
      * Kachine - Operating System provided Hardware Abstraction Layer
      * Korlib  - Basic Dotnet Common Language Build Out + Additional Core Tooling
        * Typal - CLR like Declarations
        * Objetal - Declares object specification
        * Basic Functional Layer
           * Tooling
        * Common Lib
      * Kortime - Basic Dotnet Runtime Wrapper - Instance is implied to be contained by statics 
        * Objetal - can create objects with types in place
      * Kornel - Provides the ability to host component instances that can have their own runtimes or Kors
         * [Plasmas and Plasms](https://github.com/E01D/Digital-Biological-Architecture/wiki/Kernel)
           * [Api]() (Five Dimensional)
      * Kompiler - Provides the neccessary tooling to produce libraries and executables (pre and post ccompiler modifications)
      * Kommon - Common Area / General Logic
        * Digital Cell Functionaltiy
          * Advanced Dotnet Wrapper
             * The Digital Central Dogma
               * Object Creation
               * Object Caching
               * Advanced Inversion of Control
    * Kor - Plasma / Cell / Virtual Machine (VM) / Blockchain VM / Emulated Boot Image (EBI)
      * Kachine - App provided Hardware Abstraction Layer - Dummy / Direct Access / Abstraction Layer / Emulator
      * Korlib - necessary lib to compile the runtime and kornel
      * Kortime - virtual runtime used to run programs differnetly than Dotnet or just another version of Dotnet
      * Kornel - component logic
      * Komopiler -  Provides the neccessary tooling to produce component libraries / possibly from source files other than C#.
* [Glossary](https://github.com/E01D/Digital-Biological-Architecture/wiki/Glossary)

# Using the Code

## Kernel

* Nuget Package
* Kernel Source Code
* Base Library Prototype Source Code

## Base Library

## Versions
Evobolics is planning on offering libraries that can be ran using the .NET Framework 4.6.1 and the .NET Standard 2.0.  The solution to the library is coded using the framework due to the fact Visual Studio cannot handle a large number of .NET Standard projects.  Last count had the entire solution over 700 projects in size.  It is possible though to build the .NET Standard solution using the command line.





