using System;
using Cirrious.MvvmCross.Binding.Touch.Target;
using UIKit;
using Foundation;

namespace News.iOS
{
    public class CustomUITextViewHtmlTargetBinding : MvxUITextViewTextTargetBinding
    {
        public CustomUITextViewHtmlTargetBinding (UITextView target) : base (target)
        {
        }

        protected override void SetValueImpl (object target, object value)
        {
            NSError error = null;
            var attributedString = new NSAttributedString((string)value, new NSAttributedStringDocumentAttributes { DocumentType = NSDocumentType.HTML }, ref error);
            ((UITextView)target).AttributedText = attributedString;
        }
    }
}

