using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{
    public unsafe class Device : Handle
    {
        private DeviceType _Type;
        /// <summary>
        /// A unique device vendor identifier.<br/>
        /// An example of a unique device identifier could be the PCIe ID.
        /// </summary>
        public ref readonly DeviceType Type => ref GetOrUpdateUnmanaged<DeviceType, DeviceInfo, uint>(ref _Type, DeviceInfo.Type, NativeCl.GetDeviceInfo);

        private uint _VendorId;
        /// <summary>
        /// A unique device vendor identifier.<br/>
        /// An example of a unique device identifier could be the PCIe ID.
        /// </summary>
        public ref readonly uint VendorId => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _VendorId, DeviceInfo.VendorId, NativeCl.GetDeviceInfo);

        private uint _MaxComputeUnits;
        /// <summary>
        /// The number of parallel compute units on the OpenCL device.<br/>
        /// A work-group executes on a single compute unit.<br/>
        /// The minimum value is 1.
        /// </summary>
        public ref readonly uint MaxComputeUnits => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxComputeUnits, DeviceInfo.MaxComputeUnits, NativeCl.GetDeviceInfo);

        private uint _MaxWorkItemDimensions;
        /// <summary>
        /// Maximum dimensions that specify the global and local work-item IDs used by the data parallel execution model.<br/>
        /// (Refer to clEnqueueNDRangeKernel).<br/>
        /// The minimum value is 3 for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        public ref readonly uint MaxWorkItemDimensions => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxWorkItemDimensions, DeviceInfo.MaxWorkItemDimensions, NativeCl.GetDeviceInfo);

        private uint _MaxWorkItemSizes;
        /// <summary>
        /// Maximum number of work-items that can be specified in each dimension of the work-group to clEnqueueNDRangeKernel.<br/>
        /// Returns n int entries, where n is the value returned by the query for CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS.<br/>
        /// The minimum value is (1, 1, 1) for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        public ref readonly uint MaxWorkItemSizes => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxWorkItemSizes, DeviceInfo.MaxWorkItemSizes, NativeCl.GetDeviceInfo);

        private int _MaxWorkGroupSize;
        /// <summary>
        /// Maximum number of work-items in a work-group that a device is capable of executing on a single compute unit, for any given kernel-instance running on the device.<br/>
        /// (Refer also to clEnqueueNDRangeKernel and CL_KERNEL_WORK_GROUP_SIZE ).<br/>
        /// The minimum value is 1.<br/>
        /// The returned value is an upper limit and will not necessarily maximize performance.<br/>
        /// This maximum may be larger than supported by a specific kernel (refer to the CL_KERNEL_WORK_GROUP_SIZE query of clGetKernelWorkGroupInfo).
        /// </summary>
        public ref readonly int MaxWorkGroupSize => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _MaxWorkGroupSize, DeviceInfo.MaxWorkGroupSize, NativeCl.GetDeviceInfo);

        private uint _PreferredVectorWidthChar;
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint PreferredVectorWidthChar => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredVectorWidthChar, DeviceInfo.PreferredVectorWidthChar, NativeCl.GetDeviceInfo);

        private uint _PreferredVectorWidthShort;
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint PreferredVectorWidthShort => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredVectorWidthShort, DeviceInfo.PreferredVectorWidthShort, NativeCl.GetDeviceInfo);

        private uint _PreferredVectorWidthInt;
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint PreferredVectorWidthInt => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredVectorWidthInt, DeviceInfo.PreferredVectorWidthInt, NativeCl.GetDeviceInfo);

        private uint _PreferredVectorWidthLong;
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint PreferredVectorWidthLong => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredVectorWidthLong, DeviceInfo.PreferredVectorWidthLong, NativeCl.GetDeviceInfo);

        private uint _PreferredVectorWidthFloat;
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint PreferredVectorWidthFloat => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredVectorWidthFloat, DeviceInfo.PreferredVectorWidthFloat, NativeCl.GetDeviceInfo);

        private uint _PreferredVectorWidthDouble;
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint PreferredVectorWidthDouble => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredVectorWidthDouble, DeviceInfo.PreferredVectorWidthDouble, NativeCl.GetDeviceInfo);

        private uint _PreferredVectorWidthHalf;
        /// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint PreferredVectorWidthHalf => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredVectorWidthHalf, DeviceInfo.PreferredVectorWidthHalf, NativeCl.GetDeviceInfo);

        private uint _NativeVectorWidthChar;
        /// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint NativeVectorWidthChar => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _NativeVectorWidthChar, DeviceInfo.NativeVectorWidthChar, NativeCl.GetDeviceInfo);

        private uint _NativeVectorWidthShort;
        /// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint NativeVectorWidthShort => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _NativeVectorWidthShort, DeviceInfo.NativeVectorWidthShort, NativeCl.GetDeviceInfo);

        private uint _NativeVectorWidthInt;
        /// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint NativeVectorWidthInt => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _NativeVectorWidthInt, DeviceInfo.NativeVectorWidthInt, NativeCl.GetDeviceInfo);

        private uint _NativeVectorWidthLong;
        /// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint NativeVectorWidthLong => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _NativeVectorWidthLong, DeviceInfo.NativeVectorWidthLong, NativeCl.GetDeviceInfo);

        private uint _NativeVectorWidthFloat;
        /// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint NativeVectorWidthFloat => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _NativeVectorWidthFloat, DeviceInfo.NativeVectorWidthFloat, NativeCl.GetDeviceInfo);

        private uint _NativeVectorWidthDouble;
        /// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint NativeVectorWidthDouble => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _NativeVectorWidthDouble, DeviceInfo.NativeVectorWidthDouble, NativeCl.GetDeviceInfo);

        private uint _NativeVectorWidthHalf;
        /// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<br/>
        /// If double precision is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF must return 0.
        /// </summary>
        public ref readonly uint NativeVectorWidthHalf => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _NativeVectorWidthHalf, DeviceInfo.NativeVectorWidthHalf, NativeCl.GetDeviceInfo);
        private uint _MaxClockFrequency;

        /// <summary>
        /// Clock frequency of the device in MHz.<br/>
        /// The meaning of this value is implementation-defined.<br/>
        /// For devices with multiple clock domains, the clock frequency for any of the clock domains may be returned.<br/>
        /// For devices that dynamically change frequency for power or thermal reasons, the returned clock frequency may be any valid frequency.
        /// </summary>
        public ref readonly uint MaxClockFrequency => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxClockFrequency, DeviceInfo.MaxClockFrequency, NativeCl.GetDeviceInfo);
        private uint _AddressBits;
        /// <summary>
        /// The default compute device address space size of the global address space specified as an unsigned integer value in bits.<br/>
        /// Currently supported values are 32 or 64 bits.
        /// </summary>
        public ref readonly uint AddressBits => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _AddressBits, DeviceInfo.AddressBits, NativeCl.GetDeviceInfo);

        private ulong _MaxMemAllocSize;
        /// <summary>
        /// Max size of memory object allocation in bytes.<br/>
        /// The minimum value is max(min(1024 × 1024 × 1024, 1/4th of CL_DEVICE_GLOBAL_MEM_SIZE), 32 × 1024 × 1024) for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        public ref readonly ulong MaxMemAllocSize => ref GetOrUpdateUnmanaged<ulong, DeviceInfo, uint>(ref _MaxMemAllocSize, DeviceInfo.MaxMemAllocSize, NativeCl.GetDeviceInfo);

        private bool _ImageSupport;
        /// <summary>
        /// Is CL_TRUE if images are supported by the OpenCL device and CL_FALSE otherwise.
        /// </summary>
        public ref readonly bool ImageSupport => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _ImageSupport, DeviceInfo.ImageSupport, NativeCl.GetDeviceInfo);

        private uint _MaxReadImageArgs;
        /// <summary>
        /// Max number of image objects arguments of a kernel declared with the read_only qualifier.<br/>
        /// The minimum value is 128 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly uint MaxReadImageArgs => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxReadImageArgs, DeviceInfo.MaxReadImageArgs, NativeCl.GetDeviceInfo);

        private uint _MaxWriteImageArgs;
        /// <summary>
        /// Max number of image objects arguments of a kernel declared with the write_only qualifier.<br/>
        /// The minimum value is 64 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly uint MaxWriteImageArgs => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxWriteImageArgs, DeviceInfo.MaxWriteImageArgs, NativeCl.GetDeviceInfo);

        private uint _MaxReadWriteImageArgs;
        /// <summary>
        /// Max number of image objects arguments of a kernel declared with the write_only or read_write qualifier.<br/>
        /// The minimum value is 64 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly uint MaxReadWriteImageArgs => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxReadWriteImageArgs, DeviceInfo.MaxReadWriteImageArgs, NativeCl.GetDeviceInfo);

        private string _IlVersion;
        /// <summary>
        /// The intermediate languages that can be supported by clCreateProgramWithIL for this device.<br/>
        /// Returns a space-separated list of IL version strings of the form <IL_Prefix>_<Major_Version>.<Minor_Version>.<br/>
        /// For OpenCL 2.2, SPIR-V is a required IL prefix.
        /// </summary>
        public ref readonly string IlVersion => ref GetOrUpdateString<DeviceInfo, uint>(ref _IlVersion, DeviceInfo.IlVersion, NativeCl.GetDeviceInfo);

        private int _Image2dMaxWidth;
        /// <summary>
        /// Max width of 2D image or 1D image not created from a buffer object in pixels.<br/>
        /// The minimum value is 16384 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly int Image2dMaxWidth => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _Image2dMaxWidth, DeviceInfo.Image2dMaxWidth, NativeCl.GetDeviceInfo);

        private int _Image2dMaxHeight;
        /// <summary>
        /// Max height of 2D image in pixels.<br/>
        /// The minimum value is 16384 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly int Image2dMaxHeight => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _Image2dMaxHeight, DeviceInfo.Image2dMaxHeight, NativeCl.GetDeviceInfo);

        private int _Image3dMaxWidth;
        /// <summary>
        /// Max width of 3D image in pixels.<br/>
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly int Image3dMaxWidth => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _Image3dMaxWidth, DeviceInfo.Image3dMaxWidth, NativeCl.GetDeviceInfo);

        private int _Image3dMaxHeight;
        /// <summary>
        /// Max height of 3D image in pixels.<br/>
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly int Image3dMaxHeight => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _Image3dMaxHeight, DeviceInfo.Image3dMaxHeight, NativeCl.GetDeviceInfo);

        private int _Image3dMaxDepth;
        /// <summary>
        /// Max depth of 3D image in pixels.<br/>
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly int Image3dMaxDepth => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _Image3dMaxDepth, DeviceInfo.Image3dMaxDepth, NativeCl.GetDeviceInfo);

        private int _ImageMaxBufferSize;
        /// <summary>
        /// Max number of pixels for a 1D image created from a buffer object.<br/>
        /// The minimum value is 65536 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly int ImageMaxBufferSize => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _ImageMaxBufferSize, DeviceInfo.ImageMaxBufferSize, NativeCl.GetDeviceInfo);

        private int _ImageMaxArraySize;
        /// <summary>
        /// Max number of images in a 1D or 2D image array.<br/>
        /// The minimum value is 2048 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly int ImageMaxArraySize => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _ImageMaxArraySize, DeviceInfo.ImageMaxArraySize, NativeCl.GetDeviceInfo);

        private uint _MaxSamplers;
        /// <summary>
        /// Maximum number of samplers that can be used in a kernel.<br/>
        /// The minimum value is 16 if CL_DEVICE_IMAGE_SUPPORT is CL_TRUE.
        /// </summary>
        public ref readonly uint MaxSamplers => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxSamplers, DeviceInfo.MaxSamplers, NativeCl.GetDeviceInfo);

        private uint _ImagePitchAlignment;
        /// <summary>
        /// The row pitch alignment size in pixels for 2D images created from a buffer.<br/>
        /// The value returned must be a power of 2.<br/>
        /// If the device does not support images, this value must be 0.
        /// </summary>
        public ref readonly uint ImagePitchAlignment => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _ImagePitchAlignment, DeviceInfo.ImagePitchAlignment, NativeCl.GetDeviceInfo);

        private uint _ImageBaseAddressAlignment;
        /// <summary>
        /// This query should be used when a 2D image is created from a buffer which was created using CL_MEM_USE_HOST_PTR.<br/>
        /// The value returned must be a power of 2.<br/>
        /// This query specifies the minimum alignment in pixels of the host_ptr specified to clCreateBuffer.<br/>
        /// If the device does not support images, this value must be 0.
        /// </summary>
        public ref readonly uint ImageBaseAddressAlignment => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _ImageBaseAddressAlignment, DeviceInfo.ImageBaseAddressAlignment, NativeCl.GetDeviceInfo);

        private uint _MaxPipeArgs;
        /// <summary>
        /// The maximum number of pipe objects that can be passed as arguments to a kernel.<br/>
        /// The minimum value is 16.
        /// </summary>
        public ref readonly uint MaxPipeArgs => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxPipeArgs, DeviceInfo.MaxPipeArgs, NativeCl.GetDeviceInfo);

        private uint _PipeMaxActiveReservations;
        /// <summary>
        /// The maximum number of reservations that can be active for a pipe per work-item in a kernel.<br/>
        /// A work-group reservation is counted as one reservation per work-item.<br/>
        /// The minimum value is 1.
        /// </summary>
        public ref readonly uint PipeMaxActiveReservations => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PipeMaxActiveReservations, DeviceInfo.PipeMaxActiveReservations, NativeCl.GetDeviceInfo);

        private uint _PipeMaxPacketSize;
        /// <summary>
        /// The maximum size of pipe packet in bytes.<br/>
        /// The minimum value is 1024 bytes.
        /// </summary>
        public ref readonly uint PipeMaxPacketSize => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PipeMaxPacketSize, DeviceInfo.PipeMaxPacketSize, NativeCl.GetDeviceInfo);

        private int _MaxParameterSize;
        /// <summary>
        /// Max size in bytes of all arguments that can be passed to a kernel.<br/>
        /// The minimum value is 1024 for devices that are not of type CL_DEVICE_TYPE_CUSTOM.<br/>
        /// For this minimum value, only a maximum of 128 arguments can be passed to a kernel
        /// </summary>
        public ref readonly int MaxParameterSize => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _MaxParameterSize, DeviceInfo.MaxParameterSize, NativeCl.GetDeviceInfo);

        private uint _MemBaseAddrAlign;
        /// <summary>
        /// Alignment requirement (in bits) for sub-buffer offsets.<br/>
        /// The minimum value is the size (in bits) of the largest OpenCL built-in data type supported by the device (long16 in FULL profile, long16 or int16 in EMBEDDED profile) for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        public ref readonly uint MemBaseAddrAlign => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MemBaseAddrAlign, DeviceInfo.MemBaseAddrAlign, NativeCl.GetDeviceInfo);

        private DeviceFPConfig _SingleFpConfig;
        /// <summary>
        /// Describes single precision floating-point capability of the device.<br/>
        /// This is a bit-field that describes one or more of the following values: CL_FP_DENORM - denorms are supported CL_FP_INF_NAN - INF and quiet NaNs are supported.<br/>
        /// CL_FP_ROUND_TO_NEAREST-- round to nearest even rounding mode supported CL_FP_ROUND_TO_ZERO - round to zero rounding mode supported CL_FP_ROUND_TO_INF - round to positive and negative infinity rounding modes supported CL_FP_FMA - IEEE754-2008 fused multiply-add is supported.<br/>
        /// CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT - divide and sqrt are correctly rounded as defined by the IEEE754 specification.<br/>
        /// CL_FP_SOFT_FLOAT - Basic floating-point operations (such as addition, subtraction, multiplication) are implemented in software.<br/>
        /// For the full profile, the mandated minimum floating-point capability for devices that are not of type CL_DEVICE_TYPE_CUSTOM is: CL_FP_ROUND_TO_NEAREST | CL_FP_INF_NAN.<br/>
        /// For the embedded profile, see the dedicated table.
        /// </summary>
        public ref readonly DeviceFPConfig SingleFpConfig => ref GetOrUpdateUnmanaged<DeviceFPConfig, DeviceInfo, uint>(ref _SingleFpConfig, DeviceInfo.SingleFpConfig, NativeCl.GetDeviceInfo);

        private DeviceFPConfig _DoubleFpConfig;
        /// <summary>
        /// Describes double precision floating-point capability of the OpenCL device.<br/>
        /// This is a bit-field that describes one or more of the following values: CL_FP_DENORM - denorms are supported CL_FP_INF_NAN - INF and NaNs are supported.<br/>
        /// CL_FP_ROUND_TO_NEAREST - round to nearest even rounding mode supported.<br/>
        /// CL_FP_ROUND_TO_ZERO - round to zero rounding mode supported.<br/>
        /// CL_FP_ROUND_TO_INF - round to positive and negative infinity rounding modes supported.<br/>
        /// CL_FP_FMA - IEEE754-2008 fused multiply-add is supported.<br/>
        /// CL_FP_SOFT_FLOAT - Basic floating-point operations (such as addition, subtraction, multiplication) are implemented in software.<br/>
        /// Double precision is an optional feature so the mandated minimum double precision floating-point capability is 0.<br/>
        /// If double precision is supported by the device, then the minimum double precision floating-point capability must be: CL_FP_FMA | CL_FP_ROUND_TO_NEAREST | CL_FP_INF_NAN | CL_FP_DENORM.
        /// </summary>
        public ref readonly DeviceFPConfig DoubleFpConfig => ref GetOrUpdateUnmanaged<DeviceFPConfig, DeviceInfo, uint>(ref _DoubleFpConfig, DeviceInfo.DoubleFpConfig, NativeCl.GetDeviceInfo);

        private DeviceMemCacheType _GlobalMemCacheType;
        /// <summary>
        /// Type of global memory cache supported.<br/>
        /// Valid values are: CL_NONE, CL_READ_ONLY_CACHE, and CL_READ_WRITE_CACHE.
        /// </summary>
        public ref readonly DeviceMemCacheType GlobalMemCacheType => ref GetOrUpdateUnmanaged<DeviceMemCacheType, DeviceInfo, uint>(ref _GlobalMemCacheType, DeviceInfo.GlobalMemCacheType, NativeCl.GetDeviceInfo);

        private uint _GlobalMemCachelineSize;
        /// <summary>
        /// Size of global memory cache line in bytes.
        /// </summary>
        public ref readonly uint GlobalMemCachelineSize => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _GlobalMemCachelineSize, DeviceInfo.GlobalMemCachelineSize, NativeCl.GetDeviceInfo);

        private ulong _GlobalMemCacheSize;
        /// <summary>
        /// Size of global memory cache in bytes.
        /// </summary>
        public ref readonly ulong GlobalMemCacheSize => ref GetOrUpdateUnmanaged<ulong, DeviceInfo, uint>(ref _GlobalMemCacheSize, DeviceInfo.GlobalMemCacheSize, NativeCl.GetDeviceInfo);

        private ulong _GlobalMemSize;
        /// <summary>
        /// Size of global device memory in bytes.
        /// </summary>
        public ref readonly ulong GlobalMemSize => ref GetOrUpdateUnmanaged<ulong, DeviceInfo, uint>(ref _GlobalMemSize, DeviceInfo.GlobalMemSize, NativeCl.GetDeviceInfo);

        private ulong _MaxConstantBufferSize;
        /// <summary>
        /// Max size in bytes of a constant buffer allocation.<br/>
        /// The minimum value is 64 KB for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        public ref readonly ulong MaxConstantBufferSize => ref GetOrUpdateUnmanaged<ulong, DeviceInfo, uint>(ref _MaxConstantBufferSize, DeviceInfo.MaxConstantBufferSize, NativeCl.GetDeviceInfo);

        private uint _MaxConstantArgs;
        /// <summary>
        /// Max number of arguments declared with the __constant qualifier in a kernel.<br/>
        /// The minimum value is 8 for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        public ref readonly uint MaxConstantArgs => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxConstantArgs, DeviceInfo.MaxConstantArgs, NativeCl.GetDeviceInfo);

        private int _MaxGlobalVariableSize;
        /// <summary>
        /// The maximum number of bytes of storage that may be allocated for any single variable in program scope or inside a function in an OpenCL kernel language declared in the global address space.<br/>
        /// The minimum value is 64 KB.
        /// </summary>
        public ref readonly int MaxGlobalVariableSize => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _MaxGlobalVariableSize, DeviceInfo.MaxGlobalVariableSize, NativeCl.GetDeviceInfo);

        private int _GlobalVariablePreferredTotalSize;
        /// <summary>
        /// Maximum preferred total size, in bytes, of all program variables in the global address space.<br/>
        /// This is a performance hint.<br/>
        /// An implementation may place such variables in storage with optimized device access.<br/>
        /// This query returns the capacity of such storage.<br/>
        /// The minimum value is 0.
        /// </summary>
        public ref readonly int GlobalVariablePreferredTotalSize => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _GlobalVariablePreferredTotalSize, DeviceInfo.GlobalVariablePreferredTotalSize, NativeCl.GetDeviceInfo);

        private DeviceLocalMemType _LocalMemType;
        /// <summary>
        /// Type of local memory supported.<br/>
        /// This can be set to CL_LOCAL implying dedicated local memory storage such as SRAM , or CL_GLOBAL.<br/>
        /// For custom devices, CL_NONE can also be returned indicating no local memory support.
        /// </summary>
        public ref readonly DeviceLocalMemType LocalMemType => ref GetOrUpdateUnmanaged<DeviceLocalMemType, DeviceInfo, uint>(ref _LocalMemType, DeviceInfo.LocalMemType, NativeCl.GetDeviceInfo);

        private ulong _LocalMemSize;
        /// <summary>
        /// Size of local memory region in bytes.<br/>
        /// The minimum value is 32 KB for devices that are not of type CL_DEVICE_TYPE_CUSTOM.
        /// </summary>
        public ref readonly ulong LocalMemSize => ref GetOrUpdateUnmanaged<ulong, DeviceInfo, uint>(ref _LocalMemSize, DeviceInfo.LocalMemSize, NativeCl.GetDeviceInfo);

        private bool _ErrorCorrectionSupport;
        /// <summary>
        /// Is CL_TRUE if the device implements error correction for all accesses to compute device memory (global and constant).<br/>
        /// Is CL_FALSE if the device does not implement such error correction.
        /// </summary>
        public ref readonly bool ErrorCorrectionSupport => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _ErrorCorrectionSupport, DeviceInfo.ErrorCorrectionSupport, NativeCl.GetDeviceInfo);

        private int _ProfilingTimerResolution;
        /// <summary>
        /// Describes the resolution of device timer.<br/>
        /// This is measured in nanoseconds.<br/>
        /// Refer to Profiling Operations for details.
        /// </summary>
        public ref readonly int ProfilingTimerResolution => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _ProfilingTimerResolution, DeviceInfo.ProfilingTimerResolution, NativeCl.GetDeviceInfo);

        private bool _EndianLittle;
        /// <summary>
        /// Is CL_TRUE if the OpenCL device is a little endian device and CL_FALSE otherwise
        /// </summary>
        public ref readonly bool EndianLittle => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _EndianLittle, DeviceInfo.EndianLittle, NativeCl.GetDeviceInfo);

        private bool _Available;
        /// <summary>
        /// Is CL_TRUE if the device is available and CL_FALSE otherwise.<br/>
        /// A device is considered to be available if the device can be expected to successfully execute commands enqueued to the device.
        /// </summary>
        public ref readonly bool Available => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _Available, DeviceInfo.Available, NativeCl.GetDeviceInfo);

        private bool _CompilerAvailable;
        /// <summary>
        /// Is CL_FALSE if the implementation does not have a compiler available to compile the program source.<br/>
        /// Is CL_TRUE if the compiler is available.<br/>
        /// This can be CL_FALSE for the embedded platform profile only.
        /// </summary>
        public ref readonly bool CompilerAvailable => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _CompilerAvailable, DeviceInfo.CompilerAvailable, NativeCl.GetDeviceInfo);

        private bool _LinkerAvailable;
        /// <summary>
        /// Is CL_FALSE if the implementation does not have a linker available.<br/>
        /// Is CL_TRUE if the linker is available.<br/>
        /// This can be CL_FALSE for the embedded platform profile only.<br/>
        /// This must be CL_TRUE if CL_DEVICE_COMPILER_AVAILABLE is CL_TRUE.
        /// </summary>
        public ref readonly bool LinkerAvailable => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _LinkerAvailable, DeviceInfo.LinkerAvailable, NativeCl.GetDeviceInfo);

        private DeviceExecCapabilities _ExecutionCapabilities;
        /// <summary>
        /// Describes the execution capabilities of the device.<br/>
        /// This is a bit-field that describes one or more of the following values: CL_EXEC_KERNEL - The OpenCL device can execute OpenCL kernels.<br/>
        /// CL_EXEC_NATIVE_KERNEL - The OpenCL device can execute native kernels.<br/>
        /// The mandated minimum capability is: CL_EXEC_KERNEL.
        /// </summary>
        public ref readonly DeviceExecCapabilities ExecutionCapabilities => ref GetOrUpdateUnmanaged<DeviceExecCapabilities, DeviceInfo, uint>(ref _ExecutionCapabilities, DeviceInfo.ExecutionCapabilities, NativeCl.GetDeviceInfo);

        private CommandQueueProperties _QueueOnHostProperties;
        /// <summary>
        /// Describes the on host command-queue properties supported by the device.<br/>
        /// This is a bit-field that describes one or more of the following values: CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE CL_QUEUE_PROFILING_ENABLE These properties are described in the Queue Properties table.<br/>
        /// The mandated minimum capability is: CL_QUEUE_PROFILING_ENABLE.
        /// </summary>
        public ref readonly CommandQueueProperties QueueOnHostProperties => ref GetOrUpdateUnmanaged<CommandQueueProperties, DeviceInfo, uint>(ref _QueueOnHostProperties, DeviceInfo.QueueOnHostProperties, NativeCl.GetDeviceInfo);

        private CommandQueueProperties _QueueOnDeviceProperties;
        /// <summary>
        /// Describes the on device command-queue properties supported by the device.<br/>
        /// This is a bit-field that describes one or more of the following values: CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE CL_QUEUE_PROFILING_ENABLE These properties are described in the Queue Properties table.<br/>
        /// The mandated minimum capability is: CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE | CL_QUEUE_PROFILING_ENABLE.
        /// </summary>
        public ref readonly CommandQueueProperties QueueOnDeviceProperties => ref GetOrUpdateUnmanaged<CommandQueueProperties, DeviceInfo, uint>(ref _QueueOnDeviceProperties, DeviceInfo.QueueOnDeviceProperties, NativeCl.GetDeviceInfo);

        private uint _QueueOnDevicePreferredSize;
        /// <summary>
        /// The size of the device queue in bytes preferred by the implementation.<br/>
        /// Applications should use this size for the device queue to ensure good performance.<br/>
        /// The minimum value is 16 KB
        /// </summary>
        public ref readonly uint QueueOnDevicePreferredSize => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _QueueOnDevicePreferredSize, DeviceInfo.QueueOnDevicePreferredSize, NativeCl.GetDeviceInfo);

        private uint _QueueOnDeviceMaxSize;
        /// <summary>
        /// The max.<br/>
        /// size of the device queue in bytes.<br/>
        /// The minimum value is 256 KB for the full profile and 64 KB for the embedded profile
        /// </summary>
        public ref readonly uint QueueOnDeviceMaxSize => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _QueueOnDeviceMaxSize, DeviceInfo.QueueOnDeviceMaxSize, NativeCl.GetDeviceInfo);

        private uint _MaxOnDeviceQueues;
        /// <summary>
        /// The maximum number of device queues that can be created for this device in a single context.<br/>
        /// The minimum value is 1.
        /// </summary>
        public ref readonly uint MaxOnDeviceQueues => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxOnDeviceQueues, DeviceInfo.MaxOnDeviceQueues, NativeCl.GetDeviceInfo);

        private uint _MaxOnDeviceEvents;
        /// <summary>
        /// The maximum number of events in use by a device queue.<br/>
        /// These refer to events returned by the enqueue_built-in functions to a device queue or user events returned by the create_user_event built-in function that have not been released.<br/>
        /// The minimum value is 1024.
        /// </summary>
        public ref readonly uint MaxOnDeviceEvents => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxOnDeviceEvents, DeviceInfo.MaxOnDeviceEvents, NativeCl.GetDeviceInfo);

        private string _BuiltInKernels;
        /// <summary>
        /// A semi-colon separated list of built-in kernels supported by the device.<br/>
        /// An empty string is returned if no built-in kernels are supported by the device.
        /// </summary>
        public ref readonly string BuiltInKernels => ref GetOrUpdateString<DeviceInfo, uint>(ref _BuiltInKernels, DeviceInfo.BuiltInKernels, NativeCl.GetDeviceInfo);

        private Platform _Platform;
        /// <summary>
        /// The platform associated with this device.
        /// </summary>
        public ref readonly Platform Platform => ref GetOrUpdateHandle<Platform, DeviceInfo, uint>(ref _Platform, DeviceInfo.Platform, NativeCl.GetDeviceInfo);

        private string _Name;
        /// <summary>
        /// Device name string.
        /// </summary>
        public ref readonly string Name => ref GetOrUpdateString<DeviceInfo, uint>(ref _Name, DeviceInfo.Name, NativeCl.GetDeviceInfo);

        private string _Vendor;
        /// <summary>
        /// Vendor name string.
        /// </summary>
        public ref readonly string Vendor => ref GetOrUpdateString<DeviceInfo, uint>(ref _Vendor, DeviceInfo.Vendor, NativeCl.GetDeviceInfo);

        private string _DriverVersion;
        /// <summary>
        /// OpenCL software driver version string.<br/>
        /// Follows a vendor-specific format.
        /// </summary>
        public ref readonly string DriverVersion => ref GetOrUpdateString<DeviceInfo, uint>(ref _DriverVersion, DeviceInfo.DriverVersion, NativeCl.GetDeviceInfo);

        private string _Profile;
        /// <summary>
        /// OpenCL profile string.<br/>
        /// Returns the profile name supported by the device.<br/>
        /// The profile name returned can be one of the following strings: FULL_PROFILE - if the device supports the OpenCL specification (functionality defined as part of the core specification and does not require any extensions to be supported).<br/>
        /// EMBEDDED_PROFILE - if the device supports the OpenCL embedded profile.
        /// </summary>
        public ref readonly string Profile => ref GetOrUpdateString<DeviceInfo, uint>(ref _Profile, DeviceInfo.Profile, NativeCl.GetDeviceInfo);

        private string _Version;
        /// <summary>
        /// OpenCL version string.<br/>
        /// Returns the OpenCL version supported by the device.<br/>
        /// This version string has the following format: OpenCL&lt;space>&lt;major_version.<br/>
        /// &lt;minor_version>&lt;space>&lt;vendor-specific information>The major_version.<br/>
        /// minor_version value returned will be one of 1.0, 1.1, 1.2, 2.0, 2.1 or 2.2.
        /// </summary>
        public ref readonly string Version => ref GetOrUpdateString<DeviceInfo, uint>(ref _Version, DeviceInfo.Version, NativeCl.GetDeviceInfo);

        private string _OpenClVersion;
        /// <summary>
        /// OpenCL C version string.<br/>
        /// Returns the highest OpenCL C version supported by the compiler for this device that is not of type CL_DEVICE_TYPE_CUSTOM.<br/>
        /// This version string has the following format: OpenCL&lt;space>C&lt;space>&lt;major_version.<br/>
        /// &lt;minor_version>&lt;space>&lt;vendor-specific information> The major_version.<br/>
        /// minor_version value returned must be 2.0 <br/>
        /// if CL_DEVICE_VERSION is OpenCL 2.0, OpenCL 2.1, or OpenCL 2.2.<br/>
        /// The major_version. minor_version value returned must be 1.2<br/>
        /// if CL_DEVICE_VERSION is OpenCL 1.2.<br/>
        /// the major_version.minor_version value returned must be 1.1<br/>
        /// if CL_DEVICE_VERSION is OpenCL 1.1.<br/>
        /// The major_version.minor_version value returned can be 1.0 or 1.1<br/>
        /// if CL_DEVICE_VERSION is OpenCL 1.0.
        /// </summary>
        public ref readonly string OpenClVersion => ref GetOrUpdateString<DeviceInfo, uint>(ref _OpenClVersion, DeviceInfo.OpenClVersion, NativeCl.GetDeviceInfo);

        private string _Extensions;
        /// <summary>
        /// Returns a space separated list of extension names (the extension names themselves do not contain any spaces) supported by the device.<br/>
        /// The list of extension names returned can be vendor supported extension names and one or more of the following Khronos approved extension names: cl_khr_int64_base_atomics cl_khr_int64_extended_atomics cl_khr_fp16 cl_khr_gl_sharing cl_khr_gl_event cl_khr_d3d10_sharing cl_khr_dx9_media_sharing cl_khr_d3d11_sharing cl_khr_gl_depth_images cl_khr_gl_msaa_sharing cl_khr_initialize_memory cl_khr_terminate_context cl_khr_spir cl_khr_srgb_image_writes The following approved Khronos extension names must be returned by all devices that support OpenCL C 2.<br/>
        /// 0: cl_khr_byte_addressable_store cl_khr_fp64 (for backward compatibility if double precision is supported) cl_khr_3d_image_writes cl_khr_image2d_from_buffer cl_khr_depth_images Please refer to the OpenCL Extension Specification for a detailed description of these extensions.
        /// </summary>
        public ref readonly string Extensions => ref GetOrUpdateString<DeviceInfo, uint>(ref _Extensions, DeviceInfo.Extensions, NativeCl.GetDeviceInfo);

        private int _PrintfBufferSize;
        /// <summary>
        /// Maximum size in bytes of the internal buffer that holds the output of printf calls from a kernel.<br/>
        /// The minimum value for the FULL profile is 1 MB.
        /// </summary>
        public ref readonly int PrintfBufferSize => ref GetOrUpdateUnmanaged<int, DeviceInfo, uint>(ref _PrintfBufferSize, DeviceInfo.PrintfBufferSize, NativeCl.GetDeviceInfo);

        private bool _PreferredInteropUserSync;
        /// <summary>
        /// Is CL_TRUE if the devices preference is for the user to be responsible for synchronization, when sharing memory objects between OpenCL and other APIs such as DirectX, CL_FALSE if the device / implementation has a performant path for performing synchronization of memory object shared between OpenCL and other APIs such as DirectX.
        /// </summary>
        public ref readonly bool PreferredInteropUserSync => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _PreferredInteropUserSync, DeviceInfo.PreferredInteropUserSync, NativeCl.GetDeviceInfo);

        private IntPtr _ParentDevice;
        /// <summary>
        /// Returns the IntPtr of the parent device to which this sub-device belongs.<br/>
        /// If device is a root-level device, a NULL value is returned.
        /// </summary>
        public ref readonly IntPtr ParentDevice => ref GetOrUpdateUnmanaged<IntPtr, DeviceInfo, uint>(ref _ParentDevice, DeviceInfo.ParentDevice, NativeCl.GetDeviceInfo);

        private uint _PartitionMaxSubDevices;
        /// <summary>
        /// Returns the maximum number of sub-devices that can be created when a device is partitioned.<br/>
        /// The value returned cannot exceed CL_DEVICE_MAX_COMPUTE_UNITS.
        /// </summary>
        public ref readonly uint PartitionMaxSubDevices => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PartitionMaxSubDevices, DeviceInfo.PartitionMaxSubDevices, NativeCl.GetDeviceInfo);

        private DevicePartitionProperty _PartitionProperties;
        /// <summary>
        /// Returns the list of partition types supported by device.<br/>
        /// This is an array of DevicePartitionProperty values drawn from the following list: CL_DEVICE_PARTITION_EQUALLY CL_DEVICE_PARTITION_BY_COUNTS CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN If the device cannot be partitioned (i.<br/>
        /// e.g.:<br/>
        /// there is no partitioning scheme supported by the device that will return at least two subdevices), a value of 0 will be returned.
        /// </summary>
        public ref readonly DevicePartitionProperty PartitionProperties => ref GetOrUpdateUnmanaged<DevicePartitionProperty, DeviceInfo, uint>(ref _PartitionProperties, DeviceInfo.PartitionProperties, NativeCl.GetDeviceInfo);

        private DeviceAffinityDomain _PartitionAffinityDomain;
        /// <summary>
        /// Returns the list of supported affinity domains for partitioning the device using CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN.<br/>
        /// This is a bit-field that describes one or more of the following values: CL_DEVICE_AFFINITY_DOMAIN_NUMA CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE If the device does not support any affinity domains, a value of 0 will be returned.
        /// </summary>
        public ref readonly DeviceAffinityDomain PartitionAffinityDomain => ref GetOrUpdateUnmanaged<DeviceAffinityDomain, DeviceInfo, uint>(ref _PartitionAffinityDomain, DeviceInfo.PartitionAffinityDomain, NativeCl.GetDeviceInfo);

        private DevicePartitionProperty _PartitionType;
        /// <summary>
        /// Returns the properties argument specified in clCreateSubDevices if device is a sub-device.<br/>
        /// In the case where the properties argument to clCreateSubDevices is CL_DEVICE_PARTITION_BY_AFFINITY_DOMAIN, CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE, the affinity domain used to perform the partition will be returned.<br/>
        /// This can be one of the following values: CL_DEVICE_AFFINITY_DOMAIN_NUMA CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE Otherwise the implementation may either return a param_value_size_ret of 0 i.<br/>
        /// e.g.:<br/>
        /// there is no partition type associated with device or can return a property value of 0 (where 0 is used to terminate the partition property list) in the memory that param_value points to.
        /// </summary>
        public ref readonly DevicePartitionProperty PartitionType => ref GetOrUpdateUnmanaged<DevicePartitionProperty, DeviceInfo, uint>(ref _PartitionType, DeviceInfo.PartitionType, NativeCl.GetDeviceInfo);

        private uint _ReferenceCount;
        /// <summary>
        /// Returns the device reference count.<br/>
        /// If the device is a root-level device, a reference count of one is returned.
        /// </summary>
        public ref readonly uint ReferenceCount => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _ReferenceCount, DeviceInfo.ReferenceCount, NativeCl.GetDeviceInfo);

        private SVMCapabilities _SvmCapabilities;
        /// <summary>
        /// Describes the various shared virtual memory (a.<br/>
        /// k.<br/>
        /// a.<br/>
        /// SVM) memory allocation types the device supports.<br/>
        /// Coarse-grain SVM allocations are required to be supported by all OpenCL 2.<br/>
        /// 0 devices.<br/>
        /// This is a bit-field that describes a combination of the following values: CL_DEVICE_SVM_COARSE_GRAIN_BUFFER - Support for coarse-grain buffer sharing using clSVMAlloc.<br/>
        /// Memory consistency is guaranteed at synchronization points and the host must use calls to clEnqueueMapBuffer and clEnqueueUnmapMemObject.<br/>
        /// CL_DEVICE_SVM_FINE_GRAIN_BUFFER - Support for fine-grain buffer sharing using clSVMAlloc.<br/>
        /// Memory consistency is guaranteed at synchronization points without need for clEnqueueMapBuffer and clEnqueueUnmapMemObject.<br/>
        /// CL_DEVICE_SVM_FINE_GRAIN_SYSTEM - Support for sharing the host&#8217;s entire virtual memory including memory allocated using malloc.<br/>
        /// Memory consistency is guaranteed at synchronization points.<br/>
        /// CL_DEVICE_SVM_ATOMICS - Support for the OpenCL 2.0 atomic operations that provide memory consistency across the host and all OpenCL devices supporting fine-grain SVM allocations.<br/>
        /// The mandated minimum capability is CL_DEVICE_SVM_COARSE_GRAIN_BUFFER.
        /// </summary>
        public ref readonly SVMCapabilities SvmCapabilities => ref GetOrUpdateUnmanaged<SVMCapabilities, DeviceInfo, uint>(ref _SvmCapabilities, DeviceInfo.SvmCapabilities, NativeCl.GetDeviceInfo);

        private uint _PreferredPlatformAtomicAlignment;
        /// <summary>
        /// Returns the value representing the preferred alignment in bytes for OpenCL 2.<br/>
        /// 0 fine-grained SVM atomic types.<br/>
        /// This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
        /// </summary>
        public ref readonly uint PreferredPlatformAtomicAlignment => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredPlatformAtomicAlignment, DeviceInfo.PreferredPlatformAtomicAlignment, NativeCl.GetDeviceInfo);

        private uint _PreferredGlobalAtomicAlignment;
        /// <summary>
        /// Returns the value representing the preferred alignment in bytes for OpenCL 2.<br/>
        /// 0 atomic types to global memory.<br/>
        /// This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
        /// </summary>
        public ref readonly uint PreferredGlobalAtomicAlignment => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredGlobalAtomicAlignment, DeviceInfo.PreferredGlobalAtomicAlignment, NativeCl.GetDeviceInfo);

        private uint _PreferredLocalAtomicAlignment;
        /// <summary>
        /// Returns the value representing the preferred alignment in bytes for OpenCL 2.<br/>
        /// 0 atomic types to local memory.<br/>
        /// This query can return 0 which indicates that the preferred alignment is aligned to the natural size of the type.
        /// </summary>
        public ref readonly uint PreferredLocalAtomicAlignment => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _PreferredLocalAtomicAlignment, DeviceInfo.PreferredLocalAtomicAlignment, NativeCl.GetDeviceInfo);

        private uint _MaxNumSubGroups;
        /// <summary>
        /// Maximum number of sub-groups in a work-group that a device is capable of executing on a single compute unit, for any given kernel-instance running on the device.<br/>
        /// The minimum value is 1.<br/>
        /// (Refer also to clGetKernelSubGroupInfo.)
        /// </summary>
        public ref readonly uint MaxNumSubGroups => ref GetOrUpdateUnmanaged<uint, DeviceInfo, uint>(ref _MaxNumSubGroups, DeviceInfo.MaxNumSubGroups, NativeCl.GetDeviceInfo);

        private bool _SubGroupIndependentForwardProgress;
        /// <summary>
        /// Is CL_TRUE if this device supports independent forward progress of sub-groups, CL_FALSE otherwise.<br/>
        /// If cl_khr_subgroups is supported by the device this must return CL_TRUE.
        /// </summary>
        public ref readonly bool SubGroupIndependentForwardProgress => ref GetOrUpdateUnmanaged<bool, DeviceInfo, uint>(ref _SubGroupIndependentForwardProgress, DeviceInfo.SubGroupIndependentForwardProgress, NativeCl.GetDeviceInfo);

        public override void Retain()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.RetainDevice(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
        public override void Dispose()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.ReleaseDevice(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }

    }
}
