# GraphQlGdpr
This is a demonstration of how GraphQl and Entity Framework can help your company being General Data Protection Regulation (GDPR) compliant. The GDPR requires companies to restrict the usage of personal data. If there is no purpose to use the data, the data should not be used. GraphQl can help companies with that.

GraphQl is an alternative to REST. It makes it easy to specify the data that is really needed. Here is an example of such a query.

```graphql
{
  person(id: 2)
  {
    lastName
    streetName
  }
}
````

The query above requests the data of a person with id 2. It also specifies the data that is really needed (last name and street name). The expected output is this:

````json
{
  "data": {
    "person": {
        "lastName": "Jansen",
        "streetName": "Wagenstraat"
    }
  }
}
````

The project includes a playground to write and create queries. Here is how this playground looks like.

![image](https://raw.githubusercontent.com/ConnectingApps/GraphQlGdpr/master/PlayGround.png)

To test the project, it is recommended to install a recent version of both Git and Docker first. Also .NET Core 2.2 (the SDK) needs to be installed. It has been tested with .NET Core 2.204 .

Here are the command-line statements to use:

````bash
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=PassaP@s" -p 1433:1433 --name GraphQlGdpr -d mcr.microsoft.com/mssql/server:2017-latest
git clone https://github.com/ConnectingApps/GraphQlGdpr.git
cd GraphQlGdpr
cd GraphQlGdpr.Api 
dotnet run
````

The docker statement is just because a database is needed. 


