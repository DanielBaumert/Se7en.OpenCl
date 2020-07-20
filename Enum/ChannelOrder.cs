namespace Se7en.OpenCl
{
    public enum ChannelOrder
    {
        /// <summary>
        ///  Single channel image formats where the single channel represents a RED component.
        /// </summary>
        R = 0x10B0,
        /// <summary>
        /// Single channel image formats where the single channel represents a ALPHA component.
        /// </summary>
        A = 0x10B1,
        /// <summary>
        /// A single channel image format where the single channel represents a DEPTH component.
        /// </summary>
        Depth = 0x10BD,
        /// <summary>
        /// A single channel image format where the single channel represents a LUMINANCE value.<br/>
        /// The LUMINANCE value is replicated into the RED, GREEN, and BLUE components.
        /// </summary>
        Luminance = 0x10B9,
        /// <summary>
        /// A single channel image format where the single channel represents an INTENSITY value.<br/>
        /// The INTENSITY value is replicated into the RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        Intensity = 0x10B8,
        /// <summary>
        /// Two channel image formats. The first channel always represents a RED component.<br/>
        /// The second channel represents a GREEN component.
        /// </summary>
        RG = 0x10B2,
        /// <summary>
        /// Two channel image formats. The first channel always represents a RED component.<br/>
        /// The second channel represents a ALPHA component
        /// </summary>
        RA = 0x10B3,
        /// <summary>
        /// A two channel image format, where the first channel represents a RED component and the second channel is ignored.
        /// </summary>
        Rx = 0x10BA,
        /// <summary>
        /// A three channel image format, where the three channels represent RED, GREEN, and BLUE components.
        /// </summary>
        RGB = 0x10B4,
        /// <summary>
        /// A three channel image format, where the first two channels represent RED and GREEN components and the third channel is ignored.
        /// </summary>
        RGx = 0x10BB,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        RGBA = 0x10B5,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        ARGB = 0x10B7,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        BGRA = 0x10B6,
        /// <summary>
        /// Four channel image formats, where the four channels represent RED, GREEN, BLUE, and ALPHA components.
        /// </summary>
        ABGR = 0x10C3,
        /// <summary>
        /// A four channel image format, where the first three channels represent RED, GREEN, and BLUE components and the fourth channel is ignored.
        /// </summary>
        RGBx = 0x10BC,
        /// <summary>
        /// 
        /// </summary>
        DepthStencil = 0x10BE,
        /// <summary>
        /// A three channel image format, where the three channels represent RED, GREEN, and BLUE components in the sRGB color space.
        /// </summary>
        sRGB = 0x10BF,
        /// <summary>
        /// Four channel image formats, where the first three channels represent RED, GREEN, and BLUE components in the sRGB color space.<br/>
        /// The fourth channel represents an ALPHA component.
        /// </summary>
        sRGBA = 0x10C1,
        /// <summary>
        /// Four channel image formats, where the first three channels represent RED, GREEN, and BLUE components in the sRGB color space.<br/>
        /// The fourth channel represents an ALPHA component.
        /// </summary>
        sBGRA = 0x10C2,
        /// <summary>
        /// A four channel image format, where the three channels represent RED, GREEN, and BLUE components in the sRGB color space.<br/>
        /// The fourth channel is ignored.
        /// </summary>
        sRGBx = 0x10C0,
    }
}