---
-api-id: T:Windows.ApplicationModel.Contacts.ContactInstantMessageField
-api-type: winrt class
---

<!-- Class syntax.
public class ContactInstantMessageField : Windows.ApplicationModel.Contacts.IContactField, Windows.ApplicationModel.Contacts.IContactInstantMessageField
-->

# Windows.ApplicationModel.Contacts.ContactInstantMessageField

## -description
Defines a field that is an instant messaging (IM) address.

## -remarks
Your app receives a collection of ContactInstantMessageField objects when a contact provider returns the requested contact information. You can access these objects through the [ContactInformation.InstantMessages](contactinformation_instantmessages.md) property.

## -examples
This code demonstrates the use of the ContactInstantMessageField object.



[!code-js[ContactsKnownFields_IM](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsKnownFields_IM)]

## -see-also

## -capabilities
contactsSystem
