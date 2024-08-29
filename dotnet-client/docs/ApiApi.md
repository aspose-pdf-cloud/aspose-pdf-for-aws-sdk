# IO.Swagger.Api.ApiApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PdfWebapiAddnumberPost**](ApiApi.md#pdfwebapiaddnumberpost) | **POST** /pdf/webapi/addnumber | Add Page Numbers to Document.
[**PdfWebapiChangeFontsPost**](ApiApi.md#pdfwebapichangefontspost) | **POST** /pdf/webapi/change-fonts | Change Fonts in Provided Files.
[**PdfWebapiComparisonPost**](ApiApi.md#pdfwebapicomparisonpost) | **POST** /pdf/webapi/comparison | Compare documents text.
[**PdfWebapiCompressPost**](ApiApi.md#pdfwebapicompresspost) | **POST** /pdf/webapi/compress | Compress Document.
[**PdfWebapiConvertPost**](ApiApi.md#pdfwebapiconvertpost) | **POST** /pdf/webapi/convert | Convert Document to Another Format.
[**PdfWebapiConvertWebpagePost**](ApiApi.md#pdfwebapiconvertwebpagepost) | **POST** /pdf/webapi/convert-webpage | Convert Web Page to Document.
[**PdfWebapiCropPost**](ApiApi.md#pdfwebapicroppost) | **POST** /pdf/webapi/crop | Crop Document.
[**PdfWebapiDownloadIdGet**](ApiApi.md#pdfwebapidownloadidget) | **GET** /pdf/webapi/download/{id} | File download.
[**PdfWebapiEsignPost**](ApiApi.md#pdfwebapiesignpost) | **POST** /pdf/webapi/esign | Sign Document with Certificate.
[**PdfWebapiExtractPost**](ApiApi.md#pdfwebapiextractpost) | **POST** /pdf/webapi/extract | Extract Tables from Document.
[**PdfWebapiGifPost**](ApiApi.md#pdfwebapigifpost) | **POST** /pdf/webapi/gif | Make GIF.
[**PdfWebapiHashPost**](ApiApi.md#pdfwebapihashpost) | **POST** /pdf/webapi/hash | Calculate Document Hash.
[**PdfWebapiLockPost**](ApiApi.md#pdfwebapilockpost) | **POST** /pdf/webapi/lock | Lock document.
[**PdfWebapiMergePost**](ApiApi.md#pdfwebapimergepost) | **POST** /pdf/webapi/merge | Merge Documents.
[**PdfWebapiMetadataPost**](ApiApi.md#pdfwebapimetadatapost) | **POST** /pdf/webapi/metadata | Read and Change Document Metadata.
[**PdfWebapiOrganizePost**](ApiApi.md#pdfwebapiorganizepost) | **POST** /pdf/webapi/organize | Organize Document Pages.
[**PdfWebapiParsePost**](ApiApi.md#pdfwebapiparsepost) | **POST** /pdf/webapi/parse | Parse Document.
[**PdfWebapiRedactPost**](ApiApi.md#pdfwebapiredactpost) | **POST** /pdf/webapi/redact | Redact Document Text.
[**PdfWebapiRemoveIdPost**](ApiApi.md#pdfwebapiremoveidpost) | **POST** /pdf/webapi/remove/{id} | Remove stored files.
[**PdfWebapiRemovePost**](ApiApi.md#pdfwebapiremovepost) | **POST** /pdf/webapi/remove | Remove Document Annotations.
[**PdfWebapiRemoveWatermarkPost**](ApiApi.md#pdfwebapiremovewatermarkpost) | **POST** /pdf/webapi/remove-watermark | Remove Document Watermark.
[**PdfWebapiRemovepagesPost**](ApiApi.md#pdfwebapiremovepagespost) | **POST** /pdf/webapi/removepages | Remove Pages from Document.
[**PdfWebapiRepairPost**](ApiApi.md#pdfwebapirepairpost) | **POST** /pdf/webapi/repair | Repair Document.
[**PdfWebapiResizePost**](ApiApi.md#pdfwebapiresizepost) | **POST** /pdf/webapi/resize | Resize Document.
[**PdfWebapiRotatePost**](ApiApi.md#pdfwebapirotatepost) | **POST** /pdf/webapi/rotate | Rotate Document.
[**PdfWebapiSearchPost**](ApiApi.md#pdfwebapisearchpost) | **POST** /pdf/webapi/search | Search Document Text.
[**PdfWebapiSearchablePost**](ApiApi.md#pdfwebapisearchablepost) | **POST** /pdf/webapi/searchable | Make Scanned PDF Searchable.
[**PdfWebapiSignaturePost**](ApiApi.md#pdfwebapisignaturepost) | **POST** /pdf/webapi/signature | Add Signature to Document.
[**PdfWebapiSplitdocPost**](ApiApi.md#pdfwebapisplitdocpost) | **POST** /pdf/webapi/splitdoc | Split Document.
[**PdfWebapiSplitimagePost**](ApiApi.md#pdfwebapisplitimagepost) | **POST** /pdf/webapi/splitimage | Split Image.
[**PdfWebapiStatusIdPost**](ApiApi.md#pdfwebapistatusidpost) | **POST** /pdf/webapi/status/{id} | Processing status.
[**PdfWebapiUnlockPost**](ApiApi.md#pdfwebapiunlockpost) | **POST** /pdf/webapi/unlock | Unlock Document.
[**PdfWebapiVerifyEsignPost**](ApiApi.md#pdfwebapiverifyesignpost) | **POST** /pdf/webapi/verify_esign | Verify Document Certificate.
[**PdfWebapiWatermarkPost**](ApiApi.md#pdfwebapiwatermarkpost) | **POST** /pdf/webapi/watermark | Add Watermark to Document.
[**PdfWebapiWordcounterPost**](ApiApi.md#pdfwebapiwordcounterpost) | **POST** /pdf/webapi/wordcounter | Count Words and Characters in Document.
[**PdfWebapiXfaconvertPost**](ApiApi.md#pdfwebapixfaconvertpost) | **POST** /pdf/webapi/xfaconvert | Convert XFA Format to Another Format.

<a name="pdfwebapiaddnumberpost"></a>
# **PdfWebapiAddnumberPost**
> FileResponse PdfWebapiAddnumberPost (List<byte[]> files, string documentPassword, PageNumberVerticalAlign vAlignment, PageNumberHorizontalAlign hAlignment, int? startingNumber, int? sNumber, int? fNumber, int? margin, int? fontSize, string format)

Add Page Numbers to Document.

Adds page numbers to your documents based on specified alignment, starting number, and format. The service ensures that page numbers are accurately applied, improving the readability and professionalism of your documents. It supports various formats, including DOC, PPTX, TIFF, DOCX, and PDF, to cater to your specific requirements.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var vAlignment = new PageNumberVerticalAlign(); // PageNumberVerticalAlign | The vertical alignment of the page numbers. (optional) 
            var hAlignment = new PageNumberHorizontalAlign(); // PageNumberHorizontalAlign | The horizontal alignment of the page numbers. (optional) 
            var startingNumber = 56;  // int? | The starting number for the page numbers. (optional) 
            var sNumber = 56;  // int? | The number of the first page to start numbering from. (optional) 
            var fNumber = 56;  // int? | The number of the last page to end numbering at. (optional) 
            var margin = 56;  // int? | The margin around the page numbers. (optional) 
            var fontSize = 56;  // int? | The font size of the page numbers. (optional) 
            var format = format_example;  // string | The format of the page numbers. (optional) 

            try
            {
                // Add Page Numbers to Document.
                FileResponse result = apiInstance.PdfWebapiAddnumberPost(files, documentPassword, vAlignment, hAlignment, startingNumber, sNumber, fNumber, margin, fontSize, format);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiChangeFontsPost (string fontReplacementsJson, List<byte[]> files, string documentPassword)

Change Fonts in Provided Files.

Updates the fonts in your documents according to specified replacements.  Provide the font replacement details as a JSON string and upload your files using multipart/form-data.The service processes these requests asynchronously using Kafka, ensuring efficient handling of your files.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 

            try
            {
                // Change Fonts in Provided Files.
                FileResponse result = apiInstance.PdfWebapiChangeFontsPost(fontReplacementsJson, files, documentPassword);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 

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
> FileResponse PdfWebapiComparisonPost (List<byte[]> files, string documentPassword)

Compare documents text.

Compares the text of the provided documents and highlights the differences. Upload the files you want to compare, and the service will analyze them to detect any changes in the text. The result is a new document that clearly marks all text variations, making it easy to review and understand the modifications between the original and updated versions.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 

            try
            {
                // Compare documents text.
                FileResponse result = apiInstance.PdfWebapiComparisonPost(files, documentPassword);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 

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
> FileResponse PdfWebapiCompressPost (List<byte[]> files, string documentPassword, CompressType compressType)

Compress Document.

Compresses the provided documents to reduce their file size based on the specified compression level. Upload the documents and choose the desired compression level. The service will reduce the file sizes while maintaining quality, resulting in compressed files that are easier to handle and share, saving storage space and reducing upload and download times.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var compressType = new CompressType(); // CompressType | The level of compression to use. (optional) 

            try
            {
                // Compress Document.
                FileResponse result = apiInstance.PdfWebapiCompressPost(files, documentPassword, compressType);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiConvertPost (List<byte[]> files, string documentPassword, string inputType, string outputType, XmlType xmlType, string xmlTag, int? fontSise, bool? isToSingle, string separator)

Convert Document to Another Format.

Converts documents from one format to another seamlessly. Upload the files you need to convert and specify the target format. The service will handle the conversion process efficiently, ensuring that the resulting document is ready for use in the desired format and compatible with various applications and systems.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var xmlType = new XmlType(); // XmlType | The type of XML conversion to perform, if applicable. (optional) 
            var xmlTag = xmlTag_example;  // string | The XML tag to use for conversion, if applicable. (optional) 
            var fontSise = 56;  // int? |  (optional) 
            var isToSingle = true;  // bool? | Indicates whether the conversion should result in a single file, if applicable. (optional) 
            var separator = separator_example;  // string | The separator to use when converting, if applicable. (optional) 

            try
            {
                // Convert Document to Another Format.
                FileResponse result = apiInstance.PdfWebapiConvertPost(files, documentPassword, inputType, outputType, xmlType, xmlTag, fontSise, isToSingle, separator);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiConvertWebpagePost (string webPage, string documentPassword, string outputType)

Convert Web Page to Document.

Converts a web page to a document in the specified output format. Provide the URL of the web page and choose the desired format for conversion. The service will create a document that mirrors the content and layout of the original web page, ensuring it is well-formatted and suitable for your needs.

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
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var outputType = outputType_example;  // string | The desired format for the output file. (optional) 

            try
            {
                // Convert Web Page to Document.
                FileResponse result = apiInstance.PdfWebapiConvertWebpagePost(webPage, documentPassword, outputType);
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
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiCropPost (List<byte[]> files, string documentPassword, string inputType, int? top, int? right, int? bottom, int? left, string outputType)

Crop Document.

Crops the provided document to the specified dimensions by removing unwanted areas. Upload the document and specify the dimensions for cropping. The service will adjust the file accordingly, resulting in a precisely cropped document that meets your requirements.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var top = 56;  // int? | The number of pixels to crop from the top. (optional) 
            var right = 56;  // int? | The number of pixels to crop from the right. (optional) 
            var bottom = 56;  // int? | The number of pixels to crop from the bottom. (optional) 
            var left = 56;  // int? | The number of pixels to crop from the left. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 

            try
            {
                // Crop Document.
                FileResponse result = apiInstance.PdfWebapiCropPost(files, documentPassword, inputType, top, right, bottom, left, outputType);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiEsignPost (string passw, string initials, string invite, List<byte[]> files, string documentPassword, string inputType)

Sign Document with Certificate.

Applies a digital signature to the provided document using the specified certificate. Upload the document and provide the certificate details, and the service will securely apply the signature, ensuring that the document is authenticated and legally binding.

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
            var initials = initials_example;  // string |  (optional) 
            var invite = invite_example;  // string |  (optional) 
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 

            try
            {
                // Sign Document with Certificate.
                FileResponse result = apiInstance.PdfWebapiEsignPost(passw, initials, invite, files, documentPassword, inputType);
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
 **initials** | **string**|  | [optional] 
 **invite** | **string**|  | [optional] 
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiExtractPost (List<byte[]> files, string documentPassword, string inputType, string outputType)

Extract Tables from Document.

Extracts tables from the provided document and converts them into the specified output format. Upload the document containing the tables and choose the format you prefer. The service will extract the tables and deliver them in the selected format, facilitating easier data usage and analysis.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 

            try
            {
                // Extract Tables from Document.
                FileResponse result = apiInstance.PdfWebapiExtractPost(files, documentPassword, inputType, outputType);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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

<a name="pdfwebapigifpost"></a>
# **PdfWebapiGifPost**
> FileResponse PdfWebapiGifPost (List<byte[]> files, string documentPassword, bool? keepImagesAsIs, int? resizeToImage, bool? streched, int? width, int? height, string frameTimes)

Make GIF.

Creates a GIF from a collection of images, ensuring smooth transitions and cohesive animation. Upload the images you want to include, and the service will generate a GIF based on your specifications. This service is ideal for animating a series of product shots, creating engaging social media content, or other animation needs.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var keepImagesAsIs = true;  // bool? | Indicates whether the images should be kept as is. (optional) 
            var resizeToImage = 56;  // int? | The index of the image to resize the other images to. (optional) 
            var streched = true;  // bool? |  (optional) 
            var width = 56;  // int? | The width of the GIF. (optional) 
            var height = 56;  // int? | The height of the GIF. (optional) 
            var frameTimes = frameTimes_example;  // string | The times for each frame in the GIF. (optional) 

            try
            {
                // Make GIF.
                FileResponse result = apiInstance.PdfWebapiGifPost(files, documentPassword, keepImagesAsIs, resizeToImage, streched, width, height, frameTimes);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiHashPost (List<byte[]> files, string documentPassword, string inputType, string outputType, HashAlgorithm alg)

Calculate Document Hash.

Calculates the hash values for the provided documents using the specified hashing algorithm. Upload the documents and choose the desired algorithm, and the service will generate hash values for each file. This process helps verify that the documents have not been altered or corrupted, ensuring data integrity.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var alg = new HashAlgorithm(); // HashAlgorithm | The hashing algorithm to use. (optional) 

            try
            {
                // Calculate Document Hash.
                FileResponse result = apiInstance.PdfWebapiHashPost(files, documentPassword, inputType, outputType, alg);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiLockPost (string password, List<byte[]> files)

Lock document.

Locks the provided document with a specified password to restrict access to authorized users only. Upload the file and provide a password, and the service will apply the password protection to secure the document. Optionally, you can include additional files to further enhance the security of the document.

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
            var password = password_example;  // string |  (optional) 
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 

            try
            {
                // Lock document.
                FileResponse result = apiInstance.PdfWebapiLockPost(password, files);
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
 **password** | **string**|  | [optional] 
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 

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
> FileResponse PdfWebapiMergePost (List<byte[]> files, string documentPassword, string inputType, string outputType, MergeImageType mergeType, int? horizontal, int? vertical, PageSize pageSize, bool? dcIsLandscape)

Merge Documents.

Merges multiple documents or images into a single file based on specified preferences for orientation and page size. Upload the files you want to consolidate and define your formatting preferences. This service will combine the files into one, ensuring that the final document or image meets your requirements.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output file. (optional) 
            var mergeType = new MergeImageType(); // MergeImageType | Type of merger operation. (optional) 
            var horizontal = 56;  // int? | The number of images to merge horizontally, if applicable. (optional) 
            var vertical = 56;  // int? | The number of images to merge vertically, if applicable. (optional) 
            var pageSize = new PageSize(); // PageSize | The page size for the output file, if applicable. (optional) 
            var dcIsLandscape = true;  // bool? | Indicates whether the output file should be in landscape orientation. (optional) 

            try
            {
                // Merge Documents.
                FileResponse result = apiInstance.PdfWebapiMergePost(files, documentPassword, inputType, outputType, mergeType, horizontal, vertical, pageSize, dcIsLandscape);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiMetadataPost (List<byte[]> files, string documentPassword, MetadataOperation operation, string folder, string name)

Read and Change Document Metadata.

Reads and updates the metadata of the provided documents based on specified operations. Upload the documents and define the metadata changes you need. This service will read the existing metadata, apply the changes, and ensure that your files contain accurate and updated information.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var operation = new MetadataOperation(); // MetadataOperation | The operation to perform on the metadata. (optional) 
            var folder = folder_example;  // string | The folder where the files are located. (optional) 
            var name = name_example;  // string | The name of the file to perform the operation on. (optional) 

            try
            {
                // Read and Change Document Metadata.
                FileResponse result = apiInstance.PdfWebapiMetadataPost(files, documentPassword, operation, folder, name);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiOrganizePost (List<byte[]> files, string documentPassword, string inputType, string remove, string move)

Organize Document Pages.

Reorganizes the pages of the provided document based on your instructions. Upload the document and specify which pages to remove or move, and the service will rearrange the pages accordingly, ensuring that the document is organized as you require.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var remove = remove_example;  // string | The pages to remove from the document. (optional) 
            var move = move_example;  // string | The pages to move within the document. (optional) 

            try
            {
                // Organize Document Pages.
                FileResponse result = apiInstance.PdfWebapiOrganizePost(files, documentPassword, inputType, remove, move);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiParsePost (List<byte[]> files, string documentPassword)

Parse Document.

Analyses and extracts relevant content from the provided document files. The parsing service organizes the data within your documents to make it accessible and tailored to your specific requirements.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 

            try
            {
                // Parse Document.
                FileResponse result = apiInstance.PdfWebapiParsePost(files, documentPassword);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 

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
> FileResponse PdfWebapiRedactPost (List<byte[]> files, string documentPassword, string searchQuery, string replaceText, bool? caseSensitive, bool? text, bool? comments, bool? metadata)

Redact Document Text.

Redacts sensitive information from the provided documents by removing specified text, comments, and metadata. You can specify the text to be redacted and use case-sensitive search to ensure thorough removal. This service helps maintain confidentiality and security by ensuring that sensitive information is completely removed.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var searchQuery = searchQuery_example;  // string | The text to search for and redact. (optional) 
            var replaceText = replaceText_example;  // string | The text to replace the found text with. (optional) 
            var caseSensitive = true;  // bool? | Indicates whether the search should be case-sensitive. (optional) 
            var text = true;  // bool? | Indicates whether text should be redacted. (optional) 
            var comments = true;  // bool? | Indicates whether comments should be redacted. (optional) 
            var metadata = true;  // bool? | Indicates whether metadata should be redacted. (optional) 

            try
            {
                // Redact Document Text.
                FileResponse result = apiInstance.PdfWebapiRedactPost(files, documentPassword, searchQuery, replaceText, caseSensitive, text, comments, metadata);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiRemovePost (List<byte[]> files, string documentPassword)

Remove Document Annotations.

Removes all annotations, including comments, highlights, and markup, from the provided documents. By specifying the documents, this service ensures that they are cleaned of any annotations, resulting in a clean and annotation-free file.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 

            try
            {
                // Remove Document Annotations.
                FileResponse result = apiInstance.PdfWebapiRemovePost(files, documentPassword);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 

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
> FileResponse PdfWebapiRemoveWatermarkPost (string watermarkText, int? top, int? left, int? bottom, int? right, List<byte[]> files, string documentPassword, bool? isAllPages, WatermarkType watermarkType, string removeRange)

Remove Document Watermark.

Removes an unwanted watermark from all pages of the provided document. Submit the document, and this service will efficiently eliminate the watermark, resulting in a clean version of the file without the watermark.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var isAllPages = true;  // bool? | Indicates whether the watermark should be removed from all pages. (optional) 
            var watermarkType = new WatermarkType(); // WatermarkType | The type of watermark to remove. (optional) 
            var removeRange = removeRange_example;  // string | The range of pages to remove the watermark from. (optional) 

            try
            {
                // Remove Document Watermark.
                FileResponse result = apiInstance.PdfWebapiRemoveWatermarkPost(watermarkText, top, left, bottom, right, files, documentPassword, isAllPages, watermarkType, removeRange);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiRemovepagesPost (List<byte[]> files, string documentPassword, string removeRange)

Remove Pages from Document.

Removes specified pages from the provided document, leaving only the pages you want to keep. Simply provide the document and specify which pages to remove, and the service will process the file accordingly.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var removeRange = removeRange_example;  // string | The range of pages to remove from the files. (optional) 

            try
            {
                // Remove Pages from Document.
                FileResponse result = apiInstance.PdfWebapiRemovepagesPost(files, documentPassword, removeRange);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiRepairPost (List<byte[]> files, string documentPassword)

Repair Document.

Repairs a corrupted or error-ridden document by identifying and fixing issues. Upload the problematic file, and this service will restore it to a usable state.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 

            try
            {
                // Repair Document.
                FileResponse result = apiInstance.PdfWebapiRepairPost(files, documentPassword);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 

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
> FileResponse PdfWebapiResizePost (List<byte[]> files, string documentPassword, string inputType, string outputType, ResizeType resizeType, ResizePresetType presetType, ResizePresetSize presetSize, int? width, int? height, int? percentage, bool? useProportions, ResizePageSize pageSize)

Resize Document.

Resizes the document to fit the specified dimensions or preset sizes. Provide the file and specify the desired dimensions, or select from available preset sizes to adjust the document accordingly.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var resizeType = new ResizeType(); // ResizeType | The type of resizing to apply. (optional) 
            var presetType = new ResizePresetType(); // ResizePresetType | The type of preset size to use for resizing. (optional) 
            var presetSize = new ResizePresetSize(); // ResizePresetSize | The preset size to use for resizing. (optional) 
            var width = 56;  // int? | The desired width of the resized files. (optional) 
            var height = 56;  // int? | The desired height of the resized files. (optional) 
            var percentage = 56;  // int? | The percentage to resize the files by. (optional) 
            var useProportions = true;  // bool? | Indicates whether to maintain the aspect ratio when resizing. (optional) 
            var pageSize = new ResizePageSize(); // ResizePageSize | The page size to use for the resized files. (optional) 

            try
            {
                // Resize Document.
                FileResponse result = apiInstance.PdfWebapiResizePost(files, documentPassword, inputType, outputType, resizeType, presetType, presetSize, width, height, percentage, useProportions, pageSize);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiRotatePost (List<byte[]> files, string documentPassword, RotateAngle angle, RotateType rotateType, string pageNum)

Rotate Document.

Rotates the document by a specified angle, allowing for adjustment of the document's orientation. You can choose the type of rotation and target specific pages to ensure the document is aligned according to your needs.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var angle = new RotateAngle(); // RotateAngle | The angle by which to rotate the files. (optional) 
            var rotateType = new RotateType(); // RotateType | The type of rotation to perform. (optional) 
            var pageNum = pageNum_example;  // string | The page number to rotate, if applicable. (optional) 

            try
            {
                // Rotate Document.
                FileResponse result = apiInstance.PdfWebapiRotatePost(files, documentPassword, angle, rotateType, pageNum);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiSearchPost (List<byte[]> files, string documentPassword, string query)

Search Document Text.

Searches the provided documents for the specified query and highlights the found text with a yellow background. This service helps you quickly locate and review relevant sections of your documents.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var query = query_example;  // string | The text to search for within the files. (optional) 

            try
            {
                // Search Document Text.
                FileResponse result = apiInstance.PdfWebapiSearchPost(files, documentPassword, query);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiSearchablePost (List<byte[]> files, string lang)

Make Scanned PDF Searchable.

Converts scanned PDFs into a searchable PDF format by recognizing and indexing text. This service ensures that you can easily search through your documents by making the text searchable in the specified language.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var lang = lang_example;  // string | The language of the files to be converted. (optional) 

            try
            {
                // Make Scanned PDF Searchable.
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
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
> FileResponse PdfWebapiSignaturePost (string image, string text, string textColor, List<byte[]> files, string documentPassword, string inputType, string outputType, SignatureType signatureType)

Add Signature to Document.

Adds a signature to the provided documents, allowing for the insertion of both text and image signatures. This service ensures that your documents are properly signed and authenticated according to your specifications.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var outputType = outputType_example;  // string | The desired format for the output files. (optional) 
            var signatureType = new SignatureType(); // SignatureType | The type of signature to add. (optional) 

            try
            {
                // Add Signature to Document.
                FileResponse result = apiInstance.PdfWebapiSignaturePost(image, text, textColor, files, documentPassword, inputType, outputType, signatureType);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiSplitdocPost (List<byte[]> files, string documentPassword, string inputType, SplitDocType splitType, string pairs)

Split Document.

Splits a document into smaller parts based on specified criteria, such as type or page range. This service ensures that each segment meets your exact requirements, simplifying document management and organization.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 
            var splitType = new SplitDocType(); // SplitDocType | The type of splitting to be performed. (optional) 
            var pairs = pairs_example;  // string | Optional page rage for the splitting operation. (optional) 

            try
            {
                // Split Document.
                FileResponse result = apiInstance.PdfWebapiSplitdocPost(files, documentPassword, inputType, splitType, pairs);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 
 **splitType** | [**SplitDocType**](.md)| The type of splitting to be performed. | [optional] 
 **pairs** | **string**| Optional page rage for the splitting operation. | [optional] 

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
> FileResponse PdfWebapiSplitimagePost (List<byte[]> files, string documentPassword, SplitImageType splitType, int? vertical, int? horizontal, string outputType)

Split Image.

Splits large images into smaller sections according to the specified parameters, making it easier to handle and process image data.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var splitType = new SplitImageType(); // SplitImageType | The type of splitting to be performed. (optional) 
            var vertical = 56;  // int? | The number of vertical splits to create. (optional) 
            var horizontal = 56;  // int? | The number of horizontal splits to create. (optional) 
            var outputType = outputType_example;  // string | The desired output format for the split images. (optional) 

            try
            {
                // Split Image.
                FileResponse result = apiInstance.PdfWebapiSplitimagePost(files, documentPassword, splitType, vertical, horizontal, outputType);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiUnlockPost (string password, List<byte[]> files)

Unlock Document.

Attempts to unlock a password-protected document, using any associated files if necessary, to grant access to the content.

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
            var password = password_example;  // string |  (optional) 
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 

            try
            {
                // Unlock Document.
                FileResponse result = apiInstance.PdfWebapiUnlockPost(password, files);
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
 **password** | **string**|  | [optional] 
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 

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
> FileResponse PdfWebapiVerifyEsignPost (List<byte[]> files, string documentPassword, string inputType)

Verify Document Certificate.

Verifies the electronic signature of the provided document to ensure its authenticity and integrity. This service checks the digital certificates in the document to confirm their validity and trustworthiness.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 

            try
            {
                // Verify Document Certificate.
                FileResponse result = apiInstance.PdfWebapiVerifyEsignPost(files, documentPassword, inputType);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiWatermarkPost (List<byte[]> files, string documentPassword, string inputType, string outputType, bool? isColored, bool? isText, string text, string name, int? size, bool? bold, bool? italic, bool? underlined, string color, bool? isBackground, int? rotation, float? transparency, bool? layer, int? pageFrom, int? pageTo)

Add Watermark to Document.

Adds a watermark to the provided documents, helping to protect and identify them. This service ensures that the watermark is applied according to your specifications, enhancing the security and ownership of your content.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
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
                // Add Watermark to Document.
                FileResponse result = apiInstance.PdfWebapiWatermarkPost(files, documentPassword, inputType, outputType, isColored, isText, text, name, size, bold, italic, underlined, color, isBackground, rotation, transparency, layer, pageFrom, pageTo);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiWordcounterPost (List<byte[]> files, string documentPassword, string pageRange)

Count Words and Characters in Document.

Counts the words and characters in the provided documents within the specified page range. This service helps you accurately determine the length and content density of your documents, ensuring compliance with any required specifications or limits.

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var pageRange = pageRange_example;  // string | The range of pages to count words in. (optional) 

            try
            {
                // Count Words and Characters in Document.
                FileResponse result = apiInstance.PdfWebapiWordcounterPost(files, documentPassword, pageRange);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
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
> FileResponse PdfWebapiXfaconvertPost (List<byte[]> files, string documentPassword, string inputType)

Convert XFA Format to Another Format.

Converts XFA documents to the specified format, ensuring seamless compatibility and usability. This service supports a wide range of target formats, allowing users to choose the most suitable format for their specific needs. The conversion process maintains the integrity of the original document while adapting it to the desired format, making it ideal for editing, sharing, or archiving..

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
            var files = new List<byte[]>(); // List<byte[]> |  (optional) 
            var documentPassword = documentPassword_example;  // string |  (optional) 
            var inputType = inputType_example;  // string | The format of the input files. (optional) 

            try
            {
                // Convert XFA Format to Another Format.
                FileResponse result = apiInstance.PdfWebapiXfaconvertPost(files, documentPassword, inputType);
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
 **files** | [**List<byte[]>**](byte[].md)|  | [optional] 
 **documentPassword** | **string**|  | [optional] 
 **inputType** | **string**| The format of the input files. | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

