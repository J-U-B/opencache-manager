// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ocmgtk {
    
    
    public partial class CleanupPage2 {
        
        private Gtk.Table layoutTable;
        
        private Gtk.CheckButton backupCheck;
        
        private Gtk.CheckButton compactCheck;
        
        private Gtk.Label label3;
        
        private Gtk.Entry limitEntry;
        
        private Gtk.CheckButton logLimitCheck;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.CleanupPage2
            Stetic.BinContainer.Attach(this);
            this.Name = "ocmgtk.CleanupPage2";
            // Container child ocmgtk.CleanupPage2.Gtk.Container+ContainerChild
            this.layoutTable = new Gtk.Table(((uint)(3)), ((uint)(3)), false);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowSpacing = ((uint)(6));
            this.layoutTable.ColumnSpacing = ((uint)(6));
            this.layoutTable.BorderWidth = ((uint)(6));
            // Container child layoutTable.Gtk.Table+TableChild
            this.backupCheck = new Gtk.CheckButton();
            this.backupCheck.CanFocus = true;
            this.backupCheck.Name = "backupCheck";
            this.backupCheck.Label = Mono.Unix.Catalog.GetString("Backup database before cleaning");
            this.backupCheck.Active = true;
            this.backupCheck.DrawIndicator = true;
            this.backupCheck.UseUnderline = true;
            this.layoutTable.Add(this.backupCheck);
            Gtk.Table.TableChild w1 = ((Gtk.Table.TableChild)(this.layoutTable[this.backupCheck]));
            w1.TopAttach = ((uint)(2));
            w1.BottomAttach = ((uint)(3));
            w1.YOptions = ((Gtk.AttachOptions)(4));
            // Container child layoutTable.Gtk.Table+TableChild
            this.compactCheck = new Gtk.CheckButton();
            this.compactCheck.CanFocus = true;
            this.compactCheck.Name = "compactCheck";
            this.compactCheck.Label = Mono.Unix.Catalog.GetString("Compact the size of the database");
            this.compactCheck.Active = true;
            this.compactCheck.DrawIndicator = true;
            this.compactCheck.UseUnderline = true;
            this.layoutTable.Add(this.compactCheck);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.layoutTable[this.compactCheck]));
            w2.TopAttach = ((uint)(1));
            w2.BottomAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child layoutTable.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("logs");
            this.layoutTable.Add(this.label3);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.layoutTable[this.label3]));
            w3.LeftAttach = ((uint)(2));
            w3.RightAttach = ((uint)(3));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child layoutTable.Gtk.Table+TableChild
            this.limitEntry = new Gtk.Entry();
            this.limitEntry.CanFocus = true;
            this.limitEntry.Name = "limitEntry";
            this.limitEntry.Text = Mono.Unix.Catalog.GetString("5");
            this.limitEntry.IsEditable = true;
            this.limitEntry.InvisibleChar = '●';
            this.layoutTable.Add(this.limitEntry);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.layoutTable[this.limitEntry]));
            w4.LeftAttach = ((uint)(1));
            w4.RightAttach = ((uint)(2));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child layoutTable.Gtk.Table+TableChild
            this.logLimitCheck = new Gtk.CheckButton();
            this.logLimitCheck.CanFocus = true;
            this.logLimitCheck.Name = "logLimitCheck";
            this.logLimitCheck.Label = Mono.Unix.Catalog.GetString("Limit the number of logs per cache to:");
            this.logLimitCheck.Active = true;
            this.logLimitCheck.DrawIndicator = true;
            this.logLimitCheck.UseUnderline = true;
            this.layoutTable.Add(this.logLimitCheck);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.layoutTable[this.logLimitCheck]));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            this.Add(this.layoutTable);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.logLimitCheck.Toggled += new System.EventHandler(this.OnLimitToggle);
            this.compactCheck.Toggled += new System.EventHandler(this.OnCompactToggle);
            this.backupCheck.Toggled += new System.EventHandler(this.OnBackupToggle);
        }
    }
}
