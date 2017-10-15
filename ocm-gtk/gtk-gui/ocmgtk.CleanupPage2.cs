
// This file has been generated by the GUI designer. Do not modify.
namespace ocmgtk
{
	public partial class CleanupPage2
	{
		private global::Gtk.Table layoutTable;
		
		private global::Gtk.CheckButton backupCheck;
		
		private global::Gtk.CheckButton compactCheck;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Entry limitEntry;
		
		private global::Gtk.CheckButton logLimitCheck;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ocmgtk.CleanupPage2
			global::Stetic.BinContainer.Attach (this);
			this.Name = "ocmgtk.CleanupPage2";
			// Container child ocmgtk.CleanupPage2.Gtk.Container+ContainerChild
			this.layoutTable = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.layoutTable.Name = "layoutTable";
			this.layoutTable.RowSpacing = ((uint)(6));
			this.layoutTable.ColumnSpacing = ((uint)(6));
			this.layoutTable.BorderWidth = ((uint)(6));
			// Container child layoutTable.Gtk.Table+TableChild
			this.backupCheck = new global::Gtk.CheckButton ();
			this.backupCheck.CanFocus = true;
			this.backupCheck.Name = "backupCheck";
			this.backupCheck.Label = global::Mono.Unix.Catalog.GetString ("Backup database before cleaning");
			this.backupCheck.Active = true;
			this.backupCheck.DrawIndicator = true;
			this.backupCheck.UseUnderline = true;
			this.layoutTable.Add (this.backupCheck);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.layoutTable [this.backupCheck]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutTable.Gtk.Table+TableChild
			this.compactCheck = new global::Gtk.CheckButton ();
			this.compactCheck.CanFocus = true;
			this.compactCheck.Name = "compactCheck";
			this.compactCheck.Label = global::Mono.Unix.Catalog.GetString ("Compact the size of the database");
			this.compactCheck.Active = true;
			this.compactCheck.DrawIndicator = true;
			this.compactCheck.UseUnderline = true;
			this.layoutTable.Add (this.compactCheck);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.layoutTable [this.compactCheck]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutTable.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("logs");
			this.layoutTable.Add (this.label3);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.layoutTable [this.label3]));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutTable.Gtk.Table+TableChild
			this.limitEntry = new global::Gtk.Entry ();
			this.limitEntry.CanFocus = true;
			this.limitEntry.Name = "limitEntry";
			this.limitEntry.Text = global::Mono.Unix.Catalog.GetString ("5");
			this.limitEntry.IsEditable = true;
			this.limitEntry.InvisibleChar = '●';
			this.layoutTable.Add (this.limitEntry);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.layoutTable [this.limitEntry]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child layoutTable.Gtk.Table+TableChild
			this.logLimitCheck = new global::Gtk.CheckButton ();
			this.logLimitCheck.CanFocus = true;
			this.logLimitCheck.Name = "logLimitCheck";
			this.logLimitCheck.Label = global::Mono.Unix.Catalog.GetString ("Limit the number of logs per cache to:");
			this.logLimitCheck.Active = true;
			this.logLimitCheck.DrawIndicator = true;
			this.logLimitCheck.UseUnderline = true;
			this.layoutTable.Add (this.logLimitCheck);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.layoutTable [this.logLimitCheck]));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.layoutTable);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.logLimitCheck.Toggled += new global::System.EventHandler (this.OnLimitToggle);
			this.compactCheck.Toggled += new global::System.EventHandler (this.OnCompactToggle);
			this.backupCheck.Toggled += new global::System.EventHandler (this.OnBackupToggle);
		}
	}
}
