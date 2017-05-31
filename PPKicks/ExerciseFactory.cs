using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PPKicks {
	
	public static class ExerciseFactory {

		public static IList<Exercise> Exercises { get; private set; }

		static ExerciseFactory() {

			Exercises = new ObservableCollection<Exercise>{
				new Exercise {
					Name="Bosu Stretch",
					ExerciseSnapshot = "stretch.png",
					IsFavorite=false
				},

				new Exercise {
					Name="Pistol Squat",
					ExerciseSnapshot = "squat.png",
					IsFavorite=false
				},
			};
		}
	}
}
