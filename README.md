# Week 10 Independent Project: Eau Claire's Hair Salon Database Solution!

#### A website that allows Eau Claire Managers to track their Stylists and Clients!

#### By Ashe Urban

## Technologies Used

* _C#_
* _Entity Framework_
* _SQL Database_
* _dotnet_
* _Markdown_

## Description

_You've been referred by Pierre to his friend Claire who is the owner of a hair salon called Eau Claire's Salon. She has contracted you out to create an MVC web application to help her manage her employees (stylists) and their clients. Claire should be able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist._

* _list of all stylists._
* _list of all clients that belong to that stylist._
* _add new stylists to our system when they are hired._
* _add new clients to a specific stylist. I should not be able to add a client if no stylists have been added._

_Here's the challenge:_ build a C# web application to help Eau Claire manage stylists and clients.

_Link to assignment:_ https://epicenter.epicodus.com/courses/968/code_reviews/5860

### Eau Claire's Hair Salon

_You must follow the naming conventions for your project. Projects that do not follow these conventions will not be reviewed and will be returned not passing._

_Use your first name and last name to name your database in the following way:_

_Production Database:_ first_last
_Main Project Folder:_ HairSalon

## Setup/Installation Requirements

* _clone or download responsitory to your local._
* _cd into HairSalon and run dotnet restore, dotnet build, and dotnet run to run web application._
* _touch appsettings.json and add the following configuration:_

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[first_last];uid=root;pwd=[password];"
  }
}

_NOTE:_ [first_last] should be replaced with your own database name and [password] should be replaced by your password. Do not include square brackets in final configuration.

## Known Bugs

* _Currently all properties aside from id are being pulled in as strings. Ideally, Date would use a date type and contact information would specifically be changed to phone number also with appropriate corresponding type._
* _There is a test branch called searchfunction that has WIP regarding a search function._
* _Incomplete commit history. first repository was deleted and project restarted around 9:30am._

## License

* MIT

## Contact Information

_Please contact me with any questions or contribuitions, ashe@goldentongue.com_

Copyright(c) July 2022 Ashe Urban
