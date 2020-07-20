using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum DeviceInfo  : uint
    {
        /// <summary>
        /// The OpenCL device type.<para/> 
        /// Currently supported values are:
        /// DeviceType.Cpu<br/>
        /// DeviceType.Gpu<br/>
        /// DeviceType.Accelerator<br/>
        /// DeviceType.Default<br/><br/>
        /// a combination of the above types, or DeviceType.Custom.
        /// </summary>
        Type = NativeCl.CL_DEVICE_TYPE,
		/// <summary>
        /// A unique device vendor identifier.<br/>
        /// An example of a unique device identifier could be the PCIe ID.
        /// </summary>
        VendorId = NativeCl.CL_DEVICE_VENDOR_ID,
		/// <summary>
        /// The number of parallel compute units on the OpenCL device.<br/>
        /// A work-group executes on a single compute unit.<br/>
        /// The minimum value is 1.
        /// </summary>
        MaxComputeUnits = NativeCl.CL_DEVICE_MAX_COMPUTE_UNITS,
		/// <summary>
        /// Maximum dimensions that specify the global and local work-item IDs used by the data parallel execution model.<br/>
        /// (Refer to clEnqueueNDRangeKernel).<br/>
        /// The minimum value is 3 for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.
        /// </summary>
        MaxWorkItemDimensions = NativeCl.CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS,
		/// <summary>
        /// Maximum number of work-items that can be specified in each dimension of the work-group to clEnqueueNDRangeKernel.<para/>
        /// Returns n size_t entries, where n is the value returned by the query for CL_​DEVICE_​MAX_​WORK_​ITEM_​DIMENSIONS.<para/>
        /// The minimum value is (1, 1, 1) for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.
        /// </summary>
        MaxWorkItemSizes = NativeCl.CL_DEVICE_MAX_WORK_ITEM_SIZES,
		/// <summary>
        /// Maximum number of work-items in a work-group that a device is capable of executing on a single compute unit, for any given kernel-instance running on the device.<br/>
        /// (Refer also to clEnqueueNDRangeKernel and CL_​KERNEL_​WORK_​GROUP_​SIZE ).<br/>
        /// The minimum value is 1.<br/>
        /// The returned value is an upper limit and will not necessarily maximize performance.<br/>
        /// This maximum may be larger than supported by a specific kernel (refer to the CL_​KERNEL_​WORK_​GROUP_​SIZE query of clGetKernelWorkGroupInfo).
        /// </summary>
        MaxWorkGroupSize = NativeCl.CL_DEVICE_MAX_WORK_GROUP_SIZE,
		/// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        PreferredVectorWidthChar = NativeCl.CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR,
		/// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        PreferredVectorWidthShort = NativeCl.CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT,
		/// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        PreferredVectorWidthInt = NativeCl.CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT,
		/// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        PreferredVectorWidthLong = NativeCl.CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG,
		/// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        PreferredVectorWidthFloat = NativeCl.CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT,
		/// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        PreferredVectorWidthDouble = NativeCl.CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE,
		/// <summary>
        /// Preferred native vector width size for built-in scalar types that can be put into vectors.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​PREFERRED_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        PreferredVectorWidthHalf = NativeCl.CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF,
		/// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        NativeVectorWidthChar = NativeCl.CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR,
		/// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        NativeVectorWidthShort = NativeCl.CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT,
		/// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        NativeVectorWidthInt = NativeCl.CL_DEVICE_NATIVE_VECTOR_WIDTH_INT,
		/// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        NativeVectorWidthLong = NativeCl.CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG,
		/// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        NativeVectorWidthFloat = NativeCl.CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG,
		/// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        NativeVectorWidthDouble = NativeCl.CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE,
		/// <summary>
        /// Returns the native ISA vector width.<br/>
        /// The vector width is defined as the number of scalar elements that can be stored in the vector.<para/>
        /// If double precision is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​DOUBLE must return 0.<br/>
        /// If the cl_khr_fp16 extension is not supported, CL_​DEVICE_​NATIVE_​VECTOR_​WIDTH_​HALF must return 0.
        /// </summary>
        NativeVectorWidthHalf = NativeCl.CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF,
		/// <summary>
        /// Clock frequency of the device in MHz.<br/>
        /// The meaning of this value is implementation-defined.<br/>
        /// For devices with multiple clock domains, the clock frequency for any of the clock domains may be returned.<br/>
        /// For devices that dynamically change frequency for power or thermal reasons, the returned clock frequency may be any valid frequency.
        /// </summary>
        MaxClockFrequency = NativeCl.CL_DEVICE_MAX_CLOCK_FREQUENCY,
		/// <summary>
        /// The default compute device address space size of the global address space specified as an unsigned integer value in bits.<br/>
        /// Currently supported values are 32 or 64 bits.
        /// </summary>
        AddressBits = NativeCl.CL_DEVICE_ADDRESS_BITS,
		/// <summary>
        /// Max size of memory object allocation in bytes.<br/>
        /// The minimum value is max(min(1024 × 1024 × 1024, 1/4th of CL_​DEVICE_​GLOBAL_​MEM_​SIZE), 32 × 1024 × 1024) for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.
        /// </summary>
        MaxMemAllocSize = NativeCl.CL_DEVICE_MAX_MEM_ALLOC_SIZE,
		/// <summary>
        /// Is CL_​TRUE if images are supported by the OpenCL device and CL_​FALSE otherwise.
        /// </summary>
        ImageSupport = NativeCl.CL_DEVICE_IMAGE_SUPPORT,
		/// <summary>
        /// Max number of image objects arguments of a kernel declared with the read_only qualifier.<br/>
        /// The minimum value is 128 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        MaxReadImageArgs = NativeCl.CL_DEVICE_MAX_READ_IMAGE_ARGS,
		/// <summary>
        /// Max number of image objects arguments of a kernel declared with the write_only qualifier.<br/>
        /// The minimum value is 64 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        MaxWriteImageArgs = NativeCl.CL_DEVICE_MAX_WRITE_IMAGE_ARGS,
		/// <summary>
        /// Max number of image objects arguments of a kernel declared with the write_only or read_write qualifier.<br/>
        /// The minimum value is 64 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        MaxReadWriteImageArgs = NativeCl.CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS,
		/// <summary>
        /// The intermediate languages that can be supported by clCreateProgramWithIL for this device.<br/>
        /// Returns a space-separated list of IL version strings of the form &lt;IL_Prefix&gt;_&lt;Major_Version&gt;.&lt;Minor_Version&gt;.<br/>
        /// For OpenCL 2.2, SPIR-V is a required IL prefix.
        /// </summary>
        IlVersion = NativeCl.CL_DEVICE_IL_VERSION,
		/// <summary>
        /// Max width of 2D image or 1D image not created from a buffer object in pixels.<br/>
        /// The minimum value is 16384 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        Image2dMaxWidth = NativeCl.CL_DEVICE_IMAGE2D_MAX_WIDTH,
		/// <summary>
        /// Max height of 2D image in pixels.<br/>
        /// The minimum value is 16384 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        Image2dMaxHeight = NativeCl.CL_DEVICE_IMAGE2D_MAX_HEIGHT,
		/// <summary>
        /// Max width of 3D image in pixels.<br/>
        /// The minimum value is 2048 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        Image3dMaxWidth = NativeCl.CL_DEVICE_IMAGE3D_MAX_WIDTH,
		/// <summary>
        /// Max height of 3D image in pixels.<br/>
        /// The minimum value is 2048 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        Image3dMaxHeight = NativeCl.CL_DEVICE_IMAGE3D_MAX_HEIGHT,
		/// <summary>
        /// Max depth of 3D image in pixels.<br/>
        /// The minimum value is 2048 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        Image3dMaxDepth = NativeCl.CL_DEVICE_IMAGE3D_MAX_DEPTH,
		/// <summary>
        /// Max number of pixels for a 1D image created from a buffer object.<br/>
        /// The minimum value is 65536 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        ImageMaxBufferSize = NativeCl.CL_DEVICE_IMAGE_MAX_BUFFER_SIZE,
		/// <summary>
        /// Max number of images in a 1D or 2D image array.<br/>
        /// The minimum value is 2048 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        ImageMaxArraySize = NativeCl.CL_DEVICE_IMAGE_MAX_ARRAY_SIZE,
		/// <summary>
        /// Maximum number of samplers that can be used in a kernel.<br/>
        /// The minimum value is 16 if CL_​DEVICE_​IMAGE_​SUPPORT is CL_​TRUE.
        /// </summary>
        MaxSamplers = NativeCl.CL_DEVICE_MAX_SAMPLERS,
		/// <summary>
        /// The row pitch alignment size in pixels for 2D images created from a buffer.<br/>
        /// The value returned must be a power of 2.<br/>
        /// If the device does not support images, this value must be 0.
        /// </summary>
        ImagePitchAlignment = NativeCl.CL_DEVICE_IMAGE_PITCH_ALIGNMENT,
		/// <summary>
        /// This query should be used when a 2D image is created from a buffer which was created using CL_​MEM_​USE_​HOST_​PTR.<br/>
        /// The value returned must be a power of 2.<br/>
        /// This query specifies the minimum alignment in pixels of the host_ptr specified to clCreateBuffer.<br/>
        /// If the device does not support images, this value must be 0.
        /// </summary>
        ImageBaseAddressAlignment = NativeCl.CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT,
		/// <summary>
        /// The maximum number of pipe objects that can be passed as arguments to a kernel.<br/>
        /// The minimum value is 16.
        /// </summary>
        MaxPipeArgs = NativeCl.CL_DEVICE_MAX_PIPE_ARGS,
		/// <summary>
        /// The maximum number of reservations that can be active for a pipe per work-item in a kernel.<br/>
        /// A work-group reservation is counted as one reservation per work-item.<br/>
        /// The minimum value is 1.
        /// </summary>
        PipeMaxActiveReservations = NativeCl.CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS,
		/// <summary>
        /// The maximum size of pipe packet in bytes.<br/>
        /// The minimum value is 1024 bytes.
        /// </summary>
        PipeMaxPacketSize = NativeCl.CL_DEVICE_PIPE_MAX_PACKET_SIZE,
		/// <summary>
        /// Max size in bytes of all arguments that can be passed to a kernel.<br/>
        /// The minimum value is 1024 for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.<br/>
        /// For this minimum value, only a maximum of 128 arguments can be passed to a kernel
        /// </summary>
        MaxParameterSize = NativeCl.CL_DEVICE_MAX_PARAMETER_SIZE,
		/// <summary>
        /// Alignment requirement (in bits) for sub-buffer offsets.<br/>
        /// The minimum value is the size (in bits) of the largest OpenCL built-in data type supported<br/>
        /// by the device (long16 in FULL profile, long16 or int16 in EMBEDDED profile) for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.
        /// </summary>
        MemBaseAddrAlign = NativeCl.CL_DEVICE_MEM_BASE_ADDR_ALIGN,
		/// <summary>
        /// Describes single precision floating-point capability of the device.<br/><br/>
        /// This is a bit-field that describes one or more of the following values:
        /// CL_​FP_​DENORM - denorms are supported<br/>
        /// CL_​FP_​INF_​NAN - INF and quiet NaNs are supported.<br/>
        /// CL_​FP_​ROUND_​TO_​NEAREST - round to nearest even rounding mode<br/>
        /// CL_​FP_​ROUND_​TO_​ZERO - round to zero rounding mode <br/>
        /// CL_​FP_​ROUND_​TO_​INF - round to positive and negative infinity rounding modes <br/>
        /// CL_​FP_​FMA - IEEE754-2008 fused multiply-add is supported<br/>
        /// CL_​FP_​CORRECTLY_​ROUNDED_​DIVIDE_​SQRT - divide and sqrt are correctly rounded as defined by the IEEE754 specification<br/>
        /// CL_​FP_​SOFT_​FLOAT - Basic floating-point operations (such as addition, subtraction, multiplication) are implemented in software.<br/><br/>
        /// For the full profile, the mandated minimum floating-point capability for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM is: CL_​FP_​ROUND_​TO_​NEAREST | CL_​FP_​INF_​NAN.<br/>
        /// For the embedded profile, see the dedicated table.
        /// </summary>
        SingleFpConfig = NativeCl.CL_DEVICE_SINGLE_FP_CONFIG,
		/// <summary>
        /// Describes double precision floating-point capability of the OpenCL device.<br/><br/>
        /// This is a bit-field that describes one or more of the following values:<br/>
        /// CL_​FP_​DENORM - denorms are supported<br/>
        /// CL_​FP_​INF_​NAN - INF and NaNs are supported.<br/>
        /// CL_​FP_​ROUND_​TO_​NEAREST - round to nearest even rounding mode supported.<br/>
        /// CL_​FP_​ROUND_​TO_​ZERO - round to zero rounding mode supported.<br/>
        /// CL_​FP_​ROUND_​TO_​INF - round to positive and negative infinity rounding modes supported.<br/>
        /// CL_​FP_​FMA - IEEE754-2008 fused multiply-add is supported.<br/>
        /// CL_​FP_​SOFT_​FLOAT - Basic floating-point operations (such as addition, subtraction, multiplication) are implemented in software.<br/><br/>
        /// Double precision is an optional feature so the mandated minimum double precision floating-point capability is 0.<br/>
        /// If double precision is supported by the device, then the minimum double precision floating-point capability must be:<br/>
        /// CL_​FP_​FMA | CL_​FP_​ROUND_​TO_​NEAREST | CL_​FP_​INF_​NAN | CL_​FP_​DENORM.
        /// </summary>
        DoubleFpConfig = NativeCl.CL_DEVICE_DOUBLE_FP_CONFIG,
		/// <summary>
        /// Type of global memory cache supported.<br/>
        /// Valid values are: CL_​NONE, CL_​READ_​ONLY_​CACHE, and CL_​READ_​WRITE_​CACHE.
        /// </summary>
        GlobalMemCacheType = NativeCl.CL_DEVICE_GLOBAL_MEM_CACHE_TYPE,
		/// <summary>
        /// Size of global memory cache line in bytes.
        /// </summary>
        GlobalMemCachelineSize = NativeCl.CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE,
		/// <summary>
        /// Size of global memory cache in bytes.
        /// </summary>
        GlobalMemCacheSize = NativeCl.CL_DEVICE_GLOBAL_MEM_CACHE_SIZE,
		/// <summary>
        /// Size of global device memory in bytes.
        /// </summary>
        GlobalMemSize = NativeCl.CL_DEVICE_GLOBAL_MEM_SIZE,
		/// <summary>
        /// Max size in bytes of a constant buffer allocation.<br/>
        /// The minimum value is 64 KB for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.
        /// </summary>
        MaxConstantBufferSize = NativeCl.CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE,
		/// <summary>
        /// Max number of arguments declared with the __constant qualifier in a kernel.<br/>
        /// The minimum value is 4 for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.
        /// </summary>
        MaxConstantArgs = NativeCl.CL_DEVICE_MAX_CONSTANT_ARGS,
		/// <summary>
        /// The maximum number of bytes of storage that may be allocated for any single variable in program scope or inside a function in an OpenCL kernel language declared in the global address space.<br/>
        /// The minimum value is 64 KB.
        /// </summary>
        MaxGlobalVariableSize = NativeCl.CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE,
		/// <summary>
        /// Maximum preferred total size, in bytes, of all program variables in the global address space.<br/>
        /// This is a performance hint.<br/>
        /// An implementation may place such variables in storage with optimized device access.<br/>
        /// This query returns the capacity of such storage.<br/>
        /// The minimum value is 0.
        /// </summary>
        GlobalVariablePreferredTotalSize = NativeCl.CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE,
		/// <summary>
        /// Type of local memory supported.<br/>
        /// This can be set to CL_​LOCAL implying dedicated local memory storage such as SRAM , or CL_​GLOBAL.<br/>
        /// For custom devices, CL_​NONE can also be returned indicating no local memory support.
        /// </summary>
        LocalMemType = NativeCl.CL_DEVICE_LOCAL_MEM_TYPE,
		/// <summary>
        /// Size of local memory region in bytes.<br/>
        /// The minimum value is 32 KB for devices that are not of type CL_​DEVICE_​TYPE_​CUSTOM.
        /// </summary>
        LocalMemSize = NativeCl.CL_DEVICE_LOCAL_MEM_SIZE,
		/// <summary>
        /// Is CL_​TRUE if the device implements error correction for all accesses to compute device memory (global and constant).<br/>
        /// Is CL_​FALSE if the device does not implement such error correction.
        /// </summary>
        ErrorCorrectionSupport = NativeCl.CL_DEVICE_ERROR_CORRECTION_SUPPORT,
		/// <summary>
        /// Describes the resolution of device timer.<br/>
        /// This is measured in nanoseconds.<br/>
        /// Refer to Profiling Operations for details.
        /// </summary>
        ProfilingTimerResolution = NativeCl.CL_DEVICE_PROFILING_TIMER_RESOLUTION,
		/// <summary>
        /// Is CL_​TRUE if the OpenCL device is a little endian device and CL_​FALSE otherwise
        /// </summary>
        EndianLittle = NativeCl.CL_DEVICE_ENDIAN_LITTLE,
		/// <summary>
        /// Is CL_​TRUE if the device is available and CL_​FALSE otherwise.<br/>
        /// Adevice is considered to be available if the device can be expected to successfully execute commands enqueued to the device.
        /// </summary>
        Available = NativeCl.CL_DEVICE_AVAILABLE,
		/// <summary>
        /// Is CL_​FALSE if the implementation does not have a compiler available to compile the program source.<br/>
        /// Is CL_​TRUE if the compiler is available.<br/>
        /// This can be CL_​FALSE for the embedded platform profile only.
        /// </summary>
        CompilerAvailable = NativeCl.CL_DEVICE_COMPILER_AVAILABLE,
		/// <summary>
        /// s CL_​FALSE if the implementation does not have a linker available.<br/>
        /// Is CL_​TRUE if the linker is available.<br/>
        /// This can be CL_​FALSE for the embedded platform profile only.<br/> 
        /// This must be CL_​TRUE if CL_​DEVICE_​COMPILER_​AVAILABLE is CL_​TRUE.
		/// </summary>
        LinkerAvailable = NativeCl.CL_DEVICE_LINKER_AVAILABLE,
		/// <summary>
        /// Describes the execution capabilities of the device.<br/>
        /// This is a bit-field that describes one or more of the following values:<br/>
        /// CL_​EXEC_​KERNEL - The OpenCL device can execute OpenCL kernels. 
        /// CL_​EXEC_​NATIVE_​KERNEL - The OpenCL device can execute native kernels. 
        /// The mandated minimum capability is: CL_​EXEC_​KERNEL.
        /// </summary>
        ExecutionCapabilities = NativeCl.CL_DEVICE_EXECUTION_CAPABILITIES,
		/// <summary>
        /// Describes the on host command-queue properties supported by the device.<br/><br/>
        /// This is a bit-field that describes one or more of the following values:<br/>
        /// CL_​QUEUE_​OUT_​OF_​ORDER_​EXEC_​MODE_​ENABLE<br/>
        /// CL_​QUEUE_​PROFILING_​ENABLE<br/><br/>
        /// These properties are described in the Queue Properties table. 
        /// The mandated minimum capability is: CL_​QUEUE_​PROFILING_​ENABLE.
        /// </summary>
        QueueOnHostProperties = NativeCl.CL_DEVICE_QUEUE_ON_HOST_PROPERTIES,
		/// <summary>
        /// Describes the on device command-queue properties supported by the device.<br/><br/>
        /// This is a bit-field that describes one or more of the following values:<br/>
        /// CL_​QUEUE_​OUT_​OF_​ORDER_​EXEC_​MODE_​ENABLE<br/>
        /// CL_​QUEUE_​PROFILING_​ENABLE<br/><br/>
        /// These properties are described in the Queue Properties table.<br/> 
        /// The mandated minimum capability is: CL_​QUEUE_​OUT_​OF_​ORDER_​EXEC_​MODE_​ENABLE | CL_​QUEUE_​PROFILING_​ENABLE.
        /// </summary>
        QueueOnDeviceProperties = NativeCl.CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES,
		/// <summary>
        /// The size of the device queue in bytes preferred by the implementation.<br/>
        /// Applications should use this size for the device queue to ensure good performance.<br/> 
        /// The minimum value is 16 KB
        /// /// </summary>
        QueueOnDevicePreferredSize = NativeCl.CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE,
		/// <summary>
        /// The max size of the device queue in bytes.<br/>
        /// The minimum value is 256 KB for the full profile and 64 KB for the embedded profile.
        /// </summary>
        QueueOnDeviceMaxSize = NativeCl.CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE,
		/// <summary>
        /// The maximum number of device queues that can be created for this device in a single context.<br/> 
        /// The minimum value is 1.
		/// </summary>
        MaxOnDeviceQueues = NativeCl.CL_DEVICE_MAX_ON_DEVICE_QUEUES,
		/// <summary>
        /// The maximum number of events in use by a device queue.<br/>
        /// These refer to events returned by the enqueue_ built-in functions to a device queue or user events returned by the create_user_event built-in function that have not been released.
        /// The minimum value is 1024.
		/// </summary>
        MaxOnDeviceEvents = NativeCl.CL_DEVICE_MAX_ON_DEVICE_EVENTS,
		/// <summary>
        /// A semi-colon separated list of built-in kernels supported by the device.<br/>
        /// An empty string is returned if no built-in kernels are supported by the device.
		/// </summary>
        BuiltInKernels = NativeCl.CL_DEVICE_BUILT_IN_KERNELS,
		/// <summary>
        /// The platform associated with this device.
        /// </summary>
        Platform = NativeCl.CL_DEVICE_PLATFORM,
		/// <summary>
        /// Device name string.
        /// </summary>
        Name = NativeCl.CL_DEVICE_NAME,
		/// <summary>
        /// Vendor name string.
		/// </summary>
        Vendor = NativeCl.CL_DEVICE_VENDOR,
		/// <summary>
        /// OpenCL software driver version string.<br/>
        /// Follows a vendor-specific format.
        /// </summary>
        DriverVersion = NativeCl.CL_DRIVER_VERSION,
		/// <summary>
        /// OpenCL profile string.<br/>
        /// Returns the profile name supported by the device.<br/>
        /// The profile name returned can be one of the following strings:<br/>
        /// FULL_PROFILE - if the device supports the OpenCL specification (functionality defined as part of the core specification and does not require any extensions to be supported).<br/> 
        /// EMBEDDED_PROFILE - if the device supports the OpenCL embedded profile.
		/// </summary>
        Profile = NativeCl.CL_DEVICE_PROFILE,
		/// <summary>
        /// OpenCL version string.<br/>
        /// Returns the OpenCL version supported by the device.<br/>
        /// This version string has the following format:<br/>
        /// OpenCL&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt;
        /// The major_version.minor_version value returned will be one of 1.0, 1.1, 1.2, 2.0, 2.1 or 2.2.
        /// </summary>
        Version = NativeCl.CL_DEVICE_VERSION,
		/// <summary>
        /// OpenCL C version string.<br/>
        /// Returns the highest OpenCL C version supported by the compiler for this device that is not of type CL_​DEVICE_​TYPE_​CUSTOM.<br/>
        /// This version string has the following format:<br/>
        /// OpenCL&lt;space&gt;&lt;space&gt;&lt;major_version.minor_version&gt;&lt;space&gt;&lt;vendor-specific information&gt;<br/>
        /// The major_version.minor_version value returned must be 2.0 if CL_​DEVICE_​VERSION is OpenCL 2.0, OpenCL 2.1, or OpenCL 2.2. <br/>
        /// The major_version.minor_version value returned must be 1.2 if CL_​DEVICE_​VERSION is OpenCL 1.2. <br/>
        /// The major_version.minor_version value returned must be 1.1 if CL_​DEVICE_​VERSION is OpenCL 1.1. <br/>
        /// The major_version.minor_version value returned can be 1.0 or 1.1 if CL_​DEVICE_​VERSION is OpenCL 1.0.<br/>
		///</summary>
        OpenClVersion = NativeCl.CL_DEVICE_OPENCL_C_VERSION,
		/// <summary>
        /// Returns a space separated list of extension names (the extension names themselves do not contain any spaces) supported by the device.<br/><br/>
        /// The list of extension names returned can be vendor supported extension names and one or more of the following Khronos approved extension names:<br/>
        /// cl_khr_int64_base_atomics<br/>
        /// cl_khr_int64_extended_atomics<br/>
        /// cl_khr_fp16<br/>
        /// cl_khr_gl_sharing<br/>
        /// cl_khr_gl_event<br/>
        /// cl_khr_d3d10_sharing<br/>
        /// cl_khr_dx9_media_sharing<br/>
        /// cl_khr_d3d11_sharing<br/>
        /// cl_khr_gl_depth_images<br/>
        /// cl_khr_gl_msaa_sharing<br/>
        /// cl_khr_initialize_memory<br/>
        /// cl_khr_terminate_context<br/>
        /// cl_khr_spir<br/>
        /// cl_khr_srgb_image_writes<br/><br/>
        /// The following approved Khronos extension names must be returned by all devices that support OpenCL C 2.0:<br/>
        /// cl_khr_byte_addressable_store<br/>
        /// cl_khr_fp64 (for backward compatibility if double precision is supported)<br/>
        /// cl_khr_3d_image_writes<br/>
        /// cl_khr_image2d_from_buffer<br/>
        /// cl_khr_depth_images<br/><br/>
        /// Please refer to the OpenCL Extension Specification for a detailed description of these extensions.
        ///</summary>
        Extensions = NativeCl.CL_DEVICE_EXTENSIONS,
		/// <summary>
        /// Maximum size in bytes of the internal buffer that holds the output of printf calls from a kernel.<br/>
        /// The minimum value for the FULL profile is 1 MB.
        /// </summary>
        PrintfBufferSize = NativeCl.CL_DEVICE_PRINTF_BUFFER_SIZE,
		/// <summary>
        /// Is CL_​TRUE if the devices preference is for the user to be responsible for synchronization, when sharing memory objects between OpenCL and other APIs such as DirectX, CL_​FALSE if the device / implementation has a performant path for performing synchronization of memory object shared between OpenCL and other APIs such as DirectX.
		/// </summary>
        PreferredInteropUserSync = NativeCl.CL_DEVICE_PREFERRED_INTEROP_USER_SYNC,
		/// <summary>
        /// Returns the cl_device_id of the parent device to which this sub-device belongs.<br/>
        /// If device is a root-level device, a NULL value is returned.
        /// </summary>
        ParentDevice = NativeCl.CL_DEVICE_PARENT_DEVICE,
		/// <summary>
        /// Returns the maximum number of sub-devices that can be created when a device is partitioned.<br/> 
        /// The value returned cannot exceed CL_​DEVICE_​MAX_​COMPUTE_​UNITS.
		/// </summary>
        PartitionMaxSubDevices = NativeCl.CL_DEVICE_PARTITION_MAX_SUB_DEVICES,
		/// <summary>
        /// Returns the list of partition types supported by device.<br/><br/>
        /// This is an array of cl_device_partition_property values drawn from the following list:<br/>
        /// CL_​DEVICE_​PARTITION_​EQUALLY<br/>
        /// CL_​DEVICE_​PARTITION_​BY_​COUNTS<br/>
        /// CL_​DEVICE_​PARTITION_​BY_​AFFINITY_​DOMAIN 
        /// If the device cannot be partitioned<br/>
        /// (i.e.:there is no partitioning scheme supported by the device that will return at least two subdevices), a value of 0 will be returned.
        /// </summary>
        PartitionProperties = NativeCl.CL_DEVICE_PARTITION_PROPERTIES,
		/// <summary>
        /// Returns the list of supported affinity domains for partitioning the device using CL_​DEVICE_​PARTITION_​BY_​AFFINITY_​DOMAIN.<br/><br/>
        /// This is a bit-field that describes one or more of the following values:<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​NUMA<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L4_​CACHE<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L3_​CACHE<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L2_​CACHE<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L1_​CACHE<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​NEXT_​PARTITIONABLE<br/><br/>
        /// If the device does not support any affinity domains, a value of 0 will be returned.
		/// </summary>
        PartitionAffinityDomain = NativeCl.CL_DEVICE_PARTITION_AFFINITY_DOMAIN,
		/// <summary>
        /// Returns the properties argument specified in clCreateSubDevices if device is a sub-device.<br/>
        /// In the case where the properties argument to clCreateSubDevices is CL_​DEVICE_​PARTITION_​BY_​AFFINITY_​DOMAIN, CL_​DEVICE_​AFFINITY_​DOMAIN_​NEXT_​PARTITIONABLE,<br/>
        /// the affinity domain used to perform the partition will be returned.<br/><br/>
        /// This can be one of the following values:<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​NUMA<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L4_​CACHE<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L3_​CACHE<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L2_​CACHE<br/>
        /// CL_​DEVICE_​AFFINITY_​DOMAIN_​L1_​CACHE<br/><br/> 
        /// Otherwise the implementation may either return a param_value_size_ret of 0 i.e.<br/>
        /// there is no partition type associated with device or can return a property value of 0 (where 0 is used to terminate the partition property list) in the memory that param_value points to.
        /// </summary>
        PartitionType = NativeCl.CL_DEVICE_PARTITION_TYPE,
		/// <summary>
        /// Returns the device reference count.<br/>
        /// If the device is a root-level device, a reference count of one is returned.
		/// </summary>
        ReferenceCount = NativeCl.CL_DEVICE_REFERENCE_COUNT,
		/// <summary>
        /// 
        /// </summary>
        SvmCapabilities = NativeCl.CL_DEVICE_SVM_CAPABILITIES,
		/// <summary>
        /// deprecated
        /// </summary>
        HostUnifiedMemory = NativeCl.CL_DEVICE_HOST_UNIFIED_MEMORY,
		/// <summary>
        /// 
        /// </summary>
        MinDataTypeAlignSize = NativeCl.CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE,
		/// <summary>
        /// 
        /// </summary>
        QueueProperties = NativeCl.CL_DEVICE_QUEUE_PROPERTIES,
		/// <summary>
        /// 
        /// </summary>
        PreferredPlatformAtomicAlignment = NativeCl.CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT,
		/// <summary>
        /// 
        /// </summary>
        PreferredGlobalAtomicAlignment = NativeCl.CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT,
		/// <summary>
        /// 
        /// </summary>
        PreferredLocalAtomicAlignment = NativeCl.CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT,
		/// <summary>
        /// 
        /// </summary>
        MaxNumSubGroups = NativeCl.CL_DEVICE_MAX_NUM_SUB_GROUPS,
		/// <summary>
        /// 
        /// </summary>
        SubGroupIndependentForwardProgress = NativeCl.CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS,
		
    };
}