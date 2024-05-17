using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// File processing result.
  /// </summary>
  [DataContract]
  public class FileSafeResult {
    /// <summary>
    /// Processing status
    /// </summary>
    /// <value>Processing status</value>
    [DataMember(Name="isSuccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSuccess")]
    public bool? IsSuccess { get; set; }

    /// <summary>
    /// Upload id.
    /// </summary>
    /// <value>Upload id.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// File name.
    /// </summary>
    /// <value>File name.</value>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Gets or sets the name of the upload file.
    /// </summary>
    /// <value>Gets or sets the name of the upload file.</value>
    [DataMember(Name="uploadFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploadFileName")]
    public string UploadFileName { get; set; }

    /// <summary>
    /// idUpload from request.
    /// </summary>
    /// <value>idUpload from request.</value>
    [DataMember(Name="idUpload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idUpload")]
    public string IdUpload { get; set; }

    /// <summary>
    /// File length.
    /// </summary>
    /// <value>File length.</value>
    [DataMember(Name="fileLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileLength")]
    public long? FileLength { get; set; }

    /// <summary>
    /// Gets or Sets BuiltProp
    /// </summary>
    [DataMember(Name="builtProp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "builtProp")]
    public List<DocProperty> BuiltProp { get; set; }

    /// <summary>
    /// Gets or Sets CustomProp
    /// </summary>
    [DataMember(Name="customProp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProp")]
    public List<DocProperty> CustomProp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileSafeResult {\n");
      sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  UploadFileName: ").Append(UploadFileName).Append("\n");
      sb.Append("  IdUpload: ").Append(IdUpload).Append("\n");
      sb.Append("  FileLength: ").Append(FileLength).Append("\n");
      sb.Append("  BuiltProp: ").Append(BuiltProp).Append("\n");
      sb.Append("  CustomProp: ").Append(CustomProp).Append("\n");
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
