---
-api-id: P:Windows.Globalization.CalendarIdentifiers.Korean
-api-type: winrt property
---

<!-- Property syntax
public string Korean { get; }
-->

# Windows.Globalization.CalendarIdentifiers.Korean

## -description
Gets the identifier for the Korean calendar.

## -property-value
The string "KoreanCalendar", which is the identifier for the Korean calendar.

## -remarks

The Korean calendar is exactly like the [Gregorian](calendaridentifiers_gregorian.md) calendar, except that the year and era are different.

The Korean calendar system recognizes only the current era.

Leap years in the Korean calendar correspond to the same leap years in the Gregorian calendar. A leap year in the Gregorian calendar is defined as a Gregorian year that is evenly divisible by four, except if it is divisible by 100. However, Gregorian years that are divisible by 400 are leap years. A common year has 365 days and a leap year has 366 days.

The Korean calendar has 12 months with 28 to 31 days each:<table>
   <tr><th>[MonthAsNumericString](calendar_monthasnumericstring_952914344.md)</th><th>Month</th><th>Days in common years</th><th>Days in leap years</th></tr>
   <tr><td>1</td><td>1월 (January)</td><td>31</td><td>31</td></tr>
   <tr><td>2</td><td>2월 (February)</td><td>28</td><td>29</td></tr>
   <tr><td>3</td><td>3월 (March)</td><td>31</td><td>31</td></tr>
   <tr><td>4</td><td>4월 (April)</td><td>30</td><td>30</td></tr>
   <tr><td>5</td><td>5월 (May)</td><td>31</td><td>31</td></tr>
   <tr><td>6</td><td>6월 (June)</td><td>30</td><td>30</td></tr>
   <tr><td>7</td><td>7월 (July)</td><td>31</td><td>31</td></tr>
   <tr><td>8</td><td>8월 (August)</td><td>31</td><td>31</td></tr>
   <tr><td>9</td><td>9월 (September)</td><td>30</td><td>30</td></tr>
   <tr><td>10</td><td>10월 (October)</td><td>31</td><td>31</td></tr>
   <tr><td>11</td><td>11월 (November)</td><td>30</td><td>30</td></tr>
   <tr><td>12</td><td>12월 (December)</td><td>31</td><td>31</td></tr>
</table>

February has 29 days during leap years and 28 days during common years.

The date January 1, 2012 A.D. in the Gregorian calendar is equivalent to the first day of January in the year 4345 of the current era in the Korean calendar.

Because the Korean calendar corresponds to the Gregorian calendar, Korean calendar strings for day of the week names and month names are localized for all supported locales and hence will appear in the language corresponding to the [ResolvedLanguage](calendar_resolvedlanguage.md) property of the calendar object.

## -examples

## -see-also
[ResolvedLanguage](calendar_resolvedlanguage.md)