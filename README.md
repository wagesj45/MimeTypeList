# MimeTypeList
Provides a hard-coded collection of file extension and mime type mapping. This project was inspired by [samuelneff/MimeTypeMap](https://github.com/samuelneff/MimeTypeMap). This project uses the data from that project to create classes with members for each extension and mime type for lookups.

You can access the values with the `FileExtensions` and `MimeTypes` static classes:

```c#
FileExtensions._ruleset
MimeTypes.application.onenote
```

## Installation 

You can install MimeTypeList from [Nuget.org](https://www.nuget.org/) on its [package page](https://www.nuget.org/packages/MimeTypeList/1.0.0).

## Usage

After installation MimeTypeList, include the following using statement in your class:

```cs
using MimeTypeList;
```

### Getting Extensions

```cs
Console.WriteLine(MimeTypes.application.onenote); // ".one"
```

### Getting Mime Types

```cs
Console.WriteLine(FileExtensions._ruleset); // "application/xml"
```
