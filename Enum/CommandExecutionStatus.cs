using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum CommandExecutionStatus  : uint
    {
        Complete = NativeCl.CL_COMPLETE,
		Running = NativeCl.CL_RUNNING,
		Submitted = NativeCl.CL_SUBMITTED,
		Queued = NativeCl.CL_QUEUED,
		
    };
}