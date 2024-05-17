using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the page size for resizing.
/// </summary>
public enum ResizePageSize
{
	/// <summary>
	/// Custom page size.
	/// </summary>
	Custom,

	/// <summary>
	/// A4 page size.
	/// </summary>
	A4,

	/// <summary>
	/// A3 page size.
	/// </summary>
	A3,

	/// <summary>
	/// Letter page size.
	/// </summary>
	Letter,

	/// <summary>
	/// A5 page size.
	/// </summary>
	A5,

	/// <summary>
	/// B5 page size.
	/// </summary>
	B5,

	/// <summary>
	/// Legal page size.
	/// </summary>
	Legal,

	/// <summary>
	/// Ledger page size.
	/// </summary>
	Ledger,

	/// <summary>
	/// A6 page size.
	/// </summary>
	A6,

	/// <summary>
	/// A2 page size.
	/// </summary>
	A2,

	/// <summary>
	/// A1 page size.
	/// </summary>
	A1,

	/// <summary>
	/// A0 page size.
	/// </summary>
	A0
}
}
