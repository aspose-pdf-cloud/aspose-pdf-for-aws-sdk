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
  public class ResourceMessage {
    /// <summary>
    /// Gets or Sets ResourceKey
    /// </summary>
    [DataMember(Name="resourceKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceKey")]
    public string ResourceKey { get; set; }

    /// <summary>
    /// Gets or Sets Args
    /// </summary>
    [DataMember(Name="args", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "args")]
    public List<string> Args { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResourceMessage {\n");
      sb.Append("  ResourceKey: ").Append(ResourceKey).Append("\n");
      sb.Append("  Args: ").Append(Args).Append("\n");
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
