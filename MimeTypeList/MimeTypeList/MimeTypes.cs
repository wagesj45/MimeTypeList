using MimeTypeList.MimeTypeNamespaces;
namespace MimeTypeList
{
    /// <summary> A list of mime types organized by namespace. </summary>
    public static class MimeTypes
    {
        /// <summary> Application mime type namespace. </summary>
        public static readonly ApplicationMimeType application = new ApplicationMimeType();
        /// <summary> Audio mime type namespace. </summary>
        public static readonly AudioMimeType audio = new AudioMimeType();
        /// <summary> Image mime type namespace. </summary>
        public static readonly ImageMimeType image = new ImageMimeType();
        /// <summary> Message mime type namespace. </summary>
        public static readonly MessageMimeType message = new MessageMimeType();
        /// <summary> Text mime type namespace. </summary>
        public static readonly TextMimeType text = new TextMimeType();
        /// <summary> Video mime type namespace. </summary>
        public static readonly VideoMimeType video = new VideoMimeType();
        /// <summary> X-World mime type namespace. </summary>
        public static readonly XWorldMimeType x_world = new XWorldMimeType();
    }
}