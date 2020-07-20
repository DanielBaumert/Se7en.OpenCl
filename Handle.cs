using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public abstract unsafe class Handle : IDisposable
    {
        internal delegate int GetInfoCallBack<TInfoRaw>(IntPtr h, TInfoRaw l, IntPtr i, void* v, out IntPtr e);

        internal IntPtr _handle;

        private TOut GetInfoAsUnmanaged<TOut, TInfo, TInfoRaw>(TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
            where TOut : unmanaged
            where TInfo : unmanaged
            where TInfoRaw : unmanaged
        {
            ErrorCode error;
            TOut @out;
            if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, (IntPtr)sizeof(TOut), &@out, out _)) != ErrorCode.Success)
            {
                throw new Exception(error.ToString());
            }
            return @out;
        }
        internal ref uint GetOrUpdateCount<TInfo, TInfoRaw>(ref uint count, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
            where TInfo : unmanaged
            where TInfoRaw : unmanaged
        {
            ErrorCode error;
            if (count == default)
            {
                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, IntPtr.Zero, null, out IntPtr size)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }
                count = *(uint*) &size;
            }
            return ref count;
        }
        internal ref string GetOrUpdateString<TInfo, TInfoRaw>(ref string value, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
          where TInfo : unmanaged
          where TInfoRaw : unmanaged
        {
            if (string.IsNullOrEmpty(value))
            {
                ErrorCode error;
                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, IntPtr.Zero, null, out IntPtr size)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                sbyte* stringBuffer = stackalloc sbyte[(int)size];

                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, size, stringBuffer, out _)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                value = new string(stringBuffer);
            }
            return ref value;
        }
        internal ref string[] GetOrUpdateStringArray<TInfo, TInfoRaw>(ref string[] value, ref uint count, char delimited, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
            where TInfo : unmanaged
            where TInfoRaw : unmanaged
        {
            if (value == null)
            {
                ErrorCode error;

                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, IntPtr.Zero, null, out IntPtr size)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                sbyte[] valueBuffer = new sbyte[size.ToInt32()];

                fixed (sbyte* valueBufferPtr = valueBuffer)
                {
                    if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, size, valueBufferPtr, out _)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }
                    value = new string(valueBufferPtr).Split(delimited);
                    if (count == default)
                    {
                        count = (uint)value.Length;
                    }
                }
            }

            return ref value;
        }
        internal ref string[] GetOrUpdateStringArray<TInfo, TInfoRaw>(ref string[] value, char delimited, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
            where TInfo : unmanaged
            where TInfoRaw : unmanaged
        {
            if (value == null)
            {
                ErrorCode error;
                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, IntPtr.Zero, null, out IntPtr size)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                sbyte[] valueBuffer = new sbyte[size.ToInt32()];

                fixed (sbyte* valueBufferPtr = valueBuffer)
                {
                    if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, size, valueBufferPtr, out _)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }
                    value = new string(valueBufferPtr).Split(delimited);
                }
            }

            return ref value;
        }
        internal ref TOut GetOrUpdateUnmanaged<TOut, TInfo, TInfoRaw>(ref TOut value, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
            where TOut : unmanaged
            where TInfo : unmanaged
            where TInfoRaw : unmanaged
        {
            if (value.Equals(null))
            {
                value = GetInfoAsUnmanaged<TOut, TInfo, TInfoRaw>(info, infoCallBack);
            }
            return ref value;
        }
        internal ref TOut[] GetOrUpdateUnmanagedArray<TOut, TInfo, TInfoRaw>(ref TOut[] value, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
          where TOut : unmanaged
          where TInfo : unmanaged
          where TInfoRaw : unmanaged
        {
            if (value == null)
            {

                ErrorCode error;
                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, IntPtr.Zero, null, out IntPtr size)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                fixed (TOut* valuePtr = value)
                {
                    if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, size, valuePtr, out _)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }
                }
            }
            return ref value;
        }
        internal ref TOut[] GetOrUpdateUnmanagedArray<TOut, TInfo, TInfoRaw>(ref TOut[] value, ref uint count, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
          where TOut : unmanaged
          where TInfo : unmanaged
          where TInfoRaw : unmanaged
        {
            if (value == null)
            {
                GetOrUpdateCount(ref count, info, infoCallBack);

                ErrorCode error;
                value = new TOut[(int)count];
                fixed (TOut* valuePtr = value)
                {
                    if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, (IntPtr)count, valuePtr, out _)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }
                }
            }
            return ref value;
        }
        internal ref TOut GetOrUpdateHandle<TOut, TInfo, TInfoRaw>(ref TOut value, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
            where TOut : Handle, new()
            where TInfo : unmanaged
            where TInfoRaw : unmanaged
        {
            if (value == null)
            {
                IntPtr handle;
                ErrorCode error;
                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, (IntPtr) IntPtr.Size, &handle, out _)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                value = new TOut() { _handle = handle };

            }
            return ref value;
        }
        internal ref TOut[] GetOrUpdateHandles<TOut, TInfo, TInfoRaw>(ref TOut[] value, ref uint count, TInfo info, GetInfoCallBack<TInfoRaw> infoCallBack)
         where TOut : Handle, new()
         where TInfo : unmanaged
         where TInfoRaw : unmanaged
        {
            if (value == null)
            {
                GetOrUpdateCount(ref count, info, infoCallBack);

                IntPtr* handles = stackalloc IntPtr[(int)count];
                ErrorCode error;
                if ((error = (ErrorCode)infoCallBack(_handle, *(TInfoRaw*)&info, (IntPtr)count, handles, out _)) != ErrorCode.Success)
                {
                    throw new Exception(error.ToString());
                }

                value = new TOut[(int)count];
                for (uint i = 0; i < count; i++)
                {
                    value[i] = new TOut() { _handle = (*(handles + i)) };
                }
            }
            return ref value;
        }

        public static implicit operator IntPtr(Handle handle) => handle._handle;

        public abstract void Retain();
        public abstract void Dispose();
    }
}
