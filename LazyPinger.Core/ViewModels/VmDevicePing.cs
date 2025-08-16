using CommunityToolkit.Mvvm.ComponentModel;
using LazyPinger.Base.Entities;
using LazyPinger.Base.Models;
using LazyPinger.Base.Models.Devices;

namespace LazyPinger.Core.ViewModels
{
    public partial class VmDevicePing : LazyPingerEntityVm<LazyPingerDbContext, DevicePing>
    {
        public VmDevicePing(DevicePing dbEntity) : base(dbEntity)
        {
            this.EntityTable = db => db.DevicePings;
            this.EntityID = dbEntity.ID;

            Name = Entity.Name;
            Image = Entity.Image;
            Group = Entity.DevicesGroup;
        }

        [ObservableProperty]
        public DevicesGroup group;

        [ObservableProperty]
        public string image;

        [ObservableProperty]
        public string name;

        partial void OnNameChanged(string value)
        {
            this.Entity.Name = value;
        }

        partial void OnImageChanged(string value)
        {
            this.Entity.Image = value;
        }

        partial void OnGroupChanged(DevicesGroup value)
        {
            this.Entity.DevicesGroup = value;
        }

    }
}
