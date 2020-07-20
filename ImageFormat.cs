using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{
    public struct ImageFormat
    {
        /// <summary>
        /// Specifies the number of channels and the channel layout i.e. the memory layout in which channels are stored in the image.<br/>
        /// Valid values are described in the Image Channel Order table.
        /// </summary>
        ChannelOrder ChannelOrder;
        /// <summary>
        /// describes the size of the channel data type.<br/>
        /// The list of supported values is described in the Image Channel Data Types table.<br/>
        /// The number of bits per element determined by the image_channel_data_type and image_channel_order must be a power of two.
        /// </summary>
        ChannelTypes ChannelDataTypes;
        /// <summary>
        /// Create a new ImageFormat
        /// </summary>
        /// <param name="channelOrder">
        /// Specifies the number of channels and the channel layout i.e. the memory layout in which channels are stored in the image.<br/>
        /// Valid values are described in the Image Channel Order table.
        /// </param>
        /// <param name="channeldataTypes">
        /// describes the size of the channel data type.<br/>
        /// The list of supported values is described in the Image Channel Data Types table.<br/>
        /// The number of bits per element determined by the image_channel_data_type and image_channel_order must be a power of two.
        /// </param>
        public ImageFormat(ChannelOrder channelOrder, ChannelTypes channeldataTypes)
        {
            ChannelOrder = channelOrder;
            ChannelDataTypes = channeldataTypes;
        }

        private static ImageFormat[] _imageFormats;
        public static unsafe ref readonly ImageFormat[] GetSupportedImageFormats(Context context, MemFlags flags, MemObjectType type)
        {
            if (_imageFormats == null)
            {
                ErrorCode error;
                if ((error = (ErrorCode)NativeCl.GetSupportedImageFormats(context._handle, (uint)flags, (uint)type, 0, null, out uint size)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                _imageFormats = new ImageFormat[size];

                fixed (ImageFormat* valuePtr = _imageFormats)
                {
                    if ((error = (ErrorCode)NativeCl.GetSupportedImageFormats(context._handle, (uint)flags, (uint)type, size, valuePtr, out _)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }
                }
            }
            return ref _imageFormats;
        }
    }
}