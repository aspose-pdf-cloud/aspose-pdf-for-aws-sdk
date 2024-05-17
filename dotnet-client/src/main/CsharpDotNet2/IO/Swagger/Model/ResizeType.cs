using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of resizing.
/// </summary>
public enum ResizeType
{
	/// <summary>
	/// Resize by a percentage.
	/// </summary>
	Percentage = 1,

	/// <summary>
	/// Resize by a specific number of pixels.
	/// </summary>
	Pixels = 2,

	/// <summary>
	/// Resize using preset sizes.
	/// </summary>
	Presets = 3
}
}
