using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of watermark.
/// </summary>
public enum WatermarkType
{
	/// <summary>
	/// No watermark.
	/// </summary>
	None,

	/// <summary>
	/// Artifact watermark.
	/// </summary>
	Artifact,

	/// <summary>
	/// Text watermark.
	/// </summary>
	Text,

	/// <summary>
	/// Image watermark.
	/// </summary>
	Image
}
}
