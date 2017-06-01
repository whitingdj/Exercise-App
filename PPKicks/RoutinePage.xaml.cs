using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace PPKicks {
	public partial class RoutinePage : ContentPage {

		public RoutinePage() {
			InitializeComponent();
		}

		async void OnItemTapped(object sender, ItemTappedEventArgs e) {
			Exercise tappedExercise = (Exercise)e.Item;
			await Navigation.PushAsync(new ExerciseDetails(tappedExercise));
		}

		bool reverse;

		void OnRefreshing(object sender, EventArgs e) {
			ListView lv = (ListView)sender;

			List<Exercise> reversedData = ((reverse)
				? ExerciseFactory.Exercises.OrderBy(p => p.Name)
				: ExerciseFactory.Exercises.OrderByDescending(p => p.Name)).ToList();
			reverse = !reverse;

			ExerciseFactory.Exercises.Clear();
			foreach (var item in reversedData)
				ExerciseFactory.Exercises.Add(item);

			lv.IsRefreshing = false;
		}

	}
}
