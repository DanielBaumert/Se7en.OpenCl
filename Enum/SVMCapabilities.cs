using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{  
	[Flags]
    public enum SVMCapabilities 
    {
        SvmCoarseGrainBuffer = NativeCl.CL_DEVICE_SVM_COARSE_GRAIN_BUFFER,
		SvmFineGrainBuffer = NativeCl.CL_DEVICE_SVM_FINE_GRAIN_BUFFER,
		SvmFineGrainSystem = NativeCl.CL_DEVICE_SVM_FINE_GRAIN_SYSTEM,
		SvmAtomics = NativeCl.CL_DEVICE_SVM_ATOMICS,
		
    };
}