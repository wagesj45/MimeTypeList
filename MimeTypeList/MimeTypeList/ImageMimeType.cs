namespace MimeTypeList.MimeTypeNamespaces
{
    /// <summary> Image mime type namespace. </summary>
    public class ImageMimeType
    {
        /// <summary> image/bmp </summary>
        public readonly string bmp = ".bmp";

        /// <summary> image/jpeg </summary>
        public readonly string jpeg = ".jpg";

        /// <summary> image/pict </summary>
        public readonly string pict = ".pic";

        /// <summary> image/png </summary>
        /// <remarks>Defined in [RFC-2045], [RFC-2048]</remarks>
        public readonly string png = ".png";

        /// <summary> image/x-png </summary>
        /// <remarks>See https://www.w3.org/TR/PNG/#A-Media-type :"It is recommended that implementations also recognize the media type "image/x-png"."</remarks>
        public readonly string x_png = ".png";

        /// <summary> image/tiff </summary>
        public readonly string tiff = ".tiff";

        /// <summary> image/x-macpaint </summary>
        public readonly string x_macpaint = ".mac";

        /// <summary> image/x-quicktime </summary>
        public readonly string x_quicktime = ".qti";

        /// <summary> Internal default constructor. </summary>
        internal ImageMimeType()
        {
            //
        }
    }
}