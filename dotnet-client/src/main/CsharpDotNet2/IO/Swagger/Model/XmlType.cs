using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
/// Specifies the type of XML file.
/// </summary>
public enum XmlType
{
	/// <summary>
	/// APS XML file.
	/// </summary>
	APS = 1,

	/// <summary>
	/// MobiXML file.
	/// </summary>
	MobiXml = 2,

	/// <summary>
	/// PDFXML file.
	/// </summary>
	PdfXml = 3,

	/// <summary>
	/// XLSX (Microsoft Excel XML) file.
	/// </summary>
	Xlsx = 4
}
}
