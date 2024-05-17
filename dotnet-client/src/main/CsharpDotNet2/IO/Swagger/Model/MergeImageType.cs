using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of image merging.
/// </summary>
public enum MergeImageType
{
	/// <summary>
	/// The images are merged vertically.
	/// </summary>
	Vertical = 1,

	/// <summary>
	/// The images are merged horizontally.
	/// </summary>
	Horizontal = 2,

	/// <summary>
	/// The images are merged both vertically and horizontally.
	/// </summary>
	Both = 3
}
}
