using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum PlatformInfo  : uint
    {
        /// <summary>
        /// The profile name supported by the implementation.
        /// </summary>
        Profile = NativeCl.CL_PLATFORM_PROFILE,
		/// <summary>
        /// The OpenCL version supported by the implementation
        /// </summary>
        Version = NativeCl.CL_PLATFORM_VERSION,
		/// <summary>
        /// Platform name.
        /// </summary>
        Name = NativeCl.CL_PLATFORM_NAME,
		/// <summary>
        /// Platform vendor.
        /// </summary>
        Vendor = NativeCl.CL_PLATFORM_VENDOR,
		/// <summary>
        /// Extension names supported by the platform.
        /// </summary>
        Extensions = NativeCl.CL_PLATFORM_EXTENSIONS,
		/// <summary>
        /// The resolution of the host timer in nanoseconds
        /// </summary>
        HostTimerResolution = NativeCl.CL_PLATFORM_HOST_TIMER_RESOLUTION,
		
    };
}