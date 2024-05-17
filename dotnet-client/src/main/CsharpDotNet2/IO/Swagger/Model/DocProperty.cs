using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a document property.
  /// </summary>
  [DataContract]
  public class DocProperty {
    /// <summary>
    /// Gets or sets the key of the property.
    /// </summary>
    /// <value>Gets or sets the key of the property.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or sets the name of the property.
    /// </summary>
    /// <value>Gets or sets the name of the property.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the value of the property.
    /// </summary>
    /// <value>Gets or sets the value of the property.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public Object Value { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public PropertyType Type { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the property is read-only.
    /// </summary>
    /// <value>Gets or sets a value indicating whether the property is read-only.</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? _ReadOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocProperty {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
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
