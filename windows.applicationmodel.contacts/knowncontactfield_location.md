---
-api-id: P:Windows.ApplicationModel.Contacts.KnownContactField.Location
-api-type: winrt property
---

<!-- Property syntax
public string Location { get; }
-->

# Windows.ApplicationModel.Contacts.KnownContactField.Location

## -description
> [!NOTE]
> [KnownContactField](knowncontactfield.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md), [ContactPhone](contactphone.md), [ContactConnectedServiceAccount](contactconnectedserviceaccount.md), or [ContactEmail](contactemail.md).

Contains the name of the field used for the contact's location.

## -property-value
The name of the field.

## -remarks
Use this property with the [ContactPicker.DesiredFields](contactpicker_desiredfields.md) property to specify that you want to get the location of a contact.

## -examples
This code demonstrates how to get the location of a contact.



[!code-js[ContactsKnownFields_location](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsKnownFields_location)]

## -see-also

## -capabilities
contactsSystem
