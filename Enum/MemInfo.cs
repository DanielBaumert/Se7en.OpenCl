using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{
    public enum MemInfo  : uint // cl_uint
    {
		Type = NativeCl.CL_MEM_TYPE,
		Flags = NativeCl.CL_MEM_FLAGS,
		Size = NativeCl.CL_MEM_SIZE,
		HostPtr = NativeCl.CL_MEM_HOST_PTR,
		MapCount = NativeCl.CL_MEM_MAP_COUNT,
		ReferenceCount = NativeCl.CL_MEM_REFERENCE_COUNT,
		Context = NativeCl.CL_MEM_CONTEXT,
		AssociatedMemObject = NativeCl.CL_MEM_ASSOCIATED_MEMOBJECT,
		Offset = NativeCl.CL_MEM_OFFSET,
		UsesSvmPointer = NativeCl.CL_MEM_USES_SVM_POINTER,
    };
}