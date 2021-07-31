---
-api-id: M:Windows.Devices.PointOfService.ClaimedJournalPrinter.ValidateData(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool ValidateData(System.String data)
-->

# Windows.Devices.PointOfService.ClaimedJournalPrinter.ValidateData

## -description
Determines if a [JournalPrintJob](journalprintjob.md) can successfully execute a print instruction with the specified data.

## -parameters
### -param data
The data sequence that you want to validate before you use it with the [JournalPrintJob.Print](journalprintjob_print_1512698335.md) method. This sequence may include printable data and escape sequences.

If the sequence is not valid, and you use it with [JournalPrintJob.Print](journalprintjob_print_1512698335.md) anyways, the job fails when you run it with [JournalPrintJob.ExecuteAsync](journalprintjob_executeasync_2108924004.md). You cannot remove a print instruction that uses an invalid data sequence after you add the instruction to the job with [JournalPrintJob.Print](journalprintjob_print_1512698335.md).

## -returns
True if the data passes validation; otherwise false.

## -remarks

## -examples

## -see-also
[ICommonClaimedPosPrinterStation.ValidateData](icommonclaimedposprinterstation_validatedata_977746434.md), [JournalPrintJob.Print](journalprintjob_print_1512698335.md), [JournalPrintJob.ExecuteAsync](journalprintjob_executeasync_2108924004.md)