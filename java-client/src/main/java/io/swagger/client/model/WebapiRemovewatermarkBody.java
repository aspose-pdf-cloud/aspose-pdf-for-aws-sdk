/*
 * Aspose.PDF for AWS
 * Aspose.Pdf for AWS provides a comprehensive set of endpoints for various PDF-related tasks, enabling efficient document processing and manipulation. Users can retrieve processing status, download files, manage file locks, parse documents, redact sensitive information, convert between formats, merge files, add watermarks, perform text searches, and much more. With endpoints for tasks like electronic signing, document comparison, and form filling, the API offers extensive functionality to cater to diverse PDF requirements.
 *
 * OpenAPI spec version: v1
 * Contact: sales@aspose.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * WebapiRemovewatermarkBody
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-08-29T10:06:07.701365036Z[GMT]")

public class WebapiRemovewatermarkBody {
  @SerializedName("watermarkText")
  private String watermarkText = null;

  @SerializedName("top")
  private Integer top = null;

  @SerializedName("left")
  private Integer left = null;

  @SerializedName("bottom")
  private Integer bottom = null;

  @SerializedName("right")
  private Integer right = null;

  @SerializedName("files")
  private List<File> files = null;

  @SerializedName("documentPassword")
  private String documentPassword = null;

  public WebapiRemovewatermarkBody watermarkText(String watermarkText) {
    this.watermarkText = watermarkText;
    return this;
  }

   /**
   * Get watermarkText
   * @return watermarkText
  **/
  @Schema(description = "")
  public String getWatermarkText() {
    return watermarkText;
  }

  public void setWatermarkText(String watermarkText) {
    this.watermarkText = watermarkText;
  }

  public WebapiRemovewatermarkBody top(Integer top) {
    this.top = top;
    return this;
  }

   /**
   * Get top
   * @return top
  **/
  @Schema(description = "")
  public Integer getTop() {
    return top;
  }

  public void setTop(Integer top) {
    this.top = top;
  }

  public WebapiRemovewatermarkBody left(Integer left) {
    this.left = left;
    return this;
  }

   /**
   * Get left
   * @return left
  **/
  @Schema(description = "")
  public Integer getLeft() {
    return left;
  }

  public void setLeft(Integer left) {
    this.left = left;
  }

  public WebapiRemovewatermarkBody bottom(Integer bottom) {
    this.bottom = bottom;
    return this;
  }

   /**
   * Get bottom
   * @return bottom
  **/
  @Schema(description = "")
  public Integer getBottom() {
    return bottom;
  }

  public void setBottom(Integer bottom) {
    this.bottom = bottom;
  }

  public WebapiRemovewatermarkBody right(Integer right) {
    this.right = right;
    return this;
  }

   /**
   * Get right
   * @return right
  **/
  @Schema(description = "")
  public Integer getRight() {
    return right;
  }

  public void setRight(Integer right) {
    this.right = right;
  }

  public WebapiRemovewatermarkBody files(List<File> files) {
    this.files = files;
    return this;
  }

  public WebapiRemovewatermarkBody addFilesItem(File filesItem) {
    if (this.files == null) {
      this.files = new ArrayList<File>();
    }
    this.files.add(filesItem);
    return this;
  }

   /**
   * Get files
   * @return files
  **/
  @Schema(description = "")
  public List<File> getFiles() {
    return files;
  }

  public void setFiles(List<File> files) {
    this.files = files;
  }

  public WebapiRemovewatermarkBody documentPassword(String documentPassword) {
    this.documentPassword = documentPassword;
    return this;
  }

   /**
   * Get documentPassword
   * @return documentPassword
  **/
  @Schema(description = "")
  public String getDocumentPassword() {
    return documentPassword;
  }

  public void setDocumentPassword(String documentPassword) {
    this.documentPassword = documentPassword;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    WebapiRemovewatermarkBody webapiRemovewatermarkBody = (WebapiRemovewatermarkBody) o;
    return Objects.equals(this.watermarkText, webapiRemovewatermarkBody.watermarkText) &&
        Objects.equals(this.top, webapiRemovewatermarkBody.top) &&
        Objects.equals(this.left, webapiRemovewatermarkBody.left) &&
        Objects.equals(this.bottom, webapiRemovewatermarkBody.bottom) &&
        Objects.equals(this.right, webapiRemovewatermarkBody.right) &&
        Objects.equals(this.files, webapiRemovewatermarkBody.files) &&
        Objects.equals(this.documentPassword, webapiRemovewatermarkBody.documentPassword);
  }

  @Override
  public int hashCode() {
    return Objects.hash(watermarkText, top, left, bottom, right, files, documentPassword);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class WebapiRemovewatermarkBody {\n");
    
    sb.append("    watermarkText: ").append(toIndentedString(watermarkText)).append("\n");
    sb.append("    top: ").append(toIndentedString(top)).append("\n");
    sb.append("    left: ").append(toIndentedString(left)).append("\n");
    sb.append("    bottom: ").append(toIndentedString(bottom)).append("\n");
    sb.append("    right: ").append(toIndentedString(right)).append("\n");
    sb.append("    files: ").append(toIndentedString(files)).append("\n");
    sb.append("    documentPassword: ").append(toIndentedString(documentPassword)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
