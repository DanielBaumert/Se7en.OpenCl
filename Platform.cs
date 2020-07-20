using Se7en.OpenCl.Native;
using System;

namespace Se7en.OpenCl
{
    public unsafe class Platform : Handle
    {
        private static uint _numPlatforms;
        public static ref readonly uint NumPlatforms
        {
            get
            {
                if (_numPlatforms == default)
                {
                    ErrorCode error;
                    if ((error = (ErrorCode)NativeCl.GetPlatformIDs(0, null, out _numPlatforms)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }

                }
                return ref _numPlatforms;
            }
        }
        private static Platform[] _platforms;

        public static ref readonly Platform[] Platforms
        {
            get
            {
                if (_platforms == null)
                {
                    ErrorCode error;
                    if ((error = (ErrorCode)NativeCl.GetPlatformIDs(0, null, out _numPlatforms)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }

                    IntPtr* handles = stackalloc IntPtr[(int)_numPlatforms];
                    if ((error = (ErrorCode)NativeCl.GetPlatformIDs(_numPlatforms, handles, out _)) != ErrorCode.Success)
                    {
                        throw new Exception(error.ToString());
                    }

                    _platforms = new Platform[(int)_numPlatforms];
                    for (uint i = 0; i < _numPlatforms; i++)
                    {
                        _platforms[i] = new Platform() { _handle = (*(handles + i)) };
                    }
                }
                return ref _platforms;
            }
        }

        private string _profile;
        public ref readonly string Profile => ref GetOrUpdateString<PlatformInfo, uint>(ref _profile, PlatformInfo.Profile, NativeCl.GetPlatformInfo);

        private string _version;
        public ref readonly string Version => ref GetOrUpdateString<PlatformInfo, uint>(ref _version, PlatformInfo.Version, NativeCl.GetPlatformInfo);

        private string _name;
        public ref readonly string Name => ref GetOrUpdateString<PlatformInfo, uint>(ref _name, PlatformInfo.Name, NativeCl.GetPlatformInfo);

        private string _vendor;
        public ref readonly string Vendor => ref GetOrUpdateString<PlatformInfo, uint>(ref _vendor, PlatformInfo.Vendor, NativeCl.GetPlatformInfo);

        private string _extension;
        public ref readonly string Extension => ref GetOrUpdateString<PlatformInfo, uint>(ref _extension, PlatformInfo.Extensions, NativeCl.GetPlatformInfo);

        private ulong _hostTimerResolution;
        public ref readonly ulong HostTimeResolution => ref GetOrUpdateUnmanaged<ulong, PlatformInfo, uint>(ref _hostTimerResolution, PlatformInfo.HostTimerResolution, NativeCl.GetPlatformInfo);

        private uint _deviceCount;
        public ref readonly uint DeviceCount => ref GetOrUpdateCount<DeviceType, ulong>(ref _deviceCount, DeviceType.All, NativeCl.GetDeviceIDs);

        private Device[] _devices;
        public ref readonly Device[] Devices => ref GetOrUpdateHandles<Device, DeviceType, ulong>(ref _devices, ref _deviceCount, DeviceType.All, NativeCl.GetDeviceIDs);

        public override void Dispose()
        {
            throw new NotSupportedException();
        }

        public override void Retain()
        {
            throw new NotSupportedException();
        }
    }
}
