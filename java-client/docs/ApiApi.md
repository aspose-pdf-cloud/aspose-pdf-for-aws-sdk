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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
PageNumberVerticalAlign vAlignment = new PageNumberVerticalAlign(); // PageNumberVerticalAlign | The vertical alignment of the page numbers.
PageNumberHorizontalAlign hAlignment = new PageNumberHorizontalAlign(); // PageNumberHorizontalAlign | The horizontal alignment of the page numbers.
Integer startingNumber = 56; // Integer | The starting number for the page numbers.
Integer sNumber = 56; // Integer | The number of the first page to start numbering from.
Integer fNumber = 56; // Integer | The number of the last page to end numbering at.
Integer margin = 56; // Integer | The margin around the page numbers.
Integer fontSize = 56; // Integer | The font size of the page numbers.
String format = "format_example"; // String | The format of the page numbers.
try {
    FileResponse result = apiInstance.pdfWebapiAddnumberPost(files, documentPassword, vAlignment, hAlignment, startingNumber, sNumber, fNumber, margin, fontSize, format);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiAddnumberPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **vAlignment** | [**PageNumberVerticalAlign**](.md)| The vertical alignment of the page numbers. | [optional]
 **hAlignment** | [**PageNumberHorizontalAlign**](.md)| The horizontal alignment of the page numbers. | [optional]
 **startingNumber** | **Integer**| The starting number for the page numbers. | [optional]
 **sNumber** | **Integer**| The number of the first page to start numbering from. | [optional]
 **fNumber** | **Integer**| The number of the last page to end numbering at. | [optional]
 **margin** | **Integer**| The margin around the page numbers. | [optional]
 **fontSize** | **Integer**| The font size of the page numbers. | [optional]
 **format** | **String**| The format of the page numbers. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String fontReplacementsJson = "fontReplacementsJson_example"; // String | 
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
try {
    FileResponse result = apiInstance.pdfWebapiChangeFontsPost(fontReplacementsJson, files, documentPassword);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiChangeFontsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fontReplacementsJson** | **String**|  | [optional]
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
try {
    FileResponse result = apiInstance.pdfWebapiComparisonPost(files, documentPassword);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiComparisonPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
CompressType compressType = new CompressType(); // CompressType | The level of compression to use.
try {
    FileResponse result = apiInstance.pdfWebapiCompressPost(files, documentPassword, compressType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiCompressPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String outputType = "outputType_example"; // String | The desired format for the output files.
XmlType xmlType = new XmlType(); // XmlType | The type of XML conversion to perform, if applicable.
String xmlTag = "xmlTag_example"; // String | The XML tag to use for conversion, if applicable.
Integer fontSise = 56; // Integer | 
Boolean isToSingle = true; // Boolean | Indicates whether the conversion should result in a single file, if applicable.
String separator = "separator_example"; // String | The separator to use when converting, if applicable.
try {
    FileResponse result = apiInstance.pdfWebapiConvertPost(files, documentPassword, inputType, outputType, xmlType, xmlTag, fontSise, isToSingle, separator);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiConvertPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **outputType** | **String**| The desired format for the output files. | [optional]
 **xmlType** | [**XmlType**](.md)| The type of XML conversion to perform, if applicable. | [optional]
 **xmlTag** | **String**| The XML tag to use for conversion, if applicable. | [optional]
 **fontSise** | **Integer**|  | [optional]
 **isToSingle** | **Boolean**| Indicates whether the conversion should result in a single file, if applicable. | [optional]
 **separator** | **String**| The separator to use when converting, if applicable. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String webPage = "webPage_example"; // String | 
String documentPassword = "documentPassword_example"; // String | 
String outputType = "outputType_example"; // String | The desired format for the output file.
try {
    FileResponse result = apiInstance.pdfWebapiConvertWebpagePost(webPage, documentPassword, outputType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiConvertWebpagePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webPage** | **String**|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **outputType** | **String**| The desired format for the output file. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
Integer top = 56; // Integer | The number of pixels to crop from the top.
Integer right = 56; // Integer | The number of pixels to crop from the right.
Integer bottom = 56; // Integer | The number of pixels to crop from the bottom.
Integer left = 56; // Integer | The number of pixels to crop from the left.
String outputType = "outputType_example"; // String | The desired format for the output files.
try {
    FileResponse result = apiInstance.pdfWebapiCropPost(files, documentPassword, inputType, top, right, bottom, left, outputType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiCropPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **top** | **Integer**| The number of pixels to crop from the top. | [optional]
 **right** | **Integer**| The number of pixels to crop from the right. | [optional]
 **bottom** | **Integer**| The number of pixels to crop from the bottom. | [optional]
 **left** | **Integer**| The number of pixels to crop from the left. | [optional]
 **outputType** | **String**| The desired format for the output files. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String id = "id_example"; // String | The id of the processing to download.
String file = "file_example"; // String | The name of the file to download.
try {
    apiInstance.pdfWebapiDownloadIdGet(id, file);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiDownloadIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The id of the processing to download. |
 **file** | **String**| The name of the file to download. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String passw = "passw_example"; // String | 
String initials = "initials_example"; // String | 
String invite = "invite_example"; // String | 
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
try {
    FileResponse result = apiInstance.pdfWebapiEsignPost(passw, initials, invite, files, documentPassword, inputType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiEsignPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passw** | **String**|  | [optional]
 **initials** | **String**|  | [optional]
 **invite** | **String**|  | [optional]
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String outputType = "outputType_example"; // String | The desired format for the output files.
try {
    FileResponse result = apiInstance.pdfWebapiExtractPost(files, documentPassword, inputType, outputType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiExtractPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **outputType** | **String**| The desired format for the output files. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
Boolean keepImagesAsIs = true; // Boolean | Indicates whether the images should be kept as is.
Integer resizeToImage = 56; // Integer | The index of the image to resize the other images to.
Boolean streched = true; // Boolean | 
Integer width = 56; // Integer | The width of the GIF.
Integer height = 56; // Integer | The height of the GIF.
String frameTimes = "frameTimes_example"; // String | The times for each frame in the GIF.
try {
    FileResponse result = apiInstance.pdfWebapiGifPost(files, documentPassword, keepImagesAsIs, resizeToImage, streched, width, height, frameTimes);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiGifPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **keepImagesAsIs** | **Boolean**| Indicates whether the images should be kept as is. | [optional]
 **resizeToImage** | **Integer**| The index of the image to resize the other images to. | [optional]
 **streched** | **Boolean**|  | [optional]
 **width** | **Integer**| The width of the GIF. | [optional]
 **height** | **Integer**| The height of the GIF. | [optional]
 **frameTimes** | **String**| The times for each frame in the GIF. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String outputType = "outputType_example"; // String | The desired format for the output files.
HashAlgorithm alg = new HashAlgorithm(); // HashAlgorithm | The hashing algorithm to use.
try {
    FileResponse result = apiInstance.pdfWebapiHashPost(files, documentPassword, inputType, outputType, alg);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiHashPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **outputType** | **String**| The desired format for the output files. | [optional]
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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String password = "password_example"; // String | 
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
try {
    FileResponse result = apiInstance.pdfWebapiLockPost(password, files);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiLockPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **String**|  | [optional]
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String outputType = "outputType_example"; // String | The desired format for the output file.
MergeImageType mergeType = new MergeImageType(); // MergeImageType | Type of merger operation.
Integer horizontal = 56; // Integer | The number of images to merge horizontally, if applicable.
Integer vertical = 56; // Integer | The number of images to merge vertically, if applicable.
PageSize pageSize = new PageSize(); // PageSize | The page size for the output file, if applicable.
Boolean dcIsLandscape = true; // Boolean | Indicates whether the output file should be in landscape orientation.
try {
    FileResponse result = apiInstance.pdfWebapiMergePost(files, documentPassword, inputType, outputType, mergeType, horizontal, vertical, pageSize, dcIsLandscape);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiMergePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **outputType** | **String**| The desired format for the output file. | [optional]
 **mergeType** | [**MergeImageType**](.md)| Type of merger operation. | [optional]
 **horizontal** | **Integer**| The number of images to merge horizontally, if applicable. | [optional]
 **vertical** | **Integer**| The number of images to merge vertically, if applicable. | [optional]
 **pageSize** | [**PageSize**](.md)| The page size for the output file, if applicable. | [optional]
 **dcIsLandscape** | **Boolean**| Indicates whether the output file should be in landscape orientation. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
MetadataOperation operation = new MetadataOperation(); // MetadataOperation | The operation to perform on the metadata.
String folder = "folder_example"; // String | The folder where the files are located.
String name = "name_example"; // String | The name of the file to perform the operation on.
try {
    FileResponse result = apiInstance.pdfWebapiMetadataPost(files, documentPassword, operation, folder, name);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiMetadataPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **operation** | [**MetadataOperation**](.md)| The operation to perform on the metadata. | [optional]
 **folder** | **String**| The folder where the files are located. | [optional]
 **name** | **String**| The name of the file to perform the operation on. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String remove = "remove_example"; // String | The pages to remove from the document.
String move = "move_example"; // String | The pages to move within the document.
try {
    FileResponse result = apiInstance.pdfWebapiOrganizePost(files, documentPassword, inputType, remove, move);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiOrganizePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **remove** | **String**| The pages to remove from the document. | [optional]
 **move** | **String**| The pages to move within the document. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
try {
    FileResponse result = apiInstance.pdfWebapiParsePost(files, documentPassword);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiParsePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String searchQuery = "searchQuery_example"; // String | The text to search for and redact.
String replaceText = "replaceText_example"; // String | The text to replace the found text with.
Boolean caseSensitive = true; // Boolean | Indicates whether the search should be case-sensitive.
Boolean text = true; // Boolean | Indicates whether text should be redacted.
Boolean comments = true; // Boolean | Indicates whether comments should be redacted.
Boolean metadata = true; // Boolean | Indicates whether metadata should be redacted.
try {
    FileResponse result = apiInstance.pdfWebapiRedactPost(files, documentPassword, searchQuery, replaceText, caseSensitive, text, comments, metadata);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiRedactPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **searchQuery** | **String**| The text to search for and redact. | [optional]
 **replaceText** | **String**| The text to replace the found text with. | [optional]
 **caseSensitive** | **Boolean**| Indicates whether the search should be case-sensitive. | [optional]
 **text** | **Boolean**| Indicates whether text should be redacted. | [optional]
 **comments** | **Boolean**| Indicates whether comments should be redacted. | [optional]
 **metadata** | **Boolean**| Indicates whether metadata should be redacted. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String id = "id_example"; // String | The ID of the processing to remove.
try {
    FileResponse result = apiInstance.pdfWebapiRemoveIdPost(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiRemoveIdPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The ID of the processing to remove. |

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
try {
    FileResponse result = apiInstance.pdfWebapiRemovePost(files, documentPassword);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiRemovePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String watermarkText = "watermarkText_example"; // String | 
Integer top = 56; // Integer | 
Integer left = 56; // Integer | 
Integer bottom = 56; // Integer | 
Integer right = 56; // Integer | 
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
Boolean isAllPages = true; // Boolean | Indicates whether the watermark should be removed from all pages.
WatermarkType watermarkType = new WatermarkType(); // WatermarkType | The type of watermark to remove.
String removeRange = "removeRange_example"; // String | The range of pages to remove the watermark from.
try {
    FileResponse result = apiInstance.pdfWebapiRemoveWatermarkPost(watermarkText, top, left, bottom, right, files, documentPassword, isAllPages, watermarkType, removeRange);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiRemoveWatermarkPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **watermarkText** | **String**|  | [optional]
 **top** | **Integer**|  | [optional]
 **left** | **Integer**|  | [optional]
 **bottom** | **Integer**|  | [optional]
 **right** | **Integer**|  | [optional]
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **isAllPages** | **Boolean**| Indicates whether the watermark should be removed from all pages. | [optional]
 **watermarkType** | [**WatermarkType**](.md)| The type of watermark to remove. | [optional]
 **removeRange** | **String**| The range of pages to remove the watermark from. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String removeRange = "removeRange_example"; // String | The range of pages to remove from the files.
try {
    FileResponse result = apiInstance.pdfWebapiRemovepagesPost(files, documentPassword, removeRange);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiRemovepagesPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **removeRange** | **String**| The range of pages to remove from the files. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
try {
    FileResponse result = apiInstance.pdfWebapiRepairPost(files, documentPassword);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiRepairPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String outputType = "outputType_example"; // String | The desired format for the output files.
ResizeType resizeType = new ResizeType(); // ResizeType | The type of resizing to apply.
ResizePresetType presetType = new ResizePresetType(); // ResizePresetType | The type of preset size to use for resizing.
ResizePresetSize presetSize = new ResizePresetSize(); // ResizePresetSize | The preset size to use for resizing.
Integer width = 56; // Integer | The desired width of the resized files.
Integer height = 56; // Integer | The desired height of the resized files.
Integer percentage = 56; // Integer | The percentage to resize the files by.
Boolean useProportions = true; // Boolean | Indicates whether to maintain the aspect ratio when resizing.
ResizePageSize pageSize = new ResizePageSize(); // ResizePageSize | The page size to use for the resized files.
try {
    FileResponse result = apiInstance.pdfWebapiResizePost(files, documentPassword, inputType, outputType, resizeType, presetType, presetSize, width, height, percentage, useProportions, pageSize);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiResizePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **outputType** | **String**| The desired format for the output files. | [optional]
 **resizeType** | [**ResizeType**](.md)| The type of resizing to apply. | [optional]
 **presetType** | [**ResizePresetType**](.md)| The type of preset size to use for resizing. | [optional]
 **presetSize** | [**ResizePresetSize**](.md)| The preset size to use for resizing. | [optional]
 **width** | **Integer**| The desired width of the resized files. | [optional]
 **height** | **Integer**| The desired height of the resized files. | [optional]
 **percentage** | **Integer**| The percentage to resize the files by. | [optional]
 **useProportions** | **Boolean**| Indicates whether to maintain the aspect ratio when resizing. | [optional]
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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
RotateAngle angle = new RotateAngle(); // RotateAngle | The angle by which to rotate the files.
RotateType rotateType = new RotateType(); // RotateType | The type of rotation to perform.
String pageNum = "pageNum_example"; // String | The page number to rotate, if applicable.
try {
    FileResponse result = apiInstance.pdfWebapiRotatePost(files, documentPassword, angle, rotateType, pageNum);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiRotatePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **angle** | [**RotateAngle**](.md)| The angle by which to rotate the files. | [optional]
 **rotateType** | [**RotateType**](.md)| The type of rotation to perform. | [optional]
 **pageNum** | **String**| The page number to rotate, if applicable. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String query = "query_example"; // String | The text to search for within the files.
try {
    FileResponse result = apiInstance.pdfWebapiSearchPost(files, documentPassword, query);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiSearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **query** | **String**| The text to search for within the files. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String lang = "lang_example"; // String | The language of the files to be converted.
try {
    FileResponse result = apiInstance.pdfWebapiSearchablePost(files, lang);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiSearchablePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **lang** | **String**| The language of the files to be converted. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String image = "image_example"; // String | 
String text = "text_example"; // String | 
String textColor = "textColor_example"; // String | 
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String outputType = "outputType_example"; // String | The desired format for the output files.
SignatureType signatureType = new SignatureType(); // SignatureType | The type of signature to add.
try {
    FileResponse result = apiInstance.pdfWebapiSignaturePost(image, text, textColor, files, documentPassword, inputType, outputType, signatureType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiSignaturePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **String**|  | [optional]
 **text** | **String**|  | [optional]
 **textColor** | **String**|  | [optional]
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **outputType** | **String**| The desired format for the output files. | [optional]
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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
SplitDocType splitType = new SplitDocType(); // SplitDocType | The type of splitting to be performed.
String pairs = "pairs_example"; // String | Optional page rage for the splitting operation.
try {
    FileResponse result = apiInstance.pdfWebapiSplitdocPost(files, documentPassword, inputType, splitType, pairs);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiSplitdocPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **splitType** | [**SplitDocType**](.md)| The type of splitting to be performed. | [optional]
 **pairs** | **String**| Optional page rage for the splitting operation. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
SplitImageType splitType = new SplitImageType(); // SplitImageType | The type of splitting to be performed.
Integer vertical = 56; // Integer | The number of vertical splits to create.
Integer horizontal = 56; // Integer | The number of horizontal splits to create.
String outputType = "outputType_example"; // String | The desired output format for the split images.
try {
    FileResponse result = apiInstance.pdfWebapiSplitimagePost(files, documentPassword, splitType, vertical, horizontal, outputType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiSplitimagePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **splitType** | [**SplitImageType**](.md)| The type of splitting to be performed. | [optional]
 **vertical** | **Integer**| The number of vertical splits to create. | [optional]
 **horizontal** | **Integer**| The number of horizontal splits to create. | [optional]
 **outputType** | **String**| The desired output format for the split images. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String id = "id_example"; // String | The ID of the processing to check the status of.
try {
    FileResponse result = apiInstance.pdfWebapiStatusIdPost(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiStatusIdPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The ID of the processing to check the status of. |

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
String password = "password_example"; // String | 
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
try {
    FileResponse result = apiInstance.pdfWebapiUnlockPost(password, files);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiUnlockPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **String**|  | [optional]
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
try {
    FileResponse result = apiInstance.pdfWebapiVerifyEsignPost(files, documentPassword, inputType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiVerifyEsignPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
String outputType = "outputType_example"; // String | The desired format for the output files.
Boolean isColored = true; // Boolean | Indicate is watermark will be in color or grayscale.
Boolean isText = true; // Boolean | Indicates whether the watermark is text.
String text = "text_example"; // String | The text of the watermark.
String name = "name_example"; // String | The name of the font for the text watermark.
Integer size = 56; // Integer | The size of the font for the text watermark.
Boolean bold = true; // Boolean | Indicates whether the text watermark is bold.
Boolean italic = true; // Boolean | Indicates whether the text watermark is italic.
Boolean underlined = true; // Boolean | Indicates whether the text watermark is underlined.
String color = "color_example"; // String | The color of the text or image watermark.
Boolean isBackground = true; // Boolean | Indicates whether the watermark is a background watermark.
Integer rotation = 56; // Integer | The rotation angle of the watermark.
Float transparency = 3.4F; // Float | The transparency of the watermark.
Boolean layer = true; // Boolean | Indicates whether the watermark is a layer.
Integer pageFrom = 56; // Integer | The starting page number for the watermark.
Integer pageTo = 56; // Integer | The ending page number for the watermark.
try {
    FileResponse result = apiInstance.pdfWebapiWatermarkPost(files, documentPassword, inputType, outputType, isColored, isText, text, name, size, bold, italic, underlined, color, isBackground, rotation, transparency, layer, pageFrom, pageTo);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiWatermarkPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]
 **outputType** | **String**| The desired format for the output files. | [optional]
 **isColored** | **Boolean**| Indicate is watermark will be in color or grayscale. | [optional]
 **isText** | **Boolean**| Indicates whether the watermark is text. | [optional]
 **text** | **String**| The text of the watermark. | [optional]
 **name** | **String**| The name of the font for the text watermark. | [optional]
 **size** | **Integer**| The size of the font for the text watermark. | [optional]
 **bold** | **Boolean**| Indicates whether the text watermark is bold. | [optional]
 **italic** | **Boolean**| Indicates whether the text watermark is italic. | [optional]
 **underlined** | **Boolean**| Indicates whether the text watermark is underlined. | [optional]
 **color** | **String**| The color of the text or image watermark. | [optional]
 **isBackground** | **Boolean**| Indicates whether the watermark is a background watermark. | [optional]
 **rotation** | **Integer**| The rotation angle of the watermark. | [optional]
 **transparency** | **Float**| The transparency of the watermark. | [optional]
 **layer** | **Boolean**| Indicates whether the watermark is a layer. | [optional]
 **pageFrom** | **Integer**| The starting page number for the watermark. | [optional]
 **pageTo** | **Integer**| The ending page number for the watermark. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String pageRange = "pageRange_example"; // String | The range of pages to count words in.
try {
    FileResponse result = apiInstance.pdfWebapiWordcounterPost(files, documentPassword, pageRange);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiWordcounterPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **pageRange** | **String**| The range of pages to count words in. | [optional]

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
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.ApiApi;


ApiApi apiInstance = new ApiApi();
List<File> files = Arrays.asList(new File("/path/to/file")); // List<File> | 
String documentPassword = "documentPassword_example"; // String | 
String inputType = "inputType_example"; // String | The format of the input files.
try {
    FileResponse result = apiInstance.pdfWebapiXfaconvertPost(files, documentPassword, inputType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiApi#pdfWebapiXfaconvertPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List&lt;File&gt;**](File.md)|  | [optional]
 **documentPassword** | **String**|  | [optional]
 **inputType** | **String**| The format of the input files. | [optional]

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

