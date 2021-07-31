---
-api-id: T:Windows.Devices.PointOfService.JournalPrintJob
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class JournalPrintJob : Windows.Devices.PointOfService.IPosPrinterJob
-->

# Windows.Devices.PointOfService.JournalPrintJob

## -description
Represents a set of printing instructions that you want to run on the journal printer station.

## -remarks
To create a new print job for the journal printer, call [ClaimedJournalPrinter.CreateJob](claimedjournalprinter_createjob_1417454808.md).
The created print job object is valid as long as the ClaimedJournalPrinter object that created it is valid.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | FeedPaperByLine |
| 1903 | 18362 | FeedPaperByMapModeUnit |
| 1903 | 18362 | Print(String,PosPrinterPrintOptions) |

## -examples

## -see-also
[IPosPrinterJob](iposprinterjob.md), [ClaimedJournalPrinter.CreateJob](claimedjournalprinter_createjob_1417454808.md)
