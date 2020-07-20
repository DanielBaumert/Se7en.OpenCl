using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum DeviceFPConfig 
    {
        FpDenorm = NativeCl.CL_FP_DENORM,
		FpInfNan = NativeCl.CL_FP_INF_NAN,
		FpRoundToNearest = NativeCl.CL_FP_ROUND_TO_NEAREST,
		FpRoundToZero = NativeCl.CL_FP_ROUND_TO_ZERO,
		FpRoundToInf = NativeCl.CL_FP_ROUND_TO_INF,
		FpFma = NativeCl.CL_FP_FMA,
		FpSoftFloat = NativeCl.CL_FP_SOFT_FLOAT,
		FpCorrectlyRoundedDivideSqrt = NativeCl.CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT,
		
    };
}