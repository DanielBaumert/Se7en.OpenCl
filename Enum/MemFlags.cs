using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{  
	[Flags]
    public enum MemFlags  : ulong // cl_ulong
    {
        None = NativeCl.CL_NONE,
		ReadWrite = NativeCl.CL_MEM_READ_WRITE,
		WriteOnly = NativeCl.CL_MEM_WRITE_ONLY,
		ReadOnly = NativeCl.CL_MEM_READ_ONLY,
		UseHostPtr = NativeCl.CL_MEM_USE_HOST_PTR,
		AllocHostPtr = NativeCl.CL_MEM_ALLOC_HOST_PTR,
		CopyHostPtr = NativeCl.CL_MEM_COPY_HOST_PTR,
		
    };
}