using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PPKicks {
	
	public static class ExerciseFactory {

		public static IList<Exercise> Exercises { get; private set; }

		static ExerciseFactory() {

			Exercises = new ObservableCollection<Exercise>{
				new Exercise {
					Name="Crunches",
					Focus="Great for Core Strength",
					ExerciseSnapshot = "crunch.png",
					Description= "Crunch them abs, guuuuuurl",
					IsFavorite=false
				},

				new Exercise {
					Name="Pistol Squat",
					Focus="Great for Quad Strength",
					ExerciseSnapshot = "squat.png",
					Description= "Squat them leeeeggggs, guuuuuurl",
					IsFavorite=false
				},

				new Exercise {
					Name="Deadlifts",
					Focus="Solid for tight hammies",
					ExerciseSnapshot = "deadlift.png",
					Description= "Neutral spine, slight bend in the knee, booty pop, guuuuuurl",
					IsFavorite=false
				},
			};
		}
	}
}
