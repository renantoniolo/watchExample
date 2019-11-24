// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace RockPaperScissors.WatchOSExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceButton ButtonPaper { get; set; }

		[Outlet]
		WatchKit.WKInterfaceButton ButtonRock { get; set; }

		[Outlet]
		WatchKit.WKInterfaceButton ButtonScissors { get; set; }

		[Outlet]
		WatchKit.WKInterfaceLabel LabelResult { get; set; }

		[Action ("CommandPaper")]
		partial void CommandPaper ();

		[Action ("CommandRock")]
		partial void CommandRock ();

		[Action ("CommandScissors")]
		partial void CommandScissors ();

		[Action ("Teste123")]
		partial void Teste123 ();
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelResult != null) {
				LabelResult.Dispose ();
				LabelResult = null;
			}

			if (ButtonScissors != null) {
				ButtonScissors.Dispose ();
				ButtonScissors = null;
			}

			if (ButtonPaper != null) {
				ButtonPaper.Dispose ();
				ButtonPaper = null;
			}

			if (ButtonRock != null) {
				ButtonRock.Dispose ();
				ButtonRock = null;
			}
		}
	}
}
