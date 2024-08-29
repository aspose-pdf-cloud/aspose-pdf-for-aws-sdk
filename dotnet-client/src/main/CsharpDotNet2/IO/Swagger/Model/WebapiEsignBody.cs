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
  public class WebapiEsignBody {
    /// <summary>
    /// Gets or Sets Passw
    /// </summary>
    [DataMember(Name="passw", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passw")]
    public string Passw { get; set; }

    /// <summary>
    /// Gets or Sets Initials
    /// </summary>
    [DataMember(Name="initials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initials")]
    public string Initials { get; set; }

    /// <summary>
    /// Gets or Sets Invite
    /// </summary>
    [DataMember(Name="invite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invite")]
    public string Invite { get; set; }

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
      sb.Append("class WebapiEsignBody {\n");
      sb.Append("  Passw: ").Append(Passw).Append("\n");
      sb.Append("  Initials: ").Append(Initials).Append("\n");
      sb.Append("  Invite: ").Append(Invite).Append("\n");
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
