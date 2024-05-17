using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the compression level.
/// </summary>
public enum CompressType
{
	/// <summary>
	/// Low compression level.
	/// </summary>
	Low = 1,

	/// <summary>
	/// Medium compression level.
	/// </summary>
	Medium = 2,

	/// <summary>
	/// High compression level.
	/// </summary>
	High = 3
}
}
