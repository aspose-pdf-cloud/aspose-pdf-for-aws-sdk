using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the angle of rotation.
/// </summary>
public enum RotateAngle
{
	/// <summary>
	/// Rotate the image by 90 degrees.
	/// </summary>
	On90 = 90,

	/// <summary>
	/// Rotate the image by 180 degrees.
	/// </summary>
	On180 = 180,

	/// <summary>
	/// Rotate the image by 270 degrees.
	/// </summary>
	On270 = 270
}
}
