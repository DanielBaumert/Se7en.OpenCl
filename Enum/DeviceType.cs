using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{  
	[Flags]
    public enum DeviceType  : ulong // cl_ulong
    {
        /// <summary>
        /// The default OpenCL device in the system. The default device cannot be a CL_​DEVICE_​TYPE_​CUSTOM device.
        /// </summary>
        Default = NativeCl.CL_DEVICE_TYPE_DEFAULT,
		/// <summary>
        /// An OpenCL device that is the host processor.<br/>
        /// The host processor runs the OpenCL implementations and is a single or multi-core CPU.
        /// </summary>
        Cpu = NativeCl.CL_DEVICE_TYPE_CPU,
		/// <summary>
        ///  An OpenCL device that is a GPU.<br/>
        ///  By this we mean that the device can also be used to accelerate a 3D API such as OpenGL or DirectX.
        /// </summary>
        Gpu = NativeCl.CL_DEVICE_TYPE_GPU,
		/// <summary>
        /// Dedicated OpenCL accelerators (for example the IBM CELL Blade).<br/>
        /// These devices communicate with the host processor using a peripheral interconnect such as PCIe.
        /// </summary>
        Accelerator = NativeCl.CL_DEVICE_TYPE_ACCELERATOR,
		Custom = NativeCl.CL_DEVICE_TYPE_CUSTOM,
		/// <summary>
        /// All OpenCL devices available in the system except CL_​DEVICE_​TYPE_​CUSTOM devices..
        /// </summary>
        All = NativeCl.CL_DEVICE_TYPE_ALL,
		
    };
}