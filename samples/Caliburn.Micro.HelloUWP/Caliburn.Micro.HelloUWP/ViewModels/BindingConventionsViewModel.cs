﻿using System;

namespace Caliburn.Micro.HelloUWP.ViewModels
{
    public class BindingConventionsViewModel : Screen
    {
        private DeveloperViewModel selectedDeveloper;

        public BindingConventionsViewModel()
        {
            Developers = new BindableCollection<DeveloperViewModel>
            {
                new DeveloperViewModel("Ben Gracewood"),
                new DeveloperViewModel("Ian Randall"),
                new DeveloperViewModel("Keith Patton"),
                new DeveloperViewModel("Nigel Sampson")
            };
        }

        public BindableCollection<DeveloperViewModel> Developers
        {
            get;
            private set;
        }

        public DeveloperViewModel SelectedDeveloper
        {
            get
            {
                return selectedDeveloper;
            }
            set
            {
                selectedDeveloper = value;
                NotifyOfPropertyChange(() => SelectedDeveloper);
            }
        }
        
    }
}
