using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{  
	[Flags]
    public enum CommandQueueProperties  : ulong // cl_ulong
    {
        None = NativeCl.CL_NONE,
		/// <summary>
        /// Determines whether the commands queued in the command-queue are executed in-order or out-of-order.<br/>
        /// If set, the commands in the command-queue are executed out-of-order.<br/>
        /// Otherwise, commands are executed in-order
        /// </summary>
        OutOfOrderExecModeEnable = NativeCl.CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE,
		/// <summary>
        /// Enable or disable profiling of commands in the command-queue.<br/>
        /// If set, the profiling of commands is enabled.<br/>
        /// Otherwise profiling of commands is disabled.
        /// </summary>
        QueueProfilingEnable = NativeCl.CL_QUEUE_PROFILING_ENABLE,
		/// <summary>
        /// Indicates that this is a device queue.<br/>
        /// If CL_​QUEUE_​ON_​DEVICE is set, CL_​QUEUE_​OUT_​OF_​ORDER_​EXEC_​MODE_​ENABLE(Only out-of-order device queues are supported) must also be set
        /// </summary>
        QueueOnDevice = NativeCl.CL_QUEUE_ON_DEVICE,
		/// <summary>
        /// indicates that this is the default device queue. This can only be used with CL_​QUEUE_​ON_​DEVICE
        /// </summary>
        OnDeviceDefault = NativeCl.CL_QUEUE_ON_DEVICE_DEFAULT,
		
    };
}