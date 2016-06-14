﻿namespace Atata
{
    /// <summary>
    /// Indicates the verification of the content of the &lt;h1&gt; tag when the page object is initialized.
    /// </summary>
    public class VerifyH1Attribute : VerifyHeadingTriggerAttribute
    {
        public VerifyH1Attribute(TermFormat format = TermFormat.Inherit)
            : base(format)
        {
        }

        public VerifyH1Attribute(params string[] values)
            : base(values)
        {
        }

        public VerifyH1Attribute(TermMatch match, TermFormat format = TermFormat.Inherit)
            : base(match, format)
        {
        }

        public VerifyH1Attribute(TermMatch match, params string[] values)
            : base(match, values)
        {
        }

        protected override void OnExecute<TOwner>(TriggerContext<TOwner> context, string[] values)
        {
            string name = TermResolver.ToDisplayString(values);
            var headingControl = context.Owner.CreateControl<H1<TOwner>>(name, new FindByIndexAttribute(Index));
            headingControl.VerifyUntilMatchesAny(Match, values);
        }
    }
}