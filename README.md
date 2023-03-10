# CompanyProject
ASP.NET MVC project for programming laboratories.
## Table of contents
* [General info](#general-info)
* [Project status](#project-status)
* [Project screenshots](#project-screenshots)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
This project was based on the ASP.NET course I completed during my studies. The project presents an employee management system. In the application, any user can create an account in the registration form and log in as a new employee. After logging in, user has access to: 
- the tasks page where he can record time and assign task names. 
- the annual leave page where he can enter his data like: time and name.
- he can also display the list of tasks and annual leaves.

Employee with administrator rights  after logging  in  has  access  to:
-  the  admin  panel, where  he can  view  the  list  of  employees  and  edit  their  data.  
- his own  profile, where  he can  edit  his data. Administrator  Profile  View  is  identical  to  the  profile  of  an  ordinary  employee.
- the tasks page where he can record time and assign task names. 
- the annual leave page where he can enter his data like: time and name.
- he can also display the list of tasks and annual leaves.

Every  employee  can  check  their  working  hours  data  in  the  details  tab.

## Project status
The application is finished.


## Project screenshots
![ems1](https://user-images.githubusercontent.com/89485950/215151776-383c1b10-6658-4435-acbd-7ca4320e72f3.png)
![ems2](https://user-images.githubusercontent.com/89485950/215151892-406c504d-c4c3-4fbf-8b18-64cb438caf7b.png)
![ems3](https://user-images.githubusercontent.com/89485950/215152437-cbeb7be0-5e02-4f1f-be88-506512453b3a.png)
![image](https://user-images.githubusercontent.com/89485950/215153275-a4e8fa61-4481-489a-98af-d7fab070a2d6.png)
## Technologies
- C# 
- HTML5
- ASP.NET Core 6.0
- SQL
- Bootstrap v5.3

## Setup
- Clone the repository to your local machine.
- Open the solution in Visual Studio.
- In the appsettings.json file, change the connection string to match your database settings.
- Open the Package Manager Console and   run these commands:
```
add-migration "migration name"
update-database
```
- Build and run the application
