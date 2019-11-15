using MyLeasing.Common.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyLeasingHousePrism.ViewModels
{
    
    public class PropertiesPageViewModel : ViewModelBase
    {
        private OwnerResponse _owner;
        private ObservableCollection<PropertyResponse> _properties;
        public PropertiesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Prperties";
        }

        public ObservableCollection<PropertyResponse> Properties 
        {
            get => _properties;
            set => SetProperty(ref _properties, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.ContainsKey("owner"))
            {
                _owner = parameters.GetValue<OwnerResponse>("owner");
                Title = $"Properties of: {_owner.FirstName}";
                Properties = new ObservableCollection<PropertyResponse>(_owner.Properties);
            }
        }
    }
}
