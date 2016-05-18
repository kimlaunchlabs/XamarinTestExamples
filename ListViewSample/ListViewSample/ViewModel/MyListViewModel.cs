using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListViewSample
{
	public class MyListViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public MyListViewModel ()
		{
			// some codes

		}

		//some code bindings

		void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) {
				handler (this, new PropertyChangedEventArgs (propertyName));
			}
		}

	}
}

