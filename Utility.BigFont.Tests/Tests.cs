using System;
using System.Collections.Generic;
using Xunit;

namespace Utility.BigFont.Tests
{
    /// <summary>
    ///     Tests the <see cref="BigFontGenerator"/>  class.
    /// </summary>
    public class Tests
    {
        /// <summary>
        ///     Tests all properties of the <see cref="BigFontGenerator"/>  class.
        /// </summary>
        [Fact]
        public void TestProperties()
        {
            BigFontGenerator.CurrentFont = Font.Block;

            Assert.Equal(BigFontGenerator.CurrentFont, Font.Block);

            BigFontGenerator.CurrentFontSize = FontSize.Small;

            Assert.Equal(BigFontGenerator.CurrentFontSize, FontSize.Small);

            Dictionary<Tuple<char, Font, FontSize>, string[]> alphabet = BigFontGenerator.Alphabet;
        }

        /// <summary>
        ///     Tests all overloads of the <see cref="BigFontGenerator.Generate(string, Font, FontSize)"/>  method.
        /// </summary>
        /// <remarks>
        ///     Exception testing only; asserting output not worth the hassle.
        /// </remarks>
        [Fact]
        public void TestGenerate()
        {
            string[] test = BigFontGenerator.Generate("Hello World!", Font.Block, FontSize.Large);
            string[] test2 = BigFontGenerator.Generate("Hello Again World!", FontSize.Large);
        }
    }
}
