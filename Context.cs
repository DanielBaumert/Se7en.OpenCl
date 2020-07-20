using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{
    public unsafe class Context : Handle
    {
        private uint _referenceCount;
        /// <summary>
        /// Return the context reference count.
        /// </summary>
        public ref readonly uint ReferenceCount => ref GetOrUpdateUnmanaged<uint, ContextInfo, uint>(ref _referenceCount, ContextInfo.Properties, NativeCl.GetContextInfo);

        private uint _numDevice;
        /// <summary>
        /// Return the number of devices in context.
        /// </summary>
        public ref uint NumDevice => ref GetOrUpdateCount<ContextInfo, uint>(ref _numDevice, ContextInfo.Devices, NativeCl.GetContextInfo);

        private Device[] _devices;
        /// <summary>
        /// Return the list of devices and sub-devices in context.
        /// </summary>
        public ref readonly Device[] Devices => ref GetOrUpdateHandles<Device, ContextInfo, uint>(ref _devices, ref _numDevice, ContextInfo.Devices, NativeCl.GetContextInfo);

        // TODO: CL_​CONTEXT_​PROPERTIES

        public override void Dispose()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.ReleaseContext(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
        public override void Retain()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.RetainContext(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
    }
}
