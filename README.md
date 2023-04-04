# Users Graphql


This is an API for creation of users and adress, using GraphQL.



## **Tecnologies**

.Net 6.0

Sql Server



## **Nuget Packages**

AutoMapper extensions for ASP.NET Core 

GraphQL Voyager integration for ASP.NET Core

HotChocolate.AspNetCore

HotChocolate.Data.EntityFramework

Microsoft.EntityFrameworkCore.Design

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools



## **Folders Division**



### **GraphQL**

Is Responsible for ensuring the inputs, payloads and types, that will be used by the, query, mutation and subscription.



### **InfraStructure**

Is reponsible for the context layer, that will acess the database.



### **IoC**

Is reponsible for the dependecy injection.



### **Migrations**

Is a automatic folder created by the entity frame work design, it will create de database structure.



### **Models**

Represents ours object models in this case, users and adresses.