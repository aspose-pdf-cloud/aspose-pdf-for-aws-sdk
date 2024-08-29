/**
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
package io.swagger.client.models

import io.swagger.client.models.FileProcessingErrorCode
import io.swagger.client.models.FileSafeResult

/**
 * Response class to get or set any api call status
 * @param statusCode Get or set StatusCode
 * @param status Get or set Status
 * @param text Get or set Text
 * @param locked Get or set Document locked with password
 * @param updated Last updated
 * @param sharedFiles Get or set Files
 * @param fileProcessingErrorCode 
 * @param fileCount Get count of files
 * @param fileName Get or set FileName
 * @param folderName Get or set FolderName
 * @param resultData Data displaying on file processing result page
 * @param appInstanceId Instance id where is processing located
 * @param errorCallStack 
 */
data class FileResponse (

    /* Get or set StatusCode */
    val statusCode: kotlin.Int? = null,
    /* Get or set Status */
    val status: kotlin.String? = null,
    /* Get or set Text */
    val text: kotlin.String? = null,
    /* Get or set Document locked with password */
    val locked: kotlin.Boolean? = null,
    /* Last updated */
    val updated: java.time.LocalDateTime? = null,
    /* Get or set Files */
    val sharedFiles: kotlin.Array<FileSafeResult>? = null,
    val fileProcessingErrorCode: FileProcessingErrorCode? = null,
    /* Get count of files */
    val fileCount: kotlin.Int? = null,
    /* Get or set FileName */
    val fileName: kotlin.String? = null,
    /* Get or set FolderName */
    val folderName: kotlin.String? = null,
    /* Data displaying on file processing result page */
    val resultData: kotlin.Any? = null,
    /* Instance id where is processing located */
    val appInstanceId: kotlin.String? = null,
    val errorCallStack: kotlin.String? = null
) {
}