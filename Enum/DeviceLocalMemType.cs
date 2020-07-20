using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum DeviceLocalMemType 
    {
        Local = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_NUMA,
		Global = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE,
		
    };
}