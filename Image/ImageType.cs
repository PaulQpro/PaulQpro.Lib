namespace PaulQpro.Lib.Image
{
    public enum ImageType
    {
        /// <summary>
        /// Black/White image
        /// </summary>
        g1,
        /// <summary>
        /// Gray 2 bits per pixel
        /// </summary>
        g2,
        /// <summary>
        /// Gray 4 bits per pixel
        /// </summary>
        g4,
        /// <summary>
        /// Gray 8 bits per pixel (True Gray Scale)
        /// </summary>
        g8,
        /// <summary>
        /// 1 bit per color, 3 bits per pixel
        /// </summary>
        c3,
        /// <summary>
        /// 2 bit per color, 6 bits per pixel
        /// </summary>
        c6,
        /// <summary>
        /// 4 bit per color, 12 bits per pixel
        /// </summary>
        c12,
        /// <summary>
        /// 8 bit per color, 24 bits per pixel (True Color)
        /// </summary>
        c24
    }
}
