namespace QaxMobileApp;

public partial class TeacherLogin : ContentPage
{
	public TeacherLogin()
	{
		InitializeComponent();
	}

	public void Login_TeacherPageClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new TeacherPage());
	}
}