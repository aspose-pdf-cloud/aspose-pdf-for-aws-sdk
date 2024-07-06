/*
 * Aspose.Pdf RestApi
 * Aspose.Pdf RestApi provides a comprehensive set of endpoints for various PDF-related tasks, enabling efficient document processing and manipulation. Users can retrieve processing status, download files, manage file locks, parse documents, redact sensitive information, convert between formats, merge files, add watermarks, perform text searches, and much more. With endpoints for tasks like electronic signing, document comparison, and form filling, the API offers extensive functionality to cater to diverse PDF requirements.
 *
 * OpenAPI spec version: v1
 * Contact: Evgeny.Pirogov@aspose.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import io.swagger.v3.oas.annotations.media.Schema;
import com.google.gson.annotations.SerializedName;
import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * Metadata property type
 */
@JsonAdapter(PropertyType.Adapter.class)
public enum PropertyType {
  @SerializedName("Boolean")
  BOOLEAN("Boolean"),
  @SerializedName("DateTime")
  DATETIME("DateTime"),
  @SerializedName("Double")
  DOUBLE("Double"),
  @SerializedName("Number")
  NUMBER("Number"),
  @SerializedName("String")
  STRING("String"),
  @SerializedName("StringArray")
  STRINGARRAY("StringArray"),
  @SerializedName("ObjectArray")
  OBJECTARRAY("ObjectArray"),
  @SerializedName("ByteArray")
  BYTEARRAY("ByteArray"),
  @SerializedName("Other")
  OTHER("Other");

  private String value;

  PropertyType(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static PropertyType fromValue(String input) {
    for (PropertyType b : PropertyType.values()) {
      if (b.value.equals(input)) {
        return b;
      }
    }
    return null;
  }

  public static class Adapter extends TypeAdapter<PropertyType> {
    @Override
    public void write(final JsonWriter jsonWriter, final PropertyType enumeration) throws IOException {
      jsonWriter.value(String.valueOf(enumeration.getValue()));
    }

    @Override
    public PropertyType read(final JsonReader jsonReader) throws IOException {
      Object value = jsonReader.nextString();
      return PropertyType.fromValue((String)(value));
    }
  }
}