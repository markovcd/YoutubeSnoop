namespace YoutubeSnoop.Api.Entities.Channels
{
    public class BrandingSettingsImage
    {
        /// <summary>
        /// The URL for the banner image shown on the channel page on the YouTube website. The image is 1060px by 175px.
        /// </summary>
        public string BannerImageUrl { get; set; }

        /// <summary>
        /// The URL for the banner image shown on the channel page in mobile applications. The image is 640px by 175px.
        /// </summary>
        public string BannerMobileImageUrl { get; set; }

        /// <summary>
        /// The URL for the image that appears above the video player. This is a 25-pixel-high image with a flexible width that cannot exceed 170 pixels. If you do not provide this image, your channel name will appear instead of an image.
        /// </summary>
        public string WatchIconImageUrl { get; set; }

        /// <summary>
        /// The URL for a 1px by 1px tracking pixel that can be used to collect statistics for views of the channel or video pages.
        /// </summary>
        public string TrackingImageUrl { get; set; }

        /// <summary>
        /// The URL for a low-resolution banner image that displays on the channel page in tablet applications. The image's maximum size is 1138px by 188px.
        /// </summary>
        public string BannerTabletLowImageUrl { get; set; }

        /// <summary>
        /// The URL for a banner image that displays on the channel page in tablet applications. The image is 1707px by 283px.
        /// </summary>
        public string BannerTabletImageUrl { get; set; }

        /// <summary>
        /// The URL for a high-resolution banner image that displays on the channel page in tablet applications. The image's maximum size is 2276px by 377px.
        /// </summary>
        public string BannerTabletHdImageUrl { get; set; }

        /// <summary>
        /// The URL for an extra-high-resolution banner image that displays on the channel page in tablet applications. The image's maximum size is 2560px by 424px.
        /// </summary>
        public string BannerTabletExtraHdImageUrl { get; set; }

        /// <summary>
        /// The URL for a low-resolution banner image that displays on the channel page in mobile applications. The image's maximum size is 320px by 88px.
        /// </summary>
        public string BannerMobileLowImageUrl { get; set; }

        /// <summary>
        /// The URL for a medium-resolution banner image that displays on the channel page in mobile applications. The image's maximum size is 960px by 263px.
        /// </summary>
        public string BannerMobileMediumHdImageUrl { get; set; }

        /// <summary>
        /// The URL for a high-resolution banner image that displays on the channel page in mobile applications. The image's maximum size is 1280px by 360px.
        /// </summary>
        public string BannerMobileHdImageUrl { get; set; }

        /// <summary>
        /// The URL for a very high-resolution banner image that displays on the channel page in mobile applications. The image's maximum size is 1440px by 395px.
        /// </summary>
        public string BannerMobileExtraHdImageUrl { get; set; }

        /// <summary>
        /// The URL for an extra-high-resolution banner image that displays on the channel page in television applications. The image's maximum size is 2120px by 1192px.
        /// </summary>
        public string BannerTvImageUrl { get; set; }

        /// <summary>
        /// The URL for a low-resolution banner image that displays on the channel page in television applications. The image's maximum size is 854px by 480px.
        /// </summary>
        public string BannerTvLowImageUrl { get; set; }

        /// <summary>
        /// The URL for a medium-resolution banner image that displays on the channel page in television applications. The image's maximum size is 1280px by 720px.
        /// </summary>
        public string BannerTvMediumImageUrl { get; set; }

        /// <summary>
        /// The URL for a high-resolution banner image that displays on the channel page in television applications. The image's maximum size is 1920px by 1080px.
        /// </summary>
        public string BannerTvHighImageUrl { get; set; }
    }
}