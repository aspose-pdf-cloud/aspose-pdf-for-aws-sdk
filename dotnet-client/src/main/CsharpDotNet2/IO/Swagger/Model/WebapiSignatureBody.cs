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
  public class WebapiSignatureBody {
    /// <summary>
    /// The base64 representation of image signature.
    /// </summary>
    /// <value>The base64 representation of image signature.</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// The text of signature.
    /// </summary>
    /// <value>The text of signature.</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// The text color of signature.
    /// </summary>
    /// <value>The text color of signature.</value>
    [DataMember(Name="textColor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textColor")]
    public string TextColor { get; set; }

    /// <summary>
    /// The files to add a signature to.
    /// </summary>
    /// <value>The files to add a signature to.</value>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public List<byte[]> Files { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebapiSignatureBody {\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  TextColor: ").Append(TextColor).Append("\n");
      sb.Append("  Files: ").Append(Files).Append("\n");
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
