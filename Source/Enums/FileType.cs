namespace YoutubeSnoop.Enums
{
    public enum FileType
    {
        /// <summary>
        /// The file is an archive file, such as a .zip archive.
        /// </summary>
        Archive,

        /// <summary>
        /// The file is a known audio file type, such as an .mp3 file.
        /// </summary>
        Audio,

        /// <summary>
        /// The file is a document or text file, such as a MS Word document.
        /// </summary>
        Document,

        /// <summary>
        /// The file is an image file, such as a .jpeg image.
        /// </summary>
        Image,

        /// <summary>
        /// The file is another non-video file type.
        /// </summary>
        Other,

        /// <summary>
        /// The file is a video project file, such as a Microsoft Windows Movie Maker project, that does not contain actual video data.
        /// </summary>
        Project,

        /// <summary>
        /// The file is a known video file type, such as an .mp4 file.
        /// </summary>
        Video
    }
}