# io.swagger.client - Kotlin client library for Aspose.Pdf RestApi

## Requires

* Kotlin 1.4.30
* Gradle 5.3

## Build

First, create the gradle wrapper script:

```
gradle wrapper
```

Then, run:

```
./gradlew check assemble
```

This runs all tests and packages the library.

## Features/Implementation Notes

* Supports JSON inputs/outputs, File inputs, and Form inputs.
* Supports collection formats for query parameters: csv, tsv, ssv, pipes.
* Some Kotlin and Java types are fully qualified to avoid conflicts with types defined in Swagger definitions.
* Implementation of ApiClient is intended to reduce method counts, specifically to benefit Android targets.

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApiApi* | [**pdfWebapiAddnumberPost**](docs/ApiApi.md#pdfwebapiaddnumberpost) | **POST** /pdf/webapi/addnumber | Add page numbers to document.
*ApiApi* | [**pdfWebapiChangeFontsPost**](docs/ApiApi.md#pdfwebapichangefontspost) | **POST** /pdf/webapi/change-fonts | 
*ApiApi* | [**pdfWebapiComparisonPost**](docs/ApiApi.md#pdfwebapicomparisonpost) | **POST** /pdf/webapi/comparison | Compare documents text.
*ApiApi* | [**pdfWebapiCompressPost**](docs/ApiApi.md#pdfwebapicompresspost) | **POST** /pdf/webapi/compress | Compress document.
*ApiApi* | [**pdfWebapiConvertPost**](docs/ApiApi.md#pdfwebapiconvertpost) | **POST** /pdf/webapi/convert | Convert document to another format.
*ApiApi* | [**pdfWebapiConvertWebpagePost**](docs/ApiApi.md#pdfwebapiconvertwebpagepost) | **POST** /pdf/webapi/convert-webpage | Convert web page to document.
*ApiApi* | [**pdfWebapiCropPost**](docs/ApiApi.md#pdfwebapicroppost) | **POST** /pdf/webapi/crop | Crop document.
*ApiApi* | [**pdfWebapiDownloadIdGet**](docs/ApiApi.md#pdfwebapidownloadidget) | **GET** /pdf/webapi/download/{id} | File download.
*ApiApi* | [**pdfWebapiEsignPost**](docs/ApiApi.md#pdfwebapiesignpost) | **POST** /pdf/webapi/esign | Sign document with certificate.
*ApiApi* | [**pdfWebapiExtractPost**](docs/ApiApi.md#pdfwebapiextractpost) | **POST** /pdf/webapi/extract | Extract tables from document.
*ApiApi* | [**pdfWebapiFormFillerPost**](docs/ApiApi.md#pdfwebapiformfillerpost) | **POST** /pdf/webapi/form-filler | Fill form.
*ApiApi* | [**pdfWebapiGifPost**](docs/ApiApi.md#pdfwebapigifpost) | **POST** /pdf/webapi/gif | Make GIF.
*ApiApi* | [**pdfWebapiHashPost**](docs/ApiApi.md#pdfwebapihashpost) | **POST** /pdf/webapi/hash | Calculate document hash.
*ApiApi* | [**pdfWebapiLockPost**](docs/ApiApi.md#pdfwebapilockpost) | **POST** /pdf/webapi/lock | Lock document.
*ApiApi* | [**pdfWebapiMergePost**](docs/ApiApi.md#pdfwebapimergepost) | **POST** /pdf/webapi/merge | Merge documents.
*ApiApi* | [**pdfWebapiMetadataPost**](docs/ApiApi.md#pdfwebapimetadatapost) | **POST** /pdf/webapi/metadata | Read and change document metadata.
*ApiApi* | [**pdfWebapiOrganizePost**](docs/ApiApi.md#pdfwebapiorganizepost) | **POST** /pdf/webapi/organize | Organize document pages.
*ApiApi* | [**pdfWebapiParsePost**](docs/ApiApi.md#pdfwebapiparsepost) | **POST** /pdf/webapi/parse | Parse document.
*ApiApi* | [**pdfWebapiRedactPost**](docs/ApiApi.md#pdfwebapiredactpost) | **POST** /pdf/webapi/redact | Redact document text.
*ApiApi* | [**pdfWebapiRemoveIdPost**](docs/ApiApi.md#pdfwebapiremoveidpost) | **POST** /pdf/webapi/remove/{id} | Remove stored files.
*ApiApi* | [**pdfWebapiRemovePost**](docs/ApiApi.md#pdfwebapiremovepost) | **POST** /pdf/webapi/remove | Remove document annotations.
*ApiApi* | [**pdfWebapiRemoveWatermarkPost**](docs/ApiApi.md#pdfwebapiremovewatermarkpost) | **POST** /pdf/webapi/remove-watermark | Removes document watermark.
*ApiApi* | [**pdfWebapiRemovepagesPost**](docs/ApiApi.md#pdfwebapiremovepagespost) | **POST** /pdf/webapi/removepages | Remove pages from document.
*ApiApi* | [**pdfWebapiRepairPost**](docs/ApiApi.md#pdfwebapirepairpost) | **POST** /pdf/webapi/repair | Repair document.
*ApiApi* | [**pdfWebapiResizePost**](docs/ApiApi.md#pdfwebapiresizepost) | **POST** /pdf/webapi/resize | Resize document.
*ApiApi* | [**pdfWebapiRotatePost**](docs/ApiApi.md#pdfwebapirotatepost) | **POST** /pdf/webapi/rotate | Rotate document.
*ApiApi* | [**pdfWebapiSearchPost**](docs/ApiApi.md#pdfwebapisearchpost) | **POST** /pdf/webapi/search | Search document text.
*ApiApi* | [**pdfWebapiSearchablePost**](docs/ApiApi.md#pdfwebapisearchablepost) | **POST** /pdf/webapi/searchable | Make scanned pdf searchable.
*ApiApi* | [**pdfWebapiSignaturePost**](docs/ApiApi.md#pdfwebapisignaturepost) | **POST** /pdf/webapi/signature | Add signature to document.
*ApiApi* | [**pdfWebapiSplitdocPost**](docs/ApiApi.md#pdfwebapisplitdocpost) | **POST** /pdf/webapi/splitdoc | Split document.
*ApiApi* | [**pdfWebapiSplitimagePost**](docs/ApiApi.md#pdfwebapisplitimagepost) | **POST** /pdf/webapi/splitimage | Split image.
*ApiApi* | [**pdfWebapiStatusIdPost**](docs/ApiApi.md#pdfwebapistatusidpost) | **POST** /pdf/webapi/status/{id} | Processing status.
*ApiApi* | [**pdfWebapiUnlockPost**](docs/ApiApi.md#pdfwebapiunlockpost) | **POST** /pdf/webapi/unlock | Unlock document.
*ApiApi* | [**pdfWebapiVerifyEsignPost**](docs/ApiApi.md#pdfwebapiverifyesignpost) | **POST** /pdf/webapi/verify_esign | Verify document certificate.
*ApiApi* | [**pdfWebapiWatermarkPost**](docs/ApiApi.md#pdfwebapiwatermarkpost) | **POST** /pdf/webapi/watermark | Add watermark to document.
*ApiApi* | [**pdfWebapiWordcounterPost**](docs/ApiApi.md#pdfwebapiwordcounterpost) | **POST** /pdf/webapi/wordcounter | Count words and chars in document.
*ApiApi* | [**pdfWebapiXfaconvertPost**](docs/ApiApi.md#pdfwebapixfaconvertpost) | **POST** /pdf/webapi/xfaconvert | Convert XFA format to a another format.

<a name="documentation-for-models"></a>
## Documentation for Models

 - [io.swagger.client.models.CompressType](docs/CompressType.md)
 - [io.swagger.client.models.DocProperty](docs/DocProperty.md)
 - [io.swagger.client.models.FileProcessingErrorCode](docs/FileProcessingErrorCode.md)
 - [io.swagger.client.models.FileResponse](docs/FileResponse.md)
 - [io.swagger.client.models.FileSafeResult](docs/FileSafeResult.md)
 - [io.swagger.client.models.HashAlgorithm](docs/HashAlgorithm.md)
 - [io.swagger.client.models.MergeImageType](docs/MergeImageType.md)
 - [io.swagger.client.models.MetadataOperation](docs/MetadataOperation.md)
 - [io.swagger.client.models.PageNumberHorizontalAlign](docs/PageNumberHorizontalAlign.md)
 - [io.swagger.client.models.PageNumberVerticalAlign](docs/PageNumberVerticalAlign.md)
 - [io.swagger.client.models.PageSize](docs/PageSize.md)
 - [io.swagger.client.models.PropertyType](docs/PropertyType.md)
 - [io.swagger.client.models.ResizePageSize](docs/ResizePageSize.md)
 - [io.swagger.client.models.ResizePresetSize](docs/ResizePresetSize.md)
 - [io.swagger.client.models.ResizePresetType](docs/ResizePresetType.md)
 - [io.swagger.client.models.ResizeType](docs/ResizeType.md)
 - [io.swagger.client.models.RotateAngle](docs/RotateAngle.md)
 - [io.swagger.client.models.RotateType](docs/RotateType.md)
 - [io.swagger.client.models.SignatureType](docs/SignatureType.md)
 - [io.swagger.client.models.SplitDocType](docs/SplitDocType.md)
 - [io.swagger.client.models.SplitImageType](docs/SplitImageType.md)
 - [io.swagger.client.models.WatermarkType](docs/WatermarkType.md)
 - [io.swagger.client.models.WebapiAddnumberBody](docs/WebapiAddnumberBody.md)
 - [io.swagger.client.models.WebapiChangefontsBody](docs/WebapiChangefontsBody.md)
 - [io.swagger.client.models.WebapiComparisonBody](docs/WebapiComparisonBody.md)
 - [io.swagger.client.models.WebapiCompressBody](docs/WebapiCompressBody.md)
 - [io.swagger.client.models.WebapiConvertBody](docs/WebapiConvertBody.md)
 - [io.swagger.client.models.WebapiConvertwebpageBody](docs/WebapiConvertwebpageBody.md)
 - [io.swagger.client.models.WebapiCropBody](docs/WebapiCropBody.md)
 - [io.swagger.client.models.WebapiEsignBody](docs/WebapiEsignBody.md)
 - [io.swagger.client.models.WebapiExtractBody](docs/WebapiExtractBody.md)
 - [io.swagger.client.models.WebapiFormfillerBody](docs/WebapiFormfillerBody.md)
 - [io.swagger.client.models.WebapiGifBody](docs/WebapiGifBody.md)
 - [io.swagger.client.models.WebapiHashBody](docs/WebapiHashBody.md)
 - [io.swagger.client.models.WebapiLockBody](docs/WebapiLockBody.md)
 - [io.swagger.client.models.WebapiMergeBody](docs/WebapiMergeBody.md)
 - [io.swagger.client.models.WebapiMetadataBody](docs/WebapiMetadataBody.md)
 - [io.swagger.client.models.WebapiOrganizeBody](docs/WebapiOrganizeBody.md)
 - [io.swagger.client.models.WebapiParseBody](docs/WebapiParseBody.md)
 - [io.swagger.client.models.WebapiRedactBody](docs/WebapiRedactBody.md)
 - [io.swagger.client.models.WebapiRemoveBody](docs/WebapiRemoveBody.md)
 - [io.swagger.client.models.WebapiRemovepagesBody](docs/WebapiRemovepagesBody.md)
 - [io.swagger.client.models.WebapiRemovewatermarkBody](docs/WebapiRemovewatermarkBody.md)
 - [io.swagger.client.models.WebapiRepairBody](docs/WebapiRepairBody.md)
 - [io.swagger.client.models.WebapiResizeBody](docs/WebapiResizeBody.md)
 - [io.swagger.client.models.WebapiRotateBody](docs/WebapiRotateBody.md)
 - [io.swagger.client.models.WebapiSearchBody](docs/WebapiSearchBody.md)
 - [io.swagger.client.models.WebapiSearchableBody](docs/WebapiSearchableBody.md)
 - [io.swagger.client.models.WebapiSignatureBody](docs/WebapiSignatureBody.md)
 - [io.swagger.client.models.WebapiSplitdocBody](docs/WebapiSplitdocBody.md)
 - [io.swagger.client.models.WebapiSplitimageBody](docs/WebapiSplitimageBody.md)
 - [io.swagger.client.models.WebapiUnlockBody](docs/WebapiUnlockBody.md)
 - [io.swagger.client.models.WebapiVerifyEsignBody](docs/WebapiVerifyEsignBody.md)
 - [io.swagger.client.models.WebapiWatermarkBody](docs/WebapiWatermarkBody.md)
 - [io.swagger.client.models.WebapiWordcounterBody](docs/WebapiWordcounterBody.md)
 - [io.swagger.client.models.WebapiXfaconvertBody](docs/WebapiXfaconvertBody.md)
 - [io.swagger.client.models.XmlType](docs/XmlType.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
