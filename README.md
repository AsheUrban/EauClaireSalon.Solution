# Eau Claire's Hair Salon Database Solution!

A website that allows Eau Claire Managers to track their Stylists and Clients!

#### By Ashe Urban

_This project contains two branches:_

* main
* searchfunction (WIP)

## Technologies Used on main branch

* _C#_
* _CSHTML_
* _CSS_
* _Entity Framework_
* _SQL Database_
* _dotnet_
* _Markdown_

## Description

_You've been referred by Pierre to his friend Claire who is the owner of a hair salon called Eau Claire's Salon. She has contracted you out to create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist._

* _List of all stylists._
* _List of all clients that belong to that stylist._
* _Add new stylists to our system when they are hired._
* _Add new clients to a specific stylist. I should not be able to add a client if no stylists have been added._

_Here's the challenge:_ build a C# web application to help Eau Claire manage stylists and clients.

_Link to assignment:_ https://epicenter.epicodus.com/courses/968/code_reviews/5860


## Setup/Installation Requirements

* _Clone or download responsitory to your local._
* _Cd into ./HairSalon

* _Touch appsettings.json and add the following configuration:_
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[first_last];uid=[yours];pwd=[password];"
    }
  }
  ```
  _NOTE:_ [first_last] [yours] [password] should all be replaced by your MySql access details. Do not include square brackets in final configuration.

* _Start localhost in MySQL_
* _Build database:_
  ```
  dotnet restore
  ```
  ```
  dotnet build
  ```
* _Populate database:_
  ```
  dotnet ef migrations add Initial 
  ```
    * _Optionally use .sql files provided to build schema quickly with out the need for EF migrations.

  ```
  dotnet ef database update 
  ```
* _Then use the following to run web application:_
   ```
   dotnet run OR dotnet watch run
   ```
* _Navigate to the localhost from your browser and explore the project!_
* _If you are seeing an error that tables cannot befound, there are missing or more than one DbContexts, or there are unresolvable errors related to the database use:_
  ```
  dotnet ef database drop -f --context HairSalonContext
  ```
* _Then delete your migrations folder and everything in it, then rerun intial migrations and database update using dotnet as outlined above._

## Known Bugs

* _Stylists cannot currently be edited, button-click triggers an "Are you lost?" page._
* _Currently all properties aside from id are being pulled in as strings. Ideally, Date would use a date type and contact information would specifically be changed to phone number also with appropriate corresponding type._
* _There is a test branch called searchfunction that has WIP regarding a search function._
* _Incomplete commit history. first repository was deleted and project restarted around 9:30am._

## License

* _Educational Use Only — This repository is provided for classroom and personal learning purposes. It is not licensed for public deployment, redistribution, or commercial use. No warranty or support is provided._

## 

Copyright(c) July 2022 Ashe Urban