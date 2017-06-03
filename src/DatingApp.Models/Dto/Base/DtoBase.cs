using System.ComponentModel;
using System.Runtime.CompilerServices;

using DatingApp.Data.Contracts.Dto;
using DatingApp.Data.Properties;

namespace DatingApp.Data.Dto.Base
{
    public abstract class DtoBase : IDto
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}