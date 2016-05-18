using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListViewSample
{
	public class ObservableItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		Person person;

		public ObservableItem ()
		{
			person = new Person ();
		}

		public string ProfileImage
		{
			set {
				if (!value.Equals (person.ProfileImage, StringComparison.Ordinal)) {
					person.ProfileImage = value;
					OnPropertyChanged ("ProfileImage");
				}
			} get {
				return person.ProfileImage;
			}
		}

		public string Name
		{
			set {
				if (!value.Equals (person.Name, StringComparison.Ordinal)) {
					person.Name = value;
					OnPropertyChanged ("Name");
				}
			} get {
				return person.Name;
			}
		}

		public string Address
		{
			set {
				if (!value.Equals (person.Address, StringComparison.Ordinal)) {
					person.Address = value;
					OnPropertyChanged ("Address");
				}
			} get {
				return person.Address;
			}
		}

		void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) {
				handler (this, new PropertyChangedEventArgs (propertyName));
			}
		}
	}
}

