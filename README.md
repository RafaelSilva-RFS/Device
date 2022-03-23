# Devices App

------------

### Technologies

- .Net core 3.1
- Angular 13.3.0
- Node 16.14.2
- npm 8.5.0
- SQL Server

## Summary

The project was developed as a real world application.
Thinking on project's scalability the back-end was architected respecting the domain driven design. The Device Api has 6 layers segregating the responsibility of each one and the Identity is another layer into the same project.
To the example both API's are pointing the same Database, but they are independent of each other, so thinking on scalability the API's could be hosted in different servers with different databases with the possibility to evolve to a microservices application.

## Setting Up the environment and Compiling

First you must have all SDKs  for the above technologies.

After cloning the project you will find two folder with Angular and .Net Core projects, follow these steps to set up and build the application:

#### Backend

1. Open the **Device.sln** project located into aspnet-core folder.

2. Select **Device.Identity** as Start Up Project.

3. Open the Package Manager Console and select **Device.Identity** as Default Project

4. Run the **update-database** command. This command will create and seed the Identity tables.

5. Select **Device.HttpApi.Host** as Start Up Project.

6. Open the Package Manager Console and select **Device.EntityFramework** as Default Project.

7. Run the **update-database** command. This command will create and seed the Device and DeviceDetails tables.

8. Look up at the **sslPort** property into Properties/launchSettings.json files from **Device.HttpApi.Host** and **Device.Identity**, sometimes Visual Studio change this ports after cloning  and the services on Angular are looking exactly to this ports: [**Device.HttpApi.Host  => "sslPort": 44363**] and [**Device.Identity => "sslPort": 44336**]

9. Right click on **Solution 'Device'** then click on properties. In this window go to **Start Project** tab, select the **Multiple startup projects** then change the action of **DEvice.Identity** and **Device.HttpApi.Host**  to **Start without debugging** and apply.

10. Press Ctrl + F5

Project | Port
------------- | -------------
Device.HttpApi.Host  | 44363
Device.Identity | 44336



> **Note:** If you can't run the update-database command, you can find the SQL scripts and the database scheme into folder **aspnet-core/sql**.


#### Frontend

1. Open the folder angular\Device.UI into your console.

2. Install the packages with **npm install** command

3. Build the aplication with **ng serve**

That's all folks! Now you should have the back and front end working.
The Identity was previously seed with this credential:

User | Password
------------- | -------------
admin@device.com  | 1q2w3E*

## What to expect?

It's close to a real world web system, there is the Login that comunicate with back end, generate a JWT token and save it as a cookie on the client side, then you'll have a Dashboard, My devices and Device detail pages, with functional search consuming the backend API.

[![Login](https://rafaelsilvadev.com/Devices/Login.jpg "Login")](https://rafaelsilvadev.com/Devices/Login.jpg "Login")

[![Dashboard](https://rafaelsilvadev.com/Devices/Dashboard.jpg "Dashboard")](https://rafaelsilvadev.com/Devices/Dashboard.jpg "Dashboard")

[![Devices](https://rafaelsilvadev.com/Devices/Devices.jpg "Devices")](https://rafaelsilvadev.com/Devices/Devices.jpg "Devices")

[![Device Detail](https://rafaelsilvadev.com/Devices/Device-Detail.jpg "Device Detail")](https://rafaelsilvadev.com/Devices/Device-Detail.jpg "Device Detail")


## Testing

#### Backend

To backend was implement the Swagger playground to both API's.
All end points are functional, the Device API requires authentication, you can generate the Bearer token by the *authenticate* or *new-user endpoint* on Devices Authentication API, then into Devices API click on Authorize button and send the token this way: Bearer *token-generated-on-authentication-api*

[![Devices Authentication API](https://rafaelsilvadev.com/Devices/Devices-Authentication-API.jpg "Devices Authentication API")](hthttps://rafaelsilvadev.com/Devices/Devices-Authentication-API.jpgtp:// "Devices Authentication API")

[![Devices API](https://rafaelsilvadev.com/Devices/Device-API.jpg "Devices API")](https://rafaelsilvadev.com/Devices/Device-API.jpg "Devices API")

#### Frontend

The frontend test was made with Cypress, to run the test install the Cypress package with this command:

`npm install cypress --save-dev`

An alias was created to run the test, you can type this command on sonole:

`npm run cypress:open`

[![Cypress Dashboard Test](https://rafaelsilvadev.com/Devices/Cypress-Dashboard-Test.jpg "Cypress Dashboard Test")](http://https://rafaelsilvadev.com/Devices/Cypress-Dashboard-Test.jpg "Cypress Dashboard Test")

[![Cypress Devices Test](https://rafaelsilvadev.com/Devices/Cypress-Devices-Test.jpg "Cypress Devices Test")](https://rafaelsilvadev.com/Devices/Cypress-Devices-Test.jpg "Cypress Devices Test")

> **IMPORTANT**
> It's preferable to run the tests right after seeding the database, as some tests depend on these results.



------------



Thank you for read until here!
Case you have some trouble to run or some doubt don't hesitate to get in touch.

**Rafael F. da Silva**
[https://rafaelsilvadev.com/](https://rafaelsilvadev.com/ "https://rafaelsilvadev.com/")