using ViT_Sebastian.MVVM.Views;

namespace ViT_Sebastian
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ScheduleView", typeof(ScheduleView));
            Routing.RegisterRoute("AboutView", typeof(AboutView));
            Routing.RegisterRoute("CoverageView", typeof(CoverageView));
        }
    }
}
