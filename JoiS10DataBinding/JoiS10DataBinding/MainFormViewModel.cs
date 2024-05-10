using JoiS4WinFormsIntro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JoiS10DataBinding
{
    internal class MainFormViewModel : INotifyPropertyChanged
    {
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value)
                    return;
                _lastName = value;

                //If we use [CallerMemberName] in the OnPropertyChanged method
                //OnPropertyChanged();
                //If we don't use the [CallerMemberName] in the OnPropertyChanged method
                OnPropertyChanged("LastName");
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value)
                    return;
                _firstName = value;
                OnPropertyChanged();
            }
        }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate == value)
                    return;
                _birthDate = value;
                OnPropertyChanged();
            }
        }

        public BindingList<Participant> Participants { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainFormViewModel()
        {
            Participants = new BindingList<Participant>();
            BirthDate = DateTime.Now;
        }

        public void AddParticipant()
        {
            Participants.Add(new Participant(LastName, FirstName, BirthDate));
            LastName = FirstName = string.Empty;
            BirthDate = DateTime.Today;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
