---
-api-id: P:Windows.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner
-api-type: winrt property
---

<!-- Property syntax.
public DependencyObject AccessKeyScopeOwner { get;  set; }
-->

# Windows.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner

## -description
Gets or sets a source element that provides the access key scope for this element, even if it's not in the visual tree of the source element.

Equivalent WinUI property: [Microsoft.UI.Xaml.Documents.TextElement.AccessKeyScopeOwner](/windows/winui/api/microsoft.ui.xaml.documents.textelement.accesskeyscopeowner).

## -property-value
The element that defines the access key scope.

## -remarks
The source element must have it's **IsAccessKeyScope** property set to **true**.

## -see-also
[UIElement.AccessKeyScopeOwner](./../windows.ui.xaml/uielement_accesskeyscopeowner.md)

## -examples

