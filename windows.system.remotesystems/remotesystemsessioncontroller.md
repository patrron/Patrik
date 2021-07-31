---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionController
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemSessionController 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionController

## -description
Handles the creation and management of a new remote session for other devices to join.

## -remarks
Every remote session has one participant that is the session's controller. Only the controller can specify options for the session, accept join requests from would-be participants, and remove participants from the session.

> [!IMPORTANT]
> You must confirm access to the remote system platform with a call to **[RemoteSystem.RequestAccessAsync](remotesystem_requestaccessasync_380675631.md)** before you instantiate this class.

## -see-also

## -examples
See the following code for an example of how to create a remote session and handle join requests.

```csharp

public async void StartNewSharedExperience() {
    
    var manager = new RemoteSystemSessionController("Bob’s Minecraft game");
    
    // register the following code to handle the JoinRequested event
    manager.JoinRequested += async (sender, args) => {
        // Get the deferral
        var deferral = args.GetDeferral();
        
        // display the participant (args.JoinRequest.Participant) on UI, giving the 
        // user an opportunity to respond
        // ...
        
        // If the user chooses "accept", accept this remote system as a participant
        args.JoinRequest.Accept();
    };
    
    // create and start the session
    RemoteSystemSessionCreationResult createResult = await manager.CreateSessionAsync();
    
    // handle the creation result
    if (createResult.Status == RemoteSystemSessionCreationStatus.Success) {
        // creation was successful
        RemoteSystemSession currentSession = createResult.Session;
        
        // optionally subscribe to the disconnection event
        currentSession.Disconnected += async (sender, args) => {
            // update the UI, using args.Reason
            // ...
        };
    
        // Use session ...
    
    } else if (createResult.Status == RemoteSystemSessionCreationStatus.SessionLimitsExceeded) {
        // creation failed. Optionally update UI to indicate that there are too many sessions in progress
    } else {
        // creation failed for an unknown reason. Optionally update UI
    }
}
```

## -capabilities
remoteSystem
