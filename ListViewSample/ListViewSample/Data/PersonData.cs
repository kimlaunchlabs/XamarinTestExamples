using System;
using System.Collections.ObjectModel;

namespace ListViewSample
{
	// Observable Collection
	public class PersonData
	{
		ObservableCollection <ObservableItem> person;

		public PersonData ()
		{
			person = new ObservableCollection<ObservableItem> {
				new ObservableItem {ProfileImage = "test.png", Name = "Porche Carrera GT", Address =  "Cebu"},
				new ObservableItem {ProfileImage = "test.png", Name = "Audi Lemans Quatro", Address =  "Mandaue"},
				new ObservableItem {ProfileImage = "test.png", Name = "Gumpart Apollo", Address =  "Leyte"}
			};
		}

		public ObservableCollection <ObservableItem> Persona
		{
			set {
				if (value != person) {
					person = value;
				}
			}
			get {
				return person;
			}
		}
	}
}

