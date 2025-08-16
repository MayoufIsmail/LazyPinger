
using CommunityToolkit.Mvvm.ComponentModel;
using LazyPinger.Base.Entities;
using LazyPinger.Base.Models;
using LazyPinger.Base.Models.Devices;

namespace LazyPinger.Core.ViewModels
{
    public partial class VmDevicesGroup : LazyPingerEntityVm<LazyPingerDbContext, DevicesGroup>
    {
        public VmDevicesGroup(DevicesGroup dbEntity) : base(dbEntity)
        {
            this.EntityTable = db => db.DevicesGroups;
            this.EntityID = dbEntity.ID;

            this.Type = Entity.Type;
            this.Color = Entity.Color;
        }

        [ObservableProperty]
        public string color;

        [ObservableProperty]
        public string type;

        partial void OnTypeChanged(string value)
        {
            this.Entity.Type = value;
        }

        partial void OnColorChanged(string value)
        {
            this.Entity.Color = value;
        }
    }
}
