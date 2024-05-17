using System.Text.Json.Serialization;

namespace IO.Swagger.Model {

    ///<summary>
    /// FileProcessingErrorCode enum 
    ///</summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FileProcessingErrorCode
    {
        ///<summary>
        /// OK
        ///</summary>
        OK = 0,
        ///<summary>
        /// NoImagesFound
        ///</summary>
        NoImagesFound = 10000,
        ///<summary>
        /// NoSearchResults
        ///</summary>
        NoSearchResults = 10001,
        ///<summary>
        /// WrongRegExp
        ///</summary>
        WrongRegExp = 10002,
    }
}
