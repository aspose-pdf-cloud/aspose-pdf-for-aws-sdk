<?php
/**
 * FileProcessingErrorCode
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Aspose.PDF for AWS
 *
 * Aspose.Pdf for AWS provides a comprehensive set of endpoints for various PDF-related tasks, enabling efficient document processing and manipulation. Users can retrieve processing status, download files, manage file locks, parse documents, redact sensitive information, convert between formats, merge files, add watermarks, perform text searches, and much more. With endpoints for tasks like electronic signing, document comparison, and form filling, the API offers extensive functionality to cater to diverse PDF requirements.
 *
 * OpenAPI spec version: v1
 * Contact: sales@aspose.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.60
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;
use \Swagger\Client\ObjectSerializer;

/**
 * FileProcessingErrorCode Class Doc Comment
 *
 * @category Class
 * @description FileProcessingErrorCode enum
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class FileProcessingErrorCode
{
    /**
     * Possible values of this enum
     */
    const OK = 'OK';
    const NO_IMAGES_FOUND = 'NoImagesFound';
    const NO_SEARCH_RESULTS = 'NoSearchResults';
    const WRONG_REG_EXP = 'WrongRegExp';
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public static function getAllowableEnumValues()
    {
        return [
            self::OK
            self::NO_IMAGES_FOUND
            self::NO_SEARCH_RESULTS
            self::WRONG_REG_EXP
        ];
    }
}
