using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{

    public struct ImageDesc
    {
        /// <summary>
        /// Describes the image type and must be either CL_​MEM_​OBJECT_​IMAGE1D, CL_​MEM_​OBJECT_​IMAGE1D_​BUFFER, CL_​MEM_​OBJECT_​IMAGE1D_​ARRAY, CL_​MEM_​OBJECT_​IMAGE2D, CL_​MEM_​OBJECT_​IMAGE2D_​ARRAY, or CL_​MEM_​OBJECT_​IMAGE3D.
        /// </summary>
        public MemObjectType Type;
        /// <summary>
        /// Is the width of the image in pixels.<br/>
        /// For a 2D image and image array, the image width must be a value ≥ 1 and ≤ CL_​DEVICE_​IMAGE2D_​MAX_​WIDTH.<br/>
        /// For a 3D image, the image width must be a value ≥1 and ≤ CL_​DEVICE_​IMAGE3D_​MAX_​WIDTH.<br/>
        /// For a 1D image buffer, the image width must be a value ≥1 and ≤ CL_​DEVICE_​IMAGE_​MAX_​BUFFER_​SIZE.<br/>
        /// For a 1D image and 1D image array, the image width must be a value ≥1 and ≤ CL_​DEVICE_​IMAGE2D_​MAX_​WIDTH.
        /// </summary>
        public IntPtr Width;
        /// <summary>
        /// Is the height of the image in pixels.<br/>
        /// This is only used if the image is a 2D or 3D image, or a 2D image array.<br/>
        /// For a 2D image or image array, the image height must be a value ≥ 1 and ≤ CL_​DEVICE_​IMAGE2D_​MAX_​HEIGHT.<br/>
        /// For a 3D image, the image height must be a value ≥ 1 and ≤ CL_​DEVICE_​IMAGE3D_​MAX_​HEIGHT.
        /// </summary>
        public IntPtr Height;
        /// <summary>
        /// Is the depth of the image in pixels.<br/>
        /// This is only used if the image is a 3D image and must be a value ≥ 1 and ≤ CL_​DEVICE_​IMAGE3D_​MAX_​DEPTH.
        /// </summary>
        public IntPtr Depth;
        /// <summary>
        /// Is the number of images in the image array.<br/>
        /// This is only used if the image is a 1D or 2D image array.<br/>
        /// The values for image_array_size, if specified, must be a value ≥ 1 and ≤ CL_​DEVICE_​IMAGE_​MAX_​ARRAY_​SIZE.<para/>
        /// Note that reading and writing 2D image arrays from a kernel with image_array_size=1 may be lower performance than 2D images.
        /// </summary>
        public IntPtr ArraySize;
        /// <summary>
        /// Is the scan-line pitch in bytes.<br/>
        /// This must be 0 if host_ptr is NULL and can be either 0 or ≥ image_width × size of element in bytes if host_ptr is not NULL.<br/>
        /// If host_ptr is not NULL and image_row_pitch = 0, image_row_pitch is calculated as image_width × size of element in bytes.<br/>
        /// If image_row_pitch is not 0, it must be a multiple of the image element size in bytes.<br/>
        /// For a 2D image created from a buffer, the pitch specified (or computed if pitch specified is 0) must be a multiple of 
        /// the maximum of the CL_​DEVICE_​IMAGE_​PITCH_​ALIGNMENT value for all devices in the context associated with the buffer specified by mem_object that support images.
        /// </summary>
        public IntPtr RowPitch;
        /// <summary>
        /// Is the size in bytes of each 2D slice in the 3D image or the size in bytes of each image in a 1D or 2D image array.<br/>
        /// This must be 0 if host_ptr is NULL.<br/>
        /// If host_ptr is not NULL, image_slice_pitch can be either 0 or ≥ image_row_pitch × image_height for a 2D image array or 3D image and can be either 0 or ≥ image_row_pitch for a 1D image array.<br/>
        /// If host_ptr is not NULL and image_slice_pitch = 0, image_slice_pitch is calculated as image_row_pitch × image_height for a 2D image array or 3D image and image_row_pitch for a 1D image array.<br/>
        /// If image_slice_pitch is not 0, it must be a multiple of the image_row_pitch.
        /// </summary>
        public IntPtr SlicePitch;
        /// <summary>
        /// Must be 0.
        /// </summary>
        public uint NumMipLevels;
        /// <summary>
        /// Must be 0.
        /// </summary>
        public uint MunSamples;
        /// <summary>
        /// May refer to a valid buffer or image memory object.<br/>
        /// mem_object can be a buffer memory object if image_type is CL_​MEM_​OBJECT_​IMAGE1D_​BUFFER or CL_​MEM_​OBJECT_​IMAGE2D6.<br/>
        /// mem_object can be an image object if image_type is CL_​MEM_​OBJECT_​IMAGE2D7. Otherwise it must be NULL.<br/>
        /// The image pixels are taken from the memory objects data store.<br/>
        /// When the contents of the specified memory objects data store are modified, those changes are reflected in the contents of the image object and vice-versa at corresponding synchronization points.
        /// </summary>
        BufferObject Buffer;

    }

    public unsafe class ImageObject : Handle
    {



        public override void Dispose()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.ReleaseMemObject(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }

        public override void Retain()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.RetainMemObject(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
    }
    public unsafe class BufferObject : Handle
    {
        private MemObjectType _memObjectType;
        /// <summary>
        /// Returns one of the following values:<br/>
        /// CL_​MEM_​OBJECT_​BUFFER if memobj is created with clCreateBuffer, clCreateBufferWithProperties, or clCreateSubBuffer.<br/>
        /// cl_image_desc.image_type argument value if memobj is created with clCreateImage, clCreateImageWithProperties, clCreateImage2D, or clCreateImage3D.<br/>
        /// CL_​MEM_​OBJECT_​PIPE if memobj is created with clCreatePipe.
        /// </summary>
        public ref readonly MemObjectType MemObjectType => ref GetOrUpdateUnmanaged<MemObjectType, MemInfo, uint>(ref _memObjectType, MemInfo.Type, NativeCl.GetMemObjectInfo);

        private MemFlags _memFlags;
        /// <summary>
        /// Return the flags argument value specified when memobj is created with clCreateBuffer, clCreateBufferWithProperties, clCreateSubBuffer, clCreateImage, clCreateImageWithProperties, clCreateImage2D, clCreateImage3D, or clCreatePipe.<br/>
        /// If memobj is a sub-buffer the memory access qualifiers inherited from parent buffer is also returned
        /// </summary>
        public ref readonly MemFlags MemFlags => ref GetOrUpdateUnmanaged<MemFlags, MemInfo, uint>(ref _memFlags, MemInfo.Flags, NativeCl.GetMemObjectInfo);

        private IntPtr _memSize;
        /// <summary>
        /// Return actual size of the data store associated with memobj in bytes.
        /// </summary>
        public ref readonly IntPtr MemSize => ref GetOrUpdateUnmanaged<IntPtr, MemInfo, uint>(ref _memSize, MemInfo.Size, NativeCl.GetMemObjectInfo);

        private IntPtr _hostPtr;
        /// <summary>
        /// If memobj is created with clCreateBuffer, clCreateBufferWithProperties, clCreateImage, clCreateImageWithProperties, clCreateImage2D, or clCreateImage3D, and CL_​MEM_​USE_​HOST_​PTR is specified in mem_flags, return the host_ptr argument value specified when memobj is created.<br/>
        /// Otherwise, if memobj is created with clCreateSubBuffer, and memobj is created from a buffer that was created with CL_​MEM_​USE_​HOST_​PTR specified in mem_flags, return the host_ptr passed to clCreateBuffer or clCreateBufferWithProperties, plus the origin value specified in buffer_create_info when memobj is created.<br/>
        ///  Otherwise, return NULL
        /// </summary>
        public ref readonly IntPtr HostPtr => ref GetOrUpdateUnmanaged<IntPtr, MemInfo, uint>(ref _hostPtr, MemInfo.HostPtr, NativeCl.GetMemObjectInfo);

        private uint _mapCount;
        /// <summary>
        /// Map count.
        /// </summary>
        public ref readonly uint MapCount => ref GetOrUpdateUnmanaged<uint, MemInfo, uint>(ref _mapCount, MemInfo.MapCount, NativeCl.GetMemObjectInfo);

        private uint _referenceCount;
        /// <summary>
        /// Return memobj reference count.
        /// </summary>
        public ref readonly uint ReferenceCount => ref GetOrUpdateUnmanaged<uint, MemInfo, uint>(ref _referenceCount, MemInfo.ReferenceCount, NativeCl.GetMemObjectInfo);

        private Context _context;
        /// <summary>
        /// Return context specified when memory object is created. If memobj is created using clCreateSubBuffer, the context associated with the memory object specified as the buffer argument to clCreateSubBuffer is returned.
        /// </summary>
        public ref readonly Context Context => ref GetOrUpdateHandle<Context, MemInfo, uint>(ref _context, MemInfo.Context, NativeCl.GetMemObjectInfo);

        private BufferObject _associatedMemObject;
        /// <summary>
        /// Return memory object from which memobj is created. This returns the memory object specified as buffer argument to clCreateSubBuffer if memobj is a subbuffer object created using clCreateSubBuffer.<br/>
        /// This returns the mem_object specified in cl_image_desc if memobj is an image object.<br/>
        /// Otherwise a NULL value is returned.
        /// </summary>
        public ref readonly BufferObject AssociatedMemObject => ref GetOrUpdateHandle<BufferObject, MemInfo, uint>(ref _associatedMemObject, MemInfo.AssociatedMemObject, NativeCl.GetMemObjectInfo);


        private IntPtr _offset;
        /// <summary>
        /// Return offset if memobj is a sub-buffer object created using clCreateSubBuffer.<br/>
        /// This return 0 if memobj is not a subbuffer object.
        /// </summary>
        public ref readonly IntPtr Offset => ref GetOrUpdateUnmanaged<IntPtr, MemInfo, uint>(ref _offset, MemInfo.Offset, NativeCl.GetMemObjectInfo);


        private bool _usesSVMPointer;
        /// <summary>
        /// Return CL_​TRUE if memobj is a buffer object that was created with CL_​MEM_​USE_​HOST_​PTR or is a sub-buffer object of a buffer object that was created with CL_​MEM_​USE_​HOST_​PTR and the host_ptr specified when the buffer object was created is a SVM pointer; otherwise returns CL_​FALSE.
        /// </summary>
        public ref readonly bool UsesSVMPointer => ref GetOrUpdateUnmanaged<bool, MemInfo, uint>(ref _usesSVMPointer, MemInfo.UsesSvmPointer, NativeCl.GetMemObjectInfo);

        // TODO: CL_​MEM_​PROPERTIES

        public override void Dispose()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.ReleaseMemObject(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }

        public override void Retain()
        {
            ErrorCode error;
            if ((error = (ErrorCode)NativeCl.RetainMemObject(_handle)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
        }
    }
}