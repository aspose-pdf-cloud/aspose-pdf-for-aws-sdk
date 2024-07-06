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

import io.swagger.client.models.DocProperty

/**
 * File processing result.
 * @param isSuccess Processing status
 * @param id Upload id.
 * @param fileName File name.
 * @param uploadFileName Gets or sets the name of the upload file.
 * @param idUpload idUpload from request.
 * @param fileLength File length.
 * @param builtProp 
 * @param customProp 
 */
data class FileSafeResult (

    /* Processing status */
    val isSuccess: kotlin.Boolean? = null,
    /* Upload id. */
    val id: kotlin.String? = null,
    /* File name. */
    val fileName: kotlin.String? = null,
    /* Gets or sets the name of the upload file. */
    val uploadFileName: kotlin.String? = null,
    /* idUpload from request. */
    val idUpload: kotlin.String? = null,
    /* File length. */
    val fileLength: kotlin.Long? = null,
    val builtProp: kotlin.Array<DocProperty>? = null,
    val customProp: kotlin.Array<DocProperty>? = null
) {
}