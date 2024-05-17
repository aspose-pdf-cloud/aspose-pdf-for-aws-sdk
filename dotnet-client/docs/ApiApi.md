# IO.Swagger.Api.ApiApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PdfWebapiAddnumberPost**](ApiApi.md#pdfwebapiaddnumberpost) | **POST** /pdf/webapi/addnumber | Add page numbers to document.
[**PdfWebapiChangeFontsPost**](ApiApi.md#pdfwebapichangefontspost) | **POST** /pdf/webapi/change-fonts | 
[**PdfWebapiComparisonPost**](ApiApi.md#pdfwebapicomparisonpost) | **POST** /pdf/webapi/comparison | Compare documents text.
[**PdfWebapiCompressPost**](ApiApi.md#pdfwebapicompresspost) | **POST** /pdf/webapi/compress | Compress document.
[**PdfWebapiConvertPost**](ApiApi.md#pdfwebapiconvertpost) | **POST** /pdf/webapi/convert | Convert document to another format.
[**PdfWebapiConvertWebpagePost**](ApiApi.md#pdfwebapiconvertwebpagepost) | **POST** /pdf/webapi/convert-webpage | Convert web page to document.
[**PdfWebapiCropPost**](ApiApi.md#pdfwebapicroppost) | **POST** /pdf/webapi/crop | Crop document.
[**PdfWebapiDownloadIdGet**](ApiApi.md#pdfwebapidownloadidget) | **GET** /pdf/webapi/download/{id} | File download.
[**PdfWebapiEsignPost**](ApiApi.md#pdfwebapiesignpost) | **POST** /pdf/webapi/esign | Sign document with certificate.
[**PdfWebapiExtractPost**](ApiApi.md#pdfwebapiextractpost) | **POST** /pdf/webapi/extract | Extract tables from document.
[**PdfWebapiFormFillerPost**](ApiApi.md#pdfwebapiformfillerpost) | **POST** /pdf/webapi/form-filler | Fill form.
[**PdfWebapiGifPost**](ApiApi.md#pdfwebapigifpost) | **POST** /pdf/webapi/gif | Make GIF.
[**PdfWebapiHashPost**](ApiApi.md#pdfwebapihashpost) | **POST** /pdf/webapi/hash | Calculate document hash.
[**PdfWebapiLockPost**](ApiApi.md#pdfwebapilockpost) | **POST** /pdf/webapi/lock | Lock document.
[**PdfWebapiMergePost**](ApiApi.md#pdfwebapimergepost) | **POST** /pdf/webapi/merge | Merge documents.
[**PdfWebapiMetadataPost**](ApiApi.md#pdfwebapimetadatapost) | **POST** /pdf/webapi/metadata | Read and change document metadata.
[**PdfWebapiOrganizePost**](ApiApi.md#pdfwebapiorganizepost) | **POST** /pdf/webapi/organize | Organize document pages.
[**PdfWebapiParsePost**](ApiApi.md#pdfwebapiparsepost) | **POST** /pdf/webapi/parse | Parse document.
[**PdfWebapiRedactPost**](ApiApi.md#pdfwebapiredactpost) | **POST** /pdf/webapi/redact | Redact document text.
[**PdfWebapiRemoveIdPost**](ApiApi.md#pdfwebapiremoveidpost) | **POST** /pdf/webapi/remove/{id} | Remove stored files.
[**PdfWebapiRemovePost**](ApiApi.md#pdfwebapiremovepost) | **POST** /pdf/webapi/remove | Remove document annotations.
[**PdfWebapiRemoveWatermarkPost**](ApiApi.md#pdfwebapiremovewatermarkpost) | **POST** /pdf/webapi/remove-watermark | Removes document watermark.
[**PdfWebapiRemovepagesPost**](ApiApi.md#pdfwebapiremovepagespost) | **POST** /pdf/webapi/removepages | Remove pages from document.
[**PdfWebapiRepairPost**](ApiApi.md#pdfwebapirepairpost) | **POST** /pdf/webapi/repair | Repair document.
[**PdfWebapiResizePost**](ApiApi.md#pdfwebapiresizepost) | **POST** /pdf/webapi/resize | Resize document.
[**PdfWebapiRotatePost**](ApiApi.md#pdfwebapirotatepost) | **POST** /pdf/webapi/rotate | Rotate document.
[**PdfWebapiSearchPost**](ApiApi.md#pdfwebapisearchpost) | **POST** /pdf/webapi/search | Search document text.
[**PdfWebapiSearchablePost**](ApiApi.md#pdfwebapisearchablepost) | **POST** /pdf/webapi/searchable | Make scanned pdf searchable.
[**PdfWebapiSignaturePost**](ApiApi.md#pdfwebapisignaturepost) | **POST** /pdf/webapi/signature | Add signature to document.
[**PdfWebapiSplitdocPost**](ApiApi.md#pdfwebapisplitdocpost) | **POST** /pdf/webapi/splitdoc | Split document.
[**PdfWebapiSplitimagePost**](ApiApi.md#pdfwebapisplitimagepost) | **POST** /pdf/webapi/splitimage | Split image.
[**PdfWebapiStatusIdPost**](ApiApi.md#pdfwebapistatusidpost) | **POST** /pdf/webapi/status/{id} | Processing status.
[**PdfWebapiUnlockPost**](ApiApi.md#pdfwebapiunlockpost) | **POST** /pdf/webapi/unlock | Unlock document.
[**PdfWebapiVerifyEsignPost**](ApiApi.md#pdfwebapiverifyesignpost) | **POST** /pdf/webapi/verify_esign | Verify document certificate.
[**PdfWebapiWatermarkPost**](ApiApi.md#pdfwebapiwatermarkpost) | **POST** /pdf/webapi/watermark | Add watermark to document.
[**PdfWebapiWordcounterPost**](ApiApi.md#pdfwebapiwordcounterpost) | **POST** /pdf/webapi/wordcounter | Count words and chars in document.
[**PdfWebapiXfaconvertPost**](ApiApi.md#pdfwebapixfaconvertpost) | **POST** /pdf/webapi/xfaconvert | Convert XFA format to a another format.

<a name="pdfwebapiaddnumberpost"></a>
# **PdfWebapiAddnumberPost**
> FileResponse PdfWebapiAddnumberPost (List<FileParameter> files, PageNumberVerticalAlign vAlignment, PageNumberHorizontalAlign hAlignment, int? startingNumber, int? sNumber, int? fNumber, int? margin, int? fontSize, string format)

Add page numbers to document.

Adds page numbers to the provided documents with the specified alignment, starting number, and format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiAddnumberPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var vAlignment = PageNumberVerticalAlign.B; // PageNumberVerticalAlign | The vertical alignment of the page numbers. (optional) 
            var hAlignment = PageNumberHorizontalAlign.C; // PageNumberHorizontalAlign | The horizontal alignment of the page numbers. (optional) 
            var startingNumber = 56;  // int? | The starting number for the page numbers. (optional) 
            var sNumber = 56;  // int? | The number of the first page to start numbering from. (optional) 
            var fNumber = 56;  // int? | The number of the last page to end numbering at. (optional) 
            var margin = 56;  // int? | The margin around the page numbers. (optional) 
            var fontSize = 56;  // int? | The font size of the page numbers. (optional) 
            var format = format_example;  // string | The format of the page numbers. (optional) 

            try
            {
                // Add page numbers to document.
                FileResponse result = apiInstance.PdfWebapiAddnumberPost(files, vAlignment, hAlignment, startingNumber, sNumber, fNumber, margin, fontSize, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiAddnumberPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **vAlignment** | [**PageNumberVerticalAlign**](.md)| The vertical alignment of the page numbers. | [optional] 
 **hAlignment** | [**PageNumberHorizontalAlign**](.md)| The horizontal alignment of the page numbers. | [optional] 
 **startingNumber** | **int?**| The starting number for the page numbers. | [optional] 
 **sNumber** | **int?**| The number of the first page to start numbering from. | [optional] 
 **fNumber** | **int?**| The number of the last page to end numbering at. | [optional] 
 **margin** | **int?**| The margin around the page numbers. | [optional] 
 **fontSize** | **int?**| The font size of the page numbers. | [optional] 
 **format** | **string**| The format of the page numbers. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapichangefontspost"></a>
# **PdfWebapiChangeFontsPost**
> FileResponse PdfWebapiChangeFontsPost (string fontReplacementsJson, List<FileParameter> files)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiChangeFontsPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var fontReplacementsJson = fontReplacementsJson_example;  // string |  (optional) 
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                FileResponse result = apiInstance.PdfWebapiChangeFontsPost(fontReplacementsJson, files);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiChangeFontsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fontReplacementsJson** | **string**|  | [optional] 
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapicomparisonpost"></a>
# **PdfWebapiComparisonPost**
> FileResponse PdfWebapiComparisonPost (List<FileParameter> files)

Compare documents text.

Compare provided files and create document with marked changes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiComparisonPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                // Compare documents text.
                FileResponse result = apiInstance.PdfWebapiComparisonPost(files);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiComparisonPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapicompresspost"></a>
# **PdfWebapiCompressPost**
> FileResponse PdfWebapiCompressPost (List<FileParameter> files, CompressType compressType)

Compress document.

Compresses the provided files using the specified compression level.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiCompressPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var compressType = CompressType.Low; // CompressType | The level of compression to use. (optional) 

            try
            {
                // Compress document.
                FileResponse result = apiInstance.PdfWebapiCompressPost(files, compressType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiCompressPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **compressType** | [**CompressType**](.md)| The level of compression to use. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiconvertpost"></a>
# **PdfWebapiConvertPost**
> FileResponse PdfWebapiConvertPost (List<FileParameter> files, string inputType, string outputType, XmlType xmlType, string xmlTag, int? fontSise, bool? isToSingle, string separator)

Convert document to another format.

Converts the provided files from one format to another.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiConvertPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var xmlType = XmlType.APS; // XmlType | The type of XML conversion to perform, if applicable. (optional) 
            var xmlTag = xmlTag_example;  // string | The XML tag to use for conversion, if applicable. (optional) 
            var fontSise = 56;  // int? |  (optional) 
            var isToSingle = true;  // bool? | Indicates whether the conversion should result in a single file, if applicable. (optional) 
            var separator = separator_example;  // string | The separator to use when converting, if applicable. (optional) 

            try
            {
                // Convert document to another format.
                FileResponse result = apiInstance.PdfWebapiConvertPost(files, inputType, outputType, xmlType, xmlTag, fontSise, isToSingle, separator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiConvertPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **outputType** | **string**| The desired format for the output files. | [optional] 
 **xmlType** | [**XmlType**](.md)| The type of XML conversion to perform, if applicable. | [optional] 
 **xmlTag** | **string**| The XML tag to use for conversion, if applicable. | [optional] 
 **fontSise** | **int?**|  | [optional] 
 **isToSingle** | **bool?**| Indicates whether the conversion should result in a single file, if applicable. | [optional] 
 **separator** | **string**| The separator to use when converting, if applicable. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiconvertwebpagepost"></a>
# **PdfWebapiConvertWebpagePost**
> FileResponse PdfWebapiConvertWebpagePost (string webPage, string outputType)

Convert web page to document.

Converts a web page to the specified output format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiConvertWebpagePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var webPage = webPage_example;  // string |  (optional) 
            var outputType = outputType_example;  // string | The desired format for the output file. (optional) 

            try
            {
                // Convert web page to document.
                FileResponse result = apiInstance.PdfWebapiConvertWebpagePost(webPage, outputType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiConvertWebpagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webPage** | **string**|  | [optional] 
 **outputType** | **string**| The desired format for the output file. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapicroppost"></a>
# **PdfWebapiCropPost**
> FileResponse PdfWebapiCropPost (List<FileParameter> files, string inputType, int? top, int? right, int? bottom, int? left, string outputType)

Crop document.

Crops the provided files to the specified dimensions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiCropPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var top = 56;  // int? | The number of pixels to crop from the top. (optional) 
            var right = 56;  // int? | The number of pixels to crop from the right. (optional) 
            var bottom = 56;  // int? | The number of pixels to crop from the bottom. (optional) 
            var left = 56;  // int? | The number of pixels to crop from the left. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 

            try
            {
                // Crop document.
                FileResponse result = apiInstance.PdfWebapiCropPost(files, inputType, top, right, bottom, left, outputType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiCropPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **top** | **int?**| The number of pixels to crop from the top. | [optional] 
 **right** | **int?**| The number of pixels to crop from the right. | [optional] 
 **bottom** | **int?**| The number of pixels to crop from the bottom. | [optional] 
 **left** | **int?**| The number of pixels to crop from the left. | [optional] 
 **outputType** | **string**| The desired format for the output files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapidownloadidget"></a>
# **PdfWebapiDownloadIdGet**
> void PdfWebapiDownloadIdGet (string id, string file)

File download.

Downloads processed file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiDownloadIdGetExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var id = id_example;  // string | The id of the processing to download.
            var file = file_example;  // string | The name of the file to download. (optional) 

            try
            {
                // File download.
                apiInstance.PdfWebapiDownloadIdGet(id, file);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiDownloadIdGet: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiesignpost"></a>
# **PdfWebapiEsignPost**
> FileResponse PdfWebapiEsignPost (string passw, List<FileParameter> files, string inputType)

Sign document with certificate.

Electronically signs the provided documents with the specified certificate.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiEsignPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var passw = passw_example;  // string |  (optional) 
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 

            try
            {
                // Sign document with certificate.
                FileResponse result = apiInstance.PdfWebapiEsignPost(passw, files, inputType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiEsignPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passw** | **string**|  | [optional] 
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiextractpost"></a>
# **PdfWebapiExtractPost**
> FileResponse PdfWebapiExtractPost (List<FileParameter> files, string inputType, string outputType)

Extract tables from document.

Extracts tables from the provided documents and converts them to the specified output format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiExtractPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 

            try
            {
                // Extract tables from document.
                FileResponse result = apiInstance.PdfWebapiExtractPost(files, inputType, outputType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiExtractPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **outputType** | **string**| The desired format for the output files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiformfillerpost"></a>
# **PdfWebapiFormFillerPost**
> FileResponse PdfWebapiFormFillerPost (List<FileParameter> files, string fileName)

Fill form.

Fills a form with the provided files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiFormFillerPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var fileName = fileName_example;  // string | The name of the file to fill the form with. (optional) 

            try
            {
                // Fill form.
                FileResponse result = apiInstance.PdfWebapiFormFillerPost(files, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiFormFillerPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **fileName** | **string**| The name of the file to fill the form with. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapigifpost"></a>
# **PdfWebapiGifPost**
> FileResponse PdfWebapiGifPost (List<FileParameter> files, bool? keepImagesAsIs, int? resizeToImage, bool? streched, int? width, int? height, string frameTimes)

Make GIF.

Creates a GIF from the provided images.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiGifPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var keepImagesAsIs = true;  // bool? | Indicates whether the images should be kept as is. (optional) 
            var resizeToImage = 56;  // int? | The index of the image to resize the other images to. (optional) 
            var streched = true;  // bool? |  (optional) 
            var width = 56;  // int? | The width of the GIF. (optional) 
            var height = 56;  // int? | The height of the GIF. (optional) 
            var frameTimes = frameTimes_example;  // string | The times for each frame in the GIF. (optional) 

            try
            {
                // Make GIF.
                FileResponse result = apiInstance.PdfWebapiGifPost(files, keepImagesAsIs, resizeToImage, streched, width, height, frameTimes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiGifPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **keepImagesAsIs** | **bool?**| Indicates whether the images should be kept as is. | [optional] 
 **resizeToImage** | **int?**| The index of the image to resize the other images to. | [optional] 
 **streched** | **bool?**|  | [optional] 
 **width** | **int?**| The width of the GIF. | [optional] 
 **height** | **int?**| The height of the GIF. | [optional] 
 **frameTimes** | **string**| The times for each frame in the GIF. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapihashpost"></a>
# **PdfWebapiHashPost**
> FileResponse PdfWebapiHashPost (List<FileParameter> files, string inputType, string outputType, HashAlgorithm alg)

Calculate document hash.

Calculate hashes of provided files using the specified algorithm.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiHashPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var alg = HashAlgorithm.SHA1; // HashAlgorithm | The hashing algorithm to use. (optional) 

            try
            {
                // Calculate document hash.
                FileResponse result = apiInstance.PdfWebapiHashPost(files, inputType, outputType, alg);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiHashPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **outputType** | **string**| The desired format for the output files. | [optional] 
 **alg** | [**HashAlgorithm**](.md)| The hashing algorithm to use. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapilockpost"></a>
# **PdfWebapiLockPost**
> FileResponse PdfWebapiLockPost (List<FileParameter> files, string passw)

Lock document.

Locks a document with the provided password and optional files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiLockPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var passw = passw_example;  // string | The password required to lock the resource. (optional) 

            try
            {
                // Lock document.
                FileResponse result = apiInstance.PdfWebapiLockPost(files, passw);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiLockPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **passw** | **string**| The password required to lock the resource. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapimergepost"></a>
# **PdfWebapiMergePost**
> FileResponse PdfWebapiMergePost (List<FileParameter> files, string inputType, string outputType, MergeImageType mergeType, int? horizontal, int? vertical, PageSize pageSize, bool? dcIsLandscape)

Merge documents.

Merges the provided files into a single document or image, with options for orientation and page size.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiMergePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output file. (optional) 
            var mergeType = MergeImageType.Vertical; // MergeImageType | Type of merger operation. (optional) 
            var horizontal = 56;  // int? | The number of images to merge horizontally, if applicable. (optional) 
            var vertical = 56;  // int? | The number of images to merge vertically, if applicable. (optional) 
            var pageSize = PageSize.A4; // PageSize | The page size for the output file, if applicable. (optional) 
            var dcIsLandscape = true;  // bool? | Indicates whether the output file should be in landscape orientation. (optional) 

            try
            {
                // Merge documents.
                FileResponse result = apiInstance.PdfWebapiMergePost(files, inputType, outputType, mergeType, horizontal, vertical, pageSize, dcIsLandscape);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiMergePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **outputType** | **string**| The desired format for the output file. | [optional] 
 **mergeType** | [**MergeImageType**](.md)| Type of merger operation. | [optional] 
 **horizontal** | **int?**| The number of images to merge horizontally, if applicable. | [optional] 
 **vertical** | **int?**| The number of images to merge vertically, if applicable. | [optional] 
 **pageSize** | [**PageSize**](.md)| The page size for the output file, if applicable. | [optional] 
 **dcIsLandscape** | **bool?**| Indicates whether the output file should be in landscape orientation. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapimetadatapost"></a>
# **PdfWebapiMetadataPost**
> FileResponse PdfWebapiMetadataPost (List<FileParameter> files, MetadataOperation operation, string folder, string name)

Read and change document metadata.

Performs metadata operations on the provided files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiMetadataPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var operation = MetadataOperation.Get; // MetadataOperation | The operation to perform on the metadata. (optional) 
            var folder = folder_example;  // string | The folder where the files are located. (optional) 
            var name = name_example;  // string | The name of the file to perform the operation on. (optional) 

            try
            {
                // Read and change document metadata.
                FileResponse result = apiInstance.PdfWebapiMetadataPost(files, operation, folder, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiMetadataPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **operation** | [**MetadataOperation**](.md)| The operation to perform on the metadata. | [optional] 
 **folder** | **string**| The folder where the files are located. | [optional] 
 **name** | **string**| The name of the file to perform the operation on. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiorganizepost"></a>
# **PdfWebapiOrganizePost**
> FileResponse PdfWebapiOrganizePost (List<FileParameter> files, string inputType, string remove, string move)

Organize document pages.

Organizes the provided documents by removing or moving specified pages.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiOrganizePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var remove = remove_example;  // string | The pages to remove from the document. (optional) 
            var move = move_example;  // string | The pages to move within the document. (optional) 

            try
            {
                // Organize document pages.
                FileResponse result = apiInstance.PdfWebapiOrganizePost(files, inputType, remove, move);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiOrganizePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **remove** | **string**| The pages to remove from the document. | [optional] 
 **move** | **string**| The pages to move within the document. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiparsepost"></a>
# **PdfWebapiParsePost**
> FileResponse PdfWebapiParsePost (List<FileParameter> files)

Parse document.

Parses the provided files using a parser service.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiParsePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                // Parse document.
                FileResponse result = apiInstance.PdfWebapiParsePost(files);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiParsePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiredactpost"></a>
# **PdfWebapiRedactPost**
> FileResponse PdfWebapiRedactPost (List<FileParameter> files, string searchQuery, string replaceText, bool? caseSensitive, bool? text, bool? comments, bool? metadata)

Redact document text.

Redacts specified text from the provided documents, with options to search case-sensitively, target in text, comments, and metadata.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiRedactPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var searchQuery = searchQuery_example;  // string | The text to search for and redact. (optional) 
            var replaceText = replaceText_example;  // string | The text to replace the found text with. (optional) 
            var caseSensitive = true;  // bool? | Indicates whether the search should be case-sensitive. (optional) 
            var text = true;  // bool? | Indicates whether text should be redacted. (optional) 
            var comments = true;  // bool? | Indicates whether comments should be redacted. (optional) 
            var metadata = true;  // bool? | Indicates whether metadata should be redacted. (optional) 

            try
            {
                // Redact document text.
                FileResponse result = apiInstance.PdfWebapiRedactPost(files, searchQuery, replaceText, caseSensitive, text, comments, metadata);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiRedactPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **searchQuery** | **string**| The text to search for and redact. | [optional] 
 **replaceText** | **string**| The text to replace the found text with. | [optional] 
 **caseSensitive** | **bool?**| Indicates whether the search should be case-sensitive. | [optional] 
 **text** | **bool?**| Indicates whether text should be redacted. | [optional] 
 **comments** | **bool?**| Indicates whether comments should be redacted. | [optional] 
 **metadata** | **bool?**| Indicates whether metadata should be redacted. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiremoveidpost"></a>
# **PdfWebapiRemoveIdPost**
> FileResponse PdfWebapiRemoveIdPost (string id)

Remove stored files.

Removes processed files from storage.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiRemoveIdPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var id = id_example;  // string | The ID of the processing to remove.

            try
            {
                // Remove stored files.
                FileResponse result = apiInstance.PdfWebapiRemoveIdPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiRemoveIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the processing to remove. | 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiremovepost"></a>
# **PdfWebapiRemovePost**
> FileResponse PdfWebapiRemovePost (List<FileParameter> files)

Remove document annotations.

Removes annotations from the provided documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiRemovePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                // Remove document annotations.
                FileResponse result = apiInstance.PdfWebapiRemovePost(files);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiRemovePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiremovewatermarkpost"></a>
# **PdfWebapiRemoveWatermarkPost**
> FileResponse PdfWebapiRemoveWatermarkPost (string watermarkText, int? top, int? left, int? bottom, int? right, List<FileParameter> files, bool? isAllPages, WatermarkType watermarkType, string removeRange)

Removes document watermark.

Removes a watermark from the document pages.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiRemoveWatermarkPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var watermarkText = watermarkText_example;  // string |  (optional) 
            var top = 56;  // int? |  (optional) 
            var left = 56;  // int? |  (optional) 
            var bottom = 56;  // int? |  (optional) 
            var right = 56;  // int? |  (optional) 
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var isAllPages = true;  // bool? | Indicates whether the watermark should be removed from all pages. (optional) 
            var watermarkType = WatermarkType.Artifact; // WatermarkType | The type of watermark to remove. (optional) 
            var removeRange = removeRange_example;  // string | The range of pages to remove the watermark from. (optional) 

            try
            {
                // Removes document watermark.
                FileResponse result = apiInstance.PdfWebapiRemoveWatermarkPost(watermarkText, top, left, bottom, right, files, isAllPages, watermarkType, removeRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiRemoveWatermarkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **watermarkText** | **string**|  | [optional] 
 **top** | **int?**|  | [optional] 
 **left** | **int?**|  | [optional] 
 **bottom** | **int?**|  | [optional] 
 **right** | **int?**|  | [optional] 
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **isAllPages** | **bool?**| Indicates whether the watermark should be removed from all pages. | [optional] 
 **watermarkType** | [**WatermarkType**](.md)| The type of watermark to remove. | [optional] 
 **removeRange** | **string**| The range of pages to remove the watermark from. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiremovepagespost"></a>
# **PdfWebapiRemovepagesPost**
> FileResponse PdfWebapiRemovepagesPost (List<FileParameter> files, string removeRange)

Remove pages from document.

Removes specified pages from the provided files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiRemovepagesPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var removeRange = removeRange_example;  // string | The range of pages to remove from the files. (optional) 

            try
            {
                // Remove pages from document.
                FileResponse result = apiInstance.PdfWebapiRemovepagesPost(files, removeRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiRemovepagesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **removeRange** | **string**| The range of pages to remove from the files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapirepairpost"></a>
# **PdfWebapiRepairPost**
> FileResponse PdfWebapiRepairPost (List<FileParameter> files)

Repair document.

Repairs the provided files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiRepairPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 

            try
            {
                // Repair document.
                FileResponse result = apiInstance.PdfWebapiRepairPost(files);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiRepairPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiresizepost"></a>
# **PdfWebapiResizePost**
> FileResponse PdfWebapiResizePost (List<FileParameter> files, string inputType, string outputType, ResizeType resizeType, ResizePresetType presetType, ResizePresetSize presetSize, int? width, int? height, int? percentage, bool? useProportions, ResizePageSize pageSize)

Resize document.

Resizes the provided files to the specified dimensions or using a preset size.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiResizePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var resizeType = ResizeType.Percentage; // ResizeType | The type of resizing to apply. (optional) 
            var presetType = ResizePresetType.Facebook; // ResizePresetType | The type of preset size to use for resizing. (optional) 
            var presetSize = ResizePresetSize.Facebook_Post; // ResizePresetSize | The preset size to use for resizing. (optional) 
            var width = 56;  // int? | The desired width of the resized files. (optional) 
            var height = 56;  // int? | The desired height of the resized files. (optional) 
            var percentage = 56;  // int? | The percentage to resize the files by. (optional) 
            var useProportions = true;  // bool? | Indicates whether to maintain the aspect ratio when resizing. (optional) 
            var pageSize = ResizePageSize.A4; // ResizePageSize | The page size to use for the resized files. (optional) 

            try
            {
                // Resize document.
                FileResponse result = apiInstance.PdfWebapiResizePost(files, inputType, outputType, resizeType, presetType, presetSize, width, height, percentage, useProportions, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiResizePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **outputType** | **string**| The desired format for the output files. | [optional] 
 **resizeType** | [**ResizeType**](.md)| The type of resizing to apply. | [optional] 
 **presetType** | [**ResizePresetType**](.md)| The type of preset size to use for resizing. | [optional] 
 **presetSize** | [**ResizePresetSize**](.md)| The preset size to use for resizing. | [optional] 
 **width** | **int?**| The desired width of the resized files. | [optional] 
 **height** | **int?**| The desired height of the resized files. | [optional] 
 **percentage** | **int?**| The percentage to resize the files by. | [optional] 
 **useProportions** | **bool?**| Indicates whether to maintain the aspect ratio when resizing. | [optional] 
 **pageSize** | [**ResizePageSize**](.md)| The page size to use for the resized files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapirotatepost"></a>
# **PdfWebapiRotatePost**
> FileResponse PdfWebapiRotatePost (List<FileParameter> files, RotateAngle angle, RotateType rotateType, string pageNum)

Rotate document.

Rotates the provided files by a specified angle, with options for rotation type and page number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiRotatePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var angle = RotateAngle.On90; // RotateAngle | The angle by which to rotate the files. (optional) 
            var rotateType = RotateType.S; // RotateType | The type of rotation to perform. (optional) 
            var pageNum = pageNum_example;  // string | The page number to rotate, if applicable. (optional) 

            try
            {
                // Rotate document.
                FileResponse result = apiInstance.PdfWebapiRotatePost(files, angle, rotateType, pageNum);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiRotatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **angle** | [**RotateAngle**](.md)| The angle by which to rotate the files. | [optional] 
 **rotateType** | [**RotateType**](.md)| The type of rotation to perform. | [optional] 
 **pageNum** | **string**| The page number to rotate, if applicable. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapisearchpost"></a>
# **PdfWebapiSearchPost**
> FileResponse PdfWebapiSearchPost (List<FileParameter> files, string query)

Search document text.

Searches the provided files for the specified query and makr found text with yellow background.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiSearchPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var query = query_example;  // string | The text to search for within the files. (optional) 

            try
            {
                // Search document text.
                FileResponse result = apiInstance.PdfWebapiSearchPost(files, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **query** | **string**| The text to search for within the files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapisearchablepost"></a>
# **PdfWebapiSearchablePost**
> FileResponse PdfWebapiSearchablePost (List<FileParameter> files, string lang)

Make scanned pdf searchable.

Converts the provided files into a searchable PDF format for the specified language.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiSearchablePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var lang = lang_example;  // string | The language of the files to be converted. (optional) 

            try
            {
                // Make scanned pdf searchable.
                FileResponse result = apiInstance.PdfWebapiSearchablePost(files, lang);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiSearchablePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **lang** | **string**| The language of the files to be converted. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapisignaturepost"></a>
# **PdfWebapiSignaturePost**
> FileResponse PdfWebapiSignaturePost (string image, string text, string textColor, List<FileParameter> files, string inputType, string outputType, SignatureType signatureType)

Add signature to document.

Adds a signature, text and image to the provided documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiSignaturePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var image = image_example;  // string |  (optional) 
            var text = text_example;  // string |  (optional) 
            var textColor = textColor_example;  // string |  (optional) 
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var signatureType = SignatureType.Image; // SignatureType | The type of signature to add. (optional) 

            try
            {
                // Add signature to document.
                FileResponse result = apiInstance.PdfWebapiSignaturePost(image, text, textColor, files, inputType, outputType, signatureType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiSignaturePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **image** | **string**|  | [optional] 
 **text** | **string**|  | [optional] 
 **textColor** | **string**|  | [optional] 
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **outputType** | **string**| The desired format for the output files. | [optional] 
 **signatureType** | [**SignatureType**](.md)| The type of signature to add. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapisplitdocpost"></a>
# **PdfWebapiSplitdocPost**
> FileResponse PdfWebapiSplitdocPost (List<FileParameter> files, SplitDocType splitType, string pars)

Split document.

Splits the provided documents based on the specified split type and page rage to spit.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiSplitdocPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var splitType = SplitDocType.AllPages; // SplitDocType | The type of splitting to be performed. (optional) 
            var pars = pars_example;  // string | Optional page rage for the splitting operation. (optional) 

            try
            {
                // Split document.
                FileResponse result = apiInstance.PdfWebapiSplitdocPost(files, splitType, pars);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiSplitdocPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **splitType** | [**SplitDocType**](.md)| The type of splitting to be performed. | [optional] 
 **pars** | **string**| Optional page rage for the splitting operation. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapisplitimagepost"></a>
# **PdfWebapiSplitimagePost**
> FileResponse PdfWebapiSplitimagePost (List<FileParameter> files, SplitImageType splitType, int? vertical, int? horizontal, string outputType)

Split image.

Splits the provided images into smaller parts based on the specified parameters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiSplitimagePostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var splitType = SplitImageType.Vertical; // SplitImageType | The type of splitting to be performed. (optional) 
            var vertical = 56;  // int? | The number of vertical splits to create. (optional) 
            var horizontal = 56;  // int? | The number of horizontal splits to create. (optional) 
            var outputType = outputType_example;  // string | The desired output format for the split images. (optional) 

            try
            {
                // Split image.
                FileResponse result = apiInstance.PdfWebapiSplitimagePost(files, splitType, vertical, horizontal, outputType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiSplitimagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **splitType** | [**SplitImageType**](.md)| The type of splitting to be performed. | [optional] 
 **vertical** | **int?**| The number of vertical splits to create. | [optional] 
 **horizontal** | **int?**| The number of horizontal splits to create. | [optional] 
 **outputType** | **string**| The desired output format for the split images. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapistatusidpost"></a>
# **PdfWebapiStatusIdPost**
> FileResponse PdfWebapiStatusIdPost (string id)

Processing status.

Retrieves the status of a processing.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiStatusIdPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var id = id_example;  // string | The ID of the processing to check the status of.

            try
            {
                // Processing status.
                FileResponse result = apiInstance.PdfWebapiStatusIdPost(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiStatusIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The ID of the processing to check the status of. | 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiunlockpost"></a>
# **PdfWebapiUnlockPost**
> FileResponse PdfWebapiUnlockPost (List<FileParameter> files, string passw)

Unlock document.

Attempts to unlock a document with an password and associated files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiUnlockPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var passw = passw_example;  // string | The password used in locked document. (optional) 

            try
            {
                // Unlock document.
                FileResponse result = apiInstance.PdfWebapiUnlockPost(files, passw);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiUnlockPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **passw** | **string**| The password used in locked document. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiverifyesignpost"></a>
# **PdfWebapiVerifyEsignPost**
> FileResponse PdfWebapiVerifyEsignPost (List<FileParameter> files, string inputType)

Verify document certificate.

Verifies the electronic signature of the provided files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiVerifyEsignPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 

            try
            {
                // Verify document certificate.
                FileResponse result = apiInstance.PdfWebapiVerifyEsignPost(files, inputType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiVerifyEsignPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiwatermarkpost"></a>
# **PdfWebapiWatermarkPost**
> FileResponse PdfWebapiWatermarkPost (List<FileParameter> files, string inputType, string outputType, bool? isColored, bool? isText, string text, string name, int? size, bool? bold, bool? italic, bool? underlined, string color, bool? isBackground, int? rotation, float? transparency, bool? layer, int? pageFrom, int? pageTo)

Add watermark to document.

Adds a watermark to the provided files.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiWatermarkPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var isColored = true;  // bool? | Indicate is watermark will be in color or grayscale. (optional) 
            var isText = true;  // bool? | Indicates whether the watermark is text. (optional) 
            var text = text_example;  // string | The text of the watermark. (optional) 
            var name = name_example;  // string | The name of the font for the text watermark. (optional) 
            var size = 56;  // int? | The size of the font for the text watermark. (optional) 
            var bold = true;  // bool? | Indicates whether the text watermark is bold. (optional) 
            var italic = true;  // bool? | Indicates whether the text watermark is italic. (optional) 
            var underlined = true;  // bool? | Indicates whether the text watermark is underlined. (optional) 
            var color = color_example;  // string | The color of the text or image watermark. (optional) 
            var isBackground = true;  // bool? | Indicates whether the watermark is a background watermark. (optional) 
            var rotation = 56;  // int? | The rotation angle of the watermark. (optional) 
            var transparency = 3.4;  // float? | The transparency of the watermark. (optional) 
            var layer = true;  // bool? | Indicates whether the watermark is a layer. (optional) 
            var pageFrom = 56;  // int? | The starting page number for the watermark. (optional) 
            var pageTo = 56;  // int? | The ending page number for the watermark. (optional) 

            try
            {
                // Add watermark to document.
                FileResponse result = apiInstance.PdfWebapiWatermarkPost(files, inputType, outputType, isColored, isText, text, name, size, bold, italic, underlined, color, isBackground, rotation, transparency, layer, pageFrom, pageTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiWatermarkPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **outputType** | **string**| The desired format for the output files. | [optional] 
 **isColored** | **bool?**| Indicate is watermark will be in color or grayscale. | [optional] 
 **isText** | **bool?**| Indicates whether the watermark is text. | [optional] 
 **text** | **string**| The text of the watermark. | [optional] 
 **name** | **string**| The name of the font for the text watermark. | [optional] 
 **size** | **int?**| The size of the font for the text watermark. | [optional] 
 **bold** | **bool?**| Indicates whether the text watermark is bold. | [optional] 
 **italic** | **bool?**| Indicates whether the text watermark is italic. | [optional] 
 **underlined** | **bool?**| Indicates whether the text watermark is underlined. | [optional] 
 **color** | **string**| The color of the text or image watermark. | [optional] 
 **isBackground** | **bool?**| Indicates whether the watermark is a background watermark. | [optional] 
 **rotation** | **int?**| The rotation angle of the watermark. | [optional] 
 **transparency** | **float?**| The transparency of the watermark. | [optional] 
 **layer** | **bool?**| Indicates whether the watermark is a layer. | [optional] 
 **pageFrom** | **int?**| The starting page number for the watermark. | [optional] 
 **pageTo** | **int?**| The ending page number for the watermark. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapiwordcounterpost"></a>
# **PdfWebapiWordcounterPost**
> FileResponse PdfWebapiWordcounterPost (List<FileParameter> files, string pageRange)

Count words and chars in document.

Counts the words in the provided files within the specified page range.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiWordcounterPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var pageRange = pageRange_example;  // string | The range of pages to count words in. (optional) 

            try
            {
                // Count words and chars in document.
                FileResponse result = apiInstance.PdfWebapiWordcounterPost(files, pageRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiWordcounterPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **pageRange** | **string**| The range of pages to count words in. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pdfwebapixfaconvertpost"></a>
# **PdfWebapiXfaconvertPost**
> FileResponse PdfWebapiXfaconvertPost (List<FileParameter> files, string inputType)

Convert XFA format to a another format.

Converts the provided documents from XFA format to a different format.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PdfWebapiXfaconvertPostExample
    {
        public void main()
        {

            var apiInstance = new ApiApi();
            var files = new List<FileParameter>(); // List<FileParameter> |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 

            try
            {
                // Convert XFA format to a another format.
                FileResponse result = apiInstance.PdfWebapiXfaconvertPost(files, inputType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiApi.PdfWebapiXfaconvertPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **files** | [**List<FileParameter>**](byte[].md)|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

