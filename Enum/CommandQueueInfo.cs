using Se7en.OpenCl.Native;

namespace Se7en.OpenCl
{  
    public enum CommandQueueInfo  : int // cl_int
    {
        /// <summary>
        /// the context specified when the command-queue is created
        /// </summary>
        Context = NativeCl.CL_QUEUE_CONTEXT,
		/// <summary>
        /// the device specified when the command-queue is created
        /// </summary>
        Device = NativeCl.CL_QUEUE_DEVICE,
		/// <summary>
        /// the command-queue reference count
        /// </summary>
        ReferenceCount = NativeCl.CL_QUEUE_REFERENCE_COUNT,
		/// <summary>
        /// the currently specified properties for the command-queue.<br/>
        /// These properties are specified by the value associated with the CL_​QUEUE_​PROPERTIES passed in properties argument in clCreateCommandQueueWithProperties.
        /// </summary>
        Properties = NativeCl.CL_QUEUE_PROPERTIES,
		/// <summary>
        /// the currently specified size for the device command-queue.<br/>
        /// This query is only supported for device command queues
        /// </summary>
        Size = NativeCl.CL_QUEUE_SIZE,
		
    };
}