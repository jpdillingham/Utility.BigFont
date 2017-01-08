using System;
using System.Collections.Generic;
using Xunit;

namespace Utility.BigFont.Tests
{
    /// <summary>
    ///     Tests the <see cref="BigFontGenerator"/> class.
    /// </summary>
    public class Tests
    {
        /// <summary>
        ///     Tests all properties of the <see cref="BigFontGenerator"/> class.
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
        ///     Tests all overloads of the <see cref="BigFontGenerator.Generate(string, Font, FontSize)"/> method.
        /// </summary>
        /// <remarks>Exception testing only; asserting output not worth the hassle.</remarks>
        [Fact]
        public void TestGenerate()
        {
            string[] test = BigFontGenerator.Generate("Hello World!", Font.Block, FontSize.Large);
            string[] test2 = BigFontGenerator.Generate("Hello Again World!", FontSize.Large);
        }

        /// <summary>
        ///     Tests all overloads of the <see cref="BigFontGenerator.GenerateCaseSensitive(string, Font, FontSize)"/> method.
        /// </summary>
        /// <remarks>Exception testing only; asserting output not worth the hassle.</remarks>
        [Fact]
        public void TestGenerateCaseSensitive()
        {
            string[] test = BigFontGenerator.GenerateCaseSensitive("Hello World!", Font.Block, FontSize.Large);
            string[] test1 = BigFontGenerator.GenerateCaseSensitive("Hello World!", Font.Block, FontSize.Medium);
            string[] test2 = BigFontGenerator.GenerateCaseSensitive("Hello World!", Font.Block, FontSize.Small);
            string[] test3 = BigFontGenerator.GenerateCaseSensitive("Hello World!", Font.Block);
        }

        /// <summary>
        ///     Tests the <see cref="BigFontGenerator.GetHeightOf(Font, FontSize)"/> method with all possible sizes.
        /// </summary>
        [Fact]
        public void TestGetHeightOf()
        {
            Assert.Equal(8, BigFontGenerator.GetHeightOf(Font.Graffiti, FontSize.Large));
            Assert.Equal(6, BigFontGenerator.GetHeightOf(Font.Graffiti, FontSize.Medium));
            Assert.Equal(4, BigFontGenerator.GetHeightOf(Font.Graffiti, FontSize.Small));
            Assert.Equal(8, BigFontGenerator.GetHeightOf(Font.Default, FontSize.Default));
        }
    }
}