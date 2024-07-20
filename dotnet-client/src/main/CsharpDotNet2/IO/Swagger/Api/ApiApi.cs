using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApiApi
    {
        /// <summary>
        /// Add page numbers to document. Adds page numbers to the provided documents with the specified alignment, starting number, and format.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="vAlignment">The vertical alignment of the page numbers.</param>
        /// <param name="hAlignment">The horizontal alignment of the page numbers.</param>
        /// <param name="startingNumber">The starting number for the page numbers.</param>
        /// <param name="sNumber">The number of the first page to start numbering from.</param>
        /// <param name="fNumber">The number of the last page to end numbering at.</param>
        /// <param name="margin">The margin around the page numbers.</param>
        /// <param name="fontSize">The font size of the page numbers.</param>
        /// <param name="format">The format of the page numbers.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiAddnumberPost (List<FileParameter> files, PageNumberVerticalAlign vAlignment, PageNumberHorizontalAlign hAlignment, int? startingNumber, int? sNumber, int? fNumber, int? margin, int? fontSize, string format);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fontReplacementsJson"></param>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiChangeFontsPost (string fontReplacementsJson, List<FileParameter> files);
        /// <summary>
        /// Compare documents text. Compare provided files and create document with marked changes.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiComparisonPost (List<FileParameter> files);
        /// <summary>
        /// Compress document. Compresses the provided files using the specified compression level.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="compressType">The level of compression to use.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiCompressPost (List<FileParameter> files, CompressType compressType);
        /// <summary>
        /// Convert document to another format. Converts the provided files from one format to another.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="xmlType">The type of XML conversion to perform, if applicable.</param>
        /// <param name="xmlTag">The XML tag to use for conversion, if applicable.</param>
        /// <param name="fontSise"></param>
        /// <param name="isToSingle">Indicates whether the conversion should result in a single file, if applicable.</param>
        /// <param name="separator">The separator to use when converting, if applicable.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiConvertPost (List<FileParameter> files, string inputType, string outputType, XmlType xmlType, string xmlTag, int? fontSise, bool? isToSingle, string separator);
        /// <summary>
        /// Convert web page to document. Converts a web page to the specified output format.
        /// </summary>
        /// <param name="webPage"></param>
        /// <param name="outputType">The desired format for the output file.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiConvertWebpagePost (string webPage, string outputType);
        /// <summary>
        /// Crop document. Crops the provided files to the specified dimensions.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="top">The number of pixels to crop from the top.</param>
        /// <param name="right">The number of pixels to crop from the right.</param>
        /// <param name="bottom">The number of pixels to crop from the bottom.</param>
        /// <param name="left">The number of pixels to crop from the left.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiCropPost (List<FileParameter> files, string inputType, int? top, int? right, int? bottom, int? left, string outputType);
        /// <summary>
        /// File download. Downloads processed file.
        /// </summary>
        /// <param name="id">The id of the processing to download.</param>
        /// <param name="file">The name of the file to download.</param>
        /// <returns></returns>
        void PdfWebapiDownloadIdGet (string id, string file);
        /// <summary>
        /// Sign document with certificate. Electronically signs the provided documents with the specified certificate.
        /// </summary>
        /// <param name="passw"></param>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiEsignPost (string passw, List<FileParameter> files, string inputType);
        /// <summary>
        /// Extract tables from document. Extracts tables from the provided documents and converts them to the specified output format.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiExtractPost (List<FileParameter> files, string inputType, string outputType);
        /// <summary>
        /// Fill form. Fills a form with the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="fileName">The name of the file to fill the form with.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiFormFillerPost (List<FileParameter> files, string fileName);
        /// <summary>
        /// Make GIF. Creates a GIF from the provided images.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="keepImagesAsIs">Indicates whether the images should be kept as is.</param>
        /// <param name="resizeToImage">The index of the image to resize the other images to.</param>
        /// <param name="streched"></param>
        /// <param name="width">The width of the GIF.</param>
        /// <param name="height">The height of the GIF.</param>
        /// <param name="frameTimes">The times for each frame in the GIF.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiGifPost (List<FileParameter> files, bool? keepImagesAsIs, int? resizeToImage, bool? streched, int? width, int? height, string frameTimes);
        /// <summary>
        /// Calculate document hash. Calculate hashes of provided files using the specified algorithm.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="alg">The hashing algorithm to use.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiHashPost (List<FileParameter> files, string inputType, string outputType, HashAlgorithm alg);
        /// <summary>
        /// Lock document. Locks a document with the provided password and optional files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="passw">The password required to lock the resource.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiLockPost (List<FileParameter> files, string passw);
        /// <summary>
        /// Merge documents. Merges the provided files into a single document or image, with options for orientation and page size.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output file.</param>
        /// <param name="mergeType">Type of merger operation.</param>
        /// <param name="horizontal">The number of images to merge horizontally, if applicable.</param>
        /// <param name="vertical">The number of images to merge vertically, if applicable.</param>
        /// <param name="pageSize">The page size for the output file, if applicable.</param>
        /// <param name="dcIsLandscape">Indicates whether the output file should be in landscape orientation.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiMergePost (List<FileParameter> files, string inputType, string outputType, MergeImageType mergeType, int? horizontal, int? vertical, PageSize pageSize, bool? dcIsLandscape);
        /// <summary>
        /// Read and change document metadata. Performs metadata operations on the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="operation">The operation to perform on the metadata.</param>
        /// <param name="folder">The folder where the files are located.</param>
        /// <param name="name">The name of the file to perform the operation on.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiMetadataPost (List<FileParameter> files, MetadataOperation operation, string folder, string name);
        /// <summary>
        /// Organize document pages. Organizes the provided documents by removing or moving specified pages.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="remove">The pages to remove from the document.</param>
        /// <param name="move">The pages to move within the document.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiOrganizePost (List<FileParameter> files, string inputType, string remove, string move);
        /// <summary>
        /// Parse document. Parses the provided files using a parser service.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiParsePost (List<FileParameter> files);
        /// <summary>
        /// Redact document text. Redacts specified text from the provided documents, with options to search case-sensitively, target in text, comments, and metadata.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="searchQuery">The text to search for and redact.</param>
        /// <param name="replaceText">The text to replace the found text with.</param>
        /// <param name="caseSensitive">Indicates whether the search should be case-sensitive.</param>
        /// <param name="text">Indicates whether text should be redacted.</param>
        /// <param name="comments">Indicates whether comments should be redacted.</param>
        /// <param name="metadata">Indicates whether metadata should be redacted.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiRedactPost (List<FileParameter> files, string searchQuery, string replaceText, bool? caseSensitive, bool? text, bool? comments, bool? metadata);
        /// <summary>
        /// Remove stored files. Removes processed files from storage.
        /// </summary>
        /// <param name="id">The ID of the processing to remove.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiRemoveIdPost (string id);
        /// <summary>
        /// Remove document annotations. Removes annotations from the provided documents.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiRemovePost (List<FileParameter> files);
        /// <summary>
        /// Removes document watermark. Removes a watermark from the document pages.
        /// </summary>
        /// <param name="watermarkText"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="right"></param>
        /// <param name="files"></param>
        /// <param name="isAllPages">Indicates whether the watermark should be removed from all pages.</param>
        /// <param name="watermarkType">The type of watermark to remove.</param>
        /// <param name="removeRange">The range of pages to remove the watermark from.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiRemoveWatermarkPost (string watermarkText, int? top, int? left, int? bottom, int? right, List<FileParameter> files, bool? isAllPages, WatermarkType watermarkType, string removeRange);
        /// <summary>
        /// Remove pages from document. Removes specified pages from the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="removeRange">The range of pages to remove from the files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiRemovepagesPost (List<FileParameter> files, string removeRange);
        /// <summary>
        /// Repair document. Repairs the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiRepairPost (List<FileParameter> files);
        /// <summary>
        /// Resize document. Resizes the provided files to the specified dimensions or using a preset size.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="resizeType">The type of resizing to apply.</param>
        /// <param name="presetType">The type of preset size to use for resizing.</param>
        /// <param name="presetSize">The preset size to use for resizing.</param>
        /// <param name="width">The desired width of the resized files.</param>
        /// <param name="height">The desired height of the resized files.</param>
        /// <param name="percentage">The percentage to resize the files by.</param>
        /// <param name="useProportions">Indicates whether to maintain the aspect ratio when resizing.</param>
        /// <param name="pageSize">The page size to use for the resized files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiResizePost (List<FileParameter> files, string inputType, string outputType, ResizeType resizeType, ResizePresetType presetType, ResizePresetSize presetSize, int? width, int? height, int? percentage, bool? useProportions, ResizePageSize pageSize);
        /// <summary>
        /// Rotate document. Rotates the provided files by a specified angle, with options for rotation type and page number.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="angle">The angle by which to rotate the files.</param>
        /// <param name="rotateType">The type of rotation to perform.</param>
        /// <param name="pageNum">The page number to rotate, if applicable.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiRotatePost (List<FileParameter> files, RotateAngle angle, RotateType rotateType, string pageNum);
        /// <summary>
        /// Search document text. Searches the provided files for the specified query and makr found text with yellow background.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="query">The text to search for within the files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiSearchPost (List<FileParameter> files, string query);
        /// <summary>
        /// Make scanned pdf searchable. Converts the provided files into a searchable PDF format for the specified language.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="lang">The language of the files to be converted.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiSearchablePost (List<FileParameter> files, string lang);
        /// <summary>
        /// Add signature to document. Adds a signature, text and image to the provided documents.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="text"></param>
        /// <param name="textColor"></param>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="signatureType">The type of signature to add.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiSignaturePost (string image, string text, string textColor, List<FileParameter> files, string inputType, string outputType, SignatureType signatureType);
        /// <summary>
        /// Split document. Splits the provided documents based on the specified split type and page rage to spit.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="splitType">The type of splitting to be performed.</param>
        /// <param name="pairs">Optional page rage for the splitting operation.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiSplitdocPost (List<FileParameter> files, SplitDocType splitType, string pairs);
        /// <summary>
        /// Split image. Splits the provided images into smaller parts based on the specified parameters.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="splitType">The type of splitting to be performed.</param>
        /// <param name="vertical">The number of vertical splits to create.</param>
        /// <param name="horizontal">The number of horizontal splits to create.</param>
        /// <param name="outputType">The desired output format for the split images.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiSplitimagePost (List<FileParameter> files, SplitImageType splitType, int? vertical, int? horizontal, string outputType);
        /// <summary>
        /// Processing status. Retrieves the status of a processing.
        /// </summary>
        /// <param name="id">The ID of the processing to check the status of.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiStatusIdPost (string id);
        /// <summary>
        /// Unlock document. Attempts to unlock a document with an password and associated files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="passw">The password used in locked document.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiUnlockPost (List<FileParameter> files, string passw);
        /// <summary>
        /// Verify document certificate. Verifies the electronic signature of the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiVerifyEsignPost (List<FileParameter> files, string inputType);
        /// <summary>
        /// Add watermark to document. Adds a watermark to the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="isColored">Indicate is watermark will be in color or grayscale.</param>
        /// <param name="isText">Indicates whether the watermark is text.</param>
        /// <param name="text">The text of the watermark.</param>
        /// <param name="name">The name of the font for the text watermark.</param>
        /// <param name="size">The size of the font for the text watermark.</param>
        /// <param name="bold">Indicates whether the text watermark is bold.</param>
        /// <param name="italic">Indicates whether the text watermark is italic.</param>
        /// <param name="underlined">Indicates whether the text watermark is underlined.</param>
        /// <param name="color">The color of the text or image watermark.</param>
        /// <param name="isBackground">Indicates whether the watermark is a background watermark.</param>
        /// <param name="rotation">The rotation angle of the watermark.</param>
        /// <param name="transparency">The transparency of the watermark.</param>
        /// <param name="layer">Indicates whether the watermark is a layer.</param>
        /// <param name="pageFrom">The starting page number for the watermark.</param>
        /// <param name="pageTo">The ending page number for the watermark.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiWatermarkPost (List<FileParameter> files, string inputType, string outputType, bool? isColored, bool? isText, string text, string name, int? size, bool? bold, bool? italic, bool? underlined, string color, bool? isBackground, int? rotation, float? transparency, bool? layer, int? pageFrom, int? pageTo);
        /// <summary>
        /// Count words and chars in document. Counts the words in the provided files within the specified page range.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="pageRange">The range of pages to count words in.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiWordcounterPost (List<FileParameter> files, string pageRange);
        /// <summary>
        /// Convert XFA format to a another format. Converts the provided documents from XFA format to a different format.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <returns>FileResponse</returns>
        FileResponse PdfWebapiXfaconvertPost (List<FileParameter> files, string inputType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ApiApi : IApiApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ApiApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApiApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Add page numbers to document. Adds page numbers to the provided documents with the specified alignment, starting number, and format.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="vAlignment">The vertical alignment of the page numbers.</param>
        /// <param name="hAlignment">The horizontal alignment of the page numbers.</param>
        /// <param name="startingNumber">The starting number for the page numbers.</param>
        /// <param name="sNumber">The number of the first page to start numbering from.</param>
        /// <param name="fNumber">The number of the last page to end numbering at.</param>
        /// <param name="margin">The margin around the page numbers.</param>
        /// <param name="fontSize">The font size of the page numbers.</param>
        /// <param name="format">The format of the page numbers.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiAddnumberPost (List<FileParameter> files, PageNumberVerticalAlign vAlignment, PageNumberHorizontalAlign hAlignment, int? startingNumber, int? sNumber, int? fNumber, int? margin, int? fontSize, string format)
        {
    
            var path = "/pdf/webapi/addnumber";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (vAlignment != null) queryParams.Add("vAlignment", ApiClient.ParameterToString(vAlignment)); // query parameter
 if (hAlignment != null) queryParams.Add("hAlignment", ApiClient.ParameterToString(hAlignment)); // query parameter
 if (startingNumber != null) queryParams.Add("startingNumber", ApiClient.ParameterToString(startingNumber)); // query parameter
 if (sNumber != null) queryParams.Add("sNumber", ApiClient.ParameterToString(sNumber)); // query parameter
 if (fNumber != null) queryParams.Add("fNumber", ApiClient.ParameterToString(fNumber)); // query parameter
 if (margin != null) queryParams.Add("margin", ApiClient.ParameterToString(margin)); // query parameter
 if (fontSize != null) queryParams.Add("fontSize", ApiClient.ParameterToString(fontSize)); // query parameter
 if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiAddnumberPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiAddnumberPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="fontReplacementsJson"></param>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiChangeFontsPost (string fontReplacementsJson, List<FileParameter> files)
        {
    
            var path = "/pdf/webapi/change-fonts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (fontReplacementsJson != null) formParams.Add("fontReplacementsJson", ApiClient.ParameterToString(fontReplacementsJson)); // form parameter
if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiChangeFontsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiChangeFontsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Compare documents text. Compare provided files and create document with marked changes.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiComparisonPost (List<FileParameter> files)
        {
    
            var path = "/pdf/webapi/comparison";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiComparisonPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiComparisonPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Compress document. Compresses the provided files using the specified compression level.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="compressType">The level of compression to use.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiCompressPost (List<FileParameter> files, CompressType compressType)
        {
    
            var path = "/pdf/webapi/compress";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (compressType != null) queryParams.Add("compressType", ApiClient.ParameterToString(compressType)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiCompressPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiCompressPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Convert document to another format. Converts the provided files from one format to another.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="xmlType">The type of XML conversion to perform, if applicable.</param>
        /// <param name="xmlTag">The XML tag to use for conversion, if applicable.</param>
        /// <param name="fontSise"></param>
        /// <param name="isToSingle">Indicates whether the conversion should result in a single file, if applicable.</param>
        /// <param name="separator">The separator to use when converting, if applicable.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiConvertPost (List<FileParameter> files, string inputType, string outputType, XmlType xmlType, string xmlTag, int? fontSise, bool? isToSingle, string separator)
        {
    
            var path = "/pdf/webapi/convert";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
 if (xmlType != null) queryParams.Add("xmlType", ApiClient.ParameterToString(xmlType)); // query parameter
 if (xmlTag != null) queryParams.Add("xmlTag", ApiClient.ParameterToString(xmlTag)); // query parameter
 if (fontSise != null) queryParams.Add("fontSise", ApiClient.ParameterToString(fontSise)); // query parameter
 if (isToSingle != null) queryParams.Add("isToSingle", ApiClient.ParameterToString(isToSingle)); // query parameter
 if (separator != null) queryParams.Add("separator", ApiClient.ParameterToString(separator)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiConvertPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiConvertPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Convert web page to document. Converts a web page to the specified output format.
        /// </summary>
        /// <param name="webPage"></param>
        /// <param name="outputType">The desired format for the output file.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiConvertWebpagePost (string webPage, string outputType)
        {
    
            var path = "/pdf/webapi/convert-webpage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
                        if (webPage != null) formParams.Add("webPage", ApiClient.ParameterToString(webPage)); // form parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiConvertWebpagePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiConvertWebpagePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Crop document. Crops the provided files to the specified dimensions.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="top">The number of pixels to crop from the top.</param>
        /// <param name="right">The number of pixels to crop from the right.</param>
        /// <param name="bottom">The number of pixels to crop from the bottom.</param>
        /// <param name="left">The number of pixels to crop from the left.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiCropPost (List<FileParameter> files, string inputType, int? top, int? right, int? bottom, int? left, string outputType)
        {
    
            var path = "/pdf/webapi/crop";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
 if (right != null) queryParams.Add("right", ApiClient.ParameterToString(right)); // query parameter
 if (bottom != null) queryParams.Add("bottom", ApiClient.ParameterToString(bottom)); // query parameter
 if (left != null) queryParams.Add("left", ApiClient.ParameterToString(left)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiCropPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiCropPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// File download. Downloads processed file.
        /// </summary>
        /// <param name="id">The id of the processing to download.</param>
        /// <param name="file">The name of the file to download.</param>
        /// <returns></returns>
        public void PdfWebapiDownloadIdGet (string id, string file)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PdfWebapiDownloadIdGet");
    
            var path = "/pdf/webapi/download/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (file != null) queryParams.Add("file", ApiClient.ParameterToString(file)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiDownloadIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiDownloadIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sign document with certificate. Electronically signs the provided documents with the specified certificate.
        /// </summary>
        /// <param name="passw"></param>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiEsignPost (string passw, List<FileParameter> files, string inputType)
        {
    
            var path = "/pdf/webapi/esign";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
                        if (passw != null) formParams.Add("passw", ApiClient.ParameterToString(passw)); // form parameter
if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiEsignPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiEsignPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Extract tables from document. Extracts tables from the provided documents and converts them to the specified output format.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiExtractPost (List<FileParameter> files, string inputType, string outputType)
        {
    
            var path = "/pdf/webapi/extract";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiExtractPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiExtractPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Fill form. Fills a form with the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="fileName">The name of the file to fill the form with.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiFormFillerPost (List<FileParameter> files, string fileName)
        {
    
            var path = "/pdf/webapi/form-filler";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fileName != null) queryParams.Add("fileName", ApiClient.ParameterToString(fileName)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiFormFillerPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiFormFillerPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Make GIF. Creates a GIF from the provided images.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="keepImagesAsIs">Indicates whether the images should be kept as is.</param>
        /// <param name="resizeToImage">The index of the image to resize the other images to.</param>
        /// <param name="streched"></param>
        /// <param name="width">The width of the GIF.</param>
        /// <param name="height">The height of the GIF.</param>
        /// <param name="frameTimes">The times for each frame in the GIF.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiGifPost (List<FileParameter> files, bool? keepImagesAsIs, int? resizeToImage, bool? streched, int? width, int? height, string frameTimes)
        {
    
            var path = "/pdf/webapi/gif";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keepImagesAsIs != null) queryParams.Add("keepImagesAsIs", ApiClient.ParameterToString(keepImagesAsIs)); // query parameter
 if (resizeToImage != null) queryParams.Add("resizeToImage", ApiClient.ParameterToString(resizeToImage)); // query parameter
 if (streched != null) queryParams.Add("streched", ApiClient.ParameterToString(streched)); // query parameter
 if (width != null) queryParams.Add("width", ApiClient.ParameterToString(width)); // query parameter
 if (height != null) queryParams.Add("height", ApiClient.ParameterToString(height)); // query parameter
 if (frameTimes != null) queryParams.Add("frameTimes", ApiClient.ParameterToString(frameTimes)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiGifPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiGifPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Calculate document hash. Calculate hashes of provided files using the specified algorithm.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="alg">The hashing algorithm to use.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiHashPost (List<FileParameter> files, string inputType, string outputType, HashAlgorithm alg)
        {
    
            var path = "/pdf/webapi/hash";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
 if (alg != null) queryParams.Add("alg", ApiClient.ParameterToString(alg)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiHashPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiHashPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Lock document. Locks a document with the provided password and optional files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="passw">The password required to lock the resource.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiLockPost (List<FileParameter> files, string passw)
        {
    
            var path = "/pdf/webapi/lock";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (passw != null) queryParams.Add("passw", ApiClient.ParameterToString(passw)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiLockPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiLockPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Merge documents. Merges the provided files into a single document or image, with options for orientation and page size.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output file.</param>
        /// <param name="mergeType">Type of merger operation.</param>
        /// <param name="horizontal">The number of images to merge horizontally, if applicable.</param>
        /// <param name="vertical">The number of images to merge vertically, if applicable.</param>
        /// <param name="pageSize">The page size for the output file, if applicable.</param>
        /// <param name="dcIsLandscape">Indicates whether the output file should be in landscape orientation.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiMergePost (List<FileParameter> files, string inputType, string outputType, MergeImageType mergeType, int? horizontal, int? vertical, PageSize pageSize, bool? dcIsLandscape)
        {
    
            var path = "/pdf/webapi/merge";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
 if (mergeType != null) queryParams.Add("mergeType", ApiClient.ParameterToString(mergeType)); // query parameter
 if (horizontal != null) queryParams.Add("horizontal", ApiClient.ParameterToString(horizontal)); // query parameter
 if (vertical != null) queryParams.Add("vertical", ApiClient.ParameterToString(vertical)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
 if (dcIsLandscape != null) queryParams.Add("dc_isLandscape", ApiClient.ParameterToString(dcIsLandscape)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiMergePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiMergePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Read and change document metadata. Performs metadata operations on the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="operation">The operation to perform on the metadata.</param>
        /// <param name="folder">The folder where the files are located.</param>
        /// <param name="name">The name of the file to perform the operation on.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiMetadataPost (List<FileParameter> files, MetadataOperation operation, string folder, string name)
        {
    
            var path = "/pdf/webapi/metadata";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (operation != null) queryParams.Add("operation", ApiClient.ParameterToString(operation)); // query parameter
 if (folder != null) queryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiMetadataPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiMetadataPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Organize document pages. Organizes the provided documents by removing or moving specified pages.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="remove">The pages to remove from the document.</param>
        /// <param name="move">The pages to move within the document.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiOrganizePost (List<FileParameter> files, string inputType, string remove, string move)
        {
    
            var path = "/pdf/webapi/organize";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (remove != null) queryParams.Add("remove", ApiClient.ParameterToString(remove)); // query parameter
 if (move != null) queryParams.Add("move", ApiClient.ParameterToString(move)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiOrganizePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiOrganizePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Parse document. Parses the provided files using a parser service.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiParsePost (List<FileParameter> files)
        {
    
            var path = "/pdf/webapi/parse";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiParsePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiParsePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Redact document text. Redacts specified text from the provided documents, with options to search case-sensitively, target in text, comments, and metadata.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="searchQuery">The text to search for and redact.</param>
        /// <param name="replaceText">The text to replace the found text with.</param>
        /// <param name="caseSensitive">Indicates whether the search should be case-sensitive.</param>
        /// <param name="text">Indicates whether text should be redacted.</param>
        /// <param name="comments">Indicates whether comments should be redacted.</param>
        /// <param name="metadata">Indicates whether metadata should be redacted.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiRedactPost (List<FileParameter> files, string searchQuery, string replaceText, bool? caseSensitive, bool? text, bool? comments, bool? metadata)
        {
    
            var path = "/pdf/webapi/redact";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (searchQuery != null) queryParams.Add("searchQuery", ApiClient.ParameterToString(searchQuery)); // query parameter
 if (replaceText != null) queryParams.Add("replaceText", ApiClient.ParameterToString(replaceText)); // query parameter
 if (caseSensitive != null) queryParams.Add("caseSensitive", ApiClient.ParameterToString(caseSensitive)); // query parameter
 if (text != null) queryParams.Add("text", ApiClient.ParameterToString(text)); // query parameter
 if (comments != null) queryParams.Add("comments", ApiClient.ParameterToString(comments)); // query parameter
 if (metadata != null) queryParams.Add("metadata", ApiClient.ParameterToString(metadata)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRedactPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRedactPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Remove stored files. Removes processed files from storage.
        /// </summary>
        /// <param name="id">The ID of the processing to remove.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiRemoveIdPost (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PdfWebapiRemoveIdPost");
    
            var path = "/pdf/webapi/remove/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemoveIdPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemoveIdPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Remove document annotations. Removes annotations from the provided documents.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiRemovePost (List<FileParameter> files)
        {
    
            var path = "/pdf/webapi/remove";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemovePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemovePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Removes document watermark. Removes a watermark from the document pages.
        /// </summary>
        /// <param name="watermarkText"></param>
        /// <param name="top"></param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="right"></param>
        /// <param name="files"></param>
        /// <param name="isAllPages">Indicates whether the watermark should be removed from all pages.</param>
        /// <param name="watermarkType">The type of watermark to remove.</param>
        /// <param name="removeRange">The range of pages to remove the watermark from.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiRemoveWatermarkPost (string watermarkText, int? top, int? left, int? bottom, int? right, List<FileParameter> files, bool? isAllPages, WatermarkType watermarkType, string removeRange)
        {
    
            var path = "/pdf/webapi/remove-watermark";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (isAllPages != null) queryParams.Add("isAllPages", ApiClient.ParameterToString(isAllPages)); // query parameter
 if (watermarkType != null) queryParams.Add("watermarkType", ApiClient.ParameterToString(watermarkType)); // query parameter
 if (removeRange != null) queryParams.Add("removeRange", ApiClient.ParameterToString(removeRange)); // query parameter
                        if (watermarkText != null) formParams.Add("watermarkText", ApiClient.ParameterToString(watermarkText)); // form parameter
if (top != null) formParams.Add("top", ApiClient.ParameterToString(top)); // form parameter
if (left != null) formParams.Add("left", ApiClient.ParameterToString(left)); // form parameter
if (bottom != null) formParams.Add("bottom", ApiClient.ParameterToString(bottom)); // form parameter
if (right != null) formParams.Add("right", ApiClient.ParameterToString(right)); // form parameter
if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemoveWatermarkPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemoveWatermarkPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Remove pages from document. Removes specified pages from the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="removeRange">The range of pages to remove from the files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiRemovepagesPost (List<FileParameter> files, string removeRange)
        {
    
            var path = "/pdf/webapi/removepages";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (removeRange != null) queryParams.Add("removeRange", ApiClient.ParameterToString(removeRange)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemovepagesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRemovepagesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Repair document. Repairs the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiRepairPost (List<FileParameter> files)
        {
    
            var path = "/pdf/webapi/repair";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRepairPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRepairPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Resize document. Resizes the provided files to the specified dimensions or using a preset size.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="resizeType">The type of resizing to apply.</param>
        /// <param name="presetType">The type of preset size to use for resizing.</param>
        /// <param name="presetSize">The preset size to use for resizing.</param>
        /// <param name="width">The desired width of the resized files.</param>
        /// <param name="height">The desired height of the resized files.</param>
        /// <param name="percentage">The percentage to resize the files by.</param>
        /// <param name="useProportions">Indicates whether to maintain the aspect ratio when resizing.</param>
        /// <param name="pageSize">The page size to use for the resized files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiResizePost (List<FileParameter> files, string inputType, string outputType, ResizeType resizeType, ResizePresetType presetType, ResizePresetSize presetSize, int? width, int? height, int? percentage, bool? useProportions, ResizePageSize pageSize)
        {
    
            var path = "/pdf/webapi/resize";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
 if (resizeType != null) queryParams.Add("resizeType", ApiClient.ParameterToString(resizeType)); // query parameter
 if (presetType != null) queryParams.Add("presetType", ApiClient.ParameterToString(presetType)); // query parameter
 if (presetSize != null) queryParams.Add("presetSize", ApiClient.ParameterToString(presetSize)); // query parameter
 if (width != null) queryParams.Add("width", ApiClient.ParameterToString(width)); // query parameter
 if (height != null) queryParams.Add("height", ApiClient.ParameterToString(height)); // query parameter
 if (percentage != null) queryParams.Add("percentage", ApiClient.ParameterToString(percentage)); // query parameter
 if (useProportions != null) queryParams.Add("useProportions", ApiClient.ParameterToString(useProportions)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiResizePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiResizePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Rotate document. Rotates the provided files by a specified angle, with options for rotation type and page number.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="angle">The angle by which to rotate the files.</param>
        /// <param name="rotateType">The type of rotation to perform.</param>
        /// <param name="pageNum">The page number to rotate, if applicable.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiRotatePost (List<FileParameter> files, RotateAngle angle, RotateType rotateType, string pageNum)
        {
    
            var path = "/pdf/webapi/rotate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (angle != null) queryParams.Add("angle", ApiClient.ParameterToString(angle)); // query parameter
 if (rotateType != null) queryParams.Add("rotateType", ApiClient.ParameterToString(rotateType)); // query parameter
 if (pageNum != null) queryParams.Add("pageNum", ApiClient.ParameterToString(pageNum)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRotatePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiRotatePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Search document text. Searches the provided files for the specified query and makr found text with yellow background.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="query">The text to search for within the files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiSearchPost (List<FileParameter> files, string query)
        {
    
            var path = "/pdf/webapi/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSearchPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Make scanned pdf searchable. Converts the provided files into a searchable PDF format for the specified language.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="lang">The language of the files to be converted.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiSearchablePost (List<FileParameter> files, string lang)
        {
    
            var path = "/pdf/webapi/searchable";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lang != null) queryParams.Add("lang", ApiClient.ParameterToString(lang)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSearchablePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSearchablePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Add signature to document. Adds a signature, text and image to the provided documents.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="text"></param>
        /// <param name="textColor"></param>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="signatureType">The type of signature to add.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiSignaturePost (string image, string text, string textColor, List<FileParameter> files, string inputType, string outputType, SignatureType signatureType)
        {
    
            var path = "/pdf/webapi/signature";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
 if (signatureType != null) queryParams.Add("signatureType", ApiClient.ParameterToString(signatureType)); // query parameter
                        if (image != null) formParams.Add("image", ApiClient.ParameterToString(image)); // form parameter
if (text != null) formParams.Add("text", ApiClient.ParameterToString(text)); // form parameter
if (textColor != null) formParams.Add("textColor", ApiClient.ParameterToString(textColor)); // form parameter
if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSignaturePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSignaturePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Split document. Splits the provided documents based on the specified split type and page rage to spit.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="splitType">The type of splitting to be performed.</param>
        /// <param name="pairs">Optional page rage for the splitting operation.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiSplitdocPost (List<FileParameter> files, SplitDocType splitType, string pairs)
        {
    
            var path = "/pdf/webapi/splitdoc";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (splitType != null) queryParams.Add("splitType", ApiClient.ParameterToString(splitType)); // query parameter
 if (pairs != null) queryParams.Add("pairs", ApiClient.ParameterToString(pairs)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSplitdocPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSplitdocPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Split image. Splits the provided images into smaller parts based on the specified parameters.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="splitType">The type of splitting to be performed.</param>
        /// <param name="vertical">The number of vertical splits to create.</param>
        /// <param name="horizontal">The number of horizontal splits to create.</param>
        /// <param name="outputType">The desired output format for the split images.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiSplitimagePost (List<FileParameter> files, SplitImageType splitType, int? vertical, int? horizontal, string outputType)
        {
    
            var path = "/pdf/webapi/splitimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (splitType != null) queryParams.Add("splitType", ApiClient.ParameterToString(splitType)); // query parameter
 if (vertical != null) queryParams.Add("vertical", ApiClient.ParameterToString(vertical)); // query parameter
 if (horizontal != null) queryParams.Add("horizontal", ApiClient.ParameterToString(horizontal)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSplitimagePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiSplitimagePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Processing status. Retrieves the status of a processing.
        /// </summary>
        /// <param name="id">The ID of the processing to check the status of.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiStatusIdPost (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PdfWebapiStatusIdPost");
    
            var path = "/pdf/webapi/status/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiStatusIdPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiStatusIdPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Unlock document. Attempts to unlock a document with an password and associated files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="passw">The password used in locked document.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiUnlockPost (List<FileParameter> files, string passw)
        {
    
            var path = "/pdf/webapi/unlock";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (passw != null) queryParams.Add("passw", ApiClient.ParameterToString(passw)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiUnlockPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiUnlockPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Verify document certificate. Verifies the electronic signature of the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiVerifyEsignPost (List<FileParameter> files, string inputType)
        {
    
            var path = "/pdf/webapi/verify_esign";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiVerifyEsignPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiVerifyEsignPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Add watermark to document. Adds a watermark to the provided files.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <param name="outputType">The desired format for the output files.</param>
        /// <param name="isColored">Indicate is watermark will be in color or grayscale.</param>
        /// <param name="isText">Indicates whether the watermark is text.</param>
        /// <param name="text">The text of the watermark.</param>
        /// <param name="name">The name of the font for the text watermark.</param>
        /// <param name="size">The size of the font for the text watermark.</param>
        /// <param name="bold">Indicates whether the text watermark is bold.</param>
        /// <param name="italic">Indicates whether the text watermark is italic.</param>
        /// <param name="underlined">Indicates whether the text watermark is underlined.</param>
        /// <param name="color">The color of the text or image watermark.</param>
        /// <param name="isBackground">Indicates whether the watermark is a background watermark.</param>
        /// <param name="rotation">The rotation angle of the watermark.</param>
        /// <param name="transparency">The transparency of the watermark.</param>
        /// <param name="layer">Indicates whether the watermark is a layer.</param>
        /// <param name="pageFrom">The starting page number for the watermark.</param>
        /// <param name="pageTo">The ending page number for the watermark.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiWatermarkPost (List<FileParameter> files, string inputType, string outputType, bool? isColored, bool? isText, string text, string name, int? size, bool? bold, bool? italic, bool? underlined, string color, bool? isBackground, int? rotation, float? transparency, bool? layer, int? pageFrom, int? pageTo)
        {
    
            var path = "/pdf/webapi/watermark";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
 if (outputType != null) queryParams.Add("outputType", ApiClient.ParameterToString(outputType)); // query parameter
 if (isColored != null) queryParams.Add("isColored", ApiClient.ParameterToString(isColored)); // query parameter
 if (isText != null) queryParams.Add("isText", ApiClient.ParameterToString(isText)); // query parameter
 if (text != null) queryParams.Add("text", ApiClient.ParameterToString(text)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (size != null) queryParams.Add("size", ApiClient.ParameterToString(size)); // query parameter
 if (bold != null) queryParams.Add("bold", ApiClient.ParameterToString(bold)); // query parameter
 if (italic != null) queryParams.Add("italic", ApiClient.ParameterToString(italic)); // query parameter
 if (underlined != null) queryParams.Add("underlined", ApiClient.ParameterToString(underlined)); // query parameter
 if (color != null) queryParams.Add("color", ApiClient.ParameterToString(color)); // query parameter
 if (isBackground != null) queryParams.Add("isBackground", ApiClient.ParameterToString(isBackground)); // query parameter
 if (rotation != null) queryParams.Add("rotation", ApiClient.ParameterToString(rotation)); // query parameter
 if (transparency != null) queryParams.Add("transparency", ApiClient.ParameterToString(transparency)); // query parameter
 if (layer != null) queryParams.Add("layer", ApiClient.ParameterToString(layer)); // query parameter
 if (pageFrom != null) queryParams.Add("pageFrom", ApiClient.ParameterToString(pageFrom)); // query parameter
 if (pageTo != null) queryParams.Add("pageTo", ApiClient.ParameterToString(pageTo)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiWatermarkPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiWatermarkPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Count words and chars in document. Counts the words in the provided files within the specified page range.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="pageRange">The range of pages to count words in.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiWordcounterPost (List<FileParameter> files, string pageRange)
        {
    
            var path = "/pdf/webapi/wordcounter";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pageRange != null) queryParams.Add("pageRange", ApiClient.ParameterToString(pageRange)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiWordcounterPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiWordcounterPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
        /// <summary>
        /// Convert XFA format to a another format. Converts the provided documents from XFA format to a different format.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="inputType">The format of the input files.</param>
        /// <returns>FileResponse</returns>
        public FileResponse PdfWebapiXfaconvertPost (List<FileParameter> files, string inputType)
        {
    
            var path = "/pdf/webapi/xfaconvert";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (inputType != null) queryParams.Add("inputType", ApiClient.ParameterToString(inputType)); // query parameter
                        if (files != null) fileParams = files.ToDictionary(f => f.FileName, f => f); // file parameters

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiXfaconvertPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfWebapiXfaconvertPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FileResponse) ApiClient.Deserialize(response.Content, typeof(FileResponse), response.Headers);
        }
    
    }
}
