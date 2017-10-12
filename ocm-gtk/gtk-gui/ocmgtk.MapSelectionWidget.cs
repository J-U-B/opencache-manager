
// This file has been generated by the GUI designer. Do not modify.
namespace ocmgtk
{
	public partial class MapSelectionWidget
	{
		private global::Gtk.Table table6;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Image image17;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.ScrolledWindow scrolledwindow1;
		
		private global::Gtk.TreeView mapView;
		
		private global::Gtk.Table table7;
		
		private global::Gtk.Button activateButton;
		
		private global::Gtk.Button deactivateButton;
		
		private global::Gtk.Button deleteButton;
		
		private global::Gtk.Button downButton;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.HSeparator hseparator2;
		
		private global::Gtk.HSeparator hseparator3;
		
		private global::Gtk.Button openButton;
		
		private global::Gtk.Button restoreButton;
		
		private global::Gtk.Button upButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ocmgtk.MapSelectionWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "ocmgtk.MapSelectionWidget";
			// Container child ocmgtk.MapSelectionWidget.Gtk.Container+ContainerChild
			this.table6 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table6.Name = "table6";
			this.table6.RowSpacing = ((uint)(6));
			this.table6.ColumnSpacing = ((uint)(6));
			this.table6.BorderWidth = ((uint)(6));
			// Container child table6.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.image17 = new global::Gtk.Image ();
			this.image17.Name = "image17";
			this.image17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-info", global::Gtk.IconSize.Button);
			this.hbox1.Add (this.image17);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.image17]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("The highest map in the list will be the default map when OCM starts.");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w2.Position = 1;
			this.table6.Add (this.hbox1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table6 [this.hbox1]));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.mapView = new global::Gtk.TreeView ();
			this.mapView.CanFocus = true;
			this.mapView.Name = "mapView";
			this.scrolledwindow1.Add (this.mapView);
			this.table6.Add (this.scrolledwindow1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table6 [this.scrolledwindow1]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table6.Gtk.Table+TableChild
			this.table7 = new global::Gtk.Table (((uint)(11)), ((uint)(1)), false);
			this.table7.Name = "table7";
			this.table7.RowSpacing = ((uint)(6));
			this.table7.ColumnSpacing = ((uint)(6));
			// Container child table7.Gtk.Table+TableChild
			this.activateButton = new global::Gtk.Button ();
			this.activateButton.Sensitive = false;
			this.activateButton.CanFocus = true;
			this.activateButton.Name = "activateButton";
			this.activateButton.UseUnderline = true;
			this.activateButton.Label = global::Mono.Unix.Catalog.GetString ("Enable Map");
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.activateButton.Image = w6;
			this.table7.Add (this.activateButton);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table7 [this.activateButton]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.deactivateButton = new global::Gtk.Button ();
			this.deactivateButton.Sensitive = false;
			this.deactivateButton.CanFocus = true;
			this.deactivateButton.Name = "deactivateButton";
			this.deactivateButton.UseUnderline = true;
			this.deactivateButton.Label = global::Mono.Unix.Catalog.GetString ("Disable Map");
			global::Gtk.Image w8 = new global::Gtk.Image ();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.deactivateButton.Image = w8;
			this.table7.Add (this.deactivateButton);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table7 [this.deactivateButton]));
			w9.TopAttach = ((uint)(5));
			w9.BottomAttach = ((uint)(6));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.deleteButton = new global::Gtk.Button ();
			this.deleteButton.Sensitive = false;
			this.deleteButton.CanFocus = true;
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.UseUnderline = true;
			this.deleteButton.Label = global::Mono.Unix.Catalog.GetString ("Delete Map");
			global::Gtk.Image w10 = new global::Gtk.Image ();
			w10.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.deleteButton.Image = w10;
			this.table7.Add (this.deleteButton);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table7 [this.deleteButton]));
			w11.TopAttach = ((uint)(6));
			w11.BottomAttach = ((uint)(7));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.downButton = new global::Gtk.Button ();
			this.downButton.Sensitive = false;
			this.downButton.CanFocus = true;
			this.downButton.Name = "downButton";
			this.downButton.UseUnderline = true;
			this.downButton.Label = global::Mono.Unix.Catalog.GetString ("Move Down");
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-down", global::Gtk.IconSize.Menu);
			this.downButton.Image = w12;
			this.table7.Add (this.downButton);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table7 [this.downButton]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.table7.Add (this.hseparator1);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table7 [this.hseparator1]));
			w14.TopAttach = ((uint)(3));
			w14.BottomAttach = ((uint)(4));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.table7.Add (this.hseparator2);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table7 [this.hseparator2]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.hseparator3 = new global::Gtk.HSeparator ();
			this.hseparator3.Name = "hseparator3";
			this.table7.Add (this.hseparator3);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table7 [this.hseparator3]));
			w16.TopAttach = ((uint)(7));
			w16.BottomAttach = ((uint)(8));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.openButton = new global::Gtk.Button ();
			this.openButton.CanFocus = true;
			this.openButton.Name = "openButton";
			this.openButton.UseUnderline = true;
			this.openButton.Label = global::Mono.Unix.Catalog.GetString ("Import Map File");
			global::Gtk.Image w17 = new global::Gtk.Image ();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			this.openButton.Image = w17;
			this.table7.Add (this.openButton);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table7 [this.openButton]));
			w18.TopAttach = ((uint)(9));
			w18.BottomAttach = ((uint)(11));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.restoreButton = new global::Gtk.Button ();
			this.restoreButton.CanFocus = true;
			this.restoreButton.Name = "restoreButton";
			this.restoreButton.UseUnderline = true;
			this.restoreButton.Label = global::Mono.Unix.Catalog.GetString ("Restore Defaults");
			global::Gtk.Image w19 = new global::Gtk.Image ();
			w19.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.restoreButton.Image = w19;
			this.table7.Add (this.restoreButton);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table7 [this.restoreButton]));
			w20.TopAttach = ((uint)(8));
			w20.BottomAttach = ((uint)(9));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table7.Gtk.Table+TableChild
			this.upButton = new global::Gtk.Button ();
			this.upButton.Sensitive = false;
			this.upButton.CanFocus = true;
			this.upButton.Name = "upButton";
			this.upButton.UseUnderline = true;
			this.upButton.Label = global::Mono.Unix.Catalog.GetString ("Move Up");
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-go-up", global::Gtk.IconSize.Menu);
			this.upButton.Image = w21;
			this.table7.Add (this.upButton);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table7 [this.upButton]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table6.Add (this.table7);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table6 [this.table7]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table6);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.upButton.Clicked += new global::System.EventHandler (this.OnUpButtonClicked);
			this.restoreButton.Clicked += new global::System.EventHandler (this.OnRestoreButtonClicked);
			this.openButton.Clicked += new global::System.EventHandler (this.OnOpenButtonClicked);
			this.downButton.Clicked += new global::System.EventHandler (this.OnDownButtonClicked);
			this.deleteButton.Clicked += new global::System.EventHandler (this.OnDeleteButtonClicked);
			this.deactivateButton.Clicked += new global::System.EventHandler (this.OnDeactivateButtonClicked);
			this.activateButton.Clicked += new global::System.EventHandler (this.OnActivateButtonClicked);
		}
	}
}
