using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PPKicks {
	
	public class Exercise : INotifyPropertyChanged {

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		public string ExerciseSnapshot { get; set; }

		string name;
		public string Name {
			get { return name; }
			set { SetProperty(ref name, value); }
		}

		string description;
		public string Description {
			get { return description; }
			set { SetProperty(ref description, value); }
		}


		bool isFavorite;
		public bool IsFavorite {
			get { return isFavorite; }
			set { SetProperty(ref isFavorite, value); }
		}

		bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "") {
			if (!object.Equals(field, value)) {
				field = value;
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
				return true;
			}
			return false;
		}

		public override string ToString() {
			return this.Name;
		}
	}
}
