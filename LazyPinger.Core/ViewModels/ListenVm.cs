using LazyPinger.Base.Models;
using LazyPinger.Base.Models.Devices;
using Microsoft.EntityFrameworkCore;

namespace LazyPinger.Core.ViewModels
{
    public class ListenVm
    {
        private static ListenVm? instance;
        public static ListenVm Instance => ListenVm.instance ??= new ListenVm();

        public LazyPingerDbContext dbContext { get; set; } = new();

        private ListenVm() { }

        public IEnumerable<DevicesGroup> DevicesGroups
        {
            get
            {
                return dbContext.DevicesGroups.Include(o => o.DevicePings).ToList();
            }
        }

        public IEnumerable<DevicePing> DevicesPing
        {
            get
            {
                return dbContext.DevicePings.Include(o => o.DevicesGroup).ToList();
            }
        }


        public VmUserSelection UserSelections
        {
            get
            {
                using var db = new LazyPingerDbContext();

                var res = db.UserSelections.FirstOrDefault();

                //if (res is null)
                    //return new VmUserSelection();

                return new VmUserSelection(res);
            }
            set
            {

            }
        }


    }
}
