using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of metadata operation.
/// </summary>
public enum MetadataOperation
{
	/// <summary>
	/// Retrieve metadata.
	/// </summary>
	Get,

	/// <summary>
	/// Set metadata.
	/// </summary>
	Set
}
}
