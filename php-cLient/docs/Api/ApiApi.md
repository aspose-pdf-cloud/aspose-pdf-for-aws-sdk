# Swagger\Client\ApiApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pdfWebapiAddnumberPost**](ApiApi.md#pdfwebapiaddnumberpost) | **POST** /pdf/webapi/addnumber | Add Page Numbers to Document.
[**pdfWebapiChangeFontsPost**](ApiApi.md#pdfwebapichangefontspost) | **POST** /pdf/webapi/change-fonts | Change Fonts in Provided Files.
[**pdfWebapiComparisonPost**](ApiApi.md#pdfwebapicomparisonpost) | **POST** /pdf/webapi/comparison | Compare documents text.
[**pdfWebapiCompressPost**](ApiApi.md#pdfwebapicompresspost) | **POST** /pdf/webapi/compress | Compress Document.
[**pdfWebapiConvertPost**](ApiApi.md#pdfwebapiconvertpost) | **POST** /pdf/webapi/convert | Convert Document to Another Format.
[**pdfWebapiConvertWebpagePost**](ApiApi.md#pdfwebapiconvertwebpagepost) | **POST** /pdf/webapi/convert-webpage | Convert Web Page to Document.
[**pdfWebapiCropPost**](ApiApi.md#pdfwebapicroppost) | **POST** /pdf/webapi/crop | Crop Document.
[**pdfWebapiDownloadIdGet**](ApiApi.md#pdfwebapidownloadidget) | **GET** /pdf/webapi/download/{id} | File download.
[**pdfWebapiEsignPost**](ApiApi.md#pdfwebapiesignpost) | **POST** /pdf/webapi/esign | Sign Document with Certificate.
[**pdfWebapiExtractPost**](ApiApi.md#pdfwebapiextractpost) | **POST** /pdf/webapi/extract | Extract Tables from Document.
[**pdfWebapiGifPost**](ApiApi.md#pdfwebapigifpost) | **POST** /pdf/webapi/gif | Make GIF.
[**pdfWebapiHashPost**](ApiApi.md#pdfwebapihashpost) | **POST** /pdf/webapi/hash | Calculate Document Hash.
[**pdfWebapiLockPost**](ApiApi.md#pdfwebapilockpost) | **POST** /pdf/webapi/lock | Lock document.
[**pdfWebapiMergePost**](ApiApi.md#pdfwebapimergepost) | **POST** /pdf/webapi/merge | Merge Documents.
[**pdfWebapiMetadataPost**](ApiApi.md#pdfwebapimetadatapost) | **POST** /pdf/webapi/metadata | Read and Change Document Metadata.
[**pdfWebapiOrganizePost**](ApiApi.md#pdfwebapiorganizepost) | **POST** /pdf/webapi/organize | Organize Document Pages.
[**pdfWebapiParsePost**](ApiApi.md#pdfwebapiparsepost) | **POST** /pdf/webapi/parse | Parse Document.
[**pdfWebapiRedactPost**](ApiApi.md#pdfwebapiredactpost) | **POST** /pdf/webapi/redact | Redact Document Text.
[**pdfWebapiRemoveIdPost**](ApiApi.md#pdfwebapiremoveidpost) | **POST** /pdf/webapi/remove/{id} | Remove stored files.
[**pdfWebapiRemovePost**](ApiApi.md#pdfwebapiremovepost) | **POST** /pdf/webapi/remove | Remove Document Annotations.
[**pdfWebapiRemoveWatermarkPost**](ApiApi.md#pdfwebapiremovewatermarkpost) | **POST** /pdf/webapi/remove-watermark | Remove Document Watermark.
[**pdfWebapiRemovepagesPost**](ApiApi.md#pdfwebapiremovepagespost) | **POST** /pdf/webapi/removepages | Remove Pages from Document.
[**pdfWebapiRepairPost**](ApiApi.md#pdfwebapirepairpost) | **POST** /pdf/webapi/repair | Repair Document.
[**pdfWebapiResizePost**](ApiApi.md#pdfwebapiresizepost) | **POST** /pdf/webapi/resize | Resize Document.
[**pdfWebapiRotatePost**](ApiApi.md#pdfwebapirotatepost) | **POST** /pdf/webapi/rotate | Rotate Document.
[**pdfWebapiSearchPost**](ApiApi.md#pdfwebapisearchpost) | **POST** /pdf/webapi/search | Search Document Text.
[**pdfWebapiSearchablePost**](ApiApi.md#pdfwebapisearchablepost) | **POST** /pdf/webapi/searchable | Make Scanned PDF Searchable.
[**pdfWebapiSignaturePost**](ApiApi.md#pdfwebapisignaturepost) | **POST** /pdf/webapi/signature | Add Signature to Document.
[**pdfWebapiSplitdocPost**](ApiApi.md#pdfwebapisplitdocpost) | **POST** /pdf/webapi/splitdoc | Split Document.
[**pdfWebapiSplitimagePost**](ApiApi.md#pdfwebapisplitimagepost) | **POST** /pdf/webapi/splitimage | Split Image.
[**pdfWebapiStatusIdPost**](ApiApi.md#pdfwebapistatusidpost) | **POST** /pdf/webapi/status/{id} | Processing status.
[**pdfWebapiUnlockPost**](ApiApi.md#pdfwebapiunlockpost) | **POST** /pdf/webapi/unlock | Unlock Document.
[**pdfWebapiVerifyEsignPost**](ApiApi.md#pdfwebapiverifyesignpost) | **POST** /pdf/webapi/verify_esign | Verify Document Certificate.
[**pdfWebapiWatermarkPost**](ApiApi.md#pdfwebapiwatermarkpost) | **POST** /pdf/webapi/watermark | Add Watermark to Document.
[**pdfWebapiWordcounterPost**](ApiApi.md#pdfwebapiwordcounterpost) | **POST** /pdf/webapi/wordcounter | Count Words and Characters in Document.
[**pdfWebapiXfaconvertPost**](ApiApi.md#pdfwebapixfaconvertpost) | **POST** /pdf/webapi/xfaconvert | Convert XFA Format to Another Format.

# **pdfWebapiAddnumberPost**
> \Swagger\Client\Model\FileResponse pdfWebapiAddnumberPost($files, $document_password, $v_alignment, $h_alignment, $starting_number, $s_number, $f_number, $margin, $font_size, $format)

Add Page Numbers to Document.

Adds page numbers to your documents based on specified alignment, starting number, and format. The service ensures that page numbers are accurately applied, improving the readability and professionalism of your documents. It supports various formats, including DOC, PPTX, TIFF, DOCX, and PDF, to cater to your specific requirements.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$v_alignment = new \Swagger\Client\Model\PageNumberVerticalAlign(); // \Swagger\Client\Model\PageNumberVerticalAlign | The vertical alignment of the page numbers.
$h_alignment = new \Swagger\Client\Model\PageNumberHorizontalAlign(); // \Swagger\Client\Model\PageNumberHorizontalAlign | The horizontal alignment of the page numbers.
$starting_number = 56; // int | The starting number for the page numbers.
$s_number = 56; // int | The number of the first page to start numbering from.
$f_number = 56; // int | The number of the last page to end numbering at.
$margin = 56; // int | The margin around the page numbers.
$font_size = 56; // int | The font size of the page numbers.
$format = "format_example"; // string | The format of the page numbers.

try {
    $result = $apiInstance->pdfWebapiAddnumberPost($files, $document_password, $v_alignment, $h_alignment, $starting_number, $s_number, $f_number, $margin, $font_size, $format);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiAddnumberPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **v_alignment** | [**\Swagger\Client\Model\PageNumberVerticalAlign**](../Model/.md)| The vertical alignment of the page numbers. | [optional]
 **h_alignment** | [**\Swagger\Client\Model\PageNumberHorizontalAlign**](../Model/.md)| The horizontal alignment of the page numbers. | [optional]
 **starting_number** | **int**| The starting number for the page numbers. | [optional]
 **s_number** | **int**| The number of the first page to start numbering from. | [optional]
 **f_number** | **int**| The number of the last page to end numbering at. | [optional]
 **margin** | **int**| The margin around the page numbers. | [optional]
 **font_size** | **int**| The font size of the page numbers. | [optional]
 **format** | **string**| The format of the page numbers. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiChangeFontsPost**
> \Swagger\Client\Model\FileResponse pdfWebapiChangeFontsPost($font_replacements_json, $files, $document_password)

Change Fonts in Provided Files.

Updates the fonts in your documents according to specified replacements.  Provide the font replacement details as a JSON string and upload your files using multipart/form-data.The service processes these requests asynchronously using Kafka, ensuring efficient handling of your files.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$font_replacements_json = "font_replacements_json_example"; // string | 
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 

try {
    $result = $apiInstance->pdfWebapiChangeFontsPost($font_replacements_json, $files, $document_password);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiChangeFontsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **font_replacements_json** | **string**|  | [optional]
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiComparisonPost**
> \Swagger\Client\Model\FileResponse pdfWebapiComparisonPost($files, $document_password)

Compare documents text.

Compares the text of the provided documents and highlights the differences. Upload the files you want to compare, and the service will analyze them to detect any changes in the text. The result is a new document that clearly marks all text variations, making it easy to review and understand the modifications between the original and updated versions.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 

try {
    $result = $apiInstance->pdfWebapiComparisonPost($files, $document_password);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiComparisonPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiCompressPost**
> \Swagger\Client\Model\FileResponse pdfWebapiCompressPost($files, $document_password, $compress_type)

Compress Document.

Compresses the provided documents to reduce their file size based on the specified compression level. Upload the documents and choose the desired compression level. The service will reduce the file sizes while maintaining quality, resulting in compressed files that are easier to handle and share, saving storage space and reducing upload and download times.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$compress_type = new \Swagger\Client\Model\CompressType(); // \Swagger\Client\Model\CompressType | The level of compression to use.

try {
    $result = $apiInstance->pdfWebapiCompressPost($files, $document_password, $compress_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiCompressPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **compress_type** | [**\Swagger\Client\Model\CompressType**](../Model/.md)| The level of compression to use. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiConvertPost**
> \Swagger\Client\Model\FileResponse pdfWebapiConvertPost($files, $document_password, $input_type, $output_type, $xml_type, $xml_tag, $font_sise, $is_to_single, $separator)

Convert Document to Another Format.

Converts documents from one format to another seamlessly. Upload the files you need to convert and specify the target format. The service will handle the conversion process efficiently, ensuring that the resulting document is ready for use in the desired format and compatible with various applications and systems.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$output_type = "output_type_example"; // string | The desired format for the output files.
$xml_type = new \Swagger\Client\Model\XmlType(); // \Swagger\Client\Model\XmlType | The type of XML conversion to perform, if applicable.
$xml_tag = "xml_tag_example"; // string | The XML tag to use for conversion, if applicable.
$font_sise = 56; // int | 
$is_to_single = true; // bool | Indicates whether the conversion should result in a single file, if applicable.
$separator = "separator_example"; // string | The separator to use when converting, if applicable.

try {
    $result = $apiInstance->pdfWebapiConvertPost($files, $document_password, $input_type, $output_type, $xml_type, $xml_tag, $font_sise, $is_to_single, $separator);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiConvertPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **output_type** | **string**| The desired format for the output files. | [optional]
 **xml_type** | [**\Swagger\Client\Model\XmlType**](../Model/.md)| The type of XML conversion to perform, if applicable. | [optional]
 **xml_tag** | **string**| The XML tag to use for conversion, if applicable. | [optional]
 **font_sise** | **int**|  | [optional]
 **is_to_single** | **bool**| Indicates whether the conversion should result in a single file, if applicable. | [optional]
 **separator** | **string**| The separator to use when converting, if applicable. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiConvertWebpagePost**
> \Swagger\Client\Model\FileResponse pdfWebapiConvertWebpagePost($web_page, $document_password, $output_type)

Convert Web Page to Document.

Converts a web page to a document in the specified output format. Provide the URL of the web page and choose the desired format for conversion. The service will create a document that mirrors the content and layout of the original web page, ensuring it is well-formatted and suitable for your needs.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$web_page = "web_page_example"; // string | 
$document_password = "document_password_example"; // string | 
$output_type = "output_type_example"; // string | The desired format for the output file.

try {
    $result = $apiInstance->pdfWebapiConvertWebpagePost($web_page, $document_password, $output_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiConvertWebpagePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **web_page** | **string**|  | [optional]
 **document_password** | **string**|  | [optional]
 **output_type** | **string**| The desired format for the output file. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiCropPost**
> \Swagger\Client\Model\FileResponse pdfWebapiCropPost($files, $document_password, $input_type, $top, $right, $bottom, $left, $output_type)

Crop Document.

Crops the provided document to the specified dimensions by removing unwanted areas. Upload the document and specify the dimensions for cropping. The service will adjust the file accordingly, resulting in a precisely cropped document that meets your requirements.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$top = 56; // int | The number of pixels to crop from the top.
$right = 56; // int | The number of pixels to crop from the right.
$bottom = 56; // int | The number of pixels to crop from the bottom.
$left = 56; // int | The number of pixels to crop from the left.
$output_type = "output_type_example"; // string | The desired format for the output files.

try {
    $result = $apiInstance->pdfWebapiCropPost($files, $document_password, $input_type, $top, $right, $bottom, $left, $output_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiCropPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **top** | **int**| The number of pixels to crop from the top. | [optional]
 **right** | **int**| The number of pixels to crop from the right. | [optional]
 **bottom** | **int**| The number of pixels to crop from the bottom. | [optional]
 **left** | **int**| The number of pixels to crop from the left. | [optional]
 **output_type** | **string**| The desired format for the output files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiDownloadIdGet**
> pdfWebapiDownloadIdGet($id, $file)

File download.

Downloads processed file.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | The id of the processing to download.
$file = "file_example"; // string | The name of the file to download.

try {
    $apiInstance->pdfWebapiDownloadIdGet($id, $file);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiDownloadIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the processing to download. |
 **file** | **string**| The name of the file to download. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiEsignPost**
> \Swagger\Client\Model\FileResponse pdfWebapiEsignPost($passw, $initials, $invite, $files, $document_password, $input_type)

Sign Document with Certificate.

Applies a digital signature to the provided document using the specified certificate. Upload the document and provide the certificate details, and the service will securely apply the signature, ensuring that the document is authenticated and legally binding.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$passw = "passw_example"; // string | 
$initials = "initials_example"; // string | 
$invite = "invite_example"; // string | 
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.

try {
    $result = $apiInstance->pdfWebapiEsignPost($passw, $initials, $invite, $files, $document_password, $input_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiEsignPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passw** | **string**|  | [optional]
 **initials** | **string**|  | [optional]
 **invite** | **string**|  | [optional]
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiExtractPost**
> \Swagger\Client\Model\FileResponse pdfWebapiExtractPost($files, $document_password, $input_type, $output_type)

Extract Tables from Document.

Extracts tables from the provided document and converts them into the specified output format. Upload the document containing the tables and choose the format you prefer. The service will extract the tables and deliver them in the selected format, facilitating easier data usage and analysis.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$output_type = "output_type_example"; // string | The desired format for the output files.

try {
    $result = $apiInstance->pdfWebapiExtractPost($files, $document_password, $input_type, $output_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiExtractPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **output_type** | **string**| The desired format for the output files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiGifPost**
> \Swagger\Client\Model\FileResponse pdfWebapiGifPost($files, $document_password, $keep_images_as_is, $resize_to_image, $streched, $width, $height, $frame_times)

Make GIF.

Creates a GIF from a collection of images, ensuring smooth transitions and cohesive animation. Upload the images you want to include, and the service will generate a GIF based on your specifications. This service is ideal for animating a series of product shots, creating engaging social media content, or other animation needs.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$keep_images_as_is = true; // bool | Indicates whether the images should be kept as is.
$resize_to_image = 56; // int | The index of the image to resize the other images to.
$streched = true; // bool | 
$width = 56; // int | The width of the GIF.
$height = 56; // int | The height of the GIF.
$frame_times = "frame_times_example"; // string | The times for each frame in the GIF.

try {
    $result = $apiInstance->pdfWebapiGifPost($files, $document_password, $keep_images_as_is, $resize_to_image, $streched, $width, $height, $frame_times);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiGifPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **keep_images_as_is** | **bool**| Indicates whether the images should be kept as is. | [optional]
 **resize_to_image** | **int**| The index of the image to resize the other images to. | [optional]
 **streched** | **bool**|  | [optional]
 **width** | **int**| The width of the GIF. | [optional]
 **height** | **int**| The height of the GIF. | [optional]
 **frame_times** | **string**| The times for each frame in the GIF. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiHashPost**
> \Swagger\Client\Model\FileResponse pdfWebapiHashPost($files, $document_password, $input_type, $output_type, $alg)

Calculate Document Hash.

Calculates the hash values for the provided documents using the specified hashing algorithm. Upload the documents and choose the desired algorithm, and the service will generate hash values for each file. This process helps verify that the documents have not been altered or corrupted, ensuring data integrity.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$output_type = "output_type_example"; // string | The desired format for the output files.
$alg = new \Swagger\Client\Model\HashAlgorithm(); // \Swagger\Client\Model\HashAlgorithm | The hashing algorithm to use.

try {
    $result = $apiInstance->pdfWebapiHashPost($files, $document_password, $input_type, $output_type, $alg);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiHashPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **output_type** | **string**| The desired format for the output files. | [optional]
 **alg** | [**\Swagger\Client\Model\HashAlgorithm**](../Model/.md)| The hashing algorithm to use. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiLockPost**
> \Swagger\Client\Model\FileResponse pdfWebapiLockPost($password, $files)

Lock document.

Locks the provided document with a specified password to restrict access to authorized users only. Upload the file and provide a password, and the service will apply the password protection to secure the document. Optionally, you can include additional files to further enhance the security of the document.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$password = "password_example"; // string | 
$files = array("files_example"); // string[] | 

try {
    $result = $apiInstance->pdfWebapiLockPost($password, $files);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiLockPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **string**|  | [optional]
 **files** | [**string[]**](../Model/string.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiMergePost**
> \Swagger\Client\Model\FileResponse pdfWebapiMergePost($files, $document_password, $input_type, $output_type, $merge_type, $horizontal, $vertical, $page_size, $dc_is_landscape)

Merge Documents.

Merges multiple documents or images into a single file based on specified preferences for orientation and page size. Upload the files you want to consolidate and define your formatting preferences. This service will combine the files into one, ensuring that the final document or image meets your requirements.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$output_type = "output_type_example"; // string | The desired format for the output file.
$merge_type = new \Swagger\Client\Model\MergeImageType(); // \Swagger\Client\Model\MergeImageType | Type of merger operation.
$horizontal = 56; // int | The number of images to merge horizontally, if applicable.
$vertical = 56; // int | The number of images to merge vertically, if applicable.
$page_size = new \Swagger\Client\Model\PageSize(); // \Swagger\Client\Model\PageSize | The page size for the output file, if applicable.
$dc_is_landscape = true; // bool | Indicates whether the output file should be in landscape orientation.

try {
    $result = $apiInstance->pdfWebapiMergePost($files, $document_password, $input_type, $output_type, $merge_type, $horizontal, $vertical, $page_size, $dc_is_landscape);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiMergePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **output_type** | **string**| The desired format for the output file. | [optional]
 **merge_type** | [**\Swagger\Client\Model\MergeImageType**](../Model/.md)| Type of merger operation. | [optional]
 **horizontal** | **int**| The number of images to merge horizontally, if applicable. | [optional]
 **vertical** | **int**| The number of images to merge vertically, if applicable. | [optional]
 **page_size** | [**\Swagger\Client\Model\PageSize**](../Model/.md)| The page size for the output file, if applicable. | [optional]
 **dc_is_landscape** | **bool**| Indicates whether the output file should be in landscape orientation. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiMetadataPost**
> \Swagger\Client\Model\FileResponse pdfWebapiMetadataPost($files, $document_password, $operation, $folder, $name)

Read and Change Document Metadata.

Reads and updates the metadata of the provided documents based on specified operations. Upload the documents and define the metadata changes you need. This service will read the existing metadata, apply the changes, and ensure that your files contain accurate and updated information.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$operation = new \Swagger\Client\Model\MetadataOperation(); // \Swagger\Client\Model\MetadataOperation | The operation to perform on the metadata.
$folder = "folder_example"; // string | The folder where the files are located.
$name = "name_example"; // string | The name of the file to perform the operation on.

try {
    $result = $apiInstance->pdfWebapiMetadataPost($files, $document_password, $operation, $folder, $name);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiMetadataPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **operation** | [**\Swagger\Client\Model\MetadataOperation**](../Model/.md)| The operation to perform on the metadata. | [optional]
 **folder** | **string**| The folder where the files are located. | [optional]
 **name** | **string**| The name of the file to perform the operation on. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiOrganizePost**
> \Swagger\Client\Model\FileResponse pdfWebapiOrganizePost($files, $document_password, $input_type, $remove, $move)

Organize Document Pages.

Reorganizes the pages of the provided document based on your instructions. Upload the document and specify which pages to remove or move, and the service will rearrange the pages accordingly, ensuring that the document is organized as you require.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$remove = "remove_example"; // string | The pages to remove from the document.
$move = "move_example"; // string | The pages to move within the document.

try {
    $result = $apiInstance->pdfWebapiOrganizePost($files, $document_password, $input_type, $remove, $move);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiOrganizePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **remove** | **string**| The pages to remove from the document. | [optional]
 **move** | **string**| The pages to move within the document. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiParsePost**
> \Swagger\Client\Model\FileResponse pdfWebapiParsePost($files, $document_password)

Parse Document.

Analyses and extracts relevant content from the provided document files. The parsing service organizes the data within your documents to make it accessible and tailored to your specific requirements.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 

try {
    $result = $apiInstance->pdfWebapiParsePost($files, $document_password);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiParsePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiRedactPost**
> \Swagger\Client\Model\FileResponse pdfWebapiRedactPost($files, $document_password, $search_query, $replace_text, $case_sensitive, $text, $comments, $metadata)

Redact Document Text.

Redacts sensitive information from the provided documents by removing specified text, comments, and metadata. You can specify the text to be redacted and use case-sensitive search to ensure thorough removal. This service helps maintain confidentiality and security by ensuring that sensitive information is completely removed.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$search_query = "search_query_example"; // string | The text to search for and redact.
$replace_text = "replace_text_example"; // string | The text to replace the found text with.
$case_sensitive = true; // bool | Indicates whether the search should be case-sensitive.
$text = true; // bool | Indicates whether text should be redacted.
$comments = true; // bool | Indicates whether comments should be redacted.
$metadata = true; // bool | Indicates whether metadata should be redacted.

try {
    $result = $apiInstance->pdfWebapiRedactPost($files, $document_password, $search_query, $replace_text, $case_sensitive, $text, $comments, $metadata);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiRedactPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **search_query** | **string**| The text to search for and redact. | [optional]
 **replace_text** | **string**| The text to replace the found text with. | [optional]
 **case_sensitive** | **bool**| Indicates whether the search should be case-sensitive. | [optional]
 **text** | **bool**| Indicates whether text should be redacted. | [optional]
 **comments** | **bool**| Indicates whether comments should be redacted. | [optional]
 **metadata** | **bool**| Indicates whether metadata should be redacted. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiRemoveIdPost**
> \Swagger\Client\Model\FileResponse pdfWebapiRemoveIdPost($id)

Remove stored files.

Removes processed files from storage.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | The ID of the processing to remove.

try {
    $result = $apiInstance->pdfWebapiRemoveIdPost($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiRemoveIdPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the processing to remove. |

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiRemovePost**
> \Swagger\Client\Model\FileResponse pdfWebapiRemovePost($files, $document_password)

Remove Document Annotations.

Removes all annotations, including comments, highlights, and markup, from the provided documents. By specifying the documents, this service ensures that they are cleaned of any annotations, resulting in a clean and annotation-free file.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 

try {
    $result = $apiInstance->pdfWebapiRemovePost($files, $document_password);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiRemovePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiRemoveWatermarkPost**
> \Swagger\Client\Model\FileResponse pdfWebapiRemoveWatermarkPost($watermark_text, $top, $left, $bottom, $right, $files, $document_password, $is_all_pages, $watermark_type, $remove_range)

Remove Document Watermark.

Removes an unwanted watermark from all pages of the provided document. Submit the document, and this service will efficiently eliminate the watermark, resulting in a clean version of the file without the watermark.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$watermark_text = "watermark_text_example"; // string | 
$top = 56; // int | 
$left = 56; // int | 
$bottom = 56; // int | 
$right = 56; // int | 
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$is_all_pages = true; // bool | Indicates whether the watermark should be removed from all pages.
$watermark_type = new \Swagger\Client\Model\WatermarkType(); // \Swagger\Client\Model\WatermarkType | The type of watermark to remove.
$remove_range = "remove_range_example"; // string | The range of pages to remove the watermark from.

try {
    $result = $apiInstance->pdfWebapiRemoveWatermarkPost($watermark_text, $top, $left, $bottom, $right, $files, $document_password, $is_all_pages, $watermark_type, $remove_range);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiRemoveWatermarkPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **watermark_text** | **string**|  | [optional]
 **top** | **int**|  | [optional]
 **left** | **int**|  | [optional]
 **bottom** | **int**|  | [optional]
 **right** | **int**|  | [optional]
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **is_all_pages** | **bool**| Indicates whether the watermark should be removed from all pages. | [optional]
 **watermark_type** | [**\Swagger\Client\Model\WatermarkType**](../Model/.md)| The type of watermark to remove. | [optional]
 **remove_range** | **string**| The range of pages to remove the watermark from. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiRemovepagesPost**
> \Swagger\Client\Model\FileResponse pdfWebapiRemovepagesPost($files, $document_password, $remove_range)

Remove Pages from Document.

Removes specified pages from the provided document, leaving only the pages you want to keep. Simply provide the document and specify which pages to remove, and the service will process the file accordingly.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$remove_range = "remove_range_example"; // string | The range of pages to remove from the files.

try {
    $result = $apiInstance->pdfWebapiRemovepagesPost($files, $document_password, $remove_range);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiRemovepagesPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **remove_range** | **string**| The range of pages to remove from the files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiRepairPost**
> \Swagger\Client\Model\FileResponse pdfWebapiRepairPost($files, $document_password)

Repair Document.

Repairs a corrupted or error-ridden document by identifying and fixing issues. Upload the problematic file, and this service will restore it to a usable state.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 

try {
    $result = $apiInstance->pdfWebapiRepairPost($files, $document_password);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiRepairPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiResizePost**
> \Swagger\Client\Model\FileResponse pdfWebapiResizePost($files, $document_password, $input_type, $output_type, $resize_type, $preset_type, $preset_size, $width, $height, $percentage, $use_proportions, $page_size)

Resize Document.

Resizes the document to fit the specified dimensions or preset sizes. Provide the file and specify the desired dimensions, or select from available preset sizes to adjust the document accordingly.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$output_type = "output_type_example"; // string | The desired format for the output files.
$resize_type = new \Swagger\Client\Model\ResizeType(); // \Swagger\Client\Model\ResizeType | The type of resizing to apply.
$preset_type = new \Swagger\Client\Model\ResizePresetType(); // \Swagger\Client\Model\ResizePresetType | The type of preset size to use for resizing.
$preset_size = new \Swagger\Client\Model\ResizePresetSize(); // \Swagger\Client\Model\ResizePresetSize | The preset size to use for resizing.
$width = 56; // int | The desired width of the resized files.
$height = 56; // int | The desired height of the resized files.
$percentage = 56; // int | The percentage to resize the files by.
$use_proportions = true; // bool | Indicates whether to maintain the aspect ratio when resizing.
$page_size = new \Swagger\Client\Model\ResizePageSize(); // \Swagger\Client\Model\ResizePageSize | The page size to use for the resized files.

try {
    $result = $apiInstance->pdfWebapiResizePost($files, $document_password, $input_type, $output_type, $resize_type, $preset_type, $preset_size, $width, $height, $percentage, $use_proportions, $page_size);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiResizePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **output_type** | **string**| The desired format for the output files. | [optional]
 **resize_type** | [**\Swagger\Client\Model\ResizeType**](../Model/.md)| The type of resizing to apply. | [optional]
 **preset_type** | [**\Swagger\Client\Model\ResizePresetType**](../Model/.md)| The type of preset size to use for resizing. | [optional]
 **preset_size** | [**\Swagger\Client\Model\ResizePresetSize**](../Model/.md)| The preset size to use for resizing. | [optional]
 **width** | **int**| The desired width of the resized files. | [optional]
 **height** | **int**| The desired height of the resized files. | [optional]
 **percentage** | **int**| The percentage to resize the files by. | [optional]
 **use_proportions** | **bool**| Indicates whether to maintain the aspect ratio when resizing. | [optional]
 **page_size** | [**\Swagger\Client\Model\ResizePageSize**](../Model/.md)| The page size to use for the resized files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiRotatePost**
> \Swagger\Client\Model\FileResponse pdfWebapiRotatePost($files, $document_password, $angle, $rotate_type, $page_num)

Rotate Document.

Rotates the document by a specified angle, allowing for adjustment of the document's orientation. You can choose the type of rotation and target specific pages to ensure the document is aligned according to your needs.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$angle = new \Swagger\Client\Model\RotateAngle(); // \Swagger\Client\Model\RotateAngle | The angle by which to rotate the files.
$rotate_type = new \Swagger\Client\Model\RotateType(); // \Swagger\Client\Model\RotateType | The type of rotation to perform.
$page_num = "page_num_example"; // string | The page number to rotate, if applicable.

try {
    $result = $apiInstance->pdfWebapiRotatePost($files, $document_password, $angle, $rotate_type, $page_num);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiRotatePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **angle** | [**\Swagger\Client\Model\RotateAngle**](../Model/.md)| The angle by which to rotate the files. | [optional]
 **rotate_type** | [**\Swagger\Client\Model\RotateType**](../Model/.md)| The type of rotation to perform. | [optional]
 **page_num** | **string**| The page number to rotate, if applicable. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiSearchPost**
> \Swagger\Client\Model\FileResponse pdfWebapiSearchPost($files, $document_password, $query)

Search Document Text.

Searches the provided documents for the specified query and highlights the found text with a yellow background. This service helps you quickly locate and review relevant sections of your documents.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$query = "query_example"; // string | The text to search for within the files.

try {
    $result = $apiInstance->pdfWebapiSearchPost($files, $document_password, $query);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **query** | **string**| The text to search for within the files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiSearchablePost**
> \Swagger\Client\Model\FileResponse pdfWebapiSearchablePost($files, $lang)

Make Scanned PDF Searchable.

Converts scanned PDFs into a searchable PDF format by recognizing and indexing text. This service ensures that you can easily search through your documents by making the text searchable in the specified language.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$lang = "lang_example"; // string | The language of the files to be converted.

try {
    $result = $apiInstance->pdfWebapiSearchablePost($files, $lang);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiSearchablePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **lang** | **string**| The language of the files to be converted. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiSignaturePost**
> \Swagger\Client\Model\FileResponse pdfWebapiSignaturePost($image, $text, $text_color, $files, $document_password, $input_type, $output_type, $signature_type)

Add Signature to Document.

Adds a signature to the provided documents, allowing for the insertion of both text and image signatures. This service ensures that your documents are properly signed and authenticated according to your specifications.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$image = "image_example"; // string | 
$text = "text_example"; // string | 
$text_color = "text_color_example"; // string | 
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$output_type = "output_type_example"; // string | The desired format for the output files.
$signature_type = new \Swagger\Client\Model\SignatureType(); // \Swagger\Client\Model\SignatureType | The type of signature to add.

try {
    $result = $apiInstance->pdfWebapiSignaturePost($image, $text, $text_color, $files, $document_password, $input_type, $output_type, $signature_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiSignaturePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **string**|  | [optional]
 **text** | **string**|  | [optional]
 **text_color** | **string**|  | [optional]
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **output_type** | **string**| The desired format for the output files. | [optional]
 **signature_type** | [**\Swagger\Client\Model\SignatureType**](../Model/.md)| The type of signature to add. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiSplitdocPost**
> \Swagger\Client\Model\FileResponse pdfWebapiSplitdocPost($files, $document_password, $input_type, $split_type, $pairs)

Split Document.

Splits a document into smaller parts based on specified criteria, such as type or page range. This service ensures that each segment meets your exact requirements, simplifying document management and organization.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$split_type = new \Swagger\Client\Model\SplitDocType(); // \Swagger\Client\Model\SplitDocType | The type of splitting to be performed.
$pairs = "pairs_example"; // string | Optional page rage for the splitting operation.

try {
    $result = $apiInstance->pdfWebapiSplitdocPost($files, $document_password, $input_type, $split_type, $pairs);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiSplitdocPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **split_type** | [**\Swagger\Client\Model\SplitDocType**](../Model/.md)| The type of splitting to be performed. | [optional]
 **pairs** | **string**| Optional page rage for the splitting operation. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiSplitimagePost**
> \Swagger\Client\Model\FileResponse pdfWebapiSplitimagePost($files, $document_password, $split_type, $vertical, $horizontal, $output_type)

Split Image.

Splits large images into smaller sections according to the specified parameters, making it easier to handle and process image data.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$split_type = new \Swagger\Client\Model\SplitImageType(); // \Swagger\Client\Model\SplitImageType | The type of splitting to be performed.
$vertical = 56; // int | The number of vertical splits to create.
$horizontal = 56; // int | The number of horizontal splits to create.
$output_type = "output_type_example"; // string | The desired output format for the split images.

try {
    $result = $apiInstance->pdfWebapiSplitimagePost($files, $document_password, $split_type, $vertical, $horizontal, $output_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiSplitimagePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **split_type** | [**\Swagger\Client\Model\SplitImageType**](../Model/.md)| The type of splitting to be performed. | [optional]
 **vertical** | **int**| The number of vertical splits to create. | [optional]
 **horizontal** | **int**| The number of horizontal splits to create. | [optional]
 **output_type** | **string**| The desired output format for the split images. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiStatusIdPost**
> \Swagger\Client\Model\FileResponse pdfWebapiStatusIdPost($id)

Processing status.

Retrieves the status of a processing.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$id = "id_example"; // string | The ID of the processing to check the status of.

try {
    $result = $apiInstance->pdfWebapiStatusIdPost($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiStatusIdPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the processing to check the status of. |

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiUnlockPost**
> \Swagger\Client\Model\FileResponse pdfWebapiUnlockPost($password, $files)

Unlock Document.

Attempts to unlock a password-protected document, using any associated files if necessary, to grant access to the content.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$password = "password_example"; // string | 
$files = array("files_example"); // string[] | 

try {
    $result = $apiInstance->pdfWebapiUnlockPost($password, $files);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiUnlockPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **string**|  | [optional]
 **files** | [**string[]**](../Model/string.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiVerifyEsignPost**
> \Swagger\Client\Model\FileResponse pdfWebapiVerifyEsignPost($files, $document_password, $input_type)

Verify Document Certificate.

Verifies the electronic signature of the provided document to ensure its authenticity and integrity. This service checks the digital certificates in the document to confirm their validity and trustworthiness.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.

try {
    $result = $apiInstance->pdfWebapiVerifyEsignPost($files, $document_password, $input_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiVerifyEsignPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiWatermarkPost**
> \Swagger\Client\Model\FileResponse pdfWebapiWatermarkPost($files, $document_password, $input_type, $output_type, $is_colored, $is_text, $text, $name, $size, $bold, $italic, $underlined, $color, $is_background, $rotation, $transparency, $layer, $page_from, $page_to)

Add Watermark to Document.

Adds a watermark to the provided documents, helping to protect and identify them. This service ensures that the watermark is applied according to your specifications, enhancing the security and ownership of your content.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.
$output_type = "output_type_example"; // string | The desired format for the output files.
$is_colored = true; // bool | Indicate is watermark will be in color or grayscale.
$is_text = true; // bool | Indicates whether the watermark is text.
$text = "text_example"; // string | The text of the watermark.
$name = "name_example"; // string | The name of the font for the text watermark.
$size = 56; // int | The size of the font for the text watermark.
$bold = true; // bool | Indicates whether the text watermark is bold.
$italic = true; // bool | Indicates whether the text watermark is italic.
$underlined = true; // bool | Indicates whether the text watermark is underlined.
$color = "color_example"; // string | The color of the text or image watermark.
$is_background = true; // bool | Indicates whether the watermark is a background watermark.
$rotation = 56; // int | The rotation angle of the watermark.
$transparency = 3.4; // float | The transparency of the watermark.
$layer = true; // bool | Indicates whether the watermark is a layer.
$page_from = 56; // int | The starting page number for the watermark.
$page_to = 56; // int | The ending page number for the watermark.

try {
    $result = $apiInstance->pdfWebapiWatermarkPost($files, $document_password, $input_type, $output_type, $is_colored, $is_text, $text, $name, $size, $bold, $italic, $underlined, $color, $is_background, $rotation, $transparency, $layer, $page_from, $page_to);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiWatermarkPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]
 **output_type** | **string**| The desired format for the output files. | [optional]
 **is_colored** | **bool**| Indicate is watermark will be in color or grayscale. | [optional]
 **is_text** | **bool**| Indicates whether the watermark is text. | [optional]
 **text** | **string**| The text of the watermark. | [optional]
 **name** | **string**| The name of the font for the text watermark. | [optional]
 **size** | **int**| The size of the font for the text watermark. | [optional]
 **bold** | **bool**| Indicates whether the text watermark is bold. | [optional]
 **italic** | **bool**| Indicates whether the text watermark is italic. | [optional]
 **underlined** | **bool**| Indicates whether the text watermark is underlined. | [optional]
 **color** | **string**| The color of the text or image watermark. | [optional]
 **is_background** | **bool**| Indicates whether the watermark is a background watermark. | [optional]
 **rotation** | **int**| The rotation angle of the watermark. | [optional]
 **transparency** | **float**| The transparency of the watermark. | [optional]
 **layer** | **bool**| Indicates whether the watermark is a layer. | [optional]
 **page_from** | **int**| The starting page number for the watermark. | [optional]
 **page_to** | **int**| The ending page number for the watermark. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiWordcounterPost**
> \Swagger\Client\Model\FileResponse pdfWebapiWordcounterPost($files, $document_password, $page_range)

Count Words and Characters in Document.

Counts the words and characters in the provided documents within the specified page range. This service helps you accurately determine the length and content density of your documents, ensuring compliance with any required specifications or limits.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$page_range = "page_range_example"; // string | The range of pages to count words in.

try {
    $result = $apiInstance->pdfWebapiWordcounterPost($files, $document_password, $page_range);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiWordcounterPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **page_range** | **string**| The range of pages to count words in. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **pdfWebapiXfaconvertPost**
> \Swagger\Client\Model\FileResponse pdfWebapiXfaconvertPost($files, $document_password, $input_type)

Convert XFA Format to Another Format.

Converts XFA documents to the specified format, ensuring seamless compatibility and usability. This service supports a wide range of target formats, allowing users to choose the most suitable format for their specific needs. The conversion process maintains the integrity of the original document while adapting it to the desired format, making it ideal for editing, sharing, or archiving..

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\ApiApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$files = array("files_example"); // string[] | 
$document_password = "document_password_example"; // string | 
$input_type = "input_type_example"; // string | The format of the input files.

try {
    $result = $apiInstance->pdfWebapiXfaconvertPost($files, $document_password, $input_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiApi->pdfWebapiXfaconvertPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**string[]**](../Model/string.md)|  | [optional]
 **document_password** | **string**|  | [optional]
 **input_type** | **string**| The format of the input files. | [optional]

### Return type

[**\Swagger\Client\Model\FileResponse**](../Model/FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

