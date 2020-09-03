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


## Donations

[![Donate with Trans Pay](https://support.jordanwages.com/static/donate-with-transpay-en.png)](https://support.jordanwages.com?project=3)

If you would like to donate to the development of **MimeTypeList**, please direct you donation to my [patron page](https://support.jordanwages.com) (powered by Stripe) or directly via my [PayPal.Me](https://www.paypal.me/wagesj45) page. You can also donate Ethereum [to my wallet](https://etherscan.io/address/0x917f3d67e2a7ec8884d241118ee829af57cc4afd).
