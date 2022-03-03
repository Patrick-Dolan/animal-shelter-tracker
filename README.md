# Animal Shelter Tracker

#### By _**Branden Clauson, Marni Sucher, and Patrick Dolan**_

#### _An animal tracking software site to log animals in their facility._

## Technologies Used

* C#
* .NET 5.0
* dotnet

## Description

An animal tracking software to track animals in the facility. You can track type of animals, add animals to the system, and lsit the animals available.

## Setup/Installation Requirements

* Download repo to your computer using either clone or the download link.
* Open the project in VScode or your terminal/IDE of choice.
* Create a <code>appsettings.json</code> file in the root directory of the project folder. And add the following code replacing anything in square brackets with the information it represents specific to the project database:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE-NAME-HERE];uid=[USER-ID-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

```

Example of complete appsettings.json:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=MySuperStrongPassword;"
  }
}

```
* CONTINUE WITH PROJECT SPECIFIC INSTRUCTIONS FROM HERE!

### Test Setup/Installation

* Open the repo on your editor of choice/terminal
* Navigate to ProjectName.Tests directory in your terminal
* Run the following command to setup testing:  
<code>dotnet restore</code>  
* Run tests by going to the test project in the terminal (ProjectName.Solution/ProjectName.Tests) and running the following command:  
<code>dotnet test</code>  

## Known Bugs

* _No known issues_

## Contact Me

Let me know if you run into any issues or have questions, ideas or concerns:  
dolanp1992@gmail.com

## License

_MIT_

Copyright (c) _2022_ _author name(s)_