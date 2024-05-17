using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the preset type for resizing.
/// </summary>
public enum ResizePresetType
{
	/// <summary>
	/// Instagram preset type.
	/// </summary>
	Instagram,

	/// <summary>
	/// Facebook preset type.
	/// </summary>
	Facebook,

	/// <summary>
	/// Twitter preset type.
	/// </summary>
	Twitter,

	/// <summary>
	/// Youtube preset type.
	/// </summary>
	Youtube,

	/// <summary>
	/// Pinterest preset type.
	/// </summary>
	Pinterest,

	/// <summary>
	/// LinkedIn preset type.
	/// </summary>
	LinkedIn,

	/// <summary>
	/// Snapchat preset type.
	/// </summary>
	Snapchat,

	/// <summary>
	/// Standard preset type.
	/// </summary>
	Standard
}
}
