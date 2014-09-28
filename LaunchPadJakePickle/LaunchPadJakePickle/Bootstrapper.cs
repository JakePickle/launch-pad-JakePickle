namespace LaunchPadJakePickle
{
	using Caliburn.Micro;
	using System.Windows;
	using ViewModels;
 
	class Bootstrapper : BootstrapperBase
	{
		public Bootstrapper()
		{
			Initialize();
		}
 
		protected override void OnStartup(object sender, StartupEventArgs e)
		{
			DisplayRootViewFor<MainWindowViewModel>();
		}
	}
}