using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PPKicks {
	public partial class ExerciseDetails : ContentPage {

		public ExerciseDetails(Exercise exercise) {
			BindingContext = exercise;
			InitializeComponent();
		}
	}
}
