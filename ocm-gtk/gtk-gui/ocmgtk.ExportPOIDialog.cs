
// This file has been generated by the GUI designer. Do not modify.
namespace ocmgtk
{
	public partial class ExportPOIDialog
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Entry fileEntry;
		
		private global::Gtk.Button fileButton;
		
		private global::Gtk.Image image3;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Entry catagoryEntry;
		
		private global::Gtk.ComboBox descCombo;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.CheckButton includeBMPCheck;
		
		private global::Gtk.Entry bmpFile;
		
		private global::Gtk.Button bmpButton;
		
		private global::Gtk.Image image4;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Entry proxEntry;
		
		private global::Gtk.ComboBox proxCombo;
		
		private global::Gtk.CheckButton includeChildrenCheck;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.CheckButton limitCaches;
		
		private global::Gtk.Entry limitEntry;
		
		private global::Gtk.CheckButton logCheck;
		
		private global::Gtk.Entry logEntry;
		
		private global::Gtk.ComboBox nameCombo;
		
		private global::Gtk.CheckButton proximityAlertCheck;
		
		private global::Gtk.CheckButton useHTMLCheck;
		
		private global::Gtk.Label GtkLabel4;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ocmgtk.ExportPOIDialog
			this.WidthRequest = 600;
			this.Name = "ocmgtk.ExportPOIDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Export Garmin POI");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(6));
			this.Resizable = false;
			this.AllowGrow = false;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child ocmgtk.ExportPOIDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("File:");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fileEntry = new global::Gtk.Entry ();
			this.fileEntry.CanFocus = true;
			this.fileEntry.Name = "fileEntry";
			this.fileEntry.IsEditable = true;
			this.fileEntry.InvisibleChar = '●';
			this.hbox1.Add (this.fileEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fileEntry]));
			w3.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fileButton = new global::Gtk.Button ();
			this.fileButton.CanFocus = true;
			this.fileButton.Name = "fileButton";
			// Container child fileButton.Gtk.Container+ContainerChild
			this.image3 = new global::Gtk.Image ();
			this.image3.Name = "image3";
			this.image3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			this.fileButton.Add (this.image3);
			this.hbox1.Add (this.fileButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fileButton]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(9)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.catagoryEntry = new global::Gtk.Entry ();
			this.catagoryEntry.CanFocus = true;
			this.catagoryEntry.Name = "catagoryEntry";
			this.catagoryEntry.Text = global::Mono.Unix.Catalog.GetString ("Geocaches");
			this.catagoryEntry.IsEditable = true;
			this.catagoryEntry.InvisibleChar = '●';
			this.table1.Add (this.catagoryEntry);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.catagoryEntry]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.descCombo = global::Gtk.ComboBox.NewText ();
			this.descCombo.AppendText (global::Mono.Unix.Catalog.GetString ("Cache Name"));
			this.descCombo.AppendText (global::Mono.Unix.Catalog.GetString ("Cache Code/Size/Hint"));
			this.descCombo.AppendText (global::Mono.Unix.Catalog.GetString ("Cache Code/Size/Type"));
			this.descCombo.AppendText (global::Mono.Unix.Catalog.GetString ("Full Paperless"));
			this.descCombo.Name = "descCombo";
			this.descCombo.Active = 0;
			this.table1.Add (this.descCombo);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.descCombo]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.includeBMPCheck = new global::Gtk.CheckButton ();
			this.includeBMPCheck.CanFocus = true;
			this.includeBMPCheck.Name = "includeBMPCheck";
			this.includeBMPCheck.Label = global::Mono.Unix.Catalog.GetString ("BMP Icon:");
			this.includeBMPCheck.DrawIndicator = true;
			this.includeBMPCheck.UseUnderline = true;
			this.hbox2.Add (this.includeBMPCheck);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.includeBMPCheck]));
			w9.Position = 0;
			w9.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.bmpFile = new global::Gtk.Entry ();
			this.bmpFile.Sensitive = false;
			this.bmpFile.CanFocus = true;
			this.bmpFile.Name = "bmpFile";
			this.bmpFile.IsEditable = true;
			this.bmpFile.InvisibleChar = '●';
			this.hbox2.Add (this.bmpFile);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.bmpFile]));
			w10.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.bmpButton = new global::Gtk.Button ();
			this.bmpButton.Sensitive = false;
			this.bmpButton.CanFocus = true;
			this.bmpButton.Name = "bmpButton";
			// Container child bmpButton.Gtk.Container+ContainerChild
			this.image4 = new global::Gtk.Image ();
			this.image4.Name = "image4";
			this.image4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			this.bmpButton.Add (this.image4);
			this.hbox2.Add (this.bmpButton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.bmpButton]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w13.TopAttach = ((uint)(8));
			w13.BottomAttach = ((uint)(9));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.proxEntry = new global::Gtk.Entry ();
			this.proxEntry.Sensitive = false;
			this.proxEntry.CanFocus = true;
			this.proxEntry.Name = "proxEntry";
			this.proxEntry.Text = global::Mono.Unix.Catalog.GetString ("1");
			this.proxEntry.IsEditable = true;
			this.proxEntry.InvisibleChar = '●';
			this.hbox3.Add (this.proxEntry);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.proxEntry]));
			w14.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.proxCombo = global::Gtk.ComboBox.NewText ();
			this.proxCombo.AppendText (global::Mono.Unix.Catalog.GetString ("kilometers"));
			this.proxCombo.AppendText (global::Mono.Unix.Catalog.GetString ("miles"));
			this.proxCombo.Sensitive = false;
			this.proxCombo.Name = "proxCombo";
			this.proxCombo.Active = 0;
			this.hbox3.Add (this.proxCombo);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.proxCombo]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.table1.Add (this.hbox3);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.includeChildrenCheck = new global::Gtk.CheckButton ();
			this.includeChildrenCheck.CanFocus = true;
			this.includeChildrenCheck.Name = "includeChildrenCheck";
			this.includeChildrenCheck.Label = global::Mono.Unix.Catalog.GetString ("Include Child Waypoints");
			this.includeChildrenCheck.DrawIndicator = true;
			this.includeChildrenCheck.UseUnderline = true;
			this.table1.Add (this.includeChildrenCheck);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.includeChildrenCheck]));
			w17.TopAttach = ((uint)(6));
			w17.BottomAttach = ((uint)(7));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Description:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Category:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.limitCaches = new global::Gtk.CheckButton ();
			this.limitCaches.CanFocus = true;
			this.limitCaches.Name = "limitCaches";
			this.limitCaches.Label = global::Mono.Unix.Catalog.GetString ("Limit Number of Geocaches");
			this.limitCaches.DrawIndicator = true;
			this.limitCaches.UseUnderline = true;
			this.table1.Add (this.limitCaches);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.limitCaches]));
			w21.TopAttach = ((uint)(4));
			w21.BottomAttach = ((uint)(5));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.limitEntry = new global::Gtk.Entry ();
			this.limitEntry.Sensitive = false;
			this.limitEntry.CanFocus = true;
			this.limitEntry.Name = "limitEntry";
			this.limitEntry.Text = global::Mono.Unix.Catalog.GetString ("1000");
			this.limitEntry.IsEditable = true;
			this.limitEntry.InvisibleChar = '●';
			this.table1.Add (this.limitEntry);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.limitEntry]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.logCheck = new global::Gtk.CheckButton ();
			this.logCheck.CanFocus = true;
			this.logCheck.Name = "logCheck";
			this.logCheck.Label = global::Mono.Unix.Catalog.GetString ("Limit Number of Logs");
			this.logCheck.DrawIndicator = true;
			this.logCheck.UseUnderline = true;
			this.table1.Add (this.logCheck);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.logCheck]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.logEntry = new global::Gtk.Entry ();
			this.logEntry.Sensitive = false;
			this.logEntry.CanFocus = true;
			this.logEntry.Name = "logEntry";
			this.logEntry.Text = global::Mono.Unix.Catalog.GetString ("5");
			this.logEntry.IsEditable = true;
			this.logEntry.InvisibleChar = '●';
			this.table1.Add (this.logEntry);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.logEntry]));
			w24.TopAttach = ((uint)(5));
			w24.BottomAttach = ((uint)(6));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.nameCombo = global::Gtk.ComboBox.NewText ();
			this.nameCombo.AppendText (global::Mono.Unix.Catalog.GetString ("Cache Code"));
			this.nameCombo.AppendText (global::Mono.Unix.Catalog.GetString ("Cache Name"));
			this.nameCombo.Name = "nameCombo";
			this.nameCombo.Active = 0;
			this.table1.Add (this.nameCombo);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.nameCombo]));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.proximityAlertCheck = new global::Gtk.CheckButton ();
			this.proximityAlertCheck.CanFocus = true;
			this.proximityAlertCheck.Name = "proximityAlertCheck";
			this.proximityAlertCheck.Label = global::Mono.Unix.Catalog.GetString ("Proximity Alert:");
			this.proximityAlertCheck.DrawIndicator = true;
			this.proximityAlertCheck.UseUnderline = true;
			this.table1.Add (this.proximityAlertCheck);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.proximityAlertCheck]));
			w26.TopAttach = ((uint)(3));
			w26.BottomAttach = ((uint)(4));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.useHTMLCheck = new global::Gtk.CheckButton ();
			this.useHTMLCheck.CanFocus = true;
			this.useHTMLCheck.Name = "useHTMLCheck";
			this.useHTMLCheck.Label = global::Mono.Unix.Catalog.GetString ("Convert HTML to Plain Text");
			this.useHTMLCheck.DrawIndicator = true;
			this.useHTMLCheck.UseUnderline = true;
			this.table1.Add (this.useHTMLCheck);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.useHTMLCheck]));
			w27.TopAttach = ((uint)(7));
			w27.BottomAttach = ((uint)(8));
			w27.RightAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.table1);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>POI Options</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel4;
			this.vbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame1]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Internal child ocmgtk.ExportPOIDialog.ActionArea
			global::Gtk.HButtonBox w32 = this.ActionArea;
			w32.Name = "dialog1_ActionArea";
			w32.Spacing = 10;
			w32.BorderWidth = ((uint)(5));
			w32.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w32 [this.buttonCancel]));
			w33.Expand = false;
			w33.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w34 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w32 [this.buttonOk]));
			w34.Position = 1;
			w34.Expand = false;
			w34.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 612;
			this.DefaultHeight = 415;
			this.Show ();
			this.fileButton.Clicked += new global::System.EventHandler (this.OnFileClick);
			this.proximityAlertCheck.Toggled += new global::System.EventHandler (this.OnProxToggle);
			this.logCheck.Toggled += new global::System.EventHandler (this.OnLogToggle);
			this.limitCaches.Toggled += new global::System.EventHandler (this.OnCacheToggle);
			this.includeBMPCheck.Toggled += new global::System.EventHandler (this.OnBMPToggle);
			this.bmpButton.Clicked += new global::System.EventHandler (this.OnBMPClick);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnCancelClick);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnOKClick);
		}
	}
}
