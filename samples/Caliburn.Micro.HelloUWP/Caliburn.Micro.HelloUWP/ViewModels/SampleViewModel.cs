using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.HelloUWP.ViewModels
{
    public class SampleViewModel : PropertyChangedBase
    {
        private string _title;
        private string _subtitle;
        private Type _viewModelType;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                this.Set(ref _title, value);
            }
        }

        public Type ViewModelType
        {
            get
            {
                return _viewModelType;
            }
            set
            {
                this.Set(ref _viewModelType ,value);
            }
        }

        public string Subtitle
        {
            get
            {
                return _subtitle;
            }
            set
            {
                this.Set(ref _subtitle, value);
            }
        }
    }
}
