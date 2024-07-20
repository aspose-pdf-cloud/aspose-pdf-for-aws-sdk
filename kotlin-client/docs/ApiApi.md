# ApiApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pdfWebapiAddnumberPost**](ApiApi.md#pdfWebapiAddnumberPost) | **POST** /pdf/webapi/addnumber | Add page numbers to document.
[**pdfWebapiChangeFontsPost**](ApiApi.md#pdfWebapiChangeFontsPost) | **POST** /pdf/webapi/change-fonts | 
[**pdfWebapiComparisonPost**](ApiApi.md#pdfWebapiComparisonPost) | **POST** /pdf/webapi/comparison | Compare documents text.
[**pdfWebapiCompressPost**](ApiApi.md#pdfWebapiCompressPost) | **POST** /pdf/webapi/compress | Compress document.
[**pdfWebapiConvertPost**](ApiApi.md#pdfWebapiConvertPost) | **POST** /pdf/webapi/convert | Convert document to another format.
[**pdfWebapiConvertWebpagePost**](ApiApi.md#pdfWebapiConvertWebpagePost) | **POST** /pdf/webapi/convert-webpage | Convert web page to document.
[**pdfWebapiCropPost**](ApiApi.md#pdfWebapiCropPost) | **POST** /pdf/webapi/crop | Crop document.
[**pdfWebapiDownloadIdGet**](ApiApi.md#pdfWebapiDownloadIdGet) | **GET** /pdf/webapi/download/{id} | File download.
[**pdfWebapiEsignPost**](ApiApi.md#pdfWebapiEsignPost) | **POST** /pdf/webapi/esign | Sign document with certificate.
[**pdfWebapiExtractPost**](ApiApi.md#pdfWebapiExtractPost) | **POST** /pdf/webapi/extract | Extract tables from document.
[**pdfWebapiFormFillerPost**](ApiApi.md#pdfWebapiFormFillerPost) | **POST** /pdf/webapi/form-filler | Fill form.
[**pdfWebapiGifPost**](ApiApi.md#pdfWebapiGifPost) | **POST** /pdf/webapi/gif | Make GIF.
[**pdfWebapiHashPost**](ApiApi.md#pdfWebapiHashPost) | **POST** /pdf/webapi/hash | Calculate document hash.
[**pdfWebapiLockPost**](ApiApi.md#pdfWebapiLockPost) | **POST** /pdf/webapi/lock | Lock document.
[**pdfWebapiMergePost**](ApiApi.md#pdfWebapiMergePost) | **POST** /pdf/webapi/merge | Merge documents.
[**pdfWebapiMetadataPost**](ApiApi.md#pdfWebapiMetadataPost) | **POST** /pdf/webapi/metadata | Read and change document metadata.
[**pdfWebapiOrganizePost**](ApiApi.md#pdfWebapiOrganizePost) | **POST** /pdf/webapi/organize | Organize document pages.
[**pdfWebapiParsePost**](ApiApi.md#pdfWebapiParsePost) | **POST** /pdf/webapi/parse | Parse document.
[**pdfWebapiRedactPost**](ApiApi.md#pdfWebapiRedactPost) | **POST** /pdf/webapi/redact | Redact document text.
[**pdfWebapiRemoveIdPost**](ApiApi.md#pdfWebapiRemoveIdPost) | **POST** /pdf/webapi/remove/{id} | Remove stored files.
[**pdfWebapiRemovePost**](ApiApi.md#pdfWebapiRemovePost) | **POST** /pdf/webapi/remove | Remove document annotations.
[**pdfWebapiRemoveWatermarkPost**](ApiApi.md#pdfWebapiRemoveWatermarkPost) | **POST** /pdf/webapi/remove-watermark | Removes document watermark.
[**pdfWebapiRemovepagesPost**](ApiApi.md#pdfWebapiRemovepagesPost) | **POST** /pdf/webapi/removepages | Remove pages from document.
[**pdfWebapiRepairPost**](ApiApi.md#pdfWebapiRepairPost) | **POST** /pdf/webapi/repair | Repair document.
[**pdfWebapiResizePost**](ApiApi.md#pdfWebapiResizePost) | **POST** /pdf/webapi/resize | Resize document.
[**pdfWebapiRotatePost**](ApiApi.md#pdfWebapiRotatePost) | **POST** /pdf/webapi/rotate | Rotate document.
[**pdfWebapiSearchPost**](ApiApi.md#pdfWebapiSearchPost) | **POST** /pdf/webapi/search | Search document text.
[**pdfWebapiSearchablePost**](ApiApi.md#pdfWebapiSearchablePost) | **POST** /pdf/webapi/searchable | Make scanned pdf searchable.
[**pdfWebapiSignaturePost**](ApiApi.md#pdfWebapiSignaturePost) | **POST** /pdf/webapi/signature | Add signature to document.
[**pdfWebapiSplitdocPost**](ApiApi.md#pdfWebapiSplitdocPost) | **POST** /pdf/webapi/splitdoc | Split document.
[**pdfWebapiSplitimagePost**](ApiApi.md#pdfWebapiSplitimagePost) | **POST** /pdf/webapi/splitimage | Split image.
[**pdfWebapiStatusIdPost**](ApiApi.md#pdfWebapiStatusIdPost) | **POST** /pdf/webapi/status/{id} | Processing status.
[**pdfWebapiUnlockPost**](ApiApi.md#pdfWebapiUnlockPost) | **POST** /pdf/webapi/unlock | Unlock document.
[**pdfWebapiVerifyEsignPost**](ApiApi.md#pdfWebapiVerifyEsignPost) | **POST** /pdf/webapi/verify_esign | Verify document certificate.
[**pdfWebapiWatermarkPost**](ApiApi.md#pdfWebapiWatermarkPost) | **POST** /pdf/webapi/watermark | Add watermark to document.
[**pdfWebapiWordcounterPost**](ApiApi.md#pdfWebapiWordcounterPost) | **POST** /pdf/webapi/wordcounter | Count words and chars in document.
[**pdfWebapiXfaconvertPost**](ApiApi.md#pdfWebapiXfaconvertPost) | **POST** /pdf/webapi/xfaconvert | Convert XFA format to a another format.

<a name="pdfWebapiAddnumberPost"></a>
# **pdfWebapiAddnumberPost**
> FileResponse pdfWebapiAddnumberPost(files, vAlignment, hAlignment, startingNumber, sNumber, fNumber, margin, fontSize, format)

Add page numbers to document.

Adds page numbers to the provided documents with the specified alignment, starting number, and format.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val vAlignment : PageNumberVerticalAlign =  // PageNumberVerticalAlign | The vertical alignment of the page numbers.
val hAlignment : PageNumberHorizontalAlign =  // PageNumberHorizontalAlign | The horizontal alignment of the page numbers.
val startingNumber : kotlin.Int = 56 // kotlin.Int | The starting number for the page numbers.
val sNumber : kotlin.Int = 56 // kotlin.Int | The number of the first page to start numbering from.
val fNumber : kotlin.Int = 56 // kotlin.Int | The number of the last page to end numbering at.
val margin : kotlin.Int = 56 // kotlin.Int | The margin around the page numbers.
val fontSize : kotlin.Int = 56 // kotlin.Int | The font size of the page numbers.
val format : kotlin.String = format_example // kotlin.String | The format of the page numbers.
try {
    val result : FileResponse = apiInstance.pdfWebapiAddnumberPost(files, vAlignment, hAlignment, startingNumber, sNumber, fNumber, margin, fontSize, format)
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
> FileResponse pdfWebapiChangeFontsPost(fontReplacementsJson, files)



### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val fontReplacementsJson : kotlin.String = fontReplacementsJson_example // kotlin.String | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
try {
    val result : FileResponse = apiInstance.pdfWebapiChangeFontsPost(fontReplacementsJson, files)
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

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiComparisonPost"></a>
# **pdfWebapiComparisonPost**
> FileResponse pdfWebapiComparisonPost(files)

Compare documents text.

Compare provided files and create document with marked changes.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
try {
    val result : FileResponse = apiInstance.pdfWebapiComparisonPost(files)
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

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiCompressPost"></a>
# **pdfWebapiCompressPost**
> FileResponse pdfWebapiCompressPost(files, compressType)

Compress document.

Compresses the provided files using the specified compression level.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val compressType : CompressType =  // CompressType | The level of compression to use.
try {
    val result : FileResponse = apiInstance.pdfWebapiCompressPost(files, compressType)
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
> FileResponse pdfWebapiConvertPost(files, inputType, outputType, xmlType, xmlTag, fontSise, isToSingle, separator)

Convert document to another format.

Converts the provided files from one format to another.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val xmlType : XmlType =  // XmlType | The type of XML conversion to perform, if applicable.
val xmlTag : kotlin.String = xmlTag_example // kotlin.String | The XML tag to use for conversion, if applicable.
val fontSise : kotlin.Int = 56 // kotlin.Int | 
val isToSingle : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the conversion should result in a single file, if applicable.
val separator : kotlin.String = separator_example // kotlin.String | The separator to use when converting, if applicable.
try {
    val result : FileResponse = apiInstance.pdfWebapiConvertPost(files, inputType, outputType, xmlType, xmlTag, fontSise, isToSingle, separator)
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
> FileResponse pdfWebapiConvertWebpagePost(webPage, outputType)

Convert web page to document.

Converts a web page to the specified output format.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val webPage : kotlin.String = webPage_example // kotlin.String | 
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output file.
try {
    val result : FileResponse = apiInstance.pdfWebapiConvertWebpagePost(webPage, outputType)
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
> FileResponse pdfWebapiCropPost(files, inputType, top, right, bottom, left, outputType)

Crop document.

Crops the provided files to the specified dimensions.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val top : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the top.
val right : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the right.
val bottom : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the bottom.
val left : kotlin.Int = 56 // kotlin.Int | The number of pixels to crop from the left.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
try {
    val result : FileResponse = apiInstance.pdfWebapiCropPost(files, inputType, top, right, bottom, left, outputType)
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
> FileResponse pdfWebapiEsignPost(passw, files, inputType)

Sign document with certificate.

Electronically signs the provided documents with the specified certificate.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val passw : kotlin.String = passw_example // kotlin.String | 
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
try {
    val result : FileResponse = apiInstance.pdfWebapiEsignPost(passw, files, inputType)
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
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
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
> FileResponse pdfWebapiExtractPost(files, inputType, outputType)

Extract tables from document.

Extracts tables from the provided documents and converts them to the specified output format.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
try {
    val result : FileResponse = apiInstance.pdfWebapiExtractPost(files, inputType, outputType)
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
 **inputType** | **kotlin.String**| The format of the input files. | [optional]
 **outputType** | **kotlin.String**| The desired format for the output files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiFormFillerPost"></a>
# **pdfWebapiFormFillerPost**
> FileResponse pdfWebapiFormFillerPost(files, fileName)

Fill form.

Fills a form with the provided files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val fileName : kotlin.String = fileName_example // kotlin.String | The name of the file to fill the form with.
try {
    val result : FileResponse = apiInstance.pdfWebapiFormFillerPost(files, fileName)
    println(result)
} catch (e: ClientException) {
    println("4xx response calling ApiApi#pdfWebapiFormFillerPost")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ApiApi#pdfWebapiFormFillerPost")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **fileName** | **kotlin.String**| The name of the file to fill the form with. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiGifPost"></a>
# **pdfWebapiGifPost**
> FileResponse pdfWebapiGifPost(files, keepImagesAsIs, resizeToImage, streched, width, height, frameTimes)

Make GIF.

Creates a GIF from the provided images.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val keepImagesAsIs : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the images should be kept as is.
val resizeToImage : kotlin.Int = 56 // kotlin.Int | The index of the image to resize the other images to.
val streched : kotlin.Boolean = true // kotlin.Boolean | 
val width : kotlin.Int = 56 // kotlin.Int | The width of the GIF.
val height : kotlin.Int = 56 // kotlin.Int | The height of the GIF.
val frameTimes : kotlin.String = frameTimes_example // kotlin.String | The times for each frame in the GIF.
try {
    val result : FileResponse = apiInstance.pdfWebapiGifPost(files, keepImagesAsIs, resizeToImage, streched, width, height, frameTimes)
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
> FileResponse pdfWebapiHashPost(files, inputType, outputType, alg)

Calculate document hash.

Calculate hashes of provided files using the specified algorithm.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val alg : HashAlgorithm =  // HashAlgorithm | The hashing algorithm to use.
try {
    val result : FileResponse = apiInstance.pdfWebapiHashPost(files, inputType, outputType, alg)
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
> FileResponse pdfWebapiLockPost(files, passw)

Lock document.

Locks a document with the provided password and optional files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val passw : kotlin.String = passw_example // kotlin.String | The password required to lock the resource.
try {
    val result : FileResponse = apiInstance.pdfWebapiLockPost(files, passw)
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
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **passw** | **kotlin.String**| The password required to lock the resource. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiMergePost"></a>
# **pdfWebapiMergePost**
> FileResponse pdfWebapiMergePost(files, inputType, outputType, mergeType, horizontal, vertical, pageSize, dcIsLandscape)

Merge documents.

Merges the provided files into a single document or image, with options for orientation and page size.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output file.
val mergeType : MergeImageType =  // MergeImageType | Type of merger operation.
val horizontal : kotlin.Int = 56 // kotlin.Int | The number of images to merge horizontally, if applicable.
val vertical : kotlin.Int = 56 // kotlin.Int | The number of images to merge vertically, if applicable.
val pageSize : PageSize =  // PageSize | The page size for the output file, if applicable.
val dcIsLandscape : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the output file should be in landscape orientation.
try {
    val result : FileResponse = apiInstance.pdfWebapiMergePost(files, inputType, outputType, mergeType, horizontal, vertical, pageSize, dcIsLandscape)
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
> FileResponse pdfWebapiMetadataPost(files, operation, folder, name)

Read and change document metadata.

Performs metadata operations on the provided files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val operation : MetadataOperation =  // MetadataOperation | The operation to perform on the metadata.
val folder : kotlin.String = folder_example // kotlin.String | The folder where the files are located.
val name : kotlin.String = name_example // kotlin.String | The name of the file to perform the operation on.
try {
    val result : FileResponse = apiInstance.pdfWebapiMetadataPost(files, operation, folder, name)
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
> FileResponse pdfWebapiOrganizePost(files, inputType, remove, move)

Organize document pages.

Organizes the provided documents by removing or moving specified pages.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val remove : kotlin.String = remove_example // kotlin.String | The pages to remove from the document.
val move : kotlin.String = move_example // kotlin.String | The pages to move within the document.
try {
    val result : FileResponse = apiInstance.pdfWebapiOrganizePost(files, inputType, remove, move)
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
> FileResponse pdfWebapiParsePost(files)

Parse document.

Parses the provided files using a parser service.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
try {
    val result : FileResponse = apiInstance.pdfWebapiParsePost(files)
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

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRedactPost"></a>
# **pdfWebapiRedactPost**
> FileResponse pdfWebapiRedactPost(files, searchQuery, replaceText, caseSensitive, text, comments, metadata)

Redact document text.

Redacts specified text from the provided documents, with options to search case-sensitively, target in text, comments, and metadata.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val searchQuery : kotlin.String = searchQuery_example // kotlin.String | The text to search for and redact.
val replaceText : kotlin.String = replaceText_example // kotlin.String | The text to replace the found text with.
val caseSensitive : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the search should be case-sensitive.
val text : kotlin.Boolean = true // kotlin.Boolean | Indicates whether text should be redacted.
val comments : kotlin.Boolean = true // kotlin.Boolean | Indicates whether comments should be redacted.
val metadata : kotlin.Boolean = true // kotlin.Boolean | Indicates whether metadata should be redacted.
try {
    val result : FileResponse = apiInstance.pdfWebapiRedactPost(files, searchQuery, replaceText, caseSensitive, text, comments, metadata)
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
> FileResponse pdfWebapiRemovePost(files)

Remove document annotations.

Removes annotations from the provided documents.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
try {
    val result : FileResponse = apiInstance.pdfWebapiRemovePost(files)
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

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiRemoveWatermarkPost"></a>
# **pdfWebapiRemoveWatermarkPost**
> FileResponse pdfWebapiRemoveWatermarkPost(watermarkText, top, left, bottom, right, files, isAllPages, watermarkType, removeRange)

Removes document watermark.

Removes a watermark from the document pages.

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
val isAllPages : kotlin.Boolean = true // kotlin.Boolean | Indicates whether the watermark should be removed from all pages.
val watermarkType : WatermarkType =  // WatermarkType | The type of watermark to remove.
val removeRange : kotlin.String = removeRange_example // kotlin.String | The range of pages to remove the watermark from.
try {
    val result : FileResponse = apiInstance.pdfWebapiRemoveWatermarkPost(watermarkText, top, left, bottom, right, files, isAllPages, watermarkType, removeRange)
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
> FileResponse pdfWebapiRemovepagesPost(files, removeRange)

Remove pages from document.

Removes specified pages from the provided files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val removeRange : kotlin.String = removeRange_example // kotlin.String | The range of pages to remove from the files.
try {
    val result : FileResponse = apiInstance.pdfWebapiRemovepagesPost(files, removeRange)
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
> FileResponse pdfWebapiRepairPost(files)

Repair document.

Repairs the provided files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
try {
    val result : FileResponse = apiInstance.pdfWebapiRepairPost(files)
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

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiResizePost"></a>
# **pdfWebapiResizePost**
> FileResponse pdfWebapiResizePost(files, inputType, outputType, resizeType, presetType, presetSize, width, height, percentage, useProportions, pageSize)

Resize document.

Resizes the provided files to the specified dimensions or using a preset size.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
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
    val result : FileResponse = apiInstance.pdfWebapiResizePost(files, inputType, outputType, resizeType, presetType, presetSize, width, height, percentage, useProportions, pageSize)
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
> FileResponse pdfWebapiRotatePost(files, angle, rotateType, pageNum)

Rotate document.

Rotates the provided files by a specified angle, with options for rotation type and page number.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val angle : RotateAngle =  // RotateAngle | The angle by which to rotate the files.
val rotateType : RotateType =  // RotateType | The type of rotation to perform.
val pageNum : kotlin.String = pageNum_example // kotlin.String | The page number to rotate, if applicable.
try {
    val result : FileResponse = apiInstance.pdfWebapiRotatePost(files, angle, rotateType, pageNum)
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
> FileResponse pdfWebapiSearchPost(files, query)

Search document text.

Searches the provided files for the specified query and makr found text with yellow background.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val query : kotlin.String = query_example // kotlin.String | The text to search for within the files.
try {
    val result : FileResponse = apiInstance.pdfWebapiSearchPost(files, query)
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

Make scanned pdf searchable.

Converts the provided files into a searchable PDF format for the specified language.

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
> FileResponse pdfWebapiSignaturePost(image, text, textColor, files, inputType, outputType, signatureType)

Add signature to document.

Adds a signature, text and image to the provided documents.

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
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired format for the output files.
val signatureType : SignatureType =  // SignatureType | The type of signature to add.
try {
    val result : FileResponse = apiInstance.pdfWebapiSignaturePost(image, text, textColor, files, inputType, outputType, signatureType)
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
> FileResponse pdfWebapiSplitdocPost(files, splitType, pairs)

Split document.

Splits the provided documents based on the specified split type and page rage to spit.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val splitType : SplitDocType =  // SplitDocType | The type of splitting to be performed.
val pairs : kotlin.String = pairs_example // kotlin.String | Optional page rage for the splitting operation.
try {
    val result : FileResponse = apiInstance.pdfWebapiSplitdocPost(files, splitType, pairs)
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
 **splitType** | [**SplitDocType**](.md)| The type of splitting to be performed. | [optional]
 **pars** | **kotlin.String**| Optional page rage for the splitting operation. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiSplitimagePost"></a>
# **pdfWebapiSplitimagePost**
> FileResponse pdfWebapiSplitimagePost(files, splitType, vertical, horizontal, outputType)

Split image.

Splits the provided images into smaller parts based on the specified parameters.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val splitType : SplitImageType =  // SplitImageType | The type of splitting to be performed.
val vertical : kotlin.Int = 56 // kotlin.Int | The number of vertical splits to create.
val horizontal : kotlin.Int = 56 // kotlin.Int | The number of horizontal splits to create.
val outputType : kotlin.String = outputType_example // kotlin.String | The desired output format for the split images.
try {
    val result : FileResponse = apiInstance.pdfWebapiSplitimagePost(files, splitType, vertical, horizontal, outputType)
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
> FileResponse pdfWebapiUnlockPost(files, passw)

Unlock document.

Attempts to unlock a document with an password and associated files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val passw : kotlin.String = passw_example // kotlin.String | The password used in locked document.
try {
    val result : FileResponse = apiInstance.pdfWebapiUnlockPost(files, passw)
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
 **files** | [**kotlin.Array&lt;kotlin.Array&lt;kotlin.Byte&gt;&gt;**](kotlin.Array&lt;kotlin.Byte&gt;.md)|  | [optional]
 **passw** | **kotlin.String**| The password used in locked document. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

<a name="pdfWebapiVerifyEsignPost"></a>
# **pdfWebapiVerifyEsignPost**
> FileResponse pdfWebapiVerifyEsignPost(files, inputType)

Verify document certificate.

Verifies the electronic signature of the provided files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
try {
    val result : FileResponse = apiInstance.pdfWebapiVerifyEsignPost(files, inputType)
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
> FileResponse pdfWebapiWatermarkPost(files, inputType, outputType, isColored, isText, text, name, size, bold, italic, underlined, color, isBackground, rotation, transparency, layer, pageFrom, pageTo)

Add watermark to document.

Adds a watermark to the provided files.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
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
    val result : FileResponse = apiInstance.pdfWebapiWatermarkPost(files, inputType, outputType, isColored, isText, text, name, size, bold, italic, underlined, color, isBackground, rotation, transparency, layer, pageFrom, pageTo)
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
> FileResponse pdfWebapiWordcounterPost(files, pageRange)

Count words and chars in document.

Counts the words in the provided files within the specified page range.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val pageRange : kotlin.String = pageRange_example // kotlin.String | The range of pages to count words in.
try {
    val result : FileResponse = apiInstance.pdfWebapiWordcounterPost(files, pageRange)
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
> FileResponse pdfWebapiXfaconvertPost(files, inputType)

Convert XFA format to a another format.

Converts the provided documents from XFA format to a different format.

### Example
```kotlin
// Import classes:
//import io.swagger.client.infrastructure.*
//import io.swagger.client.models.*;

val apiInstance = ApiApi()
val files : kotlin.Array<kotlin.Array<kotlin.Byte>> =  // kotlin.Array<kotlin.Array<kotlin.Byte>> | 
val inputType : kotlin.String = inputType_example // kotlin.String | The format of the input files.
try {
    val result : FileResponse = apiInstance.pdfWebapiXfaconvertPost(files, inputType)
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
 **inputType** | **kotlin.String**| The format of the input files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

