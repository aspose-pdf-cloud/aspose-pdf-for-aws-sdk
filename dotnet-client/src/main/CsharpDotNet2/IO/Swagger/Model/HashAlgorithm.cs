using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the hash algorithm to use.
/// </summary>
public enum HashAlgorithm
{
	/// <summary>
	/// The SHA-1 hash algorithm.
	/// </summary>
	SHA1,

	/// <summary>
	/// The SHA-256 hash algorithm.
	/// </summary>
	SHA256,

	/// <summary>
	/// The SHA-384 hash algorithm.
	/// </summary>
	SHA384,

	/// <summary>
	/// The SHA-512 hash algorithm.
	/// </summary>
	SHA512,

	/// <summary>
	/// The MD5 hash algorithm.
	/// </summary>
	MD5
}
}
