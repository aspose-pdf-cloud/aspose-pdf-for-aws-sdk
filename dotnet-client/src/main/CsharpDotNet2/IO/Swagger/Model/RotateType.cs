using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of rotation.
/// </summary>
public enum RotateType
{
	/// <summary>
	/// Rotate selected pages.
	/// </summary>
	S = 's',

	/// <summary>
	/// Rotate all pages.
	/// </summary>
	A = 'a'
}
}
