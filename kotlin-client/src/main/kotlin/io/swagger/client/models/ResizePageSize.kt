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


/**
 * Specifies the page size for resizing.
 * Values: CUSTOM,A4,A3,LETTER,A5,B5,LEGAL,LEDGER,A6,A2,A1,A0
 */
enum class ResizePageSize(val value: kotlin.String){
    CUSTOM("Custom"),// :/
    A4("A4"),// :/
    A3("A3"),// :/
    LETTER("Letter"),// :/
    A5("A5"),// :/
    B5("B5"),// :/
    LEGAL("Legal"),// :/
    LEDGER("Ledger"),// :/
    A6("A6"),// :/
    A2("A2"),// :/
    A1("A1"),// :/
    A0("A0");// :/
}