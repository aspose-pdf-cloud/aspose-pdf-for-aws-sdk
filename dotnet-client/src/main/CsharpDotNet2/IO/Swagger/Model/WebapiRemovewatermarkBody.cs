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
  public class WebapiRemovewatermarkBody {
    /// <summary>
    /// The text of the watermark to remove.
    /// </summary>
    /// <value>The text of the watermark to remove.</value>
    [DataMember(Name="watermarkText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "watermarkText")]
    public string WatermarkText { get; set; }

    /// <summary>
    /// The top position of the watermark.
    /// </summary>
    /// <value>The top position of the watermark.</value>
    [DataMember(Name="top", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top")]
    public int? Top { get; set; }

    /// <summary>
    /// The left position of the watermark.
    /// </summary>
    /// <value>The left position of the watermark.</value>
    [DataMember(Name="left", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "left")]
    public int? Left { get; set; }

    /// <summary>
    /// The bottom position of the watermark.
    /// </summary>
    /// <value>The bottom position of the watermark.</value>
    [DataMember(Name="bottom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bottom")]
    public int? Bottom { get; set; }

    /// <summary>
    /// The right position of the watermark.
    /// </summary>
    /// <value>The right position of the watermark.</value>
    [DataMember(Name="right", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "right")]
    public int? Right { get; set; }

    /// <summary>
    /// The files to remove the watermark from.
    /// </summary>
    /// <value>The files to remove the watermark from.</value>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public List<byte[]> Files { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebapiRemovewatermarkBody {\n");
      sb.Append("  WatermarkText: ").Append(WatermarkText).Append("\n");
      sb.Append("  Top: ").Append(Top).Append("\n");
      sb.Append("  Left: ").Append(Left).Append("\n");
      sb.Append("  Bottom: ").Append(Bottom).Append("\n");
      sb.Append("  Right: ").Append(Right).Append("\n");
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
