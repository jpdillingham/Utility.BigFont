/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █   ▀█████████▄                    ▄████████
      █     ███    ███                  ███    ███
      █     ███    ███  █     ▄████▄    ███    █▀   ██████  ██▄▄▄▄      ██
      █    ▄███▄▄▄██▀  ██    ██    ▀   ▄███▄▄▄     ██    ██ ██▀▀▀█▄ ▀███████▄
      █   ▀▀███▀▀▀██▄  ██▌  ▄██       ▀▀███▀▀▀     ██    ██ ██   ██     ██  ▀
      █     ███    ██▄ ██  ▀▀██ ███▄    ███        ██    ██ ██   ██     ██
      █     ███    ███ ██    ██    ██   ███        ██    ██ ██   ██     ██
      █   ▄█████████▀  █     ██████▀    ███         ██████   █   █     ▄██▀
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  BigFont transforms strings into large, stylized characters.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The MIT License (MIT)
      █
      █  Copyright (c) 2016 JP Dillingham (jp@dillingham.ws)
      █
      █  Permission is hereby granted, free of charge, to any person obtaining a copy
      █  of this software and associated documentation files (the "Software"), to deal
      █  in the Software without restriction, including without limitation the rights
      █  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
      █  copies of the Software, and to permit persons to whom the Software is
      █  furnished to do so, subject to the following conditions:
      █
      █  The above copyright notice and this permission notice shall be included in all
      █  copies or substantial portions of the Software.
      █
      █  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
      █  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
      █  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
      █  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
      █  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
      █  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
      █  SOFTWARE.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                               */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Utility.BigFont
{
    /// <summary>
    ///     Font type enumeration
    /// </summary>
    public enum Font
    {
        /// <summary>
        ///     Default font; DefaultFont property will be substituted when used.
        /// </summary>
        Default,

        /// <summary>
        ///     Block font.
        /// </summary>
        Block,

        /// <summary>
        ///     Graffiti font.
        /// </summary>
        Graffiti
    }

    /// <summary>
    ///     Font size enumeration; the integer value indicates the height in lines
    /// </summary>
    public enum FontSize
    {
        /// <summary>
        ///     Default size; DefaultFontSize property will be substituted when used.
        /// </summary>
        Default,

        /// <summary>
        ///     Large font size (8 lines).
        /// </summary>
        Large = 8,

        /// <summary>
        ///     Medium font size (6 lines).
        /// </summary>
        Medium = 6,

        /// <summary>
        ///     Small font size (4 lines).
        /// </summary>
        Small = 4
    }

    /// <summary>
    ///     BigFont transforms strings into large, stylized characters.
    /// </summary>
    public static class BigFontGenerator
    {
        #region Private Fields

        /// <summary>
        ///     The default font used to initialize the DefaultFont property.
        /// </summary>
        private const Font DefaultFont = Font.Block;

        /// <summary>
        ///     The default font size used to initialize the DefaultFontSize property.
        /// </summary>
        private const FontSize DefaultFontSize = FontSize.Large;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        ///     Initializes static members of the <see cref="BigFontGenerator"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1116:SplitParametersMustStartOnLineAfterDeclaration", Justification = "Reviewed.")]
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1118:ParameterMustNotSpanMultipleLines", Justification = "Reviewed.")]
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1115:ParameterMustFollowComma", Justification = "Reviewed.")]
        static BigFontGenerator()
        {
            // initialize the default properties
            CurrentFont = DefaultFont;
            CurrentFontSize = DefaultFontSize;

            // create the "Alphabet"
            Alphabet = new Dictionary<Tuple<char, Font, FontSize>, string[]>();

            /*
            █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
            █
            █  ████████▄  ███        ▄██████▄   ▄██████▄  ███    ▄██▀
            █  ███    ███ ███       ███    ███ ███    ███ ███  ▄██▀
            █  ███    ███ ███       ███    ███ ███    ███ ███▄██▀
            █  ███▄▄▄▄██▀ ███       ███    ███ ███        ████▀
            █  ███▀▀▀▀██▄ ███       ███    ███ ███        ████▄
            █  ███    ███ ███       ███    ███ ███    ███ ███▀██▄
            █  ███    ███ ███       ███    ███ ███    ███ ███  ▀██▄
            █  ████████▀  █████████  ▀██████▀   ▀██████▀  ███    ▀██▄
            █
            ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀ ▀                                 */

            Alphabet.Add(new Tuple<char, Font, FontSize>('A', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "██████████ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('B', Font.Block, FontSize.Large), new string[]
            {
                "████████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███▄▄▄▄██▀ ",
                "███▀▀▀▀██▄ ",
                "███    ███ ",
                "███    ███ ",
                "████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('C', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███        ",
                "███        ",
                "███    ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('D', Font.Block, FontSize.Large), new string[]
            {
                "████████▄  ",
                "███   ▀███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███   ▄███ ",
                "████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('E', Font.Block, FontSize.Large), new string[]
            {
                "████████ ",
                "███      ",
                "███      ",
                "███▄▄▄   ",
                "███▀▀▀   ",
                "███      ",
                "███      ",
                "████████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('F', Font.Block, FontSize.Large), new string[]
            {
                "████████ ",
                "███      ",
                "███      ",
                "███▄▄▄   ",
                "███▀▀▀   ",
                "███      ",
                "███      ",
                "███      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('G', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███        ",
                "███        ",
                "███  █████ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('H', Font.Block, FontSize.Large), new string[]
            {
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███▄▄▄▄███ ",
                "███▀▀▀▀███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('I', Font.Block, FontSize.Large), new string[]
            {
                "███ ",
                "███ ",
                "███ ",
                "███ ",
                "███ ",
                "███ ",
                "███ ",
                "███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('J', Font.Block, FontSize.Large), new string[]
            {
                "       ███ ",
                "       ███ ",
                "       ███ ",
                "       ███ ",
                "       ███ ",
                "       ███ ",
                "       ███ ",
                " ██▄  ▄███ ",
                "  ▀█████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('K', Font.Block, FontSize.Large), new string[]
            {
                "███    ▄██▀ ",
                "███  ▄██▀   ",
                "███▄██▀     ",
                "████▀       ",
                "████▄       ",
                "███▀██▄     ",
                "███  ▀██▄   ",
                "███    ▀██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('L', Font.Block, FontSize.Large), new string[]
            {
                "███       ",
                "███       ",
                "███       ",
                "███       ",
                "███       ",
                "███       ",
                "███       ",
                "█████████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('M', Font.Block, FontSize.Large), new string[]
            {
                "█████▄   ▄█████ ",
                "███ ▀█▄ ▄█▀ ███ ",
                "███  ▀█▄█▀  ███ ",
                "███   ▀█▀   ███ ",
                "███         ███ ",
                "███         ███ ",
                "███         ███ ",
                "███         ███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('N', Font.Block, FontSize.Large), new string[]
            {
                "███▄     ███ ",
                "████▄    ███ ",
                "███▀█▄   ███ ",
                "███ ▀█▄  ███ ",
                "███  ▀█▄ ███ ",
                "███   ▀█▄███ ",
                "███    ▀████ ",
                "███     ▀███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('O', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('P', Font.Block, FontSize.Large), new string[]
            {
                "████████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "████████▀  ",
                "███        ",
                "███        ",
                "███        "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Q', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███  ▀▄███ ",
                " ▀██████▀▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('R', Font.Block, FontSize.Large), new string[]
            {
                "████████▄   ",
                "███    ███  ",
                "███    ███  ",
                "███    ███  ",
                "████████▀   ",
                "███▀██▄     ",
                "███  ▀██▄   ",
                "███    ▀██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('S', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███        ",
                "▀██▄▄▄▄▄   ",
                "  ▀▀▀▀▀██▄ ",
                "       ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('T', Font.Block, FontSize.Large), new string[]
            {
                "███████████ ",
                "    ███     ",
                "    ███     ",
                "    ███     ",
                "    ███     ",
                "    ███     ",
                "    ███     ",
                "    ███     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('U', Font.Block, FontSize.Large), new string[]
            {
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('V', Font.Block, FontSize.Large), new string[]
            {
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                " ██▄  ▄██  ",
                "  ██▄▄██   ",
                "   ▀██▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('W', Font.Block, FontSize.Large), new string[]
            {
                "███         ███ ",
                "███         ███ ",
                "███         ███ ",
                "███         ███ ",
                "███   ▄█▄   ███ ",
                "███  ▄█▀█▄  ███ ",
                "███ ▄█▀ ▀█▄ ███ ",
                "█████▀   ▀█████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('X', Font.Block, FontSize.Large), new string[]
            {
                "▀██▄       ▄██▀ ",
                " ▀██▄     ▄██▀  ",
                "   ▀██▄ ▄██▀    ",
                "     ▀███▀      ",
                "     ▄███▄      ",
                "   ▄██▀ ▀██▄    ",
                " ▄██▀     ▀██▄  ",
                "▄██▀        ██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Y', Font.Block, FontSize.Large), new string[]
            {
                "▀██▄       ▄██▀ ",
                " ▀██▄     ▄██▀  ",
                "   ▀██▄ ▄██▀    ",
                "     ▀███▀      ",
                "      ███       ",
                "      ███       ",
                "      ███       ",
                "      ███       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Z', Font.Block, FontSize.Large), new string[]
            {
                "███████████ ",
                "      ▄██▀  ",
                "     ▄██▀   ",
                "    ▄██▀    ",
                "   ▄██      ",
                "  ▄██▀      ",
                " ▄██▀       ",
                "███████████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('1', Font.Block, FontSize.Large), new string[]
            {
                "▄████   ",
                "  ███   ",
                "  ███   ",
                "  ███   ",
                "  ███   ",
                "  ███   ",
                "  ███   ",
                "▄▄███▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('2', Font.Block, FontSize.Large), new string[]
            {
                " ▄███████▄  ",
                "██▀     ▄██ ",
                "       ▄██▀ ",
                "     ▄██▀   ",
                "   ▄██▀     ",
                " ▄██▀       ",
                "███▄        ",
                "███████████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('3', Font.Block, FontSize.Large), new string[]
            {
                "██████████▄  ",
                "         ███ ",
                "         ███ ",
                "    ▄▄▄███▀  ",
                "   ▀▀█████▄  ",
                "         ██▄ ",
                "         ███ ",
                "██████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('4', Font.Block, FontSize.Large), new string[]
            {
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "██████████ ",
                "       ███ ",
                "       ███ ",
                "       ███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('5', Font.Block, FontSize.Large), new string[]
            {
                "██████████ ",
                "███        ",
                "███        ",
                "████████▄  ",
                "       ███ ",
                "       ███ ",
                "       ███ ",
                "████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('6', Font.Block, FontSize.Large), new string[]
            {
                "  ▄██▀     ",
                "▄██▀       ",
                "███        ",
                "████████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('7', Font.Block, FontSize.Large), new string[]
            {
                "███████████ ",
                "        ▄██ ",
                "       ▄██▀ ",
                "      ▄██▀  ",
                "    ▄██▀    ",
                "  ▄██▀      ",
                "▄██▀        ",
                "███         "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('8', Font.Block, FontSize.Large), new string[]
            {
                " ▄███████▄  ",
                "███▀   ▀███ ",
                " ███   ███  ",
                "  ▀██▄██▀   ",
                "   ██▀██    ",
                " ▄██   ██▄  ",
                "███▄   ▄███ ",
                " ▀███████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('9', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                " ▀████████ ",
                "       ███ ",
                "       ███ ",
                " ███████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('0', Font.Block, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███ ▄█ ███ ",
                "███ █▀ ███ ",
                "███    ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(' ', Font.Block, FontSize.Large), new string[]
            {
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('(', Font.Block, FontSize.Large), new string[]
            {
                "  ▄██▀ ",
                " ██    ",
                "██     ",
                "██     ",
                "██     ",
                "██     ",
                " ██    ",
                "  ▀██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(')', Font.Block, FontSize.Large), new string[]
            {
                "▀██▄   ",
                "   ██  ",
                "    ██ ",
                "    ██ ",
                "    ██ ",
                "    ██ ",
                "   ██  ",
                "▄██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('[', Font.Block, FontSize.Large), new string[]
            {
                "██▀▀▀ ",
                "██    ",
                "██    ",
                "██    ",
                "██    ",
                "██    ",
                "██    ",
                "██▄▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(']', Font.Block, FontSize.Large), new string[]
            {
                "▀▀▀██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "▄▄▄██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('<', Font.Block, FontSize.Large), new string[]
            {
                "      ▄▄ ",
                "    ▄█▀  ",
                "  ▄█▀    ",
                "▄█▀      ",
                "▀█▄      ",
                "  ▀█▄    ",
                "    ▀█▄  ",
                "      ▀▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('>', Font.Block, FontSize.Large), new string[]
            {
                "▄▄       ",
                " ▀█▄     ",
                "   ▀█▄   ",
                "     ▀█▄ ",
                "     ▄█▀ ",
                "   ▄█▀   ",
                " ▄█▀     ",
                "▀▀       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('{', Font.Block, FontSize.Large), new string[]
            {
                "    ▄██▀ ",
                "   ██    ",
                "   ██    ",
                " ▄█▀     ",
                " ▀█▄     ",
                "   ██    ",
                "   ██    ",
                "    ▀██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('}', Font.Block, FontSize.Large), new string[]
            {
                "▀██▄    ",
                "   ██   ",
                "   ██   ",
                "    ▀█▄ ",
                "    ▄█▀ ",
                "   ██   ",
                "   ██   ",
                "▄██▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('/', Font.Block, FontSize.Large), new string[]
            {
                "       ▄█ ",
                "      ▄█▀ ",
                "     ▄█▀  ",
                "    ▄█▀   ",
                "   ▄█▀    ",
                "  ▄█▀     ",
                " ▄█▀      ",
                "▄█▀       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\\', Font.Block, FontSize.Large), new string[]
            {
                " █▄        ",
                " ▀█▄       ",
                "  ▀█▄      ",
                "   ▀█▄     ",
                "    ▀█▄    ",
                "     ▀█▄   ",
                "      ▀█▄  ",
                "       ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('.', Font.Block, FontSize.Large), new string[]
            {
                "    ",
                "    ",
                "    ",
                "    ",
                "    ",
                "    ",
                "▄▄▄ ",
                "███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(',', Font.Block, FontSize.Large), new string[]
            {
                "     ",
                "     ",
                "     ",
                "     ",
                "     ",
                "     ",
                " ▄▄▄ ",
                " ▄██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(':', Font.Block, FontSize.Large), new string[]
            {
                "      ",
                "      ",
                "███   ",
                "███   ",
                "      ",
                "███   ",
                "███   ",
                "      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(';', Font.Block, FontSize.Large), new string[]
            {
                "      ",
                "      ",
                " ███  ",
                " ███  ",
                "      ",
                " ███  ",
                " ▄██  ",
                "▀▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\'', Font.Block, FontSize.Large), new string[]
            {
                "██ ",
                "   ",
                "   ",
                "   ",
                "   ",
                "   ",
                "   ",
                "   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('"', Font.Block, FontSize.Large), new string[]
            {
                "██ ██ ",
                "      ",
                "      ",
                "      ",
                "      ",
                "      ",
                "      ",
                "      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('!', Font.Block, FontSize.Large), new string[]
            {
                "▄███▄ ",
                "█████ ",
                "█████ ",
                "█████ ",
                "▀███▀ ",
                " ███  ",
                "      ",
                " ███  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('?', Font.Block, FontSize.Large), new string[]
            {
                " ▄███████▄  ",
                "██▀    ▀███ ",
                "        ███ ",
                "    ▄▄▄██▀  ",
                "    ███     ",
                "    ███     ",
                "            ",
                "    ███     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('A', Font.Block, FontSize.Medium), new string[]
            {
                "▄█████▄ ",
                "██   ██ ",
                "██   ██ ",
                "███████ ",
                "██   ██ ",
                "██   ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('B', Font.Block, FontSize.Medium), new string[]
            {
                "██████▄ ",
                "██   ██ ",
                "██▄▄▄█▀ ",
                "██▀▀▀█▄ ",
                "██   ██ ",
                "██████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('C', Font.Block, FontSize.Medium), new string[]
            {
                "▄█████▄ ",
                "██   ██ ",
                "██      ",
                "██      ",
                "██   ██ ",
                "▀█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('D', Font.Block, FontSize.Medium), new string[]
            {
                "██████▄  ",
                "██   ▀██ ",
                "██    ██ ",
                "██    ██ ",
                "██   ▄██ ",
                "██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('E', Font.Block, FontSize.Medium), new string[]
            {
                "██████ ",
                "██     ",
                "██▄▄   ",
                "██▀▀   ",
                "██     ",
                "██████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('F', Font.Block, FontSize.Medium), new string[]
            {
                "██████ ",
                "██     ",
                "██▄▄   ",
                "██▀▀   ",
                "██     ",
                "██     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('G', Font.Block, FontSize.Medium), new string[]
            {
                "▄█████▄ ",
                "██   ██ ",
                "██      ",
                "██  ███ ",
                "██   ██ ",
                "▀█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('H', Font.Block, FontSize.Medium), new string[]
            {
                "██   ██ ",
                "██   ██ ",
                "██▄▄▄██ ",
                "██▀▀▀██ ",
                "██   ██ ",
                "██   ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('I', Font.Block, FontSize.Medium), new string[]
            {
                "██ ",
                "██ ",
                "██ ",
                "██ ",
                "██ ",
                "██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('J', Font.Block, FontSize.Medium), new string[]
            {
                "     ██ ",
                "     ██ ",
                "     ██ ",
                "     ██ ",
                "▄▄  ▄██ ",
                "▀█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('K', Font.Block, FontSize.Medium), new string[]
            {
                "██   ▄█▀ ",
                "██ ▄█▀   ",
                "███▀     ",
                "███▄     ",
                "██ ▀█▄   ",
                "██   ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('L', Font.Block, FontSize.Medium), new string[]
            {
                "██       ",
                "██       ",
                "██       ",
                "██       ",
                "██       ",
                "████████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('M', Font.Block, FontSize.Medium), new string[]
            {
                "███▄  ▄███ ",
                "██▀█▄▄█▀██ ",
                "██ ▀██▀ ██ ",
                "██      ██ ",
                "██      ██ ",
                "██      ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('N', Font.Block, FontSize.Medium), new string[]
            {
                "██     ██ ",
                "███▄   ██ ",
                "██▀█▄  ██ ",
                "██ ▀█▄ ██ ",
                "██  ▀█▄██ ",
                "██    ▀██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('O', Font.Block, FontSize.Medium), new string[]
            {
                "▄██████▄ ",
                "██    ██ ",
                "██    ██ ",
                "██    ██ ",
                "██    ██ ",
                "▀██████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('P', Font.Block, FontSize.Medium), new string[]
            {
                "██████▄ ",
                "██   ██ ",
                "██   ██ ",
                "██████▀ ",
                "██      ",
                "██      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Q', Font.Block, FontSize.Medium), new string[]
            {
                "▄█████▄  ",
                "██   ██  ",
                "██   ██  ",
                "██   ██  ",
                "██ ▀▄██  ",
                "▀█████▀▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('R', Font.Block, FontSize.Medium), new string[]
            {
                "██████▄ ",
                "██   ██ ",
                "██   ██ ",
                "██████▀ ",
                "██▀██▄  ",
                "██  ▀██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('S', Font.Block, FontSize.Medium), new string[]
            {
                "▄█████▄ ",
                "██   ▀▀ ",
                "██▄▄▄▄  ",
                " ▀▀▀▀██ ",
                "▄▄   ██ ",
                "▀█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('T', Font.Block, FontSize.Medium), new string[]
            {
                "████████ ",
                "   ██    ",
                "   ██    ",
                "   ██    ",
                "   ██    ",
                "   ██    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('U', Font.Block, FontSize.Medium), new string[]
            {
                "██   ██ ",
                "██   ██ ",
                "██   ██ ",
                "██   ██ ",
                "██   ██ ",
                "▀█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('V', Font.Block, FontSize.Medium), new string[]
            {
                "██    ██ ",
                "██    ██ ",
                "██    ██ ",
                "██    ██ ",
                " █▄  ▄█  ",
                "  ▀██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('W', Font.Block, FontSize.Medium), new string[]
            {
                "██      ██ ",
                "██      ██ ",
                "██      ██ ",
                "██ ▄██▄ ██ ",
                "██▄█▀▀█▄██ ",
                "███▀  ▀███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('X', Font.Block, FontSize.Medium), new string[]
            {
                "▀██▄   ▄██▀ ",
                " ▀██▄ ▄██▀  ",
                "   ▀███▀    ",
                "   ▄███▄    ",
                " ▄██▀ ▀██▄  ",
                "▄██▀   ▀██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Y', Font.Block, FontSize.Medium), new string[]
            {
                "▀██▄   ▄██▀ ",
                " ▀██▄ ▄██▀  ",
                "   ▀███▀    ",
                "    ▐█▌     ",
                "    ▐█▌     ",
                "    ▐█▌     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Z', Font.Block, FontSize.Medium), new string[]
            {
                "███████ ",
                "    ▄█▀ ",
                "   ▄█▀  ",
                "  ▄█▀   ",
                " ▄█▀    ",
                "███████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('1', Font.Block, FontSize.Medium), new string[]
            {
                "▄███   ",
                "  ██   ",
                "  ██   ",
                "  ██   ",
                "  ██   ",
                "▄▄██▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('2', Font.Block, FontSize.Medium), new string[]
            {
                " ▄█████▄  ",
                "██▀   ▄██ ",
                "    ▄██▀  ",
                " ▄██▀     ",
                "██▄       ",
                "█████████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('3', Font.Block, FontSize.Medium), new string[]
            {
                "███████▄  ",
                "      ███ ",
                "    ▄██▀  ",
                "   ▀▀██▄  ",
                "      ███ ",
                "███████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('4', Font.Block, FontSize.Medium), new string[]
            {
                "██   ██ ",
                "██   ██ ",
                "██   ██ ",
                "███████ ",
                "     ██ ",
                "     ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('5', Font.Block, FontSize.Medium), new string[]
            {
                "███████ ",
                "██      ",
                "██████▄ ",
                "     ██ ",
                "     ██ ",
                "██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('6', Font.Block, FontSize.Medium), new string[]
            {
                "▄██▀     ",
                "██       ",
                "███████▄ ",
                "██    ██ ",
                "██    ██ ",
                "▀██████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('7', Font.Block, FontSize.Medium), new string[]
            {
                "█████████ ",
                "      ▄██ ",
                "    ▄██▀  ",
                "  ▄██▀    ",
                "▄██▀      ",
                "███       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('8', Font.Block, FontSize.Medium), new string[]
            {
                "▄██▀▀██▄ ",
                "▀█▄  ▄█▀ ",
                "  ▀██▀   ",
                "  ▄██▄   ",
                "▄█▀  ▀█▄ ",
                "▀██▄▄██▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('9', Font.Block, FontSize.Medium), new string[]
            {
                "▄█████▄ ",
                "██   ██ ",
                "██   ██ ",
                "▀██████ ",
                "     ██ ",
                " █████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('0', Font.Block, FontSize.Medium), new string[]
            {
                " ▄████▄  ",
                "██    ██ ",
                "██ ▄█ ██ ",
                "██ █▀ ██ ",
                "██    ██ ",
                " ▀████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(' ', Font.Block, FontSize.Medium), new string[]
            {
                "     ",
                "     ",
                "     ",
                "     ",
                "     ",
                "     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('(', Font.Block, FontSize.Medium), new string[]
            {
                "  ▄█▀ ",
                " █    ",
                "█     ",
                "█     ",
                " █    ",
                "  ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(')', Font.Block, FontSize.Medium), new string[]
            {
                "▀█▄   ",
                "   █  ",
                "    █ ",
                "    █ ",
                "   █  ",
                "▄█▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('[', Font.Block, FontSize.Medium), new string[]
            {
                "█▀▀ ",
                "█   ",
                "█   ",
                "█   ",
                "█   ",
                "█▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(']', Font.Block, FontSize.Medium), new string[]
            {
                " ▀▀█ ",
                "   █ ",
                "   █ ",
                "   █ ",
                "   █ ",
                " ▄▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('<', Font.Block, FontSize.Medium), new string[]
            {
                "    ▄ ",
                "  ▄▀  ",
                "▄▀    ",
                "▀▄    ",
                "  ▀▄  ",
                "    ▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('>', Font.Block, FontSize.Medium), new string[]
            {
                "▄     ",
                " ▀▄   ",
                "   ▀▄ ",
                "   ▄▀ ",
                " ▄▀   ",
                "▀     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('{', Font.Block, FontSize.Medium), new string[]
            {
                "   ▄█▀ ",
                "  █    ",
                "▄█▀    ",
                "▀█▄    ",
                "  █    ",
                "   ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('}', Font.Block, FontSize.Medium), new string[]
            {
                "▀█▄    ",
                "   █   ",
                "   ▀█▄ ",
                "   ▄█▀ ",
                "   █   ",
                "▄█▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('/', Font.Block, FontSize.Medium), new string[]
            {
                "     ▄█ ",
                "    ▄█▀ ",
                "   ▄█▀  ",
                "  ▄█▀   ",
                " ▄█▀    ",
                "▄█▀     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\\', Font.Block, FontSize.Medium), new string[]
            {
                " █▄      ",
                " ▀█▄     ",
                "  ▀█▄    ",
                "   ▀█▄   ",
                "    ▀█▄  ",
                "     ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('.', Font.Block, FontSize.Medium), new string[]
            {
                "   ",
                "   ",
                "   ",
                "   ",
                "   ",
                "██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(',', Font.Block, FontSize.Medium), new string[]
            {
                "   ",
                "   ",
                "   ",
                "   ",
                "▄▄ ",
                "▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(':', Font.Block, FontSize.Medium), new string[]
            {
                "     ",
                "     ",
                "██   ",
                "     ",
                "██   ",
                "     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(';', Font.Block, FontSize.Medium), new string[]
            {
                "    ",
                "    ",
                "██  ",
                "    ",
                "▀█  ",
                "▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\'', Font.Block, FontSize.Medium), new string[]
            {
                "█ ",
                "  ",
                "  ",
                "  ",
                "  ",
                "  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('"', Font.Block, FontSize.Medium), new string[]
            {
                "█ █ ",
                "    ",
                "    ",
                "    ",
                "    ",
                "    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('!', Font.Block, FontSize.Medium), new string[]
            {
                "▄███▄ ",
                "█████ ",
                "▀███▀ ",
                " ███  ",
                "      ",
                " ███  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('?', Font.Block, FontSize.Medium), new string[]
            {
                "▄██████▄  ",
                "██▀   ▀██ ",
                "   ▄▄▄██▀ ",
                "   ███    ",
                "          ",
                "   ███    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('A', Font.Block, FontSize.Small), new string[]
            {
                "▄████▄ ",
                "██  ██ ",
                "██████ ",
                "██  ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('B', Font.Block, FontSize.Small), new string[]
            {
                "██▀▀█▄ ",
                "██▄▄█▀ ",
                "██  ██ ",
                "█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('C', Font.Block, FontSize.Small), new string[]
            {
                "▄████▄ ",
                "██  ▀▀ ",
                "██  ▄▄ ",
                "▀████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('D', Font.Block, FontSize.Small), new string[]
            {
                "█████▄ ",
                "██  ██ ",
                "██  ██ ",
                "█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('E', Font.Block, FontSize.Small), new string[]
            {
                "█████ ",
                "██▄▄  ",
                "██▀▀  ",
                "█████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('F', Font.Block, FontSize.Small), new string[]
            {
                "█████ ",
                "██▄▄  ",
                "██▀▀  ",
                "██    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('G', Font.Block, FontSize.Small), new string[]
            {
                "▄████▄ ",
                "██  ▀▀ ",
                "██ ▀██ ",
                "▀████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('H', Font.Block, FontSize.Small), new string[]
            {
                "██  ██ ",
                "██▄▄██ ",
                "██▀▀██ ",
                "██  ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('I', Font.Block, FontSize.Small), new string[]
            {
                "██ ",
                "██ ",
                "██ ",
                "██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('J', Font.Block, FontSize.Small), new string[]
            {
                "    ██ ",
                "    ██ ",
                "▄▄  ██ ",
                "▀████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('K', Font.Block, FontSize.Small), new string[]
            {
                "██ ▄█▀ ",
                "███▀   ",
                "███▄   ",
                "██ ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('L', Font.Block, FontSize.Small), new string[]
            {
                "██     ",
                "██     ",
                "██     ",
                "██████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('M', Font.Block, FontSize.Small), new string[]
            {
                "███▄███ ",
                "██ ▀ ██ ",
                "██   ██ ",
                "██   ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('N', Font.Block, FontSize.Small), new string[]
            {
                "██  ██ ",
                "███▄██ ",
                "██▀███ ",
                "██  ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('O', Font.Block, FontSize.Small), new string[]
            {
                "▄████▄ ",
                "██  ██ ",
                "██  ██ ",
                "▀████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('P', Font.Block, FontSize.Small), new string[]
            {
                "█████▄ ",
                "██  ██ ",
                "██▀▀▀  ",
                "██     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Q', Font.Block, FontSize.Small), new string[]
            {
                "▄████▄  ",
                "██  ██  ",
                "██ ▄██  ",
                "▀████▀▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('R', Font.Block, FontSize.Small), new string[]
            {
                "████▄ ",
                "██ ██ ",
                "████▀ ",
                "██▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('S', Font.Block, FontSize.Small), new string[]
            {
                "▄████ ",
                "██▄▄▄ ",
                "▀▀▀██ ",
                "████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('T', Font.Block, FontSize.Small), new string[]
            {
                "██████ ",
                "  ██   ",
                "  ██   ",
                "  ██   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('U', Font.Block, FontSize.Small), new string[]
            {
                "██ ██ ",
                "██ ██ ",
                "██ ██ ",
                "▀███▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('V', Font.Block, FontSize.Small), new string[]
            {
                "██ ██ ",
                "██ ██ ",
                "▐█ █▌ ",
                " ▀█▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('W', Font.Block, FontSize.Small), new string[]
            {
                "██   ██ ",
                "██   ██ ",
                "██ ▄ ██ ",
                "███▀███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('X', Font.Block, FontSize.Small), new string[]
            {
                "▀█▄ ▄█▀ ",
                " ▀█▄█▀  ",
                " ▄█▀█▄  ",
                "▄█▀ ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Y', Font.Block, FontSize.Small), new string[]
            {
                "▀█▄ ▄█▀ ",
                " ▀█▄█▀  ",
                "  ▐█▌   ",
                "  ▐█▌   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Z', Font.Block, FontSize.Small), new string[]
            {
                "█████ ",
                "  ▄█▀ ",
                " ▄█▀  ",
                "█████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('1', Font.Block, FontSize.Small), new string[]
            {
                "▄███  ",
                "  ██  ",
                "  ██  ",
                "▄▄██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('2', Font.Block, FontSize.Small), new string[]
            {
                "▄████▄ ",
                "▀  ▄█▀ ",
                " ▄█▀   ",
                "██████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('3', Font.Block, FontSize.Small), new string[]
            {
                "█████▄ ",
                "    ██ ",
                "   ▀█▄ ",
                "█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('4', Font.Block, FontSize.Small), new string[]
            {
                "██  ██ ",
                "██  ██ ",
                "██████ ",
                "    ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('5', Font.Block, FontSize.Small), new string[]
            {
                "██▀▀▀▀ ",
                "██▄▄▄  ",
                "    ██ ",
                "█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('6', Font.Block, FontSize.Small), new string[]
            {
                "▄█▀    ",
                "██▄▄▄  ",
                "██  ██ ",
                "▀████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('7', Font.Block, FontSize.Small), new string[]
            {
                "██████ ",
                "  ▄██▀ ",
                "▄██▀   ",
                "██     ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('8', Font.Block, FontSize.Small), new string[]
            {
                "▄██▀██▄ ",
                "▀█▄▄▄█▀ ",
                "▄█▀ ▀█▄ ",
                "▀██▄██▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('9', Font.Block, FontSize.Small), new string[]
            {
                "▄█████▄ ",
                "██   ██ ",
                " ▀▀▀▀██ ",
                " ▄▄▄▄█▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('0', Font.Block, FontSize.Small), new string[]
            {
                "▄█████▄ ",
                "██ ▄ ██ ",
                "██ ▀ ██ ",
                "▀█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(' ', Font.Block, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                "   ",
                "   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('(', Font.Block, FontSize.Small), new string[]
            {
                " ▄█▀ ",
                "█    ",
                "█    ",
                " ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(')', Font.Block, FontSize.Small), new string[]
            {
                "▀█▄  ",
                "   █ ",
                "   █ ",
                "▄█▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('[', Font.Block, FontSize.Small), new string[]
            {
                "█▀▀ ",
                "█   ",
                "█   ",
                "█▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(']', Font.Block, FontSize.Small), new string[]
            {
                " ▀▀█ ",
                "   █ ",
                "   █ ",
                " ▄▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('<', Font.Block, FontSize.Small), new string[]
            {
                "  ▄ ",
                "▄▀  ",
                "▀▄  ",
                "  ▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('>', Font.Block, FontSize.Small), new string[]
            {
                "▄   ",
                " ▀▄ ",
                " ▄▀ ",
                "▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('{', Font.Block, FontSize.Small), new string[]
            {
                "   ▄█▀ ",
                " ▄█    ",
                " ▀█    ",
                "   ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('}', Font.Block, FontSize.Small), new string[]
            {
                "▀█▄   ",
                "   █▄ ",
                "   █▀ ",
                "▄█▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('/', Font.Block, FontSize.Small), new string[]
            {
                "   ▄▀ ",
                "  ▄▀  ",
                " ▄▀   ",
                "▄▀    ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\\', Font.Block, FontSize.Small), new string[]
            {
                "▀▄    ",
                " ▀▄   ",
                "  ▀▄  ",
                "   ▀▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('.', Font.Block, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                "   ",
                "▄  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(',', Font.Block, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                "   ",
                "▄▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(':', Font.Block, FontSize.Small), new string[]
            {
                "  ",
                "  ",
                "▄ ",
                "▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(';', Font.Block, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                " ▀ ",
                "▄▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\'', Font.Block, FontSize.Small), new string[]
            {
                "▀ ",
                "  ",
                "  ",
                "  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('"', Font.Block, FontSize.Small), new string[]
            {
                "▀ ▀ ",
                "    ",
                "    ",
                "    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('!', Font.Block, FontSize.Small), new string[]
            {
                "▄██▄ ",
                "▀██▀ ",
                " ██  ",
                " ▄▄  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('?', Font.Block, FontSize.Small), new string[]
            {
                "▄███▄  ",
                "▀   ██ ",
                "  ██▀  ",
                "  ▄▄   "
            });

            /*
            █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
            █
            █      ▄██████▄     ▄████████   ▄████████     ▄████████    ▄████████  ▄█      ███      ▄█
            █     ███    ███   ███    ███   ███    ███   ███    ███   ███    ███ ███  ▀█████████▄ ███
            █     ███    █▀   ▄███▄▄▄▄██▀   ███    ███   ███    █▀    ███    █▀  ███▌    ▀███▀▀██ ███▌
            █    ▄███        ▀▀███▀▀▀▀▀     ███    ███  ▄███▄▄▄      ▄███▄▄▄     ███▌     ███   ▀ ███▌
            █   ▀▀███ ████▄  ▀███████████ ▀███████████ ▀▀███▀▀▀     ▀▀███▀▀▀     ███▌     ███     ███▌
            █     ███    ███   ███    ███   ███    ███   ███          ███        ███      ███     ███
            █     ███    ███   ███    ███   ███    ███   ███          ███        ███      ███     ███
            █     ████████▀    ███    ███   ███    █▀    ███          ███        █▀      ▄████▀   █▀
            █
            ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀ ▀                                 */

            Alphabet.Add(new Tuple<char, Font, FontSize>('A', Font.Graffiti, FontSize.Large), new string[]
            {
                "  ▄████████  ",
                "  ███    ███ ",
                "  ███    ███ ",
                "  ███    ███ ",
                "▀███████████ ",
                "  ███    ███ ",
                "  ███    ███ ",
                "  ███    █▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('B', Font.Graffiti, FontSize.Large), new string[]
            {
                "▀█████████▄  ",
                "  ███    ███ ",
                "  ███    ███ ",
                " ▄███▄▄▄██▀  ",
                "▀▀███▀▀▀██▄  ",
                "  ███    ██▄ ",
                "  ███    ███ ",
                "▄█████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('C', Font.Graffiti, FontSize.Large), new string[]
            {
                "▄████████  ",
                "███    ███ ",
                "███    █▀  ",
                "███        ",
                "███        ",
                "███    █▄  ",
                "███    ███ ",
                "████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('D', Font.Graffiti, FontSize.Large), new string[]
            {
                "████████▄  ",
                "███   ▀███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███   ▄███ ",
                "████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('E', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄████████ ",
                "  ███    ███ ",
                "  ███    █▀  ",
                " ▄███▄▄▄     ",
                "▀▀███▀▀▀     ",
                "  ███    █▄  ",
                "  ███    ███ ",
                "  ██████████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('F', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄████████ ",
                "  ███    ███ ",
                "  ███    █▀  ",
                " ▄███▄▄▄     ",
                "▀▀███▀▀▀     ",
                "  ███        ",
                "  ███        ",
                "  ███        "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('G', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄██████▄  ",
                "  ███    ███ ",
                "  ███    █▀  ",
                " ▄███        ",
                "▀▀███ ████▄  ",
                "  ███    ███ ",
                "  ███    ███ ",
                "  ████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('H', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄█    █▄    ",
                "  ███    ███   ",
                "  ███    ███   ",
                " ▄███▄▄▄▄███▄▄ ",
                "▀▀███▀▀▀▀███▀  ",
                "  ███    ███   ",
                "  ███    ███   ",
                "  ███    █▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('I', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄█  ",
                "███  ",
                "███▌ ",
                "███▌ ",
                "███▌ ",
                "███  ",
                "███  ",
                "█▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('J', Font.Graffiti, FontSize.Large), new string[]
            {
                "     ▄█ ",
                "    ███ ",
                "    ███ ",
                "    ███ ",
                "    ███ ",
                "    ███ ",
                "    ███ ",
                "█▄ ▄███ ",
                "▀▀▀▀▀▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('K', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄█   ▄█▄ ",
                "  ███ ▄███▀ ",
                "  ███▐██▀   ",
                " ▄█████▀    ",
                "▀▀█████▄    ",
                "  ███▐██▄   ",
                "  ███ ▀███▄ ",
                "  ███   ▀█▀ ",
                "  ▀         "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('L', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄█       ",
                "███       ",
                "███       ",
                "███       ",
                "███       ",
                "███       ",
                "███▌    ▄ ",
                "█████▄▄██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('M', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄▄▄▄███▄▄▄▄   ",
                " ▄██▀▀▀███▀▀▀██▄ ",
                " ███   ███   ███ ",
                " ███   ███   ███ ",
                " ███   ███   ███ ",
                " ███   ███   ███ ",
                " ███   ███   ███ ",
                "  ▀█   ███   █▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('N', Font.Graffiti, FontSize.Large), new string[]
            {
                "███▄▄▄▄   ",
                "███▀▀▀██▄ ",
                "███   ███ ",
                "███   ███ ",
                "███   ███ ",
                "███   ███ ",
                "███   ███ ",
                " ▀█   █▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('O', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('P', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄███████▄ ",
                "  ███    ███ ",
                "  ███    ███ ",
                "  ███    ███ ",
                "▀█████████▀  ",
                "  ███        ",
                "  ███        ",
                " ▄████▀      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Q', Font.Graffiti, FontSize.Large), new string[]
            {
                "████████▄   ",
                "███    ███  ",
                "███    ███  ",
                "███    ███  ",
                "███    ███  ",
                "███    ███  ",
                "███  ▀ ███  ",
                " ▀██████▀▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('R', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄████████ ",
                "  ███    ███ ",
                " ▄███▄▄▄▄██▀ ",
                "▀▀███▀▀▀▀▀   ",
                "▀███████████ ",
                "  ███    ███ ",
                "  ███    ███ ",
                "  ███    ███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('S', Font.Graffiti, FontSize.Large), new string[]
            {
                "   ▄████████ ",
                "  ███    ███ ",
                "  ███    █▀  ",
                "  ███        ",
                "▀███████████ ",
                "         ███ ",
                "   ▄█    ███ ",
                " ▄████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('T', Font.Graffiti, FontSize.Large), new string[]
            {
                "    ███     ",
                "▀█████████▄ ",
                "   ▀███▀▀██ ",
                "    ███   ▀ ",
                "    ███     ",
                "    ███     ",
                "    ███     ",
                "   ▄████▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('U', Font.Graffiti, FontSize.Large), new string[]
            {
                "███    █▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('V', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄█    █▄  ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                "███    ███ ",
                " ██▄  ▄██  ",
                "  ▀████▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('W', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄█     █▄  ",
                "███     ███ ",
                "███     ███ ",
                "███     ███ ",
                "███     ███ ",
                "███     ███ ",
                "███ ▄█▄ ███ ",
                " ▀███▀███▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('X', Font.Graffiti, FontSize.Large), new string[]
            {
                "▀████    ▐████▀ ",
                "  ███▌   ████▀  ",
                "   ███  ▐███    ",
                "   ▀███▄███▀    ",
                "   ████▀██▄     ",
                "   ▐███  ▀███   ",
                " ▄███     ███▄  ",
                "████       ███▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Y', Font.Graffiti, FontSize.Large), new string[]
            {
                "▄██   ▄   ",
                "███   ██▄ ",
                "███▄▄▄███ ",
                "▀▀▀▀▀▀███ ",
                "▄██   ███ ",
                "███   ███ ",
                "███   ███ ",
                " ▀█████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Z', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄███████▄  ",
                "██▀     ▄██ ",
                "      ▄███▀ ",
                " ▀█▀▄███▀▄▄ ",
                "  ▄███▀   ▀ ",
                "▄███▀       ",
                "███▄     ▄█ ",
                " ▀████████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('1', Font.Graffiti, FontSize.Large), new string[]
            {
                "▄████   ",
                "  ███   ",
                "  ███▌  ",
                "  ███▌  ",
                "  ███▌  ",
                "  ███   ",
                "  ███   ",
                "▄▄███▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('2', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄███████▄  ",
                "██▀     ▄██ ",
                "▀      ▄██▀ ",
                "     ▄██▀   ",
                "   ▄██▀     ",
                " ▄██▀       ",
                "███▄     ▄█ ",
                "▀█████████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('3', Font.Graffiti, FontSize.Large), new string[]
            {
                "██████████▄  ",
                "▀        ███ ",
                "         ███ ",
                "    ▄▄▄███▀  ",
                "   ▀▀█████▄  ",
                "         ██▄ ",
                "▄        ███ ",
                "▄█████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('4', Font.Graffiti, FontSize.Large), new string[]
            {
                "  ▄██    ██  ",
                "  ███    ███ ",
                "  ███    ███ ",
                "  ███    ███ ",
                "▀███████████ ",
                "         ███ ",
                "         ███ ",
                "         █▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('5', Font.Graffiti, FontSize.Large), new string[]
            {
                "  ██████████ ",
                "  ███        ",
                "  ███        ",
                "▀███████████ ",
                "         ███ ",
                "         ███ ",
                "   ▄█    ███ ",
                " ▄████████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('6', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄████▀      ",
                "  ███        ",
                "  ███        ",
                "▀█████████▄  ",
                "  ███    ███ ",
                "  ███    ███ ",
                "  ███    ███ ",
                "   ▀███████  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('7', Font.Graffiti, FontSize.Large), new string[]
            {
                "▄████████▄  ",
                "        ▄██ ",
                "       ▄██▀ ",
                "      ▄██▀  ",
                "▀█▀ ▄██▀ █▀ ",
                "  ▄██▀      ",
                " ▄██▀       ",
                " ▀██        "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('8', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄███████▄  ",
                "███▀    ▄██ ",
                " ▀██▄  ▄██▀ ",
                "   ▀ ▄██▀   ",
                "   ▄██▀▄▄   ",
                " ▄██▀ ▀███▄ ",
                "███▄   ▄███ ",
                " ▀███████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('9', Font.Graffiti, FontSize.Large), new string[]
            {
                "▄███████▄   ",
                "███    ███  ",
                "█▄     ███  ",
                "███    ███  ",
                "▀█████████▀ ",
                "       ███  ",
                " ▄     ███  ",
                " ██▄▄▄████▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('0', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄██████▄  ",
                "███    ███ ",
                "███    ███ ",
                "███ ▄█ ███ ",
                "███ █▀ ███ ",
                "███    ███ ",
                "███    ███ ",
                " ▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(' ', Font.Graffiti, FontSize.Large), new string[]
            {
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       ",
                "       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('(', Font.Graffiti, FontSize.Large), new string[]
            {
                "  ▄██▀ ",
                " ██    ",
                "██     ",
                "██     ",
                "██     ",
                "██     ",
                " ██    ",
                "  ▀██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(')', Font.Graffiti, FontSize.Large), new string[]
            {
                "▀██▄   ",
                "   ██  ",
                "    ██ ",
                "    ██ ",
                "    ██ ",
                "    ██ ",
                "   ██  ",
                "▄██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('[', Font.Graffiti, FontSize.Large), new string[]
            {
                "██▀▀▀ ",
                "██    ",
                "██    ",
                "██    ",
                "██    ",
                "██    ",
                "██    ",
                "██▄▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(']', Font.Graffiti, FontSize.Large), new string[]
            {
                "▀▀▀██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "   ██ ",
                "▄▄▄██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('<', Font.Graffiti, FontSize.Large), new string[]
            {
                "      ▄▄ ",
                "    ▄█▀  ",
                "  ▄█▀    ",
                "▄█▀      ",
                "▀█▄      ",
                "  ▀█▄    ",
                "    ▀█▄  ",
                "      ▀▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('>', Font.Graffiti, FontSize.Large), new string[]
            {
                "▄▄       ",
                " ▀█▄     ",
                "   ▀█▄   ",
                "     ▀█▄ ",
                "     ▄█▀ ",
                "   ▄█▀   ",
                " ▄█▀     ",
                "▀▀       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('{', Font.Graffiti, FontSize.Large), new string[]
            {
                "    ▄██▀ ",
                "   ██    ",
                "   ██    ",
                " ▄█▀     ",
                " ▀█▄     ",
                "   ██    ",
                "   ██    ",
                "    ▀██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('}', Font.Graffiti, FontSize.Large), new string[]
            {
                "▀██▄    ",
                "   ██   ",
                "   ██   ",
                "    ▀█▄ ",
                "    ▄█▀ ",
                "   ██   ",
                "   ██   ",
                "▄██▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('/', Font.Graffiti, FontSize.Large), new string[]
            {
                "       ▄█ ",
                "      ▄█▀ ",
                "     ▄█▀  ",
                "    ▄█▀   ",
                "   ▄█▀    ",
                "  ▄█▀     ",
                " ▄█▀      ",
                "▄█▀       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\\', Font.Graffiti, FontSize.Large), new string[]
            {
                " █▄        ",
                " ▀█▄       ",
                "  ▀█▄      ",
                "   ▀█▄     ",
                "    ▀█▄    ",
                "     ▀█▄   ",
                "      ▀█▄  ",
                "       ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('.', Font.Graffiti, FontSize.Large), new string[]
            {
                "    ",
                "    ",
                "    ",
                "    ",
                "    ",
                "    ",
                "▄▄▄ ",
                "███ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(',', Font.Graffiti, FontSize.Large), new string[]
            {
                "     ",
                "     ",
                "     ",
                "     ",
                "     ",
                "     ",
                " ▄▄▄ ",
                " ▄██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(':', Font.Graffiti, FontSize.Large), new string[]
            {
                "      ",
                "      ",
                "███   ",
                "███   ",
                "      ",
                "███   ",
                "███   ",
                "      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(';', Font.Graffiti, FontSize.Large), new string[]
            {
                "      ",
                "      ",
                " ███  ",
                " ███  ",
                "      ",
                " ███  ",
                " ▄██  ",
                "▀▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\'', Font.Graffiti, FontSize.Large), new string[]
            {
                "██ ",
                "   ",
                "   ",
                "   ",
                "   ",
                "   ",
                "   ",
                "   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('"', Font.Graffiti, FontSize.Large), new string[]
            {
                "██ ██ ",
                "      ",
                "      ",
                "      ",
                "      ",
                "      ",
                "      ",
                "      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('!', Font.Graffiti, FontSize.Large), new string[]
            {
                " ▄███▄  ",
                "███████ ",
                "███████ ",
                "▀█████▀ ",
                " ▀███▀  ",
                "  ███   ",
                "        ",
                "  ██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('?', Font.Graffiti, FontSize.Large), new string[]
            {
                "▄████████▄  ",
                "██▀    ▀███ ",
                " ▀      ███ ",
                "   ▄▄▄▄██▀  ",
                "    ███     ",
                "    ███     ",
                "            ",
                "    ██▀     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('A', Font.Graffiti, FontSize.Medium), new string[]
            {
                "  ▄█████  ",
                "  ██   ██ ",
                "  ██   ██ ",
                "▀████████ ",
                "  ██   ██ ",
                "  ██   █▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('B', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▀██████▄  ",
                "  ██   ██ ",
                " ▄██▄▄█▀  ",
                "▀▀██▀▀█▄  ",
                "  ██   ██ ",
                "▄██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('C', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▄██████ ",
                "██    ██ ",
                "██    ▀  ",
                "██    ▄  ",
                "██    ██ ",
                "██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('D', Font.Graffiti, FontSize.Medium), new string[]
            {
                "██████▄  ",
                "██   ▀██ ",
                "██    ██ ",
                "██    ██ ",
                "██   ▄██ ",
                "██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('E', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   ▄█████ ",
                "  ██   █  ",
                " ▄██▄▄    ",
                "▀▀██▀▀    ",
                "  ██   █  ",
                "  ███████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('F', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   ▄█████ ",
                "  ██   ▀█ ",
                " ▄██▄▄    ",
                "▀▀██▀▀    ",
                "  ██      ",
                "  ██      "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('G', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   ▄████▄  ",
                "  ██    ▀  ",
                " ▄██       ",
                "▀▀██ ███▄  ",
                "  ██    ██ ",
                "  ██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('H', Font.Graffiti, FontSize.Medium), new string[]
            {
                "  ██   █    ",
                "  ██   ██   ",
                " ▄██▄▄▄██▄▄ ",
                "▀▀██▀▀▀██▀  ",
                "  ██   ██   ",
                "  ██   ██   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('I', Font.Graffiti, FontSize.Medium), new string[]
            {
                " █  ",
                "██  ",
                "██▌ ",
                "██  ",
                "██  ",
                "█   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('J', Font.Graffiti, FontSize.Medium), new string[]
            {
                "     █ ",
                "    ██ ",
                "    ██ ",
                "    ██ ",
                "█▄ ▄██ ",
                "▀▀▀▀▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('K', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   █  █▄   ",
                "  ██ ▄██▀  ",
                "  ██▐█▀    ",
                "▀▀████     ",
                "  ██ ▀██▄  ",
                "  ▀█   ▀█▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('L', Font.Graffiti, FontSize.Medium), new string[]
            {
                " █       ",
                "██       ",
                "██       ",
                "██       ",
                "██▌    ▄ ",
                "████▄▄██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('M', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   ▄▄██▄▄▄  ",
                " ▄█▀▀██▀▀█▄ ",
                " ██  ██  ██ ",
                " ██  ██  ██ ",
                " ██  ██  ██ ",
                "  █  ██  █  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('N', Font.Graffiti, FontSize.Medium), new string[]
            {
                "██▄▄▄▄  ",
                "██▀▀▀█▄ ",
                "██   ██ ",
                "██   ██ ",
                "██   ██ ",
                " █   █  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('O', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ██████  ",
                "██    ██ ",
                "██    ██ ",
                "██    ██ ",
                "██    ██ ",
                " ██████  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('P', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   █████▄ ",
                "  ██   ██ ",
                "  ██   ██ ",
                "▀██████▀  ",
                "  ██      ",
                " ▄███▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Q', Font.Graffiti, FontSize.Medium), new string[]
            {
                "██████   ",
                "██   ██  ",
                "██   ██  ",
                "██   ██  ",
                "██ ▀ ██  ",
                " ████▀▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('R', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   █████ ",
                "  ██  ██ ",
                " ▄██▄▄█▀ ",
                "▀███████ ",
                "  ██  ██ ",
                "  ██  ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('S', Font.Graffiti, FontSize.Medium), new string[]
            {
                "  ▄█████ ",
                "  ██  ▀  ",
                "  ██     ",
                "▀███████ ",
                "   ▄  ██ ",
                " ▄████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('T', Font.Graffiti, FontSize.Medium), new string[]
            {
                "    ██    ",
                "▀███████▄ ",
                "    ██  ▀ ",
                "    ██    ",
                "    ██    ",
                "   ▄██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('U', Font.Graffiti, FontSize.Medium), new string[]
            {
                "██   █  ",
                "██   ██ ",
                "██   ██ ",
                "██   ██ ",
                "██   ██ ",
                "██████  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('V', Font.Graffiti, FontSize.Medium), new string[]
            {
                " █    █  ",
                "██    ██ ",
                "██    ██ ",
                "██    ██ ",
                " █▄  ▄█  ",
                "  ▀██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('W', Font.Graffiti, FontSize.Medium), new string[]
            {
                " █     █  ",
                "██     ██ ",
                "██     ██ ",
                "██     ██ ",
                "██ ▄█▄ ██ ",
                " ███▀███  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('X', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▀███  ▐██▀ ",
                "  ██  ██   ",
                "   ████▀   ",
                "   ████    ",
                " ▄██ ▀██   ",
                "███    ██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Y', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▄█   ▄  ",
                "██   █▄ ",
                "▀▀▀▀▀██ ",
                "▄█   ██ ",
                "██   ██ ",
                " █████  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Z', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▄██████▄ ",
                "██▀    ▄█ ",
                " ▀  ▄██▀  ",
                "  ▄██▀  ▀ ",
                " ██▄   ▄█ ",
                "▀██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('1', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▄███   ",
                "  ██   ",
                "  ██▌  ",
                "  ██▌  ",
                "  ██   ",
                "▄▄██▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('2', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▄█████▄  ",
                "██▀   ▄██ ",
                "▀   ▄██▀  ",
                " ▄██▀     ",
                "██▄    ▄█ ",
                "▀███████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('3', Font.Graffiti, FontSize.Medium), new string[]
            {
                "███████▄  ",
                "▀     ███ ",
                "    ▄██▀  ",
                "   ▀▀██▄  ",
                "▄     ███ ",
                "▄██████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('4', Font.Graffiti, FontSize.Medium), new string[]
            {
                "  ▄█   █  ",
                "  ██   ██ ",
                "  ██   ██ ",
                "▀████████ ",
                "       ██ ",
                "       █▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('5', Font.Graffiti, FontSize.Medium), new string[]
            {
                "  ███████ ",
                "  ██      ",
                "▀████████ ",
                "       ██ ",
                "   ▄   ██ ",
                " ▄█████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('6', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▄███▀     ",
                "  ██       ",
                "▀███████▄  ",
                "  ██    ██ ",
                "  ██    ██ ",
                "  ▀█████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('7', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▄██████▄  ",
                "      ▄██ ",
                "    ▄██▀  ",
                "█▀▄██▀ █▀ ",
                "▄██▀      ",
                "▀██       "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('8', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▄██▀▀█▄  ",
                " ▀█▄  ▄█▀ ",
                "  ▀▄██▀   ",
                " ▄██▀▄▄   ",
                "██▄   ▄██ ",
                " ▀█████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('9', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▄█████▄   ",
                "██▀   ██  ",
                "█▄    ██  ",
                "▀███████▀ ",
                " ▄    ██  ",
                " ██▄▄███▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('0', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▄████▄  ",
                "██    ██ ",
                "██ ▄█ ██ ",
                "██ █▀ ██ ",
                "██    ██ ",
                " ▀████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(' ', Font.Graffiti, FontSize.Medium), new string[]
            {
                "     ",
                "     ",
                "     ",
                "     ",
                "     ",
                "     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('(', Font.Graffiti, FontSize.Medium), new string[]
            {
                "  ▄█▀ ",
                " █    ",
                "█     ",
                "█     ",
                " █    ",
                "  ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(')', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▀█▄   ",
                "   █  ",
                "    █ ",
                "    █ ",
                "   █  ",
                "▄█▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('[', Font.Graffiti, FontSize.Medium), new string[]
            {
                "█▀▀ ",
                "█   ",
                "█   ",
                "█   ",
                "█   ",
                "█▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(']', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▀▀█ ",
                "   █ ",
                "   █ ",
                "   █ ",
                "   █ ",
                " ▄▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('<', Font.Graffiti, FontSize.Medium), new string[]
            {
                "    ▄ ",
                "  ▄▀  ",
                "▄▀    ",
                "▀▄    ",
                "  ▀▄  ",
                "    ▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('>', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▄     ",
                " ▀▄   ",
                "   ▀▄ ",
                "   ▄▀ ",
                " ▄▀   ",
                "▀     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('{', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   ▄█▀ ",
                "  █    ",
                "▄█▀    ",
                "▀█▄    ",
                "  █    ",
                "   ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('}', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▀█▄    ",
                "   █   ",
                "   ▀█▄ ",
                "   ▄█▀ ",
                "   █   ",
                "▄█▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('/', Font.Graffiti, FontSize.Medium), new string[]
            {
                "     ▄█ ",
                "    ▄█▀ ",
                "   ▄█▀  ",
                "  ▄█▀   ",
                " ▄█▀    ",
                "▄█▀     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\\', Font.Graffiti, FontSize.Medium), new string[]
            {
                " █▄      ",
                " ▀█▄     ",
                "  ▀█▄    ",
                "   ▀█▄   ",
                "    ▀█▄  ",
                "     ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('.', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   ",
                "   ",
                "   ",
                "   ",
                "   ",
                "██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(',', Font.Graffiti, FontSize.Medium), new string[]
            {
                "   ",
                "   ",
                "   ",
                "   ",
                "▄▄ ",
                "▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(':', Font.Graffiti, FontSize.Medium), new string[]
            {
                "     ",
                "     ",
                "██   ",
                "     ",
                "██   ",
                "     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(';', Font.Graffiti, FontSize.Medium), new string[]
            {
                "    ",
                "    ",
                "██  ",
                "    ",
                "▀█  ",
                "▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\'', Font.Graffiti, FontSize.Medium), new string[]
            {
                "█ ",
                "  ",
                "  ",
                "  ",
                "  ",
                "  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('"', Font.Graffiti, FontSize.Medium), new string[]
            {
                "█ █ ",
                "    ",
                "    ",
                "    ",
                "    ",
                "    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('!', Font.Graffiti, FontSize.Medium), new string[]
            {
                " ▄███▄  ",
                "▀█████▀ ",
                " ▀███▀  ",
                "  ███   ",
                "        ",
                "  ██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('?', Font.Graffiti, FontSize.Medium), new string[]
            {
                "▄██████▄  ",
                "██▀   ▀██ ",
                "   ▄▄▄██▀ ",
                "   ███    ",
                "          ",
                "   ██▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('A', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄█████  ",
                "██   ██ ",
                "███████ ",
                "██   ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('B', Font.Graffiti, FontSize.Small), new string[]
            {
                "▀█████▄ ",
                " ██▄▄▄▀ ",
                " ██   █ ",
                "▄█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('C', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄█████  ",
                "██   ▀  ",
                "██   ▄  ",
                "█████▀  ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('D', Font.Graffiti, FontSize.Small), new string[]
            {
                "█████▄  ",
                "██   ██ ",
                "██   ██ ",
                "█████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('E', Font.Graffiti, FontSize.Small), new string[]
            {
                " ▄████  ",
                " ██     ",
                "▀██▀▀   ",
                " ██████ ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('F', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ▄████ ",
                " ▄██▄▄▄  ",
                "  ██     ",
                "  ██     "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('G', Font.Graffiti, FontSize.Small), new string[]
            {
                "  ▄████▄ ",
                " ██    ▀ ",
                "▀██ ▀▀█▄ ",
                " ██████▀ ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('H', Font.Graffiti, FontSize.Small), new string[]
            {
                " ██  █   ",
                " ██▄▄██▄ ",
                "▀██▀▀██  ",
                " ██  ██  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('I', Font.Graffiti, FontSize.Small), new string[]
            {
                " █ ",
                "██ ",
                "██ ",
                "█  ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('J', Font.Graffiti, FontSize.Small), new string[]
            {
                "    █ ",
                "   ██ ",
                "▄ ▄██ ",
                "▀▀▀▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('K', Font.Graffiti, FontSize.Small), new string[]
            {
                " ██ ▄█▀  ",
                " ██▐█▀   ",
                "▀████    ",
                " ██ ▀█▄  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('L', Font.Graffiti, FontSize.Small), new string[]
            {
                " █     ",
                "██     ",
                "██   ▄ ",
                "██▄▄██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('M', Font.Graffiti, FontSize.Small), new string[]
            {
                "  ▄▄███▄▄  ",
                "▄█▀▀██▀▀█▄ ",
                "██  ██  ██ ",
                " █  ██  █  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('N', Font.Graffiti, FontSize.Small), new string[]
            {
                "██▄▄▄  ",
                "██▀▀█▄ ",
                "██  ██ ",
                " █  █  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('O', Font.Graffiti, FontSize.Small), new string[]
            {
                " █████  ",
                "██   ██ ",
                "██   ██ ",
                " █████  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('P', Font.Graffiti, FontSize.Small), new string[]
            {
                "  █████▄ ",
                " ██   ██ ",
                "▀██▀▀▀▀  ",
                "▄███▀    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Q', Font.Graffiti, FontSize.Small), new string[]
            {
                "██████   ",
                "██   ██  ",
                "██ ▀ ██  ",
                " ████▀▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('R', Font.Graffiti, FontSize.Small), new string[]
            {
                "  █████ ",
                " ██  ██ ",
                "▄██▄▄█▀ ",
                " ██  ██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('S', Font.Graffiti, FontSize.Small), new string[]
            {
                " ▄█████ ",
                " ██  ▀  ",
                "▀▀▀▀▀██ ",
                "▄█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('T', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ██    ",
                "▀██████▄ ",
                "   ██    ",
                "  ▄██▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('U', Font.Graffiti, FontSize.Small), new string[]
            {
                "█   █  ",
                "█   ██ ",
                "█   ██ ",
                "█████  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('V', Font.Graffiti, FontSize.Small), new string[]
            {
                " █   █  ",
                "██   ██ ",
                " █▄ ▄█  ",
                "  ▀█▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('W', Font.Graffiti, FontSize.Small), new string[]
            {
                " █   █  ",
                "██   ██ ",
                "██▄█▄██ ",
                " ██▀██  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('X', Font.Graffiti, FontSize.Small), new string[]
            {
                " ██   ██ ",
                "  ██▄██▀ ",
                "  ▄█▀█▄  ",
                "▄██  ▀██ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Y', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄█  ▄  ",
                "▀▀▀▀██ ",
                "██  ██ ",
                " ████  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('Z', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄████▄ ",
                "▀  ▄█▀ ",
                " ▄█▀ ▀ ",
                "█████▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('1', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄██   ",
                "  █▌  ",
                "  █▌  ",
                "▄▄█▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('2', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄████▄ ",
                "▀  ▄█▀ ",
                " ▄█▀   ",
                "██████ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('3', Font.Graffiti, FontSize.Small), new string[]
            {
                "████▄  ",
                "▀   ██ ",
                "▄  ▀██ ",
                "▄███▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('4', Font.Graffiti, FontSize.Small), new string[]
            {
                " ▄█  █  ",
                " ██  ██ ",
                "▀██████ ",
                "     █▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('5', Font.Graffiti, FontSize.Small), new string[]
            {
                " ██▀▀▀▀▀ ",
                "▀███████ ",
                "  ▄   ██ ",
                "▄█████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('6', Font.Graffiti, FontSize.Small), new string[]
            {
                " ██▀     ",
                "▀█████▄  ",
                " █    ██ ",
                " ▀████▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('7', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄█████▄ ",
                "   ▄██▀ ",
                "▀▄██▀ ▀ ",
                "██▀     ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('8', Font.Graffiti, FontSize.Small), new string[]
            {
                " ▄█▀▀█  ",
                " ▀▄▄▄▀  ",
                "██   ██ ",
                " ▀▄▄▄▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('9', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄████   ",
                "█▀   █  ",
                "▀▀▀▀▀█▀ ",
                " █▄▄██▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('0', Font.Graffiti, FontSize.Small), new string[]
            {
                " ▄███▄  ",
                "██ ▄ ██ ",
                "██ ▀ ██ ",
                " ▀███▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(' ', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                "   ",
                "   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('(', Font.Graffiti, FontSize.Small), new string[]
            {
                " ▄█▀ ",
                "█    ",
                "█    ",
                " ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(')', Font.Graffiti, FontSize.Small), new string[]
            {
                "▀█▄  ",
                "   █ ",
                "   █ ",
                "▄█▀  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('[', Font.Graffiti, FontSize.Small), new string[]
            {
                "█▀▀ ",
                "█   ",
                "█   ",
                "█▄▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(']', Font.Graffiti, FontSize.Small), new string[]
            {
                " ▀▀█ ",
                "   █ ",
                "   █ ",
                " ▄▄█ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('<', Font.Graffiti, FontSize.Small), new string[]
            {
                "  ▄ ",
                "▄▀  ",
                "▀▄  ",
                "  ▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('>', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄   ",
                " ▀▄ ",
                " ▄▀ ",
                "▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('{', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ▄█▀ ",
                " ▄█    ",
                " ▀█    ",
                "   ▀█▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('}', Font.Graffiti, FontSize.Small), new string[]
            {
                "▀█▄   ",
                "   █▄ ",
                "   █▀ ",
                "▄█▀   "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('/', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ▄▀ ",
                "  ▄▀  ",
                " ▄▀   ",
                "▄▀    ",
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\\', Font.Graffiti, FontSize.Small), new string[]
            {
                "▀▄    ",
                " ▀▄   ",
                "  ▀▄  ",
                "   ▀▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('.', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                "   ",
                "▄  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(',', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                "   ",
                "▄▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(':', Font.Graffiti, FontSize.Small), new string[]
            {
                "  ",
                "  ",
                "▄ ",
                "▄ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>(';', Font.Graffiti, FontSize.Small), new string[]
            {
                "   ",
                "   ",
                " ▀ ",
                "▄▀ "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('\'', Font.Graffiti, FontSize.Small), new string[]
            {
                "▀ ",
                "  ",
                "  ",
                "  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('"', Font.Graffiti, FontSize.Small), new string[]
            {
                "▀ ▀ ",
                "    ",
                "    ",
                "    "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('!', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄██▄ ",
                "▀██▀ ",
                " ██  ",
                " ▄▄  "
            });

            Alphabet.Add(new Tuple<char, Font, FontSize>('?', Font.Graffiti, FontSize.Small), new string[]
            {
                "▄███▄  ",
                "▀   ██ ",
                "  ██▀  ",
                "  ▄▄   "
            });
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        ///     Gets the alphabet.
        /// </summary>
        public static Dictionary<Tuple<char, Font, FontSize>, string[]> Alphabet { get; private set; }

        /// <summary>
        ///     Gets or sets the current font.
        /// </summary>
        public static Font CurrentFont { get; set; }

        /// <summary>
        ///     Gets or sets the current font size.
        /// </summary>
        public static FontSize CurrentFontSize { get; set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        ///     Generates a large string of characters corresponding to the input phrase.
        /// </summary>
        /// <remarks>Any character that doesn't exist in the alphabet will be replaced with a question mark.</remarks>
        /// <param name="phrase">The phrase to generate.</param>
        /// <param name="size">The size of the font to use.</param>
        /// <returns>A string array containing the generated output.</returns>
        /// <seealso cref="Generate(string, Font, FontSize)"/>
        public static string[] Generate(string phrase, FontSize size = FontSize.Default)
        {
            return Generate(phrase, DefaultFont, size == FontSize.Default ? DefaultFontSize : size);
        }

        /// <summary>
        ///     Generates a large string of characters corresponding to the input phrase.
        /// </summary>
        /// <remarks>Any character that doesn't exist in the alphabet will be replaced with a question mark.</remarks>
        /// <param name="phrase">The phrase to generate.</param>
        /// <param name="font">The Font type to use.</param>
        /// <param name="size">The size of the font to use.</param>
        /// <returns>A string array containing the generated output.</returns>
        public static string[] Generate(string phrase, Font font = Font.Default, FontSize size = FontSize.Default)
        {
            // substitute default font and size values with the configured default values
            font = font == Font.Default ? DefaultFont : font;
            size = size == FontSize.Default ? DefaultFontSize : size;

            // create the result array of the proper size
            string[] r = new string[(int)size];

            // populate the result array
            foreach (char c in phrase.ToUpper())
            {
                for (int i = 0; i < (int)size; i++)
                {
                    r[i] += Alphabet[new Tuple<char, Font, FontSize>(Alphabet.ContainsKey(new Tuple<char, Font, FontSize>(c, font, size)) ? c : '?', font, size)][i];
                }
            }

            return r;
        }

        /// <summary>
        ///     Generates a large string of characters corresponding to the input phrase while simulating upper and lower case
        ///     characters by reducing the specified font size by one size, if the specified size is not <see cref="FontSize.Small"/>.
        /// </summary>
        /// <param name="phrase">The phrase to generate.</param>
        /// <param name="font">The Font type to use.</param>
        /// <param name="size">The size of the font to use.</param>
        /// <returns>A string array containing the generated output.</returns>
        public static string[] GenerateCaseSensitive(string phrase, Font font = Font.Default, FontSize size = FontSize.Default)
        {
            int maxHeight = GetHeightOf(font, size);
            FontSize lowercaseSize = GetLowerCaseFontSizeOf(size);
            string[] output = new string[maxHeight];

            foreach (char c in phrase)
            {
                string[] letter;

                if (char.IsUpper(c))
                {
                    letter = Generate(c.ToString(), font, size);
                }
                else
                {
                    letter = Generate(c.ToString(), font, lowercaseSize);
                }

                // if the current letter is lowercase, pad the top lines of the output array with blanks equal to the width of the character
                int heightDifference = maxHeight - letter.Length;
                string pad = new string(' ', letter[0].Length);

                for (int i = 0; i < heightDifference; i++)
                {
                    output[i] += pad;
                }

                // append the rest of the new letter to the output array
                for (int i = heightDifference; i < output.Length; i++)
                {
                    output[i] += letter[i - heightDifference];
                }
            }

            return output;
        }

        /// <summary>
        ///     Returns the height, in lines, of the characters of the specified <see cref="Font"/> and <see cref="FontSize"/>.
        /// </summary>
        /// <param name="font">The Font for which the height is to be returned.</param>
        /// <param name="size">The FontSize for which the height is to be returned.</param>
        /// <returns>The height, in lines, of the characters of the specified Font and FontSize.</returns>
        public static int GetHeightOf(Font font, FontSize size)
        {
            if (size == FontSize.Default)
            {
                size = DefaultFontSize;
            }

            if (font == Font.Default)
            {
                font = DefaultFont;
            }

            return Alphabet[new Tuple<char, Font, FontSize>('A', font, size)].Length;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///     Returns the <see cref="FontSize"/> corresponding to one size lower than the specified size. If
        ///     <see cref="FontSize.Small"/> is specified, it is returned as there is no smaller size.
        /// </summary>
        /// <param name="size">The size for which the smaller size is to be returned.</param>
        /// <returns>The FontSize corresponding to one size lower than the specified size.</returns>
        private static FontSize GetLowerCaseFontSizeOf(FontSize size)
        {
            if (size == FontSize.Default)
            {
                size = DefaultFontSize;
            }

            if (size == FontSize.Large)
            {
                return FontSize.Medium;
            }
            else if (size == FontSize.Medium)
            {
                return FontSize.Small;
            }
            else
            {
                return size;
            }
        }

        #endregion Private Methods
    }
}