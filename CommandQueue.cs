using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{
    public unsafe class CommandQueue : Handle
    {

        private Context _context;
        /// <summary>
        /// Return the context specified when the command-queue is created.
        /// </summary>
        public ref readonly Context Context => ref GetOrUpdateHandle<Context, CommandQueueInfo, uint>(ref _context, CommandQueueInfo.Context, NativeCl.GetCommandQueueInfo);

        private Device _device;
        /// <summary>
        /// Return the device specified when the command-queue is created.
        /// </summary>
        public ref readonly Device Device => ref GetOrUpdateHandle<Device, CommandQueueInfo, uint>(ref _device, CommandQueueInfo.Device, NativeCl.GetCommandQueueInfo);

        private uint _referenceCount;
        /// <summary>
        /// Return the command-queue reference count.
        /// </summary>
        public ref readonly uint ReferenceCount => ref GetOrUpdateUnmanaged<uint, CommandQueueInfo, uint>(ref _referenceCount, CommandQueueInfo.ReferenceCount, NativeCl.GetCommandQueueInfo);

        // TODO: cl_command_queue_properties

        private uint _queueSize;
        /// <summary>
        /// Return the currently specified size for the device command-queue.<br/>
        /// This query is only supported for device command queues.
        /// </summary>
        public ref readonly uint QueueSize => ref GetOrUpdateUnmanaged<uint, CommandQueueInfo, uint>(ref _queueSize, CommandQueueInfo.Size, NativeCl.GetCommandQueueInfo);

        private CommandQueue _queueDeviceDefault;
        /// <summary>
        /// Return the current default command queue for the underlying device.
        /// </summary>
        public ref readonly CommandQueue QueueDeviceDefault => ref GetOrUpdateHandle<CommandQueue, CommandQueueInfo, uint>(ref _queueDeviceDefault, CommandQueueInfo.Context, NativeCl.GetCommandQueueInfo);

        public override void Dispose()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.ReleaseCommandQueue(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }

        public override void Retain()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.RetainCommandQueue(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
    }
}
