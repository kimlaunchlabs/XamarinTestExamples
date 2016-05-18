using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.Windows.Input;

namespace MVVMTestSample
{
	public class MVVMTestViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private PersonRepository _repository;

		public MVVMTestViewModel ()
		{
			// This should be injected
			_repository = new PersonRepository();

			// Populate the ViewModel
			var person = _repository.GetPerson(1);
			Name = person.Name;
			Updated = person.Updated;
		}

		private string _name;
		public string Name
		{
			get {
				return _name;
			}
			set {
				_name = value;
				OnPropertyChanged();
			}
		}

		private string _updated;
		public string Updated
		{
			get {
				return _updated;
			}
			set {
				_updated = value;
				OnPropertyChanged ();
			}
		}

		public ICommand Save 
		{
			get {
				return new Command (() => {

					// Perform some logic
					Updated = DateTime.Now.ToString();

					// Store data to back end
					var person = _repository.GetPerson(1);
					person.Name = _name;
					person.Updated = _updated;
					_repository.Update(person);

					System.Diagnostics.Debug.WriteLine ("Name: " + Name + "\nUpdated " + Updated);
				});
			}
		}


		private void OnPropertyChanged ([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) {
				handler (this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}

