# _Word Counter_

#### _Count word Repetition, {10/4/2019}_

#### By _**Devin Cooley**_

## Description

_The purpose of this application is to take a word and a sentence from a user, then count the number of occurances of that word in the sentence._

## Specifications

### User Interface

| Spec                      |Input          | Output |
|:---------------------------|:-------------|:------|
|Takes a single word input to be checked for.|"pickle","two pickle"|true, Error|
|Converts all words in sentence and keyword to lower case for comparison|"Pickle","Two Pickle"|"pickle","two pickle"|
|Converts sentence into a list of words to be checked(solving pickle vs pickles issue)|"two pickle"|"two","pickle"|
|If the sentence does not contain the string, program notifies user|"pickle", "Contains no PickleS"|"The sentence does not contain 'pickle'."|
|Counts the number of instances of keyword in sentence|"I pickle, you pickle, we all pickle!"|3|

## Setup/Installation Requirements

_Make sure you have the neccessary software installed to run C# and .NET from your console. Clone the project repository and navigate into the root directory with your console.  Run the program with .NET. If you would like to run or manage tests, navigate to the WordCounter.Tests file and run a "dotnet restore"._

## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Send any questions or comments to Devin Cooley at dcooley1350@gmail.com._

## Technologies Used

_This program was written using C# and the .NET Framework._

### License

*This software is licensed under the MIT license.*

Copyright (c) 2016 **_Devin Cooley_**