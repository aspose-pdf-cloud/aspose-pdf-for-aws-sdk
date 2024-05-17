using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of image splitting.
/// </summary>
public enum SplitImageType
{
	/// <summary>
	/// The image is split vertically.
	/// </summary>
	Vertical = 1,

	/// <summary>
	/// The image is split horizontally.
	/// </summary>
	Horizontal = 2,

	/// <summary>
	/// The image is split both vertically and horizontally.
	/// </summary>
	Both = 3
}
}
