namespace ViewsDemo.Views;

public partial class SettersPage : ContentPage
{
	public SettersPage()
	{
		InitializeComponent();
		datePicker.Date = new DateTime(2022, 05, 22);
		datePicker.MinimumDate = datePicker.Date.AddMonths(-12);
        datePicker.MaximumDate = datePicker.Date.AddMonths(12);
    }

	private void Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if(label != null)
		{
			label.Text = $"Checkbox: {e.Value}";
		}
	}

	private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
	{
		if(label != null)
		{
			label.Text = $"DatePicker: {e.NewDate}"; 
		}
	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		image!.Rotation = e.NewValue;
		label!.Text = $"Slider: {e.NewValue:F2}";
	}

	private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		slider!.Value = e.NewValue;
	}
}