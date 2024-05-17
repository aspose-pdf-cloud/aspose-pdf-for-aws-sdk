using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response class to get or set any api call status
  /// </summary>
  [DataContract]
  public class FileResponse {
    /// <summary>
    /// Get or set StatusCode
    /// </summary>
    /// <value>Get or set StatusCode</value>
    [DataMember(Name="statusCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusCode")]
    public int? StatusCode { get; set; }

    /// <summary>
    /// Get or set Status
    /// </summary>
    /// <value>Get or set Status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Get or set Text
    /// </summary>
    /// <value>Get or set Text</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Get or set Document locked with password
    /// </summary>
    /// <value>Get or set Document locked with password</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Last updated
    /// </summary>
    /// <value>Last updated</value>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Get or set Files
    /// </summary>
    /// <value>Get or set Files</value>
    [DataMember(Name="sharedFiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sharedFiles")]
    public List<FileSafeResult> SharedFiles { get; set; }

    /// <summary>
    /// Get or set Files
    /// </summary>
    /// <value>Get or set Files</value>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public List<string> Files { get; set; }

    /// <summary>
    /// Gets or Sets FileProcessingErrorCode
    /// </summary>
    [DataMember(Name="fileProcessingErrorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileProcessingErrorCode")]
    public FileProcessingErrorCode FileProcessingErrorCode { get; set; }

    /// <summary>
    /// Get count of files
    /// </summary>
    /// <value>Get count of files</value>
    [DataMember(Name="fileCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileCount")]
    public int? FileCount { get; set; }

    /// <summary>
    /// Get or set FileName
    /// </summary>
    /// <value>Get or set FileName</value>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Get or set FolderName
    /// </summary>
    /// <value>Get or set FolderName</value>
    [DataMember(Name="folderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folderName")]
    public string FolderName { get; set; }

    /// <summary>
    /// Data displaying on file processing result page
    /// </summary>
    /// <value>Data displaying on file processing result page</value>
    [DataMember(Name="resultData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultData")]
    public Object ResultData { get; set; }

    /// <summary>
    /// Instance id where is processing located
    /// </summary>
    /// <value>Instance id where is processing located</value>
    [DataMember(Name="appInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appInstanceId")]
    public string AppInstanceId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileResponse {\n");
      sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      sb.Append("  SharedFiles: ").Append(SharedFiles).Append("\n");
      sb.Append("  Files: ").Append(Files).Append("\n");
      sb.Append("  FileProcessingErrorCode: ").Append(FileProcessingErrorCode).Append("\n");
      sb.Append("  FileCount: ").Append(FileCount).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  FolderName: ").Append(FolderName).Append("\n");
      sb.Append("  ResultData: ").Append(ResultData).Append("\n");
      sb.Append("  AppInstanceId: ").Append(AppInstanceId).Append("\n");
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
