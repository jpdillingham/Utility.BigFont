# BigFont
A C# class for transforming strings into large, stylized characters.

## Why?
For fun, and because I needed something that would improve readability of big log files by adding something that would stick out when scrolling through them.

## Usage

### Default/Large Font
```c#
foreach (string s in BigFont.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Large))
    Console.WriteLine(s);
```

### Output

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

### Other Sizes and Fonts

#### Medium Block

```c#
foreach (string s in BigFont.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Medium))
    Console.WriteLine(s);
```

#### Output

```
██   ██ ██████ ██       ██       ▄██████▄      ██      ██ ▄██████▄ █████▄ ██       ██████▄
██   ██ ██     ██       ██       ██    ██      ██      ██ ██    ██ ██  ██ ██       ██   ▀██
██▄▄▄██ ██▄▄   ██       ██       ██    ██      ██      ██ ██    ██ ██  ██ ██       ██    ██
██▀▀▀██ ██▀▀   ██       ██       ██    ██      ██ ▄██▄ ██ ██    ██ █████▀ ██       ██    ██
██   ██ ██     ██       ██       ██    ██      ██▄█▀▀█▄██ ██    ██ ██▀█▄  ██       ██   ▄██
██   ██ ██████ ████████ ████████ ▀██████▀      ███▀  ▀███ ▀██████▀ ██ ▀██ ████████ ██████▀
```

#### Small Block

```c#
foreach (string s in BigFont.Generate("Hello World", BigFont.Font.Block, BigFont.FontSize.Small))
    Console.WriteLine(s);
```

#### Output

```
██  ██ █████ ██     ██     ▄█████▄    ██     ██ ▄█████▄ █████▄ ██     █████▄
██▄▄██ ██▄▄  ██     ██     ██   ██    ██     ██ ██   ██ ██  ██ ██     ██   ██
██▀▀██ ██▀▀  ██     ██     ██   ██    ██ ▄█▄ ██ ██   ██ ████▀  ██     ██   ██
██  ██ █████ ██████ ██████ ▀█████▀    ███▀ ▀███ ▀█████▀ ██ ▀█▄ ██████ █████▀
```

#### Large Graffiti

```c#
foreach (string s in BigFont.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Large))
    Console.WriteLine(s);
```

#### Output

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

```c#
foreach (string s in BigFont.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Medium))
    Console.WriteLine(s);
```

#### Output

```
  ██   █       ▄█████  █        █        ██████        █     █   ██████     █████  █       ██████▄
  ██   ██     ██   █  ██       ██       ██    ██      ██     ██ ██    ██   ██  ██ ██       ██   ▀██
 ▄██▄▄▄██▄▄  ▄██▄▄    ██       ██       ██    ██      ██     ██ ██    ██  ▄██▄▄█▀ ██       ██    ██
▀▀██▀▀▀██▀  ▀▀██▀▀    ██       ██       ██    ██      ██     ██ ██    ██ ▀███████ ██       ██    ██
  ██   ██     ██   █  ██▌    ▄ ██▌    ▄ ██    ██      ██ ▄█▄ ██ ██    ██   ██  ██ ██▌    ▄ ██   ▄██
  ██   ██     ███████ ████▄▄██ ████▄▄██  ██████        ███▀███   ██████    ██  ██ ████▄▄██ ██████▀
```

#### Small Graffiti

```c#
foreach (string s in BigFont.Generate("Hello World", BigFont.Font.Graffiti, BigFont.FontSize.Small))
    Console.WriteLine(s);
```

### Output

```
 ██  █    ▄████   █      █      █████      █   █   █████    █████  █     █████▄
 ██▄▄██▄  ██     ██     ██     ██   ██    ██   ██ ██   ██  ██  ██ ██     ██   ██
▀██▀▀██  ▀██▀▀   ██   ▄ ██   ▄ ██   ██    ██▄█▄██ ██   ██ ▄██▄▄█▀ ██   ▄ ██   ██
 ██  ██   ██████ ██▄▄██ ██▄▄██  █████      ██▀██   █████   ██  ██ ██▄▄██ █████▀
```

## Notes

The character strings were generated by the following application using the "Delta Corps Priest 1" font.  I created the number and punctuation characters in the same style.

http://patorjk.com/software/taag/

### Customization

## Configuration

### Default Font and Font Size

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
