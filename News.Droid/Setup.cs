using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using Android.Widget;
using Cirrious.MvvmCross.Binding.Bindings.Target.Construction;
using News.Droid.CustomBindings;

namespace News.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void FillTargetFactories (Cirrious.MvvmCross.Binding.Bindings.Target.Construction.IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories (registry);
            registry.RegisterCustomBindingFactory<TextView>("Html", textView => new CustomTextViewHtmlTargetBinding(textView));
        }
    }
}