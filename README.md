# _Word Counter C#_

#### _Word Counter C#, 4/27/18_

#### By _**Randy Weyer**_

## Description

_A website that counts the number of times a given word appears in a list of words._

### Specs
| Spec | Input | Output | Description |
| :-------------     | :------------- | :------------- |  :------------- |
| **One Letter Match** | Word: "a" <br/>List of words: "a" | 1 | Basic Function |
| **One Letter Match with Multiple Words in List** | Word: "a" <br/>List of words: "I", "a" | 1 | List becomes more complicated |
| **Two Letter Match** | Word: "in" <br/>List of words: "an", "in" | 1 | Matching becomes more complicated |
| **Six Letter Match** | Word: "inside" <br/>List of words: "a", "inside" | 1 | Can count longer strings |
| **One Letter Matches Regardless of Capitalization** | Word: "i" <br/>List of words: "a", "I" | 1 | Capitalization will still match words |
| **Six Letter Matches with Abnormal Capitalization** | Word: "iNSidE" <br/>List of words: "a", "inside" | 1 | Abnormal capitalization will still match words |
| **No Input** | Word: "" <br/>List of words: "" | 0 | Expect the condition that user doesn't enter any value |
| **Partial Match** | Word: "a" <br/>List of words: "an" | 0 | Prevent partial matches from incrementing counter |
| **No Matches Found** | Word: "outside" <br/>List of words: "a", "an", "in", "inside" | 0 | Expect the condition that there is no match |
| **Incorrect Input (Number)** | Word: "5" <br/>List of words: "a" | Test will not run | Prevent numbers as input |
| **Incorrect Input (No Letter Values)** | Word: "!#$%^&*()<>?{}\,./;[]1234567890" <br/>List of words: "a" | Test will not run | Only allow words that have letters |
## Setup/Installation Requirements

* _Clone or download the repository._
* _If downloaded, unzip the files into a single directory._
* _Open the Windows PowerShell and move to the main directory \WordCounter.Solutions_
* _Run "dotnet restore" in the PowerShell in the folder \WordCounter.Solutions\WordCounter_
* _Run "dotnet restore" in the PowerShell in the folder \WordCounter.Solutions\WordCounter.Tests_
* _To run tests, run "dotnet test" in the PowerShell in the folder \WordCounter.Solutions\WordCounter.Tests_
* _To view the website, run "dotnet run" in the PowerShell in the folder \WordCounter.Solutions\WordCounter_
* _Open a web browser (Firefox or Chrome for best results)._
* _Enter "localhost:5000" into the address bar._

## Known Bugs

_No known bugs in this version._

## Support and contact details

_If you would like to contact me for any further information or update requests, email me at RandyPWeyer@gmail.com_

## Technologies Used

_C#, HTML/CSS, Bootstrap_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Randy Weyer_**
