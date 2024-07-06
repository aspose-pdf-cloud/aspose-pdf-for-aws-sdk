/**
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
package io.swagger.client.models

import io.swagger.client.models.PropertyType

/**
 * Represents a document property.
 * @param key Gets or sets the key of the property.
 * @param name Gets or sets the name of the property.
 * @param value Gets or sets the value of the property.
 * @param type 
 * @param readOnly Gets or sets a value indicating whether the property is read-only.
 */
data class DocProperty (

    /* Gets or sets the key of the property. */
    val key: kotlin.String? = null,
    /* Gets or sets the name of the property. */
    val name: kotlin.String? = null,
    /* Gets or sets the value of the property. */
    val value: kotlin.Any? = null,
    val type: PropertyType? = null,
    /* Gets or sets a value indicating whether the property is read-only. */
    val readOnly: kotlin.Boolean? = null
) {
}