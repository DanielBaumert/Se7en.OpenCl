using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum DeviceAffinityDomain 
    {
        DeviceAffinityDomainNuma = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_NUMA,
		DeviceAffinityDomainL4Cache = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE,
		DeviceAffinityDomainL3Cache = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE,
		DeviceAffinityDomainL2Cache = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE,
		DeviceAffinityDomainL1Cache = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE,
		DeviceAffinityDomainNextPartitionable = NativeCl.CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE,
		
    };
}