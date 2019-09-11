# GraphQlGdpr
This is a demonstration of how GraphQl and Entity Framework can help your company being General Data Protection Regulation (GDPR) compliant. The GDPR requires companies to be restrict the usage of personal data. If there is no purpose to use the data, the data should not be used. GraphQl can help companies with that.

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

The query above requests the data of a person with id 1. It also specifies the data that is really needed (last name and street name). The expected output is this:

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


