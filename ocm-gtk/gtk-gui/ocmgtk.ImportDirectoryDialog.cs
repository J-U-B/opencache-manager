
// This file has been generated by the GUI designer. Do not modify.
namespace ocmgtk
{
	public partial class ImportDirectoryDialog
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.FileChooserButton dirChooser;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.CheckButton deleteCheck;
		
		private global::Gtk.CheckButton statusCheck;
		
		private global::Gtk.CheckButton oldLogsCheck;
		
		private global::Gtk.CheckButton gsakFieldsCheck;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.CheckButton addToListCheck;
		
		private global::Gtk.ComboBox bmCombo;
		
		private global::Gtk.Button addBmrkButton;
		
		private global::Gtk.Image image20;
		
		private global::Gtk.Label GtkLabel7;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ocmgtk.ImportDirectoryDialog
			this.WidthRequest = 500;
			this.Name = "ocmgtk.ImportDirectoryDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Import Directory");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(6));
			this.Resizable = false;
			this.AllowGrow = false;
			// Internal child ocmgtk.ImportDirectoryDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.dirChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select A Folder"), ((global::Gtk.FileChooserAction)(2)));
			this.dirChooser.Name = "dirChooser";
			this.dirChooser.ShowHidden = true;
			this.table1.Add (this.dirChooser);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.dirChooser]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Directory:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.table1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.deleteCheck = new global::Gtk.CheckButton ();
			this.deleteCheck.CanFocus = true;
			this.deleteCheck.Name = "deleteCheck";
			this.deleteCheck.Label = global::Mono.Unix.Catalog.GetString ("Delete files on completion");
			this.deleteCheck.DrawIndicator = true;
			this.deleteCheck.UseUnderline = true;
			this.vbox2.Add (this.deleteCheck);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.deleteCheck]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.statusCheck = new global::Gtk.CheckButton ();
			this.statusCheck.CanFocus = true;
			this.statusCheck.Name = "statusCheck";
			this.statusCheck.Label = global::Mono.Unix.Catalog.GetString ("Do not overwrite existing found status in database");
			this.statusCheck.DrawIndicator = true;
			this.statusCheck.UseUnderline = true;
			this.vbox2.Add (this.statusCheck);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusCheck]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.oldLogsCheck = new global::Gtk.CheckButton ();
			this.oldLogsCheck.CanFocus = true;
			this.oldLogsCheck.Name = "oldLogsCheck";
			this.oldLogsCheck.Label = global::Mono.Unix.Catalog.GetString ("Purge old cache logs");
			this.oldLogsCheck.DrawIndicator = true;
			this.oldLogsCheck.UseUnderline = true;
			this.vbox2.Add (this.oldLogsCheck);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.oldLogsCheck]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.gsakFieldsCheck = new global::Gtk.CheckButton ();
			this.gsakFieldsCheck.CanFocus = true;
			this.gsakFieldsCheck.Name = "gsakFieldsCheck";
			this.gsakFieldsCheck.Label = global::Mono.Unix.Catalog.GetString ("Ignore GSAK/OCM extra fields in GPX file");
			this.gsakFieldsCheck.DrawIndicator = true;
			this.gsakFieldsCheck.UseUnderline = true;
			this.vbox2.Add (this.gsakFieldsCheck);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.gsakFieldsCheck]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.addToListCheck = new global::Gtk.CheckButton ();
			this.addToListCheck.CanFocus = true;
			this.addToListCheck.Name = "addToListCheck";
			this.addToListCheck.Label = global::Mono.Unix.Catalog.GetString ("Add to bookmark list:");
			this.addToListCheck.DrawIndicator = true;
			this.addToListCheck.UseUnderline = true;
			this.hbox1.Add (this.addToListCheck);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.addToListCheck]));
			w9.Position = 0;
			w9.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.bmCombo = global::Gtk.ComboBox.NewText ();
			this.bmCombo.Sensitive = false;
			this.bmCombo.Name = "bmCombo";
			this.hbox1.Add (this.bmCombo);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.bmCombo]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.addBmrkButton = new global::Gtk.Button ();
			this.addBmrkButton.Sensitive = false;
			this.addBmrkButton.CanFocus = true;
			this.addBmrkButton.Name = "addBmrkButton";
			// Container child addBmrkButton.Gtk.Container+ContainerChild
			this.image20 = new global::Gtk.Image ();
			this.image20.Sensitive = false;
			this.image20.Name = "image20";
			this.image20.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.addBmrkButton.Add (this.image20);
			this.hbox1.Add (this.addBmrkButton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.addBmrkButton]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			this.GtkAlignment2.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel7 = new global::Gtk.Label ();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Options</b>");
			this.GtkLabel7.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel7;
			w1.Add (this.frame1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(w1 [this.frame1]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Internal child ocmgtk.ImportDirectoryDialog.ActionArea
			global::Gtk.HButtonBox w17 = this.ActionArea;
			w17.Name = "dialog1_ActionArea";
			w17.Spacing = 10;
			w17.BorderWidth = ((uint)(5));
			w17.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonCancel]));
			w18.Expand = false;
			w18.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w17 [this.buttonOk]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 512;
			this.DefaultHeight = 281;
			this.Show ();
			this.addToListCheck.Toggled += new global::System.EventHandler (this.OnBmrkToggle);
			this.addBmrkButton.Clicked += new global::System.EventHandler (this.OnAddClicked);
		}
	}
}
