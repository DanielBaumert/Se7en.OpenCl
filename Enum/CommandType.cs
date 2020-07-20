using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum CommandType  : uint
    {
        NDRangeKernel = NativeCl.CL_COMMAND_NDRANGE_KERNEL,
		Task = NativeCl.CL_COMMAND_TASK,
		NativeKernel = NativeCl.CL_COMMAND_NATIVE_KERNEL,
		ReadBuffer = NativeCl.CL_COMMAND_READ_BUFFER,
		WriteBuffer = NativeCl.CL_COMMAND_WRITE_BUFFER,
		CopyBuffer = NativeCl.CL_COMMAND_COPY_BUFFER,
		ReadImage = NativeCl.CL_COMMAND_READ_IMAGE,
		WriteImage = NativeCl.CL_COMMAND_WRITE_IMAGE,
		CopyImage = NativeCl.CL_COMMAND_COPY_IMAGE,
		CopyImageToBuffer = NativeCl.CL_COMMAND_COPY_IMAGE_TO_BUFFER,
		CopyBufferToImage = NativeCl.CL_COMMAND_COPY_BUFFER_TO_IMAGE,
		MapBuffer = NativeCl.CL_COMMAND_MAP_BUFFER,
		MapImage = NativeCl.CL_COMMAND_MAP_IMAGE,
		UnmapMemObject = NativeCl.CL_COMMAND_UNMAP_MEM_OBJECT,
		Marker = NativeCl.CL_COMMAND_MARKER,
		AcquireGlObjects = NativeCl.CL_COMMAND_ACQUIRE_GL_OBJECTS,
		ReleaseGlObjects = NativeCl.CL_COMMAND_RELEASE_GL_OBJECTS,
		ReadBufferRect = NativeCl.CL_COMMAND_READ_BUFFER_RECT,
		WriteBufferRect = NativeCl.CL_COMMAND_WRITE_BUFFER_RECT,
		CopyBufferRect = NativeCl.CL_COMMAND_COPY_BUFFER_RECT,
		User = NativeCl.CL_COMMAND_USER,
		Barrier = NativeCl.CL_COMMAND_BARRIER,
		MigrateMemObjects = NativeCl.CL_COMMAND_MIGRATE_MEM_OBJECTS,
		FillBuffer = NativeCl.CL_COMMAND_FILL_BUFFER,
		FillImage = NativeCl.CL_COMMAND_FILL_IMAGE,
		SVMFree = NativeCl.CL_COMMAND_SVM_FREE,
		SVMMemcpy = NativeCl.CL_COMMAND_SVM_MEMCPY,
		SVMMemfill = NativeCl.CL_COMMAND_SVM_MEMFILL,
		SVMMap = NativeCl.CL_COMMAND_SVM_MAP,
		SVMUnmap = NativeCl.CL_COMMAND_SVM_UNMAP,
		
    };
}