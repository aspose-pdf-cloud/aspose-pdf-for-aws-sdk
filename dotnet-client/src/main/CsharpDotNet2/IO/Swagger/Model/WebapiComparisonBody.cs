using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WebapiComparisonBody {
    /// <summary>
    /// Gets or Sets Files
    /// </summary>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public List<byte[]> Files { get; set; }

    /// <summary>
    /// Gets or Sets DocumentPassword
    /// </summary>
    [DataMember(Name="documentPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentPassword")]
    public string DocumentPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebapiComparisonBody {\n");
      sb.Append("  Files: ").Append(Files).Append("\n");
      sb.Append("  DocumentPassword: ").Append(DocumentPassword).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
