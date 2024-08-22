namespace ViewsDemo.Views;

public partial class CommandPage : ContentPage
{
	public CommandPage()
	{
		InitializeComponent();
	}
	public void Clicked(object sender, EventArgs e)
	{
		label.Text = "Button Clicked";
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if(label != null)
		{
			label.Text = $"RadioButton {(sender as RadioButton).Content}: {e.Value}";
		}
	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{
		label.Text = "Image Button clicked";
	}
}