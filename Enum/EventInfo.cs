using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum EventInfo  : int
    {
        CommandExecutionStatus = NativeCl.CL_EVENT_COMMAND_EXECUTION_STATUS,
		CommandQueue = NativeCl.CL_EVENT_COMMAND_QUEUE,
		CommandType = NativeCl.CL_EVENT_COMMAND_TYPE,
		Context = NativeCl.CL_EVENT_CONTEXT,
		ReferenceCount = NativeCl.CL_EVENT_REFERENCE_COUNT,
		
    };
}