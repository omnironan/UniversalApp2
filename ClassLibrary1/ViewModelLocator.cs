using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace SharedViewModels
{
    public class ViewModelLocator
    {
        public SharedViewModel SharedViewModel
        {
            get { return ServiceLocator.Current.GetInstance<SharedViewModel>(); }
        }

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<SharedViewModel>();
        }
    }
}
