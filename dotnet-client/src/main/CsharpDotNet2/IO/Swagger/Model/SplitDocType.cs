using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of document splitting.
/// </summary>
public enum SplitDocType
{
	/// <summary>
	/// All pages are included in the split documents.
	/// </summary>
	AllPages = 1,

	/// <summary>
	/// Odd and even pages are split into separate documents.
	/// </summary>
	OddEven = 2,

	/// <summary>
	/// A specific page is split into a separate document.
	/// </summary>
	SpecifiedPage = 3,

	/// <summary>
	/// A range of pages is split into separate documents.
	/// </summary>
	PageRange = 4,

	/// <summary>
	/// A range of pages is split into a single document.
	/// </summary>
	PageRangeIntoSingleFile = 5,

	/// <summary>
	/// Every Nth page is split into a separate document.
	/// </summary>
	NPage = 6
}
}
