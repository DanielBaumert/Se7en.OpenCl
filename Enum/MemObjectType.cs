using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum MemObjectType 
    {
        Buffer = NativeCl.CL_MEM_OBJECT_BUFFER,
		Image2d = NativeCl.CL_MEM_OBJECT_IMAGE2D,
		Image3d = NativeCl.CL_MEM_OBJECT_IMAGE3D,
		Image2dArray = NativeCl.CL_MEM_OBJECT_IMAGE2D_ARRAY,
		Image1d = NativeCl.CL_MEM_OBJECT_IMAGE1D,
		Image1dArray = NativeCl.CL_MEM_OBJECT_IMAGE1D_ARRAY,
		Image1dBuffer = NativeCl.CL_MEM_OBJECT_IMAGE1D_BUFFER,
		Pipe = NativeCl.CL_MEM_OBJECT_PIPE,
		
    };
}