// ******************************************************************
// Copyright (c) William Bradley
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using AngleSharp.Dom;
using Mechanize.Html;

namespace Mechanize.ParseAngleSharp
{
    /// <summary>
    /// The Container for <see cref="IAttr"/>.
    /// </summary>
    public class AngleSharpAttribute : IHtmlAttribute
    {
        internal AngleSharpAttribute(IAttr Attribute)
        {
            this.Attribute = Attribute;
        }

        /// <summary>
        /// The Name of the Attribute.
        /// </summary>
        public string Name => Attribute.Name;

        /// <summary>
        /// The Value of the Attribute.
        /// </summary>
        public string Value => Attribute.Value;

        /// <summary>
        /// The Underlying Attribute Instance.
        /// </summary>
        public readonly IAttr Attribute;
    }
}