using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the horizontal alignment of the page number.
/// </summary>
public enum PageNumberHorizontalAlign
{
	/// <summary>
	/// Align the page number in the center.
	/// </summary>
	C = 'c',

	/// <summary>
	/// Align the page number to the left.
	/// </summary>
	L = 'l',

	/// <summary>
	/// Align the page number to the right.
	/// </summary>
	R = 'r'
}
}
