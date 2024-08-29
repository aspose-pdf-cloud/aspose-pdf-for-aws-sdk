# ApiApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pdfWebapiAddnumberPost**](ApiApi.md#pdfWebapiAddnumberPost) | **POST** /pdf/webapi/addnumber | Add Page Numbers to Document.
[**pdfWebapiChangeFontsPost**](ApiApi.md#pdfWebapiChangeFontsPost) | **POST** /pdf/webapi/change-fonts | Change Fonts in Provided Files.
[**pdfWebapiComparisonPost**](ApiApi.md#pdfWebapiComparisonPost) | **POST** /pdf/webapi/comparison | Compare documents text.
[**pdfWebapiCompressPost**](ApiApi.md#pdfWebapiCompressPost) | **POST** /pdf/webapi/compress | Compress Document.
[**pdfWebapiConvertPost**](ApiApi.md#pdfWebapiConvertPost) | **POST** /pdf/webapi/convert | Convert Document to Another Format.
[**pdfWebapiConvertWebpagePost**](ApiApi.md#pdfWebapiConvertWebpagePost) | **POST** /pdf/webapi/convert-webpage | Convert Web Page to Document.
[**pdfWebapiCropPost**](ApiApi.md#pdfWebapiCropPost) | **POST** /pdf/webapi/crop | Crop Document.
[**pdfWebapiDownloadIdGet**](ApiApi.md#pdfWebapiDownloadIdGet) | **GET** /pdf/webapi/download/{id} | File download.
[**pdfWebapiEsignPost**](ApiApi.md#pdfWebapiEsignPost) | **POST** /pdf/webapi/esign | Sign Document with Certificate.
[**pdfWebapiExtractPost**](ApiApi.md#pdfWebapiExtractPost) | **POST** /pdf/webapi/extract | Extract Tables from Document.
[**pdfWebapiGifPost**](ApiApi.md#pdfWebapiGifPost) | **POST** /pdf/webapi/gif | Make GIF.
[**pdfWebapiHashPost**](ApiApi.md#pdfWebapiHashPost) | **POST** /pdf/webapi/hash | Calculate Document Hash.
[**pdfWebapiLockPost**](ApiApi.md#pdfWebapiLockPost) | **POST** /pdf/webapi/lock | Lock document.
[**pdfWebapiMergePost**](ApiApi.md#pdfWebapiMergePost) | **POST** /pdf/webapi/merge | Merge Documents.
[**pdfWebapiMetadataPost**](ApiApi.md#pdfWebapiMetadataPost) | **POST** /pdf/webapi/metadata | Read and Change Document Metadata.
[**pdfWebapiOrganizePost**](ApiApi.md#pdfWebapiOrganizePost) | **POST** /pdf/webapi/organize | Organize Document Pages.
[**pdfWebapiParsePost**](ApiApi.md#pdfWebapiParsePost) | **POST** /pdf/webapi/parse | Parse Document.
[**pdfWebapiRedactPost**](ApiApi.md#pdfWebapiRedactPost) | **POST** /pdf/webapi/redact | Redact Document Text.
[**pdfWebapiRemoveIdPost**](ApiApi.md#pdfWebapiRemoveIdPost) | **POST** /pdf/webapi/remove/{id} | Remove stored files.
[**pdfWebapiRemovePost**](ApiApi.md#pdfWebapiRemovePost) | **POST** /pdf/webapi/remove | Remove Document Annotations.
[**pdfWebapiRemoveWatermarkPost**](ApiApi.md#pdfWebapiRemoveWatermarkPost) | **POST** /pdf/webapi/remove-watermark | Remove Document Watermark.
[**pdfWebapiRemovepagesPost**](ApiApi.md#pdfWebapiRemovepagesPost) | **POST** /pdf/webapi/removepages | Remove Pages from Document.
[**pdfWebapiRepairPost**](ApiApi.md#pdfWebapiRepairPost) | **POST** /pdf/webapi/repair | Repair Document.
[**pdfWebapiResizePost**](ApiApi.md#pdfWebapiResizePost) | **POST** /pdf/webapi/resize | Resize Document.
[**pdfWebapiRotatePost**](ApiApi.md#pdfWebapiRotatePost) | **POST** /pdf/webapi/rotate | Rotate Document.
[**pdfWebapiSearchPost**](ApiApi.md#pdfWebapiSearchPost) | **POST** /pdf/webapi/search | Search Document Text.
[**pdfWebapiSearchablePost**](ApiApi.md#pdfWebapiSearchablePost) | **POST** /pdf/webapi/searchable | Make Scanned PDF Searchable.
[**pdfWebapiSignaturePost**](ApiApi.md#pdfWebapiSignaturePost) | **POST** /pdf/webapi/signature | Add Signature to Document.
[**pdfWebapiSplitdocPost**](ApiApi.md#pdfWebapiSplitdocPost) | **POST** /pdf/webapi/splitdoc | Split Document.
[**pdfWebapiSplitimagePost**](ApiApi.md#pdfWebapiSplitimagePost) | **POST** /pdf/webapi/splitimage | Split Image.
[**pdfWebapiStatusIdPost**](ApiApi.md#pdfWebapiStatusIdPost) | **POST** /pdf/webapi/status/{id} | Processing status.
[**pdfWebapiUnlockPost**](ApiApi.md#pdfWebapiUnlockPost) | **POST** /pdf/webapi/unlock | Unlock Document.
[**pdfWebapiVerifyEsignPost**](ApiApi.md#pdfWebapiVerifyEsignPost) | **POST** /pdf/webapi/verify_esign | Verify Document Certificate.
[**pdfWebapiWatermarkPost**](ApiApi.md#pdfWebapiWatermarkPost) | **POST** /pdf/webapi/watermark | Add Watermark to Document.
[**pdfWebapiWordcounterPost**](ApiApi.md#pdfWebapiWordcounterPost) | **POST** /pdf/webapi/wordcounter | Count Words and Characters in Document.
[**pdfWebapiXfaconvertPost**](ApiApi.md#pdfWebapiXfaconvertPost) | **POST** /pdf/webapi/xfaconvert | Convert XFA Format to Another Format.

<a name="pdfWebapiAddnumberPost"></a>
# **pdfWebapiAddnumberPost**
> FileResponse pdfWebapiAddnumberPost(files, documentPassword, vAlignment, hAlignment, startingNumber, sNumber, fNumber, margin, fontSize, format)

Add Page Numbers to Document.

Adds page numbers to your documents based on specified alignment, starting number, and format. The service ensures that page numbers are accurately applied, improving the readability and professionalism of your documents. It supports various formats, including DOC, PPTX, TIFF, DOCX, and PDF, to cater to your specific requirements.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val vAlignment : PageNumberVerticalAlign =  // PageNumberVerticalAlign | The vertical alignment of the page numbers.
val hAlignment : PageNumberHorizontalAlign =  // PageNumberHorizontalAlign | The horizontal alignment of the page numbers.
val startingNumber : kotlin.Int = 56 // kotlin.Int | The starting number for the page numbers.
val sNumber : kotlin.Int = 56 // kotlin.Int | The number of the first page to start numbering from.
val fNumber : kotlin.Int = 56 // kotlin.Int | The number of the last page to end numbering at.
val margin : kotlin.Int = 56 // kotlin.Int | The margin around the page numbers.
val fontSize : kotlin.Int = 56 // kotlin.Int | The font size of the page numbers.
val format : kotlin.String = format_example // kotlin.String | The format of the page numbers.
try {
    val result : FileResponse = apiInstance.pdfWebapiAddnumberPost(files, documentPassword, vAlignment, hAlignment, startingNumber, sNumber, fNumber, margin, fontSize, format)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiAddnumberPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiAddnumberPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **vAlignment** | [**PageNumberVerticalAlign**](.md)| The vertical alignment of the page numbers. | [optional]
 **hAlignment** | [**PageNumberHorizontalAlign**](.md)| The horizontal alignment of the page numbers. | [optional]
 **startingNumber** | **kotlin.Int**| The starting number for the page numbers. | [optional]
 **sNumber** | **kotlin.Int**| The number of the first page to start numbering from. | [optional]
 **fNumber** | **kotlin.Int**| The number of the last page to end numbering at. | [optional]
 **margin** | **kotlin.Int**| The margin around the page numbers. | [optional]
 **fontSize** | **kotlin.Int**| The font size of the page numbers. | [optional]
 **format** | **kotlin.String**| The format of the page numbers. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiChangeFontsPost"></a>
# **pdfWebapiChangeFontsPost**
> FileResponse pdfWebapiChangeFontsPost(fontReplacementsJson, files, documentPassword)

Change Fonts in Provided Files.

Updates the fonts in your documents according to specified replacements.  Provide the font replacement details as a JSON string and upload your files using multipart/form-data.The service processes these requests asynchronously using Kafka, ensuring efficient handling of your files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val fontReplacementsJson : kotlin.String = fontReplacementsJson_example // kotlin.String | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
try {
    val result : FileResponse = apiInstance.pdfWebapiChangeFontsPost(fontReplacementsJson, files, documentPassword)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiChangeFontsPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiChangeFontsPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fontReplacementsJson** | **kotlin.String**|  | [optional]
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiComparisonPost"></a>
# **pdfWebapiComparisonPost**
> FileResponse pdfWebapiComparisonPost(files, documentPassword)

Compare documents text.

Compares the text of the provided documents and highlights the differences. Upload the files you want to compare, and the service will analyze them to detect any changes in the text. The result is a new document that clearly marks all text variations, making it easy to review and understand the modifications between the original and updated versions.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
try {
    val result : FileResponse = apiInstance.pdfWebapiComparisonPost(files, documentPassword)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiComparisonPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiComparisonPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiCompressPost"></a>
# **pdfWebapiCompressPost**
> FileResponse pdfWebapiCompressPost(files, documentPassword, compressType)

Compress Document.

Compresses the provided documents to reduce their file size based on the specified compression level. Upload the documents and choose the desired compression level. The service will reduce the file sizes while maintaining quality, resulting in compressed files that are easier to handle and share, saving storage space and reducing upload and download times.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val compressType : CompressType =  // CompressType | The level of compression to use.
try {
    val result : FileResponse = apiInstance.pdfWebapiCompressPost(files, documentPassword, compressType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiCompressPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiCompressPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **compressType** | [**CompressType**](.md)| The level of compression to use. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiConvertPost"></a>
# **pdfWebapiConvertPost**
> FileResponse pdfWebapiConvertPost(files, documentPassword, inputType, outputType, xmlType, xmlTag, fontSise, isToSingle, separator)

Convert Document to Another Format.

Converts documents from one format to another seamlessly. Upload the files you need to convert and specify the target format. The service will handle the conversion process efficiently, ensuring that the resulting document is ready for use in the desired format and compatible with various applications and systems.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val xmlType : XmlType =  // XmlType | The type of XML conversion to perform, if applicable.
val xmlTag : kotlin.String = xmlTag_example // kotlin.String | The XML tag to use for conversion, if applicable.
val fontSise : kotlin.Int = 56 // kotlin.Int | 
val isToSingle : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the conversion should result in a single file, if applicable.
val separator : kotlin.String = separator_example // kotlin.String | The separator to use when converting, if applicable.
try {
    val result : FileResponse = apiInstance.pdfWebapiConvertPost(files, documentPassword, inputType, outputType, xmlType, xmlTag, fontSise, isToSingle, separator)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiConvertPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiConvertPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]
 **xmlType** | [**XmlType**](.md)| The type of XML conversion to perform, if applicable. | [optional]
 **xmlTag** | **kotlin.String**| The XML tag to use for conversion, if applicable. | [optional]
 **fontSise** | **kotlin.Int**|  | [optional]
 **isToSingle** | **kotlin.Boolean**| Indicates whether the conversion should result in a single file, if applicable. | [optional]
 **separator** | **kotlin.String**| The separator to use when converting, if applicable. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiConvertWebpagePost"></a>
# **pdfWebapiConvertWebpagePost**
> FileResponse pdfWebapiConvertWebpagePost(webPage, documentPassword, outputType)

Convert Web Page to Document.

Converts a web page to a document in the specified output format. Provide the URL of the web page and choose the desired format for conversion. The service will create a document that mirrors the content and layout of the original web page, ensuring it is well-formatted and suitable for your needs.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val webPage : kotlin.String = webPage_example // kotlin.String | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output file.
try {
    val result : FileResponse = apiInstance.pdfWebapiConvertWebpagePost(webPage, documentPassword, outputType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiConvertWebpagePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiConvertWebpagePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webPage** | **kotlin.String**|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **outputType** | **kotlin.String**| The desired format for the output file. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiCropPost"></a>
# **pdfWebapiCropPost**
> FileResponse pdfWebapiCropPost(files, documentPassword, inputType, top, right, bottom, left, outputType)

Crop Document.

Crops the provided document to the specified dimensions by removing unwanted areas. Upload the document and specify the dimensions for cropping. The service will adjust the file accordingly, resulting in a precisely cropped document that meets your requirements.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val top : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the top.
val right : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the right.
val bottom : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the bottom.
val left : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the left.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
try {
    val result : FileResponse = apiInstance.pdfWebapiCropPost(files, documentPassword, inputType, top, right, bottom, left, outputType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiCropPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiCropPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **top** | **kotlin.Int**| The number of pixels to crop from the top. | [optional]
 **right** | **kotlin.Int**| The number of pixels to crop from the right. | [optional]
 **bottom** | **kotlin.Int**| The number of pixels to crop from the bottom. | [optional]
 **left** | **kotlin.Int**| The number of pixels to crop from the left. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiDownloadIdGet"></a>
# **pdfWebapiDownloadIdGet**
> pdfWebapiDownloadIdGet(id, file)

File download.

Downloads processed file.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val id : kotlin.String = id_example // kotlin.String | The id of the processing to download.
val file : kotlin.String = file_example // kotlin.String | The name of the file to download.
try {
    apiInstance.pdfWebapiDownloadIdGet(id, file)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiDownloadIdGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiDownloadIdGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.String**| The id of the processing to download. |
 **file** | **kotlin.String**| The name of the file to download. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="pdfWebapiEsignPost"></a>
# **pdfWebapiEsignPost**
> FileResponse pdfWebapiEsignPost(passw, initials, invite, files, documentPassword, inputType)

Sign Document with Certificate.

Applies a digital signature to the provided document using the specified certificate. Upload the document and provide the certificate details, and the service will securely apply the signature, ensuring that the document is authenticated and legally binding.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val passw : kotlin.String = passw_example // kotlin.String | 
val initials : kotlin.String = initials_example // kotlin.String | 
val invite : kotlin.String = invite_example // kotlin.String | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
try {
    val result : FileResponse = apiInstance.pdfWebapiEsignPost(passw, initials, invite, files, documentPassword, inputType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiEsignPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiEsignPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passw** | **kotlin.String**|  | [optional]
 **initials** | **kotlin.String**|  | [optional]
 **invite** | **kotlin.String**|  | [optional]
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiExtractPost"></a>
# **pdfWebapiExtractPost**
> FileResponse pdfWebapiExtractPost(files, documentPassword, inputType, outputType)

Extract Tables from Document.

Extracts tables from the provided document and converts them into the specified output format. Upload the document containing the tables and choose the format you prefer. The service will extract the tables and deliver them in the selected format, facilitating easier data usage and analysis.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
try {
    val result : FileResponse = apiInstance.pdfWebapiExtractPost(files, documentPassword, inputType, outputType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiExtractPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiExtractPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiGifPost"></a>
# **pdfWebapiGifPost**
> FileResponse pdfWebapiGifPost(files, documentPassword, keepImagesAsIs, resizeToImage, streched, width, height, frameTimes)

Make GIF.

Creates a GIF from a collection of images, ensuring smooth transitions and cohesive animation. Upload the images you want to include, and the service will generate a GIF based on your specifications. This service is ideal for animating a series of product shots, creating engaging social media content, or other animation needs.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val keepImagesAsIs : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the images should be kept as is.
val resizeToImage : kotlin.Int = 56 // kotlin.Int | The index of the image to resize the other images to.
val streched : kotlin.Boolean = true // kotlin.Boolean | 
val width : kotlin.Int = 56 // kotlin.Int | The width of the GIF.
val height : kotlin.Int = 56 // kotlin.Int | The height of the GIF.
val frameTimes : kotlin.String = frameTimes_example // kotlin.String | The times for each frame in the GIF.
try {
    val result : FileResponse = apiInstance.pdfWebapiGifPost(files, documentPassword, keepImagesAsIs, resizeToImage, streched, width, height, frameTimes)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiGifPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiGifPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **keepImagesAsIs** | **kotlin.Boolean**| Indicates whether the images should be kept as is. | [optional]
 **resizeToImage** | **kotlin.Int**| The index of the image to resize the other images to. | [optional]
 **streched** | **kotlin.Boolean**|  | [optional]
 **width** | **kotlin.Int**| The width of the GIF. | [optional]
 **height** | **kotlin.Int**| The height of the GIF. | [optional]
 **frameTimes** | **kotlin.String**| The times for each frame in the GIF. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiHashPost"></a>
# **pdfWebapiHashPost**
> FileResponse pdfWebapiHashPost(files, documentPassword, inputType, outputType, alg)

Calculate Document Hash.

Calculates the hash values for the provided documents using the specified hashing algorithm. Upload the documents and choose the desired algorithm, and the service will generate hash values for each file. This process helps verify that the documents have not been altered or corrupted, ensuring data integrity.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val alg : HashAlgorithm =  // HashAlgorithm | The hashing algorithm to use.
try {
    val result : FileResponse = apiInstance.pdfWebapiHashPost(files, documentPassword, inputType, outputType, alg)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiHashPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiHashPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]
 **alg** | [**HashAlgorithm**](.md)| The hashing algorithm to use. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiLockPost"></a>
# **pdfWebapiLockPost**
> FileResponse pdfWebapiLockPost(password, files)

Lock document.

Locks the provided document with a specified password to restrict access to authorized users only. Upload the file and provide a password, and the service will apply the password protection to secure the document. Optionally, you can include additional files to further enhance the security of the document.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val password : kotlin.String = password_example // kotlin.String | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
try {
    val result : FileResponse = apiInstance.pdfWebapiLockPost(password, files)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiLockPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiLockPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **kotlin.String**|  | [optional]
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiMergePost"></a>
# **pdfWebapiMergePost**
> FileResponse pdfWebapiMergePost(files, documentPassword, inputType, outputType, mergeType, horizontal, vertical, pageSize, dcIsLandscape)

Merge Documents.

Merges multiple documents or images into a single file based on specified preferences for orientation and page size. Upload the files you want to consolidate and define your formatting preferences. This service will combine the files into one, ensuring that the final document or image meets your requirements.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output file.
val mergeType : MergeImageType =  // MergeImageType | Type of merger operation.
val horizontal : kotlin.Int = 56 // kotlin.Int | The number of images to merge horizontally, if applicable.
val vertical : kotlin.Int = 56 // kotlin.Int | The number of images to merge vertically, if applicable.
val pageSize : PageSize =  // PageSize | The page size for the output file, if applicable.
val dcIsLandscape : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the output file should be in landscape orientation.
try {
    val result : FileResponse = apiInstance.pdfWebapiMergePost(files, documentPassword, inputType, outputType, mergeType, horizontal, vertical, pageSize, dcIsLandscape)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiMergePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiMergePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output file. | [optional]
 **mergeType** | [**MergeImageType**](.md)| Type of merger operation. | [optional]
 **horizontal** | **kotlin.Int**| The number of images to merge horizontally, if applicable. | [optional]
 **vertical** | **kotlin.Int**| The number of images to merge vertically, if applicable. | [optional]
 **pageSize** | [**PageSize**](.md)| The page size for the output file, if applicable. | [optional]
 **dcIsLandscape** | **kotlin.Boolean**| Indicates whether the output file should be in landscape orientation. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiMetadataPost"></a>
# **pdfWebapiMetadataPost**
> FileResponse pdfWebapiMetadataPost(files, documentPassword, operation, folder, name)

Read and Change Document Metadata.

Reads and updates the metadata of the provided documents based on specified operations. Upload the documents and define the metadata changes you need. This service will read the existing metadata, apply the changes, and ensure that your files contain accurate and updated information.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val operation : MetadataOperation =  // MetadataOperation | The operation to perform on the metadata.
val folder : kotlin.String = folder_example // kotlin.String | The folder where the files are located.
val name : kotlin.String = name_example // kotlin.String | The name of the file to perform the operation on.
try {
    val result : FileResponse = apiInstance.pdfWebapiMetadataPost(files, documentPassword, operation, folder, name)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiMetadataPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiMetadataPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **operation** | [**MetadataOperation**](.md)| The operation to perform on the metadata. | [optional]
 **folder** | **kotlin.String**| The folder where the files are located. | [optional]
 **name** | **kotlin.String**| The name of the file to perform the operation on. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiOrganizePost"></a>
# **pdfWebapiOrganizePost**
> FileResponse pdfWebapiOrganizePost(files, documentPassword, inputType, remove, move)

Organize Document Pages.

Reorganizes the pages of the provided document based on your instructions. Upload the document and specify which pages to remove or move, and the service will rearrange the pages accordingly, ensuring that the document is organized as you require.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val remove : kotlin.String = remove_example // kotlin.String | The pages to remove from the document.
val move : kotlin.String = move_example // kotlin.String | The pages to move within the document.
try {
    val result : FileResponse = apiInstance.pdfWebapiOrganizePost(files, documentPassword, inputType, remove, move)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiOrganizePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiOrganizePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **remove** | **kotlin.String**| The pages to remove from the document. | [optional]
 **move** | **kotlin.String**| The pages to move within the document. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiParsePost"></a>
# **pdfWebapiParsePost**
> FileResponse pdfWebapiParsePost(files, documentPassword)

Parse Document.

Analyses and extracts relevant content from the provided document files. The parsing service organizes the data within your documents to make it accessible and tailored to your specific requirements.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
try {
    val result : FileResponse = apiInstance.pdfWebapiParsePost(files, documentPassword)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiParsePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiParsePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRedactPost"></a>
# **pdfWebapiRedactPost**
> FileResponse pdfWebapiRedactPost(files, documentPassword, searchQuery, replaceText, caseSensitive, text, comments, metadata)

Redact Document Text.

Redacts sensitive information from the provided documents by removing specified text, comments, and metadata. You can specify the text to be redacted and use case-sensitive search to ensure thorough removal. This service helps maintain confidentiality and security by ensuring that sensitive information is completely removed.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val searchQuery : kotlin.String = searchQuery_example // kotlin.String | The text to search for and redact.
val replaceText : kotlin.String = replaceText_example // kotlin.String | The text to replace the found text with.
val caseSensitive : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the search should be case-sensitive.
val text : kotlin.Boolean = true // kotlin.Boolean | Indicates whether text should be redacted.
val comments : kotlin.Boolean = true // kotlin.Boolean | Indicates whether comments should be redacted.
val metadata : kotlin.Boolean = true // kotlin.Boolean | Indicates whether metadata should be redacted.
try {
    val result : FileResponse = apiInstance.pdfWebapiRedactPost(files, documentPassword, searchQuery, replaceText, caseSensitive, text, comments, metadata)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiRedactPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiRedactPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **searchQuery** | **kotlin.String**| The text to search for and redact. | [optional]
 **replaceText** | **kotlin.String**| The text to replace the found text with. | [optional]
 **caseSensitive** | **kotlin.Boolean**| Indicates whether the search should be case-sensitive. | [optional]
 **text** | **kotlin.Boolean**| Indicates whether text should be redacted. | [optional]
 **comments** | **kotlin.Boolean**| Indicates whether comments should be redacted. | [optional]
 **metadata** | **kotlin.Boolean**| Indicates whether metadata should be redacted. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRemoveIdPost"></a>
# **pdfWebapiRemoveIdPost**
> FileResponse pdfWebapiRemoveIdPost(id)

Remove stored files.

Removes processed files from storage.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val id : kotlin.String = id_example // kotlin.String | The ID of the processing to remove.
try {
    val result : FileResponse = apiInstance.pdfWebapiRemoveIdPost(id)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiRemoveIdPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiRemoveIdPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.String**| The ID of the processing to remove. |

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRemovePost"></a>
# **pdfWebapiRemovePost**
> FileResponse pdfWebapiRemovePost(files, documentPassword)

Remove Document Annotations.

Removes all annotations, including comments, highlights, and markup, from the provided documents. By specifying the documents, this service ensures that they are cleaned of any annotations, resulting in a clean and annotation-free file.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
try {
    val result : FileResponse = apiInstance.pdfWebapiRemovePost(files, documentPassword)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiRemovePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiRemovePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRemoveWatermarkPost"></a>
# **pdfWebapiRemoveWatermarkPost**
> FileResponse pdfWebapiRemoveWatermarkPost(watermarkText, top, left, bottom, right, files, documentPassword, isAllPages, watermarkType, removeRange)

Remove Document Watermark.

Removes an unwanted watermark from all pages of the provided document. Submit the document, and this service will efficiently eliminate the watermark, resulting in a clean version of the file without the watermark.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val watermarkText : kotlin.String = watermarkText_example // kotlin.String | 
val top : kotlin.Int = 56 // kotlin.Int | 
val left : kotlin.Int = 56 // kotlin.Int | 
val bottom : kotlin.Int = 56 // kotlin.Int | 
val right : kotlin.Int = 56 // kotlin.Int | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val isAllPages : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the watermark should be removed from all pages.
val watermarkType : WatermarkType =  // WatermarkType | The type of watermark to remove.
val removeRange : kotlin.String = removeRange_example // kotlin.String | The range of pages to remove the watermark from.
try {
    val result : FileResponse = apiInstance.pdfWebapiRemoveWatermarkPost(watermarkText, top, left, bottom, right, files, documentPassword, isAllPages, watermarkType, removeRange)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiRemoveWatermarkPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiRemoveWatermarkPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **watermarkText** | **kotlin.String**|  | [optional]
 **top** | **kotlin.Int**|  | [optional]
 **left** | **kotlin.Int**|  | [optional]
 **bottom** | **kotlin.Int**|  | [optional]
 **right** | **kotlin.Int**|  | [optional]
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **isAllPages** | **kotlin.Boolean**| Indicates whether the watermark should be removed from all pages. | [optional]
 **watermarkType** | [**WatermarkType**](.md)| The type of watermark to remove. | [optional]
 **removeRange** | **kotlin.String**| The range of pages to remove the watermark from. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRemovepagesPost"></a>
# **pdfWebapiRemovepagesPost**
> FileResponse pdfWebapiRemovepagesPost(files, documentPassword, removeRange)

Remove Pages from Document.

Removes specified pages from the provided document, leaving only the pages you want to keep. Simply provide the document and specify which pages to remove, and the service will process the file accordingly.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val removeRange : kotlin.String = removeRange_example // kotlin.String | The range of pages to remove from the files.
try {
    val result : FileResponse = apiInstance.pdfWebapiRemovepagesPost(files, documentPassword, removeRange)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiRemovepagesPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiRemovepagesPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **removeRange** | **kotlin.String**| The range of pages to remove from the files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRepairPost"></a>
# **pdfWebapiRepairPost**
> FileResponse pdfWebapiRepairPost(files, documentPassword)

Repair Document.

Repairs a corrupted or error-ridden document by identifying and fixing issues. Upload the problematic file, and this service will restore it to a usable state.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
try {
    val result : FileResponse = apiInstance.pdfWebapiRepairPost(files, documentPassword)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiRepairPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiRepairPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiResizePost"></a>
# **pdfWebapiResizePost**
> FileResponse pdfWebapiResizePost(files, documentPassword, inputType, outputType, resizeType, presetType, presetSize, width, height, percentage, useProportions, pageSize)

Resize Document.

Resizes the document to fit the specified dimensions or preset sizes. Provide the file and specify the desired dimensions, or select from available preset sizes to adjust the document accordingly.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val resizeType : ResizeType =  // ResizeType | The type of resizing to apply.
val presetType : ResizePresetType =  // ResizePresetType | The type of preset size to use for resizing.
val presetSize : ResizePresetSize =  // ResizePresetSize | The preset size to use for resizing.
val width : kotlin.Int = 56 // kotlin.Int | The desired width of the resized files.
val height : kotlin.Int = 56 // kotlin.Int | The desired height of the resized files.
val percentage : kotlin.Int = 56 // kotlin.Int | The percentage to resize the files by.
val useProportions : kotlin.Boolean = true // kotlin.Boolean | Indicates whether to maintain the aspect ratio when resizing.
val pageSize : ResizePageSize =  // ResizePageSize | The page size to use for the resized files.
try {
    val result : FileResponse = apiInstance.pdfWebapiResizePost(files, documentPassword, inputType, outputType, resizeType, presetType, presetSize, width, height, percentage, useProportions, pageSize)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiResizePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiResizePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]
 **resizeType** | [**ResizeType**](.md)| The type of resizing to apply. | [optional]
 **presetType** | [**ResizePresetType**](.md)| The type of preset size to use for resizing. | [optional]
 **presetSize** | [**ResizePresetSize**](.md)| The preset size to use for resizing. | [optional]
 **width** | **kotlin.Int**| The desired width of the resized files. | [optional]
 **height** | **kotlin.Int**| The desired height of the resized files. | [optional]
 **percentage** | **kotlin.Int**| The percentage to resize the files by. | [optional]
 **useProportions** | **kotlin.Boolean**| Indicates whether to maintain the aspect ratio when resizing. | [optional]
 **pageSize** | [**ResizePageSize**](.md)| The page size to use for the resized files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRotatePost"></a>
# **pdfWebapiRotatePost**
> FileResponse pdfWebapiRotatePost(files, documentPassword, angle, rotateType, pageNum)

Rotate Document.

Rotates the document by a specified angle, allowing for adjustment of the document&#x27;s orientation. You can choose the type of rotation and target specific pages to ensure the document is aligned according to your needs.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val angle : RotateAngle =  // RotateAngle | The angle by which to rotate the files.
val rotateType : RotateType =  // RotateType | The type of rotation to perform.
val pageNum : kotlin.String = pageNum_example // kotlin.String | The page number to rotate, if applicable.
try {
    val result : FileResponse = apiInstance.pdfWebapiRotatePost(files, documentPassword, angle, rotateType, pageNum)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiRotatePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiRotatePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **angle** | [**RotateAngle**](.md)| The angle by which to rotate the files. | [optional]
 **rotateType** | [**RotateType**](.md)| The type of rotation to perform. | [optional]
 **pageNum** | **kotlin.String**| The page number to rotate, if applicable. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiSearchPost"></a>
# **pdfWebapiSearchPost**
> FileResponse pdfWebapiSearchPost(files, documentPassword, query)

Search Document Text.

Searches the provided documents for the specified query and highlights the found text with a yellow background. This service helps you quickly locate and review relevant sections of your documents.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val query : kotlin.String = query_example // kotlin.String | The text to search for within the files.
try {
    val result : FileResponse = apiInstance.pdfWebapiSearchPost(files, documentPassword, query)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiSearchPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiSearchPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **query** | **kotlin.String**| The text to search for within the files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiSearchablePost"></a>
# **pdfWebapiSearchablePost**
> FileResponse pdfWebapiSearchablePost(files, lang)

Make Scanned PDF Searchable.

Converts scanned PDFs into a searchable PDF format by recognizing and indexing text. This service ensures that you can easily search through your documents by making the text searchable in the specified language.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val lang : kotlin.String = lang_example // kotlin.String | The language of the files to be converted.
try {
    val result : FileResponse = apiInstance.pdfWebapiSearchablePost(files, lang)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiSearchablePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiSearchablePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **lang** | **kotlin.String**| The language of the files to be converted. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiSignaturePost"></a>
# **pdfWebapiSignaturePost**
> FileResponse pdfWebapiSignaturePost(image, text, textColor, files, documentPassword, inputType, outputType, signatureType)

Add Signature to Document.

Adds a signature to the provided documents, allowing for the insertion of both text and image signatures. This service ensures that your documents are properly signed and authenticated according to your specifications.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val image : kotlin.String = image_example // kotlin.String | 
val text : kotlin.String = text_example // kotlin.String | 
val textColor : kotlin.String = textColor_example // kotlin.String | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val signatureType : SignatureType =  // SignatureType | The type of signature to add.
try {
    val result : FileResponse = apiInstance.pdfWebapiSignaturePost(image, text, textColor, files, documentPassword, inputType, outputType, signatureType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiSignaturePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiSignaturePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **kotlin.String**|  | [optional]
 **text** | **kotlin.String**|  | [optional]
 **textColor** | **kotlin.String**|  | [optional]
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]
 **signatureType** | [**SignatureType**](.md)| The type of signature to add. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiSplitdocPost"></a>
# **pdfWebapiSplitdocPost**
> FileResponse pdfWebapiSplitdocPost(files, documentPassword, inputType, splitType, pairs)

Split Document.

Splits a document into smaller parts based on specified criteria, such as type or page range. This service ensures that each segment meets your exact requirements, simplifying document management and organization.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val splitType : SplitDocType =  // SplitDocType | The type of splitting to be performed.
val pairs : kotlin.String = pairs_example // kotlin.String | Optional page rage for the splitting operation.
try {
    val result : FileResponse = apiInstance.pdfWebapiSplitdocPost(files, documentPassword, inputType, splitType, pairs)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiSplitdocPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiSplitdocPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **splitType** | [**SplitDocType**](.md)| The type of splitting to be performed. | [optional]
 **pairs** | **kotlin.String**| Optional page rage for the splitting operation. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiSplitimagePost"></a>
# **pdfWebapiSplitimagePost**
> FileResponse pdfWebapiSplitimagePost(files, documentPassword, splitType, vertical, horizontal, outputType)

Split Image.

Splits large images into smaller sections according to the specified parameters, making it easier to handle and process image data.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val splitType : SplitImageType =  // SplitImageType | The type of splitting to be performed.
val vertical : kotlin.Int = 56 // kotlin.Int | The number of vertical splits to create.
val horizontal : kotlin.Int = 56 // kotlin.Int | The number of horizontal splits to create.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired output format for the split images.
try {
    val result : FileResponse = apiInstance.pdfWebapiSplitimagePost(files, documentPassword, splitType, vertical, horizontal, outputType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiSplitimagePost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiSplitimagePost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **splitType** | [**SplitImageType**](.md)| The type of splitting to be performed. | [optional]
 **vertical** | **kotlin.Int**| The number of vertical splits to create. | [optional]
 **horizontal** | **kotlin.Int**| The number of horizontal splits to create. | [optional]
 **outputType** | **kotlin.String**| The desired output format for the split images. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiStatusIdPost"></a>
# **pdfWebapiStatusIdPost**
> FileResponse pdfWebapiStatusIdPost(id)

Processing status.

Retrieves the status of a processing.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val id : kotlin.String = id_example // kotlin.String | The ID of the processing to check the status of.
try {
    val result : FileResponse = apiInstance.pdfWebapiStatusIdPost(id)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiStatusIdPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiStatusIdPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.String**| The ID of the processing to check the status of. |

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiUnlockPost"></a>
# **pdfWebapiUnlockPost**
> FileResponse pdfWebapiUnlockPost(password, files)

Unlock Document.

Attempts to unlock a password-protected document, using any associated files if necessary, to grant access to the content.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val password : kotlin.String = password_example // kotlin.String | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
try {
    val result : FileResponse = apiInstance.pdfWebapiUnlockPost(password, files)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiUnlockPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiUnlockPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **kotlin.String**|  | [optional]
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiVerifyEsignPost"></a>
# **pdfWebapiVerifyEsignPost**
> FileResponse pdfWebapiVerifyEsignPost(files, documentPassword, inputType)

Verify Document Certificate.

Verifies the electronic signature of the provided document to ensure its authenticity and integrity. This service checks the digital certificates in the document to confirm their validity and trustworthiness.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
try {
    val result : FileResponse = apiInstance.pdfWebapiVerifyEsignPost(files, documentPassword, inputType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiVerifyEsignPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiVerifyEsignPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiWatermarkPost"></a>
# **pdfWebapiWatermarkPost**
> FileResponse pdfWebapiWatermarkPost(files, documentPassword, inputType, outputType, isColored, isText, text, name, size, bold, italic, underlined, color, isBackground, rotation, transparency, layer, pageFrom, pageTo)

Add Watermark to Document.

Adds a watermark to the provided documents, helping to protect and identify them. This service ensures that the watermark is applied according to your specifications, enhancing the security and ownership of your content.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val isColored : kotlin.Boolean = true // kotlin.Boolean | Indicate is watermark will be in color or grayscale.
val isText : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the watermark is text.
val text : kotlin.String = text_example // kotlin.String | The text of the watermark.
val name : kotlin.String = name_example // kotlin.String | The name of the font for the text watermark.
val size : kotlin.Int = 56 // kotlin.Int | The size of the font for the text watermark.
val bold : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the text watermark is bold.
val italic : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the text watermark is italic.
val underlined : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the text watermark is underlined.
val color : kotlin.String = color_example // kotlin.String | The color of the text or image watermark.
val isBackground : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the watermark is a background watermark.
val rotation : kotlin.Int = 56 // kotlin.Int | The rotation angle of the watermark.
val transparency : kotlin.Float = 3.4 // kotlin.Float | The transparency of the watermark.
val layer : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the watermark is a layer.
val pageFrom : kotlin.Int = 56 // kotlin.Int | The starting page number for the watermark.
val pageTo : kotlin.Int = 56 // kotlin.Int | The ending page number for the watermark.
try {
    val result : FileResponse = apiInstance.pdfWebapiWatermarkPost(files, documentPassword, inputType, outputType, isColored, isText, text, name, size, bold, italic, underlined, color, isBackground, rotation, transparency, layer, pageFrom, pageTo)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiWatermarkPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiWatermarkPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]
 **isColored** | **kotlin.Boolean**| Indicate is watermark will be in color or grayscale. | [optional]
 **isText** | **kotlin.Boolean**| Indicates whether the watermark is text. | [optional]
 **text** | **kotlin.String**| The text of the watermark. | [optional]
 **name** | **kotlin.String**| The name of the font for the text watermark. | [optional]
 **size** | **kotlin.Int**| The size of the font for the text watermark. | [optional]
 **bold** | **kotlin.Boolean**| Indicates whether the text watermark is bold. | [optional]
 **italic** | **kotlin.Boolean**| Indicates whether the text watermark is italic. | [optional]
 **underlined** | **kotlin.Boolean**| Indicates whether the text watermark is underlined. | [optional]
 **color** | **kotlin.String**| The color of the text or image watermark. | [optional]
 **isBackground** | **kotlin.Boolean**| Indicates whether the watermark is a background watermark. | [optional]
 **rotation** | **kotlin.Int**| The rotation angle of the watermark. | [optional]
 **transparency** | **kotlin.Float**| The transparency of the watermark. | [optional]
 **layer** | **kotlin.Boolean**| Indicates whether the watermark is a layer. | [optional]
 **pageFrom** | **kotlin.Int**| The starting page number for the watermark. | [optional]
 **pageTo** | **kotlin.Int**| The ending page number for the watermark. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiWordcounterPost"></a>
# **pdfWebapiWordcounterPost**
> FileResponse pdfWebapiWordcounterPost(files, documentPassword, pageRange)

Count Words and Characters in Document.

Counts the words and characters in the provided documents within the specified page range. This service helps you accurately determine the length and content density of your documents, ensuring compliance with any required specifications or limits.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val pageRange : kotlin.String = pageRange_example // kotlin.String | The range of pages to count words in.
try {
    val result : FileResponse = apiInstance.pdfWebapiWordcounterPost(files, documentPassword, pageRange)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiWordcounterPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiWordcounterPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **pageRange** | **kotlin.String**| The range of pages to count words in. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiXfaconvertPost"></a>
# **pdfWebapiXfaconvertPost**
> FileResponse pdfWebapiXfaconvertPost(files, documentPassword, inputType)

Convert XFA Format to Another Format.

Converts XFA documents to the specified format, ensuring seamless compatibility and usability. This service supports a wide range of target formats, allowing users to choose the most suitable format for their specific needs. The conversion process maintains the integrity of the original document while adapting it to the desired format, making it ideal for editing, sharing, or archiving..

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val documentPassword : kotlin.String = documentPassword_example // kotlin.String | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
try {
    val result : FileResponse = apiInstance.pdfWebapiXfaconvertPost(files, documentPassword, inputType)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiXfaconvertPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiXfaconvertPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **documentPassword** | **kotlin.String**|  | [optional]
 **inputType** | **kotlin.String**| The format of the input files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

