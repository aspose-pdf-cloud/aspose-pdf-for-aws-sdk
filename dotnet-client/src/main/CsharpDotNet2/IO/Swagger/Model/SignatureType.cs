using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of signature.
/// </summary>
public enum SignatureType
{
	/// <summary>
	/// Signature is an image.
	/// </summary>
	Image,

	/// <summary>
	/// Signature is a drawing.
	/// </summary>
	Drawing,

	/// <summary>
	/// Signature is text.
	/// </summary>
	Text
}
}
