namespace Se7en.OpenCl
{
    public enum ChannelTypes
    {
        /// <summary>
        /// Each channel component is a normalized signed 8-bit integer value
        /// </summary>
        SNormInt8 = 0x10d0,
        /// <summary>
        /// Each channel component is a normalized signed 16-bit integer value
        /// </summary>
        SNormInt16 = 0x10d1,
        /// <summary>
        /// Each channel component is a normalized unsigned 8-bit integer value
        /// </summary>
        UNormInt8 = 0x10d2,
        /// <summary>
        /// Each channel component is a normalized unsigned 16-bit integer value
        /// </summary>
        UNormInt16 = 0x10d3,
        /// <summary>
        /// Represents a normalized 5-6-5 3-channel RGB image.<br/>
        /// The channel order must be CL_​RGB or CL_​RGBx.
        /// </summary>
        UNormShort565 = 0x10d4,
        /// <summary>
        /// Represents a normalized x-5-5-5 4-channel xRGB image.<br/>
        /// The channel order must be CL_​RGB or CL_​RGBx.
        /// </summary>
        UNormShort555 = 0x10d5,
        /// <summary>
        /// Represents a normalized x-10-10-10 4-channel xRGB image.<br/>
        /// The channel order must be CL_​RGB or CL_​RGBx.
        /// </summary>
        UNormInt101010 = 0x10d6,
        /// <summary>
        /// Represents a normalized 10-10-10-2 four-channel RGBA image.<br/>
        /// The channel order must be CL_​RGBA.
        /// </summary>
        UNormInt1010102 = 0x10E0,
        /// <summary>
        /// Each channel component is an unnormalized signed 8-bit integer value
        /// </summary>
        SignedInt8 = 0x10D7,
        /// <summary>
        /// Each channel component is an unnormalized signed 16-bit integer value
        /// </summary>
        SignedInt16 = 0x10D8,
        /// <summary>
        /// Each channel component is an unnormalized signed 32-bit integer value
        /// </summary>
        SignedInt32 = 0x10D9,
        /// <summary>
        /// Each channel component is an unnormalized unsigned 8-bit integer value
        /// </summary>
        UnsignedInt8 = 0x10DA,
        /// <summary>
        /// Each channel component is an unnormalized unsigned 16-bit integer value
        /// </summary>
        UnsignedInt16 = 0x10DB,
        /// <summary>
        /// Each channel component is an unnormalized unsigned 24-bit integer value
        /// </summary>
        UnsignedInt24 = 0x10DF,
        /// <summary>
        /// Each channel component is an unnormalized unsigned 32-bit integer value
        /// </summary>
        UnsignedInt32 = 0x10DC,
        /// <summary>
        /// Each channel component is a 16-bit half-float value
        /// </summary>
        HalfFloat = 0x10DD,
        /// <summary>
        /// Each channel component is a single precision floating-point value
        /// </summary>
        Float = 0x10DE,
    }
}