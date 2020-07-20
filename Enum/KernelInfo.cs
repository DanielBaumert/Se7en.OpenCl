using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum KernelInfo  : int // cl_int
    {
        /// <summary>
        /// the kernel function name
        /// </summary>
        FunctionName = NativeCl.CL_KERNEL_FUNCTION_NAME,
		/// <summary>
        /// the number of arguments to kernel
        /// </summary>
        NumArgs = NativeCl.CL_KERNEL_NUM_ARGS,
		/// <summary>
        /// the kernel reference count
        /// </summary>
        ReferenceCount = NativeCl.CL_KERNEL_REFERENCE_COUNT,
		/// <summary>
        /// the context associated with kernel
        /// </summary>
        Context = NativeCl.CL_KERNEL_CONTEXT,
		/// <summary>
        /// the program object associated with kernel
        /// </summary>
        Program = NativeCl.CL_KERNEL_PROGRAM,
		/// <summary>
        /// any attributes specified using the __attribute__ OpenCL C qualifier
        /// </summary>
        Attributes = NativeCl.CL_KERNEL_ATTRIBUTES,
		MaxNumSubGroups = NativeCl.CL_KERNEL_MAX_NUM_SUB_GROUPS,
		CompileNumSubGroups = NativeCl.CL_KERNEL_COMPILE_NUM_SUB_GROUPS,
		
    };
}