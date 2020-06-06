namespace Ventas.Infrastructure
{
    using ViewModels;

    public class IntanceLocator
    {
        public MainViewModel Main { get; set; }
        public IntanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
