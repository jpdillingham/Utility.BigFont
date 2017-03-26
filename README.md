# BigFont

[![Build status](https://ci.appveyor.com/api/projects/status/6calauwc19uf1ygo?svg=true)](https://ci.appveyor.com/project/jpdillingham/utility-bigfont)
[![Build Status](https://travis-ci.org/jpdillingham/Utility.BigFont.svg?branch=master)](https://travis-ci.org/jpdillingham/Utility.BigFont)
[![codecov](https://codecov.io/gh/jpdillingham/Utility.BigFont/branch/master/graph/badge.svg)](https://codecov.io/gh/jpdillingham/Utility.BigFont)
[![NuGet version](https://img.shields.io/nuget/v/Utility.BigFont.svg)](https://www.nuget.org/packages/Utility.BigFont/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/jpdillingham/Utility.BigFont/blob/master/LICENSE)

A C# Class Library for transforming strings into large, stylized characters.

## Why?
For fun, and because I needed something that would improve readability of big log files by adding something that would stick out when scrolling through them.

## Installation 

Install from the NuGet gallery GUI or with the Package Manager Console using the following command:

```Install-Package BigFont```

## BigFont.BigFont

The ```BigFont``` class is the only type within the namespace. 

### Methods

#### Generate()

Generates a large string of characters corresponding to the input phrase.

Any character that doesn't exist in the alphabet will be replaced with a question mark.

##### Example

```c#
BigFontGenerator.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Large)
```

##### Output

```
███    ███ ████████ ███       ███        ▄██████▄         ███         ███  ▄██████▄  ████████▄   ███       ████████▄
███    ███ ███      ███       ███       ███    ███        ███         ███ ███    ███ ███    ███  ███       ███   ▀███
███    ███ ███      ███       ███       ███    ███        ███         ███ ███    ███ ███    ███  ███       ███    ███
███▄▄▄▄███ ███▄▄▄   ███       ███       ███    ███        ███         ███ ███    ███ ███    ███  ███       ███    ███
███▀▀▀▀███ ███▀▀▀   ███       ███       ███    ███        ███   ▄█▄   ███ ███    ███ ████████▀   ███       ███    ███
███    ███ ███      ███       ███       ███    ███        ███  ▄█▀█▄  ███ ███    ███ ███▀██▄     ███       ███    ███
███    ███ ███      ███       ███       ███    ███        ███ ▄█▀ ▀█▄ ███ ███    ███ ███  ▀██▄   ███       ███   ▄███
███    ███ ████████ █████████ █████████  ▀██████▀         █████▀   ▀█████  ▀██████▀  ███    ▀██▄ █████████ ████████▀
```

```c#
BigFontGenerator.GenerateCaseSensitive("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Large)
```

##### Output

```
   ▄█    █▄                                               ▄█     █▄
  ███    ███                                             ███     ███
  ███    ███      ▄█████  █        █        ██████       ███     ███  ██████     █████  █       ██████▄
 ▄███▄▄▄▄███▄▄   ██   █  ██       ██       ██    ██      ███     ███ ██    ██   ██  ██ ██       ██   ▀██
▀▀███▀▀▀▀███▀   ▄██▄▄    ██       ██       ██    ██      ███     ███ ██    ██  ▄██▄▄█▀ ██       ██    ██
  ███    ███   ▀▀██▀▀    ██       ██       ██    ██      ███     ███ ██    ██ ▀███████ ██       ██    ██
  ███    ███     ██   █  ██▌    ▄ ██▌    ▄ ██    ██      ███ ▄█▄ ███ ██    ██   ██  ██ ██▌    ▄ ██   ▄██
  ███    █▀      ███████ ████▄▄██ ████▄▄██  ██████        ▀███▀███▀   ██████    ██  ██ ████▄▄██ ██████▀
```


### Other Sizes and Fonts

#### Medium Block

##### Example

```c#
foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Medium))
    Console.WriteLine(s);
```

##### Output

```
██   ██ ██████ ██       ██       ▄██████▄      ██      ██ ▄██████▄ █████▄ ██       ██████▄
██   ██ ██     ██       ██       ██    ██      ██      ██ ██    ██ ██  ██ ██       ██   ▀██
██▄▄▄██ ██▄▄   ██       ██       ██    ██      ██      ██ ██    ██ ██  ██ ██       ██    ██
██▀▀▀██ ██▀▀   ██       ██       ██    ██      ██ ▄██▄ ██ ██    ██ █████▀ ██       ██    ██
██   ██ ██     ██       ██       ██    ██      ██▄█▀▀█▄██ ██    ██ ██▀█▄  ██       ██   ▄██
██   ██ ██████ ████████ ████████ ▀██████▀      ███▀  ▀███ ▀██████▀ ██ ▀██ ████████ ██████▀
```

#### Small Block

##### Example

```c#
foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Small))
    Console.WriteLine(s);
```

##### Output

```
██  ██ █████ ██     ██     ▄█████▄    ██     ██ ▄█████▄ █████▄ ██     █████▄
██▄▄██ ██▄▄  ██     ██     ██   ██    ██     ██ ██   ██ ██  ██ ██     ██   ██
██▀▀██ ██▀▀  ██     ██     ██   ██    ██ ▄█▄ ██ ██   ██ ████▀  ██     ██   ██
██  ██ █████ ██████ ██████ ▀█████▀    ███▀ ▀███ ▀█████▀ ██ ▀█▄ ██████ █████▀
```

#### Large Graffiti

##### Example

```c#
foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Large))
    Console.WriteLine(s);
```

##### Output

```
   ▄█    █▄       ▄████████  ▄█        ▄█        ▄██████▄          ▄█     █▄   ▄██████▄     ▄████████  ▄█       ████████▄
  ███    ███     ███    ███ ███       ███       ███    ███        ███     ███ ███    ███   ███    ███ ███       ███   ▀███
  ███    ███     ███    █▀  ███       ███       ███    ███        ███     ███ ███    ███  ▄███▄▄▄▄██▀ ███       ███    ███
 ▄███▄▄▄▄███▄▄  ▄███▄▄▄     ███       ███       ███    ███        ███     ███ ███    ███ ▀▀███▀▀▀▀▀   ███       ███    ███
▀▀███▀▀▀▀███▀  ▀▀███▀▀▀     ███       ███       ███    ███        ███     ███ ███    ███ ▀███████████ ███       ███    ███
  ███    ███     ███    █▄  ███       ███       ███    ███        ███     ███ ███    ███   ███    ███ ███       ███    ███
  ███    ███     ███    ███ ███▌    ▄ ███▌    ▄ ███    ███        ███ ▄█▄ ███ ███    ███   ███    ███ ███▌    ▄ ███   ▄███
  ███    █▀      ██████████ █████▄▄██ █████▄▄██  ▀██████▀          ▀███▀███▀   ▀██████▀    ███    ███ █████▄▄██ ████████▀
```

#### Medium Graffiti

##### Example

```c#
foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Medium))
    Console.WriteLine(s);
```

##### Output

```
  ██   █       ▄█████  █        █        ██████        █     █   ██████     █████  █       ██████▄
  ██   ██     ██   █  ██       ██       ██    ██      ██     ██ ██    ██   ██  ██ ██       ██   ▀██
 ▄██▄▄▄██▄▄  ▄██▄▄    ██       ██       ██    ██      ██     ██ ██    ██  ▄██▄▄█▀ ██       ██    ██
▀▀██▀▀▀██▀  ▀▀██▀▀    ██       ██       ██    ██      ██     ██ ██    ██ ▀███████ ██       ██    ██
  ██   ██     ██   █  ██▌    ▄ ██▌    ▄ ██    ██      ██ ▄█▄ ██ ██    ██   ██  ██ ██▌    ▄ ██   ▄██
  ██   ██     ███████ ████▄▄██ ████▄▄██  ██████        ███▀███   ██████    ██  ██ ████▄▄██ ██████▀
```

#### Small Graffiti

##### Example

```c#
foreach (string s in BigFontGenerator.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Small))
    Console.WriteLine(s);
```

##### Output

```
 ██  █    ▄████   █      █      █████      █   █   █████    █████  █     █████▄
 ██▄▄██▄  ██     ██     ██     ██   ██    ██   ██ ██   ██  ██  ██ ██     ██   ██
▀██▀▀██  ▀██▀▀   ██   ▄ ██   ▄ ██   ██    ██▄█▄██ ██   ██ ▄██▄▄█▀ ██   ▄ ██   ██
 ██  ██   ██████ ██▄▄██ ██▄▄██  █████      ██▀██   █████   ██  ██ ██▄▄██ █████▀
```

## Notes

The character strings were generated by the following application using the "Delta Corps Priest 1" font.  I created the number and punctuation characters in the same style.

http://patorjk.com/software/taag/

## Configuration

### Modify Default Font and Font Size

Configure the default font and font size for the class by changing the two constant variables in the ```Variables``` region:

```c#
#region Variables

/// <summary>
/// The default font.
/// </summary>
private const Font defaultFont = Font.Block;

/// <summary>
/// The default font size.
/// </summary>
private const FontSize defaultFontSize = FontSize.Large;

#endregion
```

### Programmatically Change Defaults

Modify the ```DefaultFont``` and ```DefaultFontSize``` properties upon the first usage of the class to change the default values.  This will override defaults specified in the ```Variables``` section.

```c#
BigFont.DefaultFont = BigFont.Font.Block;
BigFont.DefaultFontSize = BigFont.FontSize.Large;
```

Acceptable values can be found in the ```Font``` and ```FontSize``` enumerations, but are:

Fonts:
* Font.Block
* Font.Graffiti

Font Sizes:
* FontSize.Large
* FontSize.Medium
* FontSize.Small

### Additional Fonts and Font Sizes

Additional fonts and font sizes can be added by adding new values corresponding to the new size and/or font to the ```Font``` and ```FontSize``` enumerations, then by adding additional statements within the ```BigFont()``` constructor, copying the existing functionality.  ```Alphabet.Add()``` statements should reference the appropriate font and font size enumeration values corresponding to the letter being added.
