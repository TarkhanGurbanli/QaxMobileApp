namespace QaxMobileApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
          
        }

        private void Teacher_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TeacherLogin());
        }

        private void Parent_Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ParentLogin());
        }

        private void Success_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OurSuccessesPage());
        }

        private void Achievements_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OurAchievementsPage());
        }

        private void Services_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ServicesPage());
        }

        private void Contact_PageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}