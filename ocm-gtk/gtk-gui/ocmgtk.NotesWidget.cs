
// This file has been generated by the GUI designer. Do not modify.
namespace ocmgtk
{
	public partial class NotesWidget
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.ToggleAction boldAction;
		
		private global::Gtk.Action italicAction;
		
		private global::Gtk.Action missingImageAction;
		
		private global::Gtk.Action underlineAction;
		
		private global::Gtk.VBox vbox1;
		
		private global::ocmgtk.HTMLEditorWidget editorWidget;
		
		private global::Gtk.HButtonBox hbuttonbox1;
		
		private global::Gtk.Button saveButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ocmgtk.NotesWidget
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.boldAction = new global::Gtk.ToggleAction ("boldAction", null, null, "gtk-bold");
			w2.Add (this.boldAction, null);
			this.italicAction = new global::Gtk.Action ("italicAction", null, null, "gtk-italic");
			w2.Add (this.italicAction, null);
			this.missingImageAction = new global::Gtk.Action ("missingImageAction", null, null, "gtk-missing-image");
			w2.Add (this.missingImageAction, null);
			this.underlineAction = new global::Gtk.Action ("underlineAction", null, null, "gtk-underline");
			w2.Add (this.underlineAction, null);
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "ocmgtk.NotesWidget";
			// Container child ocmgtk.NotesWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.editorWidget = null;
			this.vbox1.Add (this.editorWidget);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.editorWidget]));
			w3.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.saveButton = new global::Gtk.Button ();
			this.saveButton.Sensitive = false;
			this.saveButton.CanFocus = true;
			this.saveButton.Name = "saveButton";
			this.saveButton.UseUnderline = true;
			this.saveButton.Label = global::Mono.Unix.Catalog.GetString ("_Save");
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.saveButton.Image = w4;
			this.hbuttonbox1.Add (this.saveButton);
			global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.saveButton]));
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox1]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
			this.saveButton.Clicked += new global::System.EventHandler (this.OnSaveNotes);
		}
	}
}
