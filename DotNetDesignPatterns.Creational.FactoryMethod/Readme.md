# Factory Method C#
Factory Method is a design pattern that defines an interface for creating an object, but subclasses decide which implementation to instatiante.

## Thoughts
Factory Method is a great pattern to use when there are shared methods and properties, but the implementation varies between use cases.

## Example Use Cases
### Multiple external APIs that perform similar functionality but on separate SaaS platforms
Let's say, for example, you've got an CRM SaaS application that uses either Dynamics or SalesForce as it's underlying data platform. A given customer may have their Contact data persisted to the corresponding Dynamics or to Salesforce objects, but you the basic interopability is the same between the platforms.

With a Factory method implementation, you could, for example, have code like this on your Contact form...

`
  var contactDetails = GetContactDetailsFromForm();
  var contactApi = _creator.GetApi();
  contactApi.UpdateContact(contactDetails);
`

_creator, for example, could be passed as a constructor parameter or there may be separate logic that reads the customer configuration on class creation.

_creator.GetApi() would return a concrete instance of the abstract class ContactApi.

Those concrete implementations, SalesforceContactApi or DynamicsContactApi, would then know how to make the appropriate API calls (SOAP, REST, etc.) to the respective services in order to update the contact.

At a later date, you could also implement other CRM Api Providers, for example, Oracle, Sugar, etc., and doing so would only require creating a compatible ContactApi implementation and modifying _creator.GetApi() to support returning the respective new ContactApi object.