namespace MimeTypeList.MimeTypeNamespaces
{
    /// <summary> Text mime type namespace. </summary>
    public class TextMimeType
    {
        /// <summary> text/html </summary>
        public readonly string html = ".html";

        /// <summary> text/plain </summary>
        public readonly string plain = ".txt";

        /// <summary> text/scriptlet </summary>
        public readonly string scriptlet = ".wsc";

        /// <summary> text/xml </summary>
        public readonly string xml = ".xml";

        /// <summary> Internal default constructor. </summary>
        internal TextMimeType()
        {
            //
        }
    }
}