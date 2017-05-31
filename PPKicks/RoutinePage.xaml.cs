using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PPKicks {
	public partial class RoutinePage : ContentPage {
		public RoutinePage() {
			InitializeComponent();
		}

		async void OnItemTapped(object Sender, ItemTappedEventArgs e) {
			Exercise tappedExercise = (Exercise)e.Item;
			await Navigation.PushAsync(new ExerciseDetails(tappedExercise));
		}
	}
}
