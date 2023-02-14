# Abstract Factory Pattern
Abstract Factory is a creational design pattern, which solves the problem of creating entire product families without specifying their concrete classes. Abstract Factory defines an interface for creating all distinct products but leaves the actual product creation to concrete factory classes.

## Thoughts
Abstract Factory is a great pattern to use when there are shared methods and properties, but the implementation varies between use cases.

## Example Use Cases
### Multiple external APIs that perform similar functionality but on separate SaaS platforms
Let's say, for example, you've got an CRM SaaS application that uses either Dynamics or SalesForce as it's underlying data platform. A given customer may have their Contact data persisted to the corresponding Dynamics or to Salesforce objects, but the basic interopability (methods, functions) is the same between the platforms.

With a Factory method implementation, you could, for example, have code like this on your Contact form...

`
  var contactDetails = GetContactDetailsFromForm();
  var contactApi = _creator.GetApi();
  contactApi.UpdateContact(contactDetails);
`

_creator.GetApi() returns a concrete implementation of the Api, and those concrete implementations (e.g., SalesforceContactApi, DynamicsContactApi), would then know how to make the appropriate API calls (e.g., Rest, SOAP), to perform the respective actions (e.g., UpdateContact, GetContact, DeleteContact).

At a later date, you could also implement other CRM Api Providers, for example, Oracle, Sugar, etc., and doing so would only require creating a compatible ContactApi implementation and modifying _creator.GetApi() to support returning the respective new ContactApi object.