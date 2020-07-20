using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum ContextInfo  : uint // cl_uint
    {
        ReferenceCount = NativeCl.CL_CONTEXT_REFERENCE_COUNT,
		Devices = NativeCl.CL_CONTEXT_DEVICES,
		Properties = NativeCl.CL_CONTEXT_PROPERTIES,
		
    };
}