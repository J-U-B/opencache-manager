
// This file has been generated by the GUI designer. Do not modify.
namespace ocmgtk
{
	public partial class HTMLEditorWidget
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.ScrolledWindow editorWindow;
		
		private global::Gtk.TextView editor;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ocmgtk.HTMLEditorWidget
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "ocmgtk.HTMLEditorWidget";
			// Container child ocmgtk.HTMLEditorWidget.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.editorWindow = new global::Gtk.ScrolledWindow ();
			this.editorWindow.CanFocus = true;
			this.editorWindow.Name = "editorWindow";
			this.editorWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child editorWindow.Gtk.Container+ContainerChild
			this.editor = new global::Gtk.TextView ();
			this.editor.CanFocus = true;
			this.editor.Name = "editor";
			this.editor.WrapMode = ((global::Gtk.WrapMode)(2));
			this.editorWindow.Add (this.editor);
			this.vbox3.Add (this.editorWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.editorWindow]));
			w4.Position = 0;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
		}
	}
}
