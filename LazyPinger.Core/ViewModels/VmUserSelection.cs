using CommunityToolkit.Mvvm.ComponentModel;
using LazyPinger.Base.Entities;
using LazyPinger.Base.Models;

namespace LazyPinger.Core.ViewModels
{
    public partial class VmUserSelection : LazyPingerEntityVm<LazyPingerDbContext, UserSelection>
    {
        public VmUserSelection(UserSelection dbEntity) : base(dbEntity)
        {
            this.EntityTable = db => db.UserSelections;
            this.EntityID = dbEntity.ID;

            IsAutoRunDisabled = Entity.AutoRun;
            IsFastPingDisabled = Entity.FastPing;
        }

        [ObservableProperty]
        public bool isAutoRunDisabled;

        [ObservableProperty]
        public bool isFastPingDisabled;

        partial void OnIsAutoRunDisabledChanged(bool value)
        {
            this.Entity.AutoRun = value;
        }
        partial void OnIsFastPingDisabledChanged(bool value)
        {
            this.Entity.FastPing = value;
        }
    }
}
