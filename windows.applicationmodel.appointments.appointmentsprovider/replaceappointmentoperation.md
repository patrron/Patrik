---
-api-id: T:Windows.ApplicationModel.Appointments.AppointmentsProvider.ReplaceAppointmentOperation
-api-type: winrt class
---

<!-- Class syntax.
public class ReplaceAppointmentOperation : Windows.ApplicationModel.Appointments.AppointmentsProvider.IReplaceAppointmentOperation
-->

# Windows.ApplicationModel.Appointments.AppointmentsProvider.ReplaceAppointmentOperation

## -description
Represents the operation object associated with replacing an appointment. Appointments provider apps use this info to perform the operation.

## -remarks
This class is used as the value of the ReplaceAppointmentOperation event data property from the [AppointmentsProviderRemoveAppointmentActivatedEventArgs](../windows.applicationmodel.activation/appointmentsproviderremoveappointmentactivatedeventargs.md) event data class. An appointments provider app typically goes through a series of casts and property checks starting from the [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md) event data of a general activation event handler. If the activation indicates that it's an **AppointmentsProvider** app activation kind with **Remove** as the verb, then it's appropriate to cast event data to [AppointmentsProviderRemoveAppointmentActivatedEventArgs](../windows.applicationmodel.activation/appointmentsproviderremoveappointmentactivatedeventargs.md).

Providers call methods of ReplaceAppointmentOperation to indicate whether the operation was completed, was canceled, or when a provider error prevented the operation from being completed. Calling these methods influences the async results that the activating app gets back from one of its [ShowReplaceAppointmentAsync](/uwp/api/windows.applicationmodel.appointments.appointmentmanager.showreplaceappointmentasync) calls. All of the reporting methods ([ReportCompleted](replaceappointmentoperation_reportcompleted_458863373.md), [ReportCanceled](replaceappointmentoperation_reportcanceled_1921025216.md), [ReportError](replaceappointmentoperation_reporterror_1034694985.md)) dismiss the Replace Appointment UI.

## -examples

## -see-also

## -capabilities
appointmentsSystem
