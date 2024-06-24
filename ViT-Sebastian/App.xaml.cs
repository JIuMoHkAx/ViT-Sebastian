namespace ViT_Sebastian
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        #if WINDOWS
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            const int newWidth = 600;
            const int newHeight = 850;

            window.Height = newHeight;
            window.Width = newWidth;

            return window;
        }
        #endif
    }
}
