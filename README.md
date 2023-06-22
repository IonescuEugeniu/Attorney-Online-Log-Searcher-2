# Attorney Online: Log Searcher 2
Log Searcher 2 is a tool made with the sole purpose of scouring through the dozens and possibly hundreds of .log files stored inside the /logs folders of Attorney Online clients. The application is standalone and the project is not associated with any other Attorney Online development project, official or otherwise.

The project is written in C# and uses [.NET 6](https://dotnet.microsoft.com/en-us/download).

## Usage
LS2 aims to function similar to an image board search engine, allowing the use of multiple, case-insensitive search terms and the use of prefixes to adjust searches.
### "Optional" and "Required" Search Terms
Search terms are categorized into "optional" and "required" with the use of prefixes when the search button is clicked. The program will make use of these categories like this:
```
if (ArrayContainsAny(line, termsOptional) && ArrayContainsAll(line, termsRequired))
{
    rtb_logOutput.Text += "<" + file + ">" + "\n" + line + "\n";
}
```
If the string contains any of the "optional" terms and all of the "required" terms, the string and the file of origin's path will be displayed in the program window. Note that you are not required to have both of each category of search terms, only one.
### Special Characters
```
; - separates search terms;
? - term is optional;
! - term is required.
```
Terms will be assumed to be "optional" by default.

## Credits
The  logo is an edit of the Attorney Online logo, designed by Lucas Carbi. The characters depicted in the logo are owned by Capcom.
### Microsoft Windows API Codepack
This project uses [Microsoft Windows API Code Pack](https://github.com/Wagnerp/Windows-API-CodePack-NET) v7.0.4, originally developed by Microsoft Corp., modified by Jacob Slusser, and further modified by Peter Wagner (Wagnerp).
