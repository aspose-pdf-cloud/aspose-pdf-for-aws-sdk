using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the page size for the merged images.
/// </summary>
public enum PageSize
{
	/// <summary>
	/// The page size is A4.
	/// </summary>
	A4,

	/// <summary>
	/// The page size is Letter.
	/// </summary>
	Letter,

	/// <summary>
	/// The page size is Fit to content.
	/// </summary>
	Fit
}
}
