using System;
using Android.Text;
using Android.Widget;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Binding.ExtensionMethods;
using Cirrious.MvvmCross.Binding.Droid.Target;
using Cirrious.MvvmCross.Binding;

namespace News.Droid.CustomBindings
{
    public class MvxTextViewHtmlTargetBinding
        : MvxTextViewTextTargetBinding
    {
        public MvxTextViewHtmlTargetBinding(TextView target)
            : base(target)
        {
        }

        protected override void SetValueImpl(object target, object toSet)
        {
         //   ((TextView)target).Text = (string)toSet;
            ((TextView)target).TextFormatted = Html.FromHtml((string)toSet);
        }
    }
}