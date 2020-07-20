using Se7en.OpenCl.Native;
using System;
namespace Se7en.OpenCl
{
    public unsafe class Event : Handle
    {
        private CommandQueue _commandQueue;
        /// <summary>
        /// Return the command-queue associated with event. For user event objects, a NULL value is returned.
        /// </summary>
        public ref readonly CommandQueue CommandQueue => ref GetOrUpdateHandle<CommandQueue, EventInfo, uint>(ref _commandQueue, EventInfo.CommandQueue, NativeCl.GetEventInfo);

        private Context _context;
        /// <summary>
        /// Return the context associated with event.
        /// </summary>
        public ref readonly Context Context => ref GetOrUpdateHandle<Context, EventInfo, uint>(ref _context, EventInfo.Context, NativeCl.GetEventInfo);

        private CommandType _commandType;
        /// <summary>
        /// Return the command associated with event.
        /// </summary>
        public ref readonly CommandType CommandType => ref GetOrUpdateUnmanaged<CommandType, EventInfo, uint>(ref _commandType, EventInfo.CommandType, NativeCl.GetEventInfo);

        private CommandExecutionStatus _commandExecutionStatus;
        /// <summary>
        /// Return the execution status of the command identified by event. Valid values are:<para/>
        /// CL_​QUEUED(command has been enqueued in the command-queue),<br/>
        /// CL_​SUBMITTED(enqueued command has been submitted by the host to the device associated with the command-queue),<br/>
        /// CL_​RUNNING(device is currently executing this command),<br/>
        /// CL_​COMPLETE(the command has completed), or<br/>
        /// Error code given by a negative integer value.<para/>
        /// (command was abnormally terminated - this may be caused by a bad memory access etc.).<br/>
        /// These error codes come from the same set of error codes that are returned from the platform or runtime API calls as return values or errcode_ret values.
        /// </summary>
        public ref readonly CommandExecutionStatus CommandExecutionStatus => ref GetOrUpdateUnmanaged<CommandExecutionStatus, EventInfo, uint>(ref _commandExecutionStatus, EventInfo.CommandExecutionStatus, NativeCl.GetEventInfo);

        private uint _referenceCount;
        /// <summary>
        /// Return the event  reference count.
        /// </summary>
        public ref readonly uint ReferenceCount => ref GetOrUpdateUnmanaged<uint, EventInfo, uint>(ref _referenceCount, EventInfo.ReferenceCount, NativeCl.GetEventInfo);

        public override void Dispose()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.ReleaseEvent(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }

        public override void Retain()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.RetainEvent(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
    }
}
