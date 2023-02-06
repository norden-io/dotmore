using System;
using System.Text;
using System.Linq;

namespace dotmore.Extensions {
	public static class StringBuilderExtensions {
		/// <summary>
		/// Appends the .ToString() value of the object supplied along with the default line terminator.
		/// </summary>
		public static StringBuilder AppendLine(this StringBuilder that, object value) {
			if (value == null) {
				return that.AppendLine();
			}
			else {
				return that.AppendLine(value.ToString());
			}
		}
	}
}
