<?php
/**
 * SplitDocType
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Aspose.Pdf RestApi
 *
 * Aspose.Pdf RestApi provides a comprehensive set of endpoints for various PDF-related tasks, enabling efficient document processing and manipulation. Users can retrieve processing status, download files, manage file locks, parse documents, redact sensitive information, convert between formats, merge files, add watermarks, perform text searches, and much more. With endpoints for tasks like electronic signing, document comparison, and form filling, the API offers extensive functionality to cater to diverse PDF requirements.
 *
 * OpenAPI spec version: v1
 * Contact: Evgeny.Pirogov@aspose.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.54
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;
use \Swagger\Client\ObjectSerializer;

/**
 * SplitDocType Class Doc Comment
 *
 * @category Class
 * @description Specifies the type of document splitting.
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class SplitDocType
{
    /**
     * Possible values of this enum
     */
    const ALL_PAGES = 'AllPages';
    const ODD_EVEN = 'OddEven';
    const SPECIFIED_PAGE = 'SpecifiedPage';
    const PAGE_RANGE = 'PageRange';
    const PAGE_RANGE_INTO_SINGLE_FILE = 'PageRangeIntoSingleFile';
    const N_PAGE = 'NPage';
    /**
     * Gets allowable values of the enum
     * @return string[]
     */
    public static function getAllowableEnumValues()
    {
        return [
            self::ALL_PAGES
            self::ODD_EVEN
            self::SPECIFIED_PAGE
            self::PAGE_RANGE
            self::PAGE_RANGE_INTO_SINGLE_FILE
            self::N_PAGE
        ];
    }
}
