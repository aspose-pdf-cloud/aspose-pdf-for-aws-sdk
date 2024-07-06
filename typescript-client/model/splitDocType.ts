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

/**
 * Specifies the type of document splitting.
 */
export type SplitDocType = 'AllPages' | 'OddEven' | 'SpecifiedPage' | 'PageRange' | 'PageRangeIntoSingleFile' | 'NPage';

export const SplitDocType = {
    AllPages: 'AllPages' as SplitDocType,
    OddEven: 'OddEven' as SplitDocType,
    SpecifiedPage: 'SpecifiedPage' as SplitDocType,
    PageRange: 'PageRange' as SplitDocType,
    PageRangeIntoSingleFile: 'PageRangeIntoSingleFile' as SplitDocType,
    NPage: 'NPage' as SplitDocType
};