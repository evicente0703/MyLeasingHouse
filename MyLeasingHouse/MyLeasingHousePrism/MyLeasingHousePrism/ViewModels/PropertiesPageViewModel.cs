using MyLeasing.Common.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLeasingHousePrism.ViewModels
{
    
    public class PropertiesPageViewModel : ViewModelBase
    {
        private OwnerResponse _owner;
        public PropertiesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Prperties";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("owner"))
            {
                _owner = parameters.GetValue<OwnerResponse>("owner");
                Title = $"Properties of: {_owner.FirstName}";
            }
        }
    }
}
