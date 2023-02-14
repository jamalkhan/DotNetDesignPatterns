# Factory Method C#
Factory Method is a design pattern that defines an interface for creating an object, but the creation logic is abstraction from the client.

| Difficulty | Easy |

## Example Use Cases
### Multiple external APIs that perform similar functionality but on separate SaaS platforms
Let's say, for example, you've got an CRM SaaS application that uses either Dynamics or SalesForce as it's underlying data platform. A given customer may have their Contact data persisted to the corresponding Dynamics or to Salesforce objects, and instantiation of your clients vary based on customer specific configuration settings.

With a Factory Method implementation, you could, for example, have code like this on your Contact form...

`
  var contactDetails = GetContactDetailsFromForm();
  var contactApi = _creator.GetApi();
  contactApi.UpdateContact(contactDetails);
`

_creator, you'll notice abstracts the creation of the contactAPI, returning an abstract contactAPI. Buried within the _creator.GetApi() method, your code may for example, check for the existence of a SalesForce.config or Dynamics.config record, which may have completely different structures, and based on which one it finds, it then creates an instance of the appropriate Api, e.g., SalesforceContactApi.

This abstraction allows usage of the Api to be apathetic to the underlying configuration loading.
