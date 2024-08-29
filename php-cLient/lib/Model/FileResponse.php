<?php
/**
 * FileResponse
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

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * FileResponse Class Doc Comment
 *
 * @category Class
 * @description Response class to get or set any api call status
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class FileResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'FileResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'status_code' => 'int',
        'status' => 'string',
        'text' => 'string',
        'locked' => 'bool',
        'updated' => '\DateTime',
        'shared_files' => '\Swagger\Client\Model\FileSafeResult[]',
        'file_processing_error_code' => '\Swagger\Client\Model\FileProcessingErrorCode',
        'file_count' => 'int',
        'file_name' => 'string',
        'folder_name' => 'string',
        'result_data' => '',
        'app_instance_id' => 'string',
        'error_call_stack' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'status_code' => 'int32',
        'status' => null,
        'text' => null,
        'locked' => null,
        'updated' => 'date-time',
        'shared_files' => null,
        'file_processing_error_code' => null,
        'file_count' => 'int32',
        'file_name' => null,
        'folder_name' => null,
        'result_data' => null,
        'app_instance_id' => null,
        'error_call_stack' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'status_code' => 'statusCode',
        'status' => 'status',
        'text' => 'text',
        'locked' => 'locked',
        'updated' => 'updated',
        'shared_files' => 'sharedFiles',
        'file_processing_error_code' => 'fileProcessingErrorCode',
        'file_count' => 'fileCount',
        'file_name' => 'fileName',
        'folder_name' => 'folderName',
        'result_data' => 'resultData',
        'app_instance_id' => 'appInstanceId',
        'error_call_stack' => 'errorCallStack'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'status_code' => 'setStatusCode',
        'status' => 'setStatus',
        'text' => 'setText',
        'locked' => 'setLocked',
        'updated' => 'setUpdated',
        'shared_files' => 'setSharedFiles',
        'file_processing_error_code' => 'setFileProcessingErrorCode',
        'file_count' => 'setFileCount',
        'file_name' => 'setFileName',
        'folder_name' => 'setFolderName',
        'result_data' => 'setResultData',
        'app_instance_id' => 'setAppInstanceId',
        'error_call_stack' => 'setErrorCallStack'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'status_code' => 'getStatusCode',
        'status' => 'getStatus',
        'text' => 'getText',
        'locked' => 'getLocked',
        'updated' => 'getUpdated',
        'shared_files' => 'getSharedFiles',
        'file_processing_error_code' => 'getFileProcessingErrorCode',
        'file_count' => 'getFileCount',
        'file_name' => 'getFileName',
        'folder_name' => 'getFolderName',
        'result_data' => 'getResultData',
        'app_instance_id' => 'getAppInstanceId',
        'error_call_stack' => 'getErrorCallStack'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }



    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['status_code'] = isset($data['status_code']) ? $data['status_code'] : null;
        $this->container['status'] = isset($data['status']) ? $data['status'] : null;
        $this->container['text'] = isset($data['text']) ? $data['text'] : null;
        $this->container['locked'] = isset($data['locked']) ? $data['locked'] : null;
        $this->container['updated'] = isset($data['updated']) ? $data['updated'] : null;
        $this->container['shared_files'] = isset($data['shared_files']) ? $data['shared_files'] : null;
        $this->container['file_processing_error_code'] = isset($data['file_processing_error_code']) ? $data['file_processing_error_code'] : null;
        $this->container['file_count'] = isset($data['file_count']) ? $data['file_count'] : null;
        $this->container['file_name'] = isset($data['file_name']) ? $data['file_name'] : null;
        $this->container['folder_name'] = isset($data['folder_name']) ? $data['folder_name'] : null;
        $this->container['result_data'] = isset($data['result_data']) ? $data['result_data'] : null;
        $this->container['app_instance_id'] = isset($data['app_instance_id']) ? $data['app_instance_id'] : null;
        $this->container['error_call_stack'] = isset($data['error_call_stack']) ? $data['error_call_stack'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets status_code
     *
     * @return int
     */
    public function getStatusCode()
    {
        return $this->container['status_code'];
    }

    /**
     * Sets status_code
     *
     * @param int $status_code Get or set StatusCode
     *
     * @return $this
     */
    public function setStatusCode($status_code)
    {
        $this->container['status_code'] = $status_code;

        return $this;
    }

    /**
     * Gets status
     *
     * @return string
     */
    public function getStatus()
    {
        return $this->container['status'];
    }

    /**
     * Sets status
     *
     * @param string $status Get or set Status
     *
     * @return $this
     */
    public function setStatus($status)
    {
        $this->container['status'] = $status;

        return $this;
    }

    /**
     * Gets text
     *
     * @return string
     */
    public function getText()
    {
        return $this->container['text'];
    }

    /**
     * Sets text
     *
     * @param string $text Get or set Text
     *
     * @return $this
     */
    public function setText($text)
    {
        $this->container['text'] = $text;

        return $this;
    }

    /**
     * Gets locked
     *
     * @return bool
     */
    public function getLocked()
    {
        return $this->container['locked'];
    }

    /**
     * Sets locked
     *
     * @param bool $locked Get or set Document locked with password
     *
     * @return $this
     */
    public function setLocked($locked)
    {
        $this->container['locked'] = $locked;

        return $this;
    }

    /**
     * Gets updated
     *
     * @return \DateTime
     */
    public function getUpdated()
    {
        return $this->container['updated'];
    }

    /**
     * Sets updated
     *
     * @param \DateTime $updated Last updated
     *
     * @return $this
     */
    public function setUpdated($updated)
    {
        $this->container['updated'] = $updated;

        return $this;
    }

    /**
     * Gets shared_files
     *
     * @return \Swagger\Client\Model\FileSafeResult[]
     */
    public function getSharedFiles()
    {
        return $this->container['shared_files'];
    }

    /**
     * Sets shared_files
     *
     * @param \Swagger\Client\Model\FileSafeResult[] $shared_files Get or set Files
     *
     * @return $this
     */
    public function setSharedFiles($shared_files)
    {
        $this->container['shared_files'] = $shared_files;

        return $this;
    }

    /**
     * Gets file_processing_error_code
     *
     * @return \Swagger\Client\Model\FileProcessingErrorCode
     */
    public function getFileProcessingErrorCode()
    {
        return $this->container['file_processing_error_code'];
    }

    /**
     * Sets file_processing_error_code
     *
     * @param \Swagger\Client\Model\FileProcessingErrorCode $file_processing_error_code file_processing_error_code
     *
     * @return $this
     */
    public function setFileProcessingErrorCode($file_processing_error_code)
    {
        $this->container['file_processing_error_code'] = $file_processing_error_code;

        return $this;
    }

    /**
     * Gets file_count
     *
     * @return int
     */
    public function getFileCount()
    {
        return $this->container['file_count'];
    }

    /**
     * Sets file_count
     *
     * @param int $file_count Get count of files
     *
     * @return $this
     */
    public function setFileCount($file_count)
    {
        $this->container['file_count'] = $file_count;

        return $this;
    }

    /**
     * Gets file_name
     *
     * @return string
     */
    public function getFileName()
    {
        return $this->container['file_name'];
    }

    /**
     * Sets file_name
     *
     * @param string $file_name Get or set FileName
     *
     * @return $this
     */
    public function setFileName($file_name)
    {
        $this->container['file_name'] = $file_name;

        return $this;
    }

    /**
     * Gets folder_name
     *
     * @return string
     */
    public function getFolderName()
    {
        return $this->container['folder_name'];
    }

    /**
     * Sets folder_name
     *
     * @param string $folder_name Get or set FolderName
     *
     * @return $this
     */
    public function setFolderName($folder_name)
    {
        $this->container['folder_name'] = $folder_name;

        return $this;
    }

    /**
     * Gets result_data
     *
     * @return 
     */
    public function getResultData()
    {
        return $this->container['result_data'];
    }

    /**
     * Sets result_data
     *
     * @param  $result_data Data displaying on file processing result page
     *
     * @return $this
     */
    public function setResultData($result_data)
    {
        $this->container['result_data'] = $result_data;

        return $this;
    }

    /**
     * Gets app_instance_id
     *
     * @return string
     */
    public function getAppInstanceId()
    {
        return $this->container['app_instance_id'];
    }

    /**
     * Sets app_instance_id
     *
     * @param string $app_instance_id Instance id where is processing located
     *
     * @return $this
     */
    public function setAppInstanceId($app_instance_id)
    {
        $this->container['app_instance_id'] = $app_instance_id;

        return $this;
    }

    /**
     * Gets error_call_stack
     *
     * @return string
     */
    public function getErrorCallStack()
    {
        return $this->container['error_call_stack'];
    }

    /**
     * Sets error_call_stack
     *
     * @param string $error_call_stack error_call_stack
     *
     * @return $this
     */
    public function setErrorCallStack($error_call_stack)
    {
        $this->container['error_call_stack'] = $error_call_stack;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    #[\ReturnTypeWillChange]
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
