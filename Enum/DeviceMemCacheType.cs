using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum DeviceMemCacheType 
    {
        None = NativeCl.CL_NONE,
		ReadOnlyCache = NativeCl.CL_READ_ONLY_CACHE,
		ReadWriteCache = NativeCl.CL_READ_WRITE_CACHE,
		
    };
}