---
-api-id: P:Windows.ApplicationModel.Contacts.KnownContactField.PhoneNumber
-api-type: winrt property
---

<!-- Property syntax
public string PhoneNumber { get; }
-->

# Windows.ApplicationModel.Contacts.KnownContactField.PhoneNumber

## -description
> [!NOTE]
> [KnownContactField](knowncontactfield.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md), [ContactPhone](contactphone.md), [ContactConnectedServiceAccount](contactconnectedserviceaccount.md), or [ContactEmail](contactemail.md).

Contains the name of the field used for phone numbers.

## -property-value
The name of the field.

## -remarks
Use this property with the [ContactPicker.DesiredFields](contactpicker_desiredfields.md) property to specify that you want to get the phone numbers of a contact.

## -examples
This code demonstrates how to get a phone number of a contact.



[!code-js[ContactsKnownFields_phone](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsKnownFields_phone)]

## -see-also

## -capabilities
contactsSystem
