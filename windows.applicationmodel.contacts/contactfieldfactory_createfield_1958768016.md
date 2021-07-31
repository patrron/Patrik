---
-api-id: M:Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateField(System.String,System.String,Windows.ApplicationModel.Contacts.ContactFieldType,Windows.ApplicationModel.Contacts.ContactFieldCategory)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactField CreateField(System.String name, System.String value, Windows.ApplicationModel.Contacts.ContactFieldType type, Windows.ApplicationModel.Contacts.ContactFieldCategory category)
-->

# Windows.ApplicationModel.Contacts.ContactFieldFactory.CreateField

## -description
> [!NOTE]
> [IContactFieldFactory](icontactfieldfactory.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactPhone](contactphone.md) or [ContactEmail](contactemail.md).

Creates a field to contain information about a contact.

## -parameters
### -param name
The name of the field.

### -param value
The value of the field.

### -param type
The type of field.

### -param category
The category the field belongs to.

## -returns
Contains a field that you can add to a [Contact](contact.md) object.

## -remarks

## -examples

## -see-also
[CreateField(String, ContactFieldType)](contactfieldfactory_createfield_1723791966.md), [CreateField(String, ContactFieldType, ContactFieldCategory)](contactfieldfactory_createfield_377552818.md)
## -capabilities
contactsSystem
