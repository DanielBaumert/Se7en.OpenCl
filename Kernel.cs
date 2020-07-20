using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{
    public unsafe class Kernel : Handle
    {
        private string _functionName;
        /// <summary>
        /// Return the kernel function name.
        /// </summary>
        public ref readonly string FunctionName => ref GetOrUpdateString<KernelInfo, uint>(ref _functionName, KernelInfo.FunctionName, NativeCl.GetKernelInfo);

        private uint _numArgs;
        /// <summary>
        /// Return the number of arguments to kernel
        /// </summary>
        public ref readonly uint NumArgs => ref GetOrUpdateUnmanaged<uint, KernelInfo, uint>(ref _numArgs, KernelInfo.NumArgs, NativeCl.GetKernelInfo);

        private uint _referenceCount;
        /// <summary>
        /// Return the kernel reference count.
        /// </summary>
        public ref readonly uint ReferenceCount => ref GetOrUpdateUnmanaged<uint, KernelInfo, uint>(ref _referenceCount, KernelInfo.ReferenceCount, NativeCl.GetKernelInfo);

        private Context _context;
        /// <summary>
        /// Return the context associated with kernel.
        /// </summary>
        public ref readonly Context Context => ref GetOrUpdateHandle<Context, KernelInfo, uint>(ref _context, KernelInfo.Context, NativeCl.GetKernelInfo);

        private Programm _programm;
        /// <summary>
        /// Return the program object associated with kernel.
        /// </summary>
        public ref readonly Programm Programm => ref GetOrUpdateHandle<Programm, KernelInfo, uint>(ref _programm, KernelInfo.Program, NativeCl.GetKernelInfo);

        private string[] _attributes;
        /// <summary>
        /// Returns any attributes specified using the __attribute__ OpenCL C qualifier with the kernel function declaration in the program source.
        /// </summary>
        public ref readonly string[] Attribues => ref GetOrUpdateStringArray<KernelInfo, uint>(ref _attributes, ' ', KernelInfo.Attributes, NativeCl.GetKernelInfo);

        public override void Dispose()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.ReleaseKernel(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
        public override void Retain()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.RetainKernel(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
    }
}
