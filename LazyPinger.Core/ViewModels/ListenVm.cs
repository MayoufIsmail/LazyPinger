using LazyPinger.Base.Models;
using LazyPinger.Base.Models.Devices;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace LazyPinger.Core.ViewModels
{
    public class ListenVm
    {
        private static ListenVm? instance;
        public static ListenVm Instance => ListenVm.instance ??= new ListenVm();

        public LazyPingerDbContext dbContext { get; set; } = new();

        private ListenVm() { }

        public IEnumerable<DevicesGroup> DevicesGroup
        {
            get
            {
                return GetDevicesGroup();
            }
        }

        public IEnumerable<DevicePing> DevicesPing
        {
            get
            {
                return GetDevicePing();
            }
        }

        public IEnumerable<VmDevicesGroup> DevicesGroupVm
        {
            get
            {
                return GetDevicesGroupVm();
            }
        }

        public VmUserSelection? UserSelectionsVm
        {
            get
            {
                return GetUserSelectionVm();
            }
        }


        public List<DevicesGroup> GetDevicesGroup()
        {
            try
            {
                return dbContext.DevicesGroups.Include(o => o.DevicePings).ToList();
            }
            catch (Exception ex)
            {
                return new();
            }
        }

        public List<VmDevicesGroup> GetDevicesGroupVm()
        {
            try
            {
                return dbContext.DevicesGroups.Include(o => o.DevicePings).ToList().Select((o) => new VmDevicesGroup(o)
                {
                    Color = o.Color,
                    Type = o.Type
                }).ToList();
            }
            catch (Exception ex)
            {
                return new();
            }
        }

        public List<DevicePing> GetDevicePing()
        {
            try
            {
                return dbContext.DevicePings.Include(o => o.DevicesGroup).ToList() ?? new List<DevicePing>();
            }
            catch (Exception ex)
            {
                return new();
            }
        }

        public VmUserSelection? GetUserSelectionVm()
        {
            try
            {
                var res = dbContext.UserSelections.FirstOrDefault();
                if (res == null) return null;
                return new VmUserSelection(res);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
