using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum ProgramInfo  : uint // cl_uint
    {
        /// <summary>
        /// the program reference count
        /// </summary>
        ReferenceCount = NativeCl.CL_PROGRAM_REFERENCE_COUNT,
		/// <summary>
        /// the context specified when the program object is created
        /// </summary>
        Context = NativeCl.CL_PROGRAM_CONTEXT,
		/// <summary>
        ///  the number of devices associated with program
        /// </summary>
        NumDevices = NativeCl.CL_PROGRAM_NUM_DEVICES,
		/// <summary>
        /// the list of devices associated with the program object.<br/>
        /// This can be the devices associated with context on which the program object has been created or can be a subset of devices that are specified when a program object is created using clCreateProgramWithBinary.
        /// </summary>
        Devices = NativeCl.CL_PROGRAM_DEVICES,
		/// <summary>
        /// the program source code specified by clCreateProgramWithSource<para/>
        /// If program is created using clCreateProgramWithBinary, clCreateProgramWithIL or clCreateProgramWithBuiltInKernels,<br/>
        /// a null string or the appropriate program source code is returned depending on whether or not the program source code is stored in the binary.
        /// </summary>
        Source = NativeCl.CL_PROGRAM_SOURCE,
		/// <summary>
        /// an array that contains the size in bytes of the program binary (could be an executable binary, compiled binary or library binary) for each device associated with program.<br/>
        /// The size of the array is the number of devices associated with program.<para/>
        /// If a binary is not available for a device(s), a size of zero is returned.
        /// </summary>
        BinarySizes = NativeCl.CL_PROGRAM_BINARY_SIZES,
		/// <summary>
        /// the program binaries (could be an executable binary, compiled binary or library binary) for all devices associated with program.<para/>
        /// https://www.khronos.org/registry/OpenCL/sdk/2.2/docs/man/html/clGetProgramInfo.html
        /// </summary>
        Binaries = NativeCl.CL_PROGRAM_BINARIES,
		/// <summary>
        /// the number of kernels declared in program that can be created with clCreateKernel
        /// </summary>
        NumKernels = NativeCl.CL_PROGRAM_NUM_KERNELS,
		/// <summary>
        /// a semi-colon separated list of kernel names in program that can be created with clCreateKernel.
        /// </summary>
        KernelNames = NativeCl.CL_PROGRAM_KERNEL_NAMES,
		/// <summary>
        /// Returns the program IL for programs created with clCreateProgramWithIL.<para/>#
        /// If program is created with clCreateProgramWithSource, clCreateProgramWithBinary or clCreateProgramWithBuiltInKernels the memory pointed to by param_value will be unchanged and param_value_size_retwill be set to 0.
        /// </summary>
        IL = NativeCl.CL_PROGRAM_IL,
		/// <summary>
        /// This indicates that the program object contains non-trivial constructor(s) that will be executed by runtime before any kernel from the program is executed.
        /// </summary>
        ScopeGlobalCtorsPresent = NativeCl.CL_PROGRAM_SCOPE_GLOBAL_CTORS_PRESENT,
		/// <summary>
        /// This indicates that the program object contains non-trivial destructor(s) that will be executed by runtime when program is destroyed.
        /// </summary>
        ScopeGlobalDtorsPresent = NativeCl.CL_PROGRAM_SCOPE_GLOBAL_DTORS_PRESENT,
		
    };
}