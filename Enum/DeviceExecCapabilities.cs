using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum DeviceExecCapabilities 
    {
        ExecKernel = NativeCl.CL_EXEC_KERNEL,
		ExecNativeKernel = NativeCl.CL_EXEC_NATIVE_KERNEL,
		
    };
}