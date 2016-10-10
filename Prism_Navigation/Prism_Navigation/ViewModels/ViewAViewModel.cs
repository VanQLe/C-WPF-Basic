using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism_Navigation.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prism_Navigation.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        public ViewAViewModel(IEventAggregator eventAggregator )
        {
            _eventAggregator = eventAggregator;
            FirstName = "Van";
            UpdateCommand = new DelegateCommand(UpdateMethod,CanUpdate).ObservesProperty(() => FirstName).ObservesProperty(() => LastName);
        }
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                SetProperty(ref _firstName, value);
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                SetProperty(ref _lastName, value);
            }
        }

        private DateTime _lastUpdated;
        public DateTime LastUpdated
        {
            get
            {
                return _lastUpdated;
            }

            set
            {
                SetProperty(ref _lastUpdated, value);
            }
        }

        public DelegateCommand UpdateCommand { get; set; }

        private void UpdateMethod()
        {
            LastUpdated = DateTime.Now;
            _eventAggregator.GetEvent<UpdateEvent>().Publish(LastUpdated.ToString());
        }

        private bool CanUpdate()
        {
            return (!String.IsNullOrWhiteSpace(FirstName) && !String.IsNullOrWhiteSpace(LastName));
        }
    }
}
