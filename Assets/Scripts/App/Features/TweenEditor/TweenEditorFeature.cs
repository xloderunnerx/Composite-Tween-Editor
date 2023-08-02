using Composite.Core;

namespace App.Features.TweenEditor
{
	public class TweenEditorFeature : AbstractFeature
	{
		public override void InstallBindings()
		{
			CompositionRoot.BindFromHierarchy<TweenEditorView>();
			CompositionRoot.BindController<TweenEditorController>();
		}

		public override bool IsEnabled()
		{
			return CompositionRoot.GetInstance<TweenEditorConfiguration>().isEnabled;
		}
	}
}