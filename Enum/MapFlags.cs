using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{  
	[Flags]
    public enum MapFlags  : uint
    {
        /// <summary>
        /// This flag specifies that the region being mapped in the memory object is being mapped for reading.
        /// </summary>
        Read = NativeCl.CL_MAP_READ,
		/// <summary>
        /// This flag specifies that the region being mapped in the memory object is being mapped for writing.
        /// </summary>
        Write = NativeCl.CL_MAP_WRITE,
		/// <summary>
        /// This flag specifies that the region being mapped in the memory object is being mapped for writing.<br/>
        /// MapFlags.Read or MapFlags.Write and MapFlags.WriteInvalidateRegion are mutually exclusive.
        /// </summary>
        WriteInvalidateRegion = NativeCl.CL_MAP_WRITE_INVALIDATE_REGION,
		
    };
}