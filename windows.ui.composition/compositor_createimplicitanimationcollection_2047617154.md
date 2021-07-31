---
-api-id: M:Windows.UI.Composition.Compositor.CreateImplicitAnimationCollection
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.ImplicitAnimationCollection CreateImplicitAnimationCollection()
-->

# Windows.UI.Composition.Compositor.CreateImplicitAnimationCollection

## -description
Creates an instance of [ImplicitAnimationCollection](implicitanimationcollection.md).

Equivalent WinUI method: [Microsoft.UI.Composition.Compositor.CreateImplicitAnimationCollection](/windows/winui/api/microsoft.ui.composition.compositor.createimplicitanimationcollection).

## -returns
Returns the created [ImplicitAnimationCollection](implicitanimationcollection.md) object.

## -remarks

## -examples
```csharp

class PropertyAnimation 
{ 
  PropertyAnimation(Compositor compositor, SpriteVisual heroVisual, SpriteVisual listVisual) 
  { 
    // Define ImplicitAnimationCollection 
    ImplicitAnimationCollection implicitAnimations = compositor.CreateImplicitAnimationCollection(); 

    // Trigger animation when the “Offset” property changes. 
    implicitAnimations["Offset"] = CreateAnimation(compositor); 

    // Assign ImplicitAnimations to a visual. Unlike Visual.Children,     
    // ImplicitAnimations can be shared by multiple visuals so that they  
    // share the same implicit animation behavior (same as Visual.Clip). 
    heroVisual.ImplicitAnimations = implicitAnimations; 

    // ImplicitAnimations can be shared among visuals  
    listVisual.ImplicitAnimations = implicitAnimations; 

    listVisual.Offset = new Vector3(20f, 20f, 20f); 
  } 

  Vector3KeyFrameAnimation CreateAnimation(Compositor compositor) 
  { 
    Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation(); 
    animation.InsertExpressionKeyFrame(0f, "this.StartingValue"); 
    animation.InsertExpressionKeyFrame(1f, "this.FinalValue"); 
    animation.Target = “Offset”; 
    animation.Duration = TimeSpan.FromSeconds(0.25); 
    return animation; 
  } 

} 
          
          
```



## -see-also
