# _Eau Clair's Hair Salon_

#### By _**Rosario Ruvalcaba**_

#### _A C# web application to manage Stylists and Clients for 'Eau Clair's Hair Salon' using an SQL database._

## Technologies Used

* _C#_
* _.Net 5.0_
* _ASP .Net Core MVC_
* _Razor View Engine_
* _MySQL Workbench_
* _Entity Core Framework_
* _Markdown, CSS, Bootstrap, HTML_

## Description

_This project consists of an C# MVC web application that allows a salon manager to manage information on her employees (stylists) and their clients. It allows the management of the fictional 'Eau Clair's Hair Salon' to add Stylists and Clients to an SQL Database with the use of Entity Core Framework. The manager can also view details for each Stylist/Client and delete clients. The project was created as a code review for Epicodus following the Database Basics section on C#._


## Setup/Installation Requirements

* _Clone repository from Github and save a copy on own computer. Then on your local copy, navigate to the top level of the directory._

* _If saving repository remotely, make an initial commit pushing ONLY your .gitignore file so sensitive information is not pushed._

* _Ensure you have C# and .NET installed by running the command [dotnet --version] in your terminal. If the response is not a version number, install .NET from Microsoft website._

* _Install MySQL Community Server MySQL Workbench per instruction provided below by Epicodus:_
  * _[https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql]_

* _Open MySQL Workbench and import the database provided with this project (rosario_ruvalcaba)._
  * _see HairSalonSchema.jpg for a visual representation of the tables_



* _Create file called appsettings.json in the main project directory (HairSalon)_
  * _Open file and add the following: { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE NAME HERE];uid=[USER ID HERE];pwd=[PASSWORD HERE];" } }_
  * _Substitute your own information for DATABASE NAME HERE, USER ID HERE, and PASSWORD HERE._

* _Navigate to the HairSalon directory in the project and run the command [dotnet restore, then dotnet build]._

* _While still in the HairSalon directory, run the command [dotnet run] to run the application using a localhost server._

## Known Bugs

* _At the moment: user can enter 'blank' Stylists/Clients as well as the wrong data type, such as letters for a phone number._

## License

MIT License

Copyright (c) _July_2022_ _Rosario Ruvalcaba Harwood_