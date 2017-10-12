
// This file has been generated by the GUI designer. Do not modify.
namespace ocmgtk
{
	public partial class GeocacheInfoPanel
	{
		private global::Gtk.VBox infoPanelVBOX;
		
		private global::Gtk.Label statusLabel;
		
		private global::Gtk.ScrolledWindow scrolledwindow1;
		
		private global::Gtk.Table table1;
		
		private global::Gtk.Image cacheIcon;
		
		private global::Gtk.Frame frame2;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.Table attrTable;
		
		private global::Gtk.Label attrLabel;
		
		private global::Gtk.Label GtkLabel3;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label placedByLabel;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label dateLabel;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label infoDateLabel;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label cacheSizeLabel;
		
		private global::Gtk.Label diffLabel;
		
		private global::Gtk.Image diff_i1;
		
		private global::Gtk.Image diff_i2;
		
		private global::Gtk.Image diff_i3;
		
		private global::Gtk.Image diff_i4;
		
		private global::Gtk.Image diff_i5;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Image terr_i1;
		
		private global::Gtk.Image terr_i2;
		
		private global::Gtk.Image terr_i3;
		
		private global::Gtk.Image terr_i4;
		
		private global::Gtk.Image terr_i5;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Label countryLabel;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label lastFoundDateLabel;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label lfoundLabel;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Label cacheCodeLabel;
		
		private global::Gtk.Label cacheNameLabel;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.Label cacheTypeLabel;
		
		private global::Gtk.Label origCoord;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Label coordinateLabel;
		
		private global::Gtk.Label distance_label;
		
		private global::Gtk.Button logButton;
		
		private global::Gtk.Table UDataTable;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Label uData1;
		
		private global::Gtk.Label uData2;
		
		private global::Gtk.Label uData3;
		
		private global::Gtk.Label uData4;
		
		private global::Gtk.Button viewButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ocmgtk.GeocacheInfoPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "ocmgtk.GeocacheInfoPanel";
			// Container child ocmgtk.GeocacheInfoPanel.Gtk.Container+ContainerChild
			this.infoPanelVBOX = new global::Gtk.VBox ();
			this.infoPanelVBOX.Name = "infoPanelVBOX";
			this.infoPanelVBOX.Spacing = 6;
			this.infoPanelVBOX.BorderWidth = ((uint)(6));
			// Container child infoPanelVBOX.Gtk.Box+BoxChild
			this.statusLabel = new global::Gtk.Label ();
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.UseMarkup = true;
			this.statusLabel.Justify = ((global::Gtk.Justification)(2));
			this.infoPanelVBOX.Add (this.statusLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.infoPanelVBOX [this.statusLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child infoPanelVBOX.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w2 = new global::Gtk.Viewport ();
			w2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(8)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.cacheIcon = new global::Gtk.Image ();
			this.cacheIcon.Name = "cacheIcon";
			this.cacheIcon.Xpad = 5;
			this.cacheIcon.Ypad = 5;
			this.table1.Add (this.cacheIcon);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.cacheIcon]));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.attrTable = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
			this.attrTable.Name = "attrTable";
			this.attrTable.RowSpacing = ((uint)(1));
			this.attrTable.ColumnSpacing = ((uint)(1));
			this.attrTable.BorderWidth = ((uint)(6));
			// Container child attrTable.Gtk.Table+TableChild
			this.attrLabel = new global::Gtk.Label ();
			this.attrLabel.Name = "attrLabel";
			this.attrLabel.Xalign = 0F;
			this.attrLabel.Yalign = 0F;
			this.attrLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
			this.attrLabel.UseMarkup = true;
			this.attrLabel.Wrap = true;
			this.attrLabel.WidthChars = 80;
			this.attrTable.Add (this.attrLabel);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.attrTable [this.attrLabel]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.attrTable);
			this.frame2.Add (this.GtkAlignment2);
			this.GtkLabel3 = new global::Gtk.Label ();
			this.GtkLabel3.Name = "GtkLabel3";
			this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Attributes</b>");
			this.GtkLabel3.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel3;
			this.table1.Add (this.frame2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.frame2]));
			w7.TopAttach = ((uint)(6));
			w7.BottomAttach = ((uint)(7));
			w7.RightAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xpad = 5;
			this.label3.Ypad = 5;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>A cache by:</b>");
			this.label3.UseMarkup = true;
			this.hbox2.Add (this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label3]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.placedByLabel = new global::Gtk.Label ();
			this.placedByLabel.Name = "placedByLabel";
			this.placedByLabel.Xpad = 5;
			this.placedByLabel.Ypad = 5;
			this.placedByLabel.LabelProp = "<name>";
			this.placedByLabel.Ellipsize = ((global::Pango.EllipsizeMode)(3));
			this.placedByLabel.MaxWidthChars = 15;
			this.hbox2.Add (this.placedByLabel);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.placedByLabel]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xpad = 5;
			this.label5.Ypad = 5;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Hidden on:</b>");
			this.label5.UseMarkup = true;
			this.label5.Justify = ((global::Gtk.Justification)(1));
			this.hbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label5]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.dateLabel = new global::Gtk.Label ();
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Xpad = 5;
			this.dateLabel.Ypad = 5;
			this.dateLabel.Xalign = 0F;
			this.dateLabel.LabelProp = "<date>";
			this.hbox2.Add (this.dateLabel);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.dateLabel]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Last Update:</b>");
			this.label2.UseMarkup = true;
			this.hbox2.Add (this.label2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
			w12.Position = 4;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.infoDateLabel = new global::Gtk.Label ();
			this.infoDateLabel.Name = "infoDateLabel";
			this.infoDateLabel.LabelProp = "<date>";
			this.hbox2.Add (this.infoDateLabel);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.infoDateLabel]));
			w13.Position = 5;
			w13.Expand = false;
			w13.Fill = false;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xpad = 5;
			this.label1.Ypad = 5;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Cache Size:</b>");
			this.label1.UseMarkup = true;
			this.hbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label1]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.cacheSizeLabel = new global::Gtk.Label ();
			this.cacheSizeLabel.Name = "cacheSizeLabel";
			this.cacheSizeLabel.Ypad = 5;
			this.cacheSizeLabel.LabelProp = "<cacheSize>";
			this.hbox3.Add (this.cacheSizeLabel);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.cacheSizeLabel]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.diffLabel = new global::Gtk.Label ();
			this.diffLabel.Name = "diffLabel";
			this.diffLabel.Xpad = 5;
			this.diffLabel.Ypad = 5;
			this.diffLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Difficulty:</b>");
			this.diffLabel.UseMarkup = true;
			this.hbox3.Add (this.diffLabel);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.diffLabel]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.diff_i1 = new global::Gtk.Image ();
			this.diff_i1.Name = "diff_i1";
			this.hbox3.Add (this.diff_i1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.diff_i1]));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.diff_i2 = new global::Gtk.Image ();
			this.diff_i2.Name = "diff_i2";
			this.hbox3.Add (this.diff_i2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.diff_i2]));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.diff_i3 = new global::Gtk.Image ();
			this.diff_i3.Name = "diff_i3";
			this.hbox3.Add (this.diff_i3);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.diff_i3]));
			w20.Position = 5;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.diff_i4 = new global::Gtk.Image ();
			this.diff_i4.Name = "diff_i4";
			this.hbox3.Add (this.diff_i4);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.diff_i4]));
			w21.Position = 6;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.diff_i5 = new global::Gtk.Image ();
			this.diff_i5.Name = "diff_i5";
			this.hbox3.Add (this.diff_i5);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.diff_i5]));
			w22.Position = 7;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xpad = 5;
			this.label4.Ypad = 5;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Terrain:</b>");
			this.label4.UseMarkup = true;
			this.hbox3.Add (this.label4);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label4]));
			w23.Position = 8;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.terr_i1 = new global::Gtk.Image ();
			this.terr_i1.Name = "terr_i1";
			this.hbox3.Add (this.terr_i1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.terr_i1]));
			w24.Position = 9;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.terr_i2 = new global::Gtk.Image ();
			this.terr_i2.Name = "terr_i2";
			this.hbox3.Add (this.terr_i2);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.terr_i2]));
			w25.Position = 10;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.terr_i3 = new global::Gtk.Image ();
			this.terr_i3.Name = "terr_i3";
			this.hbox3.Add (this.terr_i3);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.terr_i3]));
			w26.Position = 11;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.terr_i4 = new global::Gtk.Image ();
			this.terr_i4.Name = "terr_i4";
			this.hbox3.Add (this.terr_i4);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.terr_i4]));
			w27.Position = 12;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.terr_i5 = new global::Gtk.Image ();
			this.terr_i5.Name = "terr_i5";
			this.hbox3.Add (this.terr_i5);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.terr_i5]));
			w28.Position = 13;
			w28.Expand = false;
			w28.Fill = false;
			this.table1.Add (this.hbox3);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox3]));
			w29.TopAttach = ((uint)(5));
			w29.BottomAttach = ((uint)(6));
			w29.RightAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.countryLabel = new global::Gtk.Label ();
			this.countryLabel.Name = "countryLabel";
			this.countryLabel.Xpad = 6;
			this.countryLabel.Xalign = 0F;
			this.countryLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<country>");
			this.hbox4.Add (this.countryLabel);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.countryLabel]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Last Log By You:</b>");
			this.label6.UseMarkup = true;
			this.hbox4.Add (this.label6);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label6]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.lastFoundDateLabel = new global::Gtk.Label ();
			this.lastFoundDateLabel.Name = "lastFoundDateLabel";
			this.lastFoundDateLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Never");
			this.hbox4.Add (this.lastFoundDateLabel);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.lastFoundDateLabel]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xpad = 5;
			this.label7.Ypad = 5;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Last Found:</b>");
			this.label7.UseMarkup = true;
			this.hbox4.Add (this.label7);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label7]));
			w33.Position = 3;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.lfoundLabel = new global::Gtk.Label ();
			this.lfoundLabel.Name = "lfoundLabel";
			this.lfoundLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<lfound>");
			this.hbox4.Add (this.lfoundLabel);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.lfoundLabel]));
			w34.Position = 4;
			w34.Expand = false;
			w34.Fill = false;
			this.table1.Add (this.hbox4);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox4]));
			w35.TopAttach = ((uint)(3));
			w35.BottomAttach = ((uint)(4));
			w35.RightAttach = ((uint)(3));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 2;
			// Container child hbox5.Gtk.Box+BoxChild
			this.cacheCodeLabel = new global::Gtk.Label ();
			this.cacheCodeLabel.Name = "cacheCodeLabel";
			this.cacheCodeLabel.Xalign = 0F;
			this.cacheCodeLabel.LabelProp = "<cacheCode>";
			this.hbox5.Add (this.cacheCodeLabel);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.cacheCodeLabel]));
			w36.Position = 0;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.cacheNameLabel = new global::Gtk.Label ();
			this.cacheNameLabel.Name = "cacheNameLabel";
			this.cacheNameLabel.Xalign = 0F;
			this.cacheNameLabel.LabelProp = "<cacheName>";
			this.cacheNameLabel.Ellipsize = ((global::Pango.EllipsizeMode)(3));
			this.hbox5.Add (this.cacheNameLabel);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.cacheNameLabel]));
			w37.Position = 1;
			this.table1.Add (this.hbox5);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox5]));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.cacheTypeLabel = new global::Gtk.Label ();
			this.cacheTypeLabel.Name = "cacheTypeLabel";
			this.cacheTypeLabel.Xalign = 0F;
			this.cacheTypeLabel.LabelProp = "<cacheType>";
			this.hbox6.Add (this.cacheTypeLabel);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.cacheTypeLabel]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.origCoord = new global::Gtk.Label ();
			this.origCoord.Name = "origCoord";
			this.origCoord.Xpad = 6;
			this.origCoord.Xalign = 0F;
			this.origCoord.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.hbox6.Add (this.origCoord);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.origCoord]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			this.table1.Add (this.hbox6);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox6]));
			w41.TopAttach = ((uint)(1));
			w41.BottomAttach = ((uint)(2));
			w41.LeftAttach = ((uint)(1));
			w41.RightAttach = ((uint)(2));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.coordinateLabel = new global::Gtk.Label ();
			this.coordinateLabel.Name = "coordinateLabel";
			this.coordinateLabel.Xalign = 0F;
			this.coordinateLabel.LabelProp = "<coord>";
			this.hbox8.Add (this.coordinateLabel);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.coordinateLabel]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.distance_label = new global::Gtk.Label ();
			this.distance_label.Name = "distance_label";
			this.distance_label.Xalign = 0F;
			this.distance_label.LabelProp = "<bearing & distance>";
			this.distance_label.Ellipsize = ((global::Pango.EllipsizeMode)(3));
			this.hbox8.Add (this.distance_label);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.distance_label]));
			w43.Position = 1;
			this.table1.Add (this.hbox8);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox8]));
			w44.TopAttach = ((uint)(2));
			w44.BottomAttach = ((uint)(3));
			w44.LeftAttach = ((uint)(1));
			w44.RightAttach = ((uint)(2));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.logButton = new global::Gtk.Button ();
			this.logButton.CanFocus = true;
			this.logButton.Name = "logButton";
			this.logButton.UseUnderline = true;
			this.logButton.Label = global::Mono.Unix.Catalog.GetString ("Log My Find...");
			global::Gtk.Image w45 = new global::Gtk.Image ();
			w45.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ocmgtk.icons.scalable.log.svg");
			this.logButton.Image = w45;
			this.table1.Add (this.logButton);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.table1 [this.logButton]));
			w46.LeftAttach = ((uint)(2));
			w46.RightAttach = ((uint)(3));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.UDataTable = new global::Gtk.Table (((uint)(1)), ((uint)(8)), false);
			this.UDataTable.Name = "UDataTable";
			this.UDataTable.RowSpacing = ((uint)(6));
			this.UDataTable.ColumnSpacing = ((uint)(6));
			this.UDataTable.BorderWidth = ((uint)(5));
			// Container child UDataTable.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xpad = 6;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>User Data 3:</b>");
			this.label10.UseMarkup = true;
			this.UDataTable.Add (this.label10);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.label10]));
			w47.LeftAttach = ((uint)(4));
			w47.RightAttach = ((uint)(5));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child UDataTable.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xpad = 6;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>User Data 4:</b>");
			this.label11.UseMarkup = true;
			this.UDataTable.Add (this.label11);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.label11]));
			w48.LeftAttach = ((uint)(6));
			w48.RightAttach = ((uint)(7));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child UDataTable.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>User Data 1:</b>");
			this.label8.UseMarkup = true;
			this.UDataTable.Add (this.label8);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.label8]));
			w49.XOptions = ((global::Gtk.AttachOptions)(4));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child UDataTable.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xpad = 6;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>User Data 2:</b>");
			this.label9.UseMarkup = true;
			this.UDataTable.Add (this.label9);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.label9]));
			w50.LeftAttach = ((uint)(2));
			w50.RightAttach = ((uint)(3));
			w50.XOptions = ((global::Gtk.AttachOptions)(4));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child UDataTable.Gtk.Table+TableChild
			this.uData1 = new global::Gtk.Label ();
			this.uData1.Name = "uData1";
			this.uData1.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
			this.UDataTable.Add (this.uData1);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.uData1]));
			w51.LeftAttach = ((uint)(1));
			w51.RightAttach = ((uint)(2));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child UDataTable.Gtk.Table+TableChild
			this.uData2 = new global::Gtk.Label ();
			this.uData2.Name = "uData2";
			this.uData2.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
			this.UDataTable.Add (this.uData2);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.uData2]));
			w52.LeftAttach = ((uint)(3));
			w52.RightAttach = ((uint)(4));
			w52.XOptions = ((global::Gtk.AttachOptions)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child UDataTable.Gtk.Table+TableChild
			this.uData3 = new global::Gtk.Label ();
			this.uData3.Name = "uData3";
			this.uData3.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
			this.UDataTable.Add (this.uData3);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.uData3]));
			w53.LeftAttach = ((uint)(5));
			w53.RightAttach = ((uint)(6));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child UDataTable.Gtk.Table+TableChild
			this.uData4 = new global::Gtk.Label ();
			this.uData4.Name = "uData4";
			this.uData4.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
			this.UDataTable.Add (this.uData4);
			global::Gtk.Table.TableChild w54 = ((global::Gtk.Table.TableChild)(this.UDataTable [this.uData4]));
			w54.LeftAttach = ((uint)(7));
			w54.RightAttach = ((uint)(8));
			w54.XOptions = ((global::Gtk.AttachOptions)(4));
			w54.YOptions = ((global::Gtk.AttachOptions)(4));
			this.table1.Add (this.UDataTable);
			global::Gtk.Table.TableChild w55 = ((global::Gtk.Table.TableChild)(this.table1 [this.UDataTable]));
			w55.TopAttach = ((uint)(7));
			w55.BottomAttach = ((uint)(8));
			w55.RightAttach = ((uint)(3));
			w55.XOptions = ((global::Gtk.AttachOptions)(4));
			w55.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.viewButton = new global::Gtk.Button ();
			this.viewButton.CanFocus = true;
			this.viewButton.Name = "viewButton";
			this.viewButton.UseUnderline = true;
			this.viewButton.Label = global::Mono.Unix.Catalog.GetString ("View Online...");
			this.table1.Add (this.viewButton);
			global::Gtk.Table.TableChild w56 = ((global::Gtk.Table.TableChild)(this.table1 [this.viewButton]));
			w56.TopAttach = ((uint)(1));
			w56.BottomAttach = ((uint)(2));
			w56.LeftAttach = ((uint)(2));
			w56.RightAttach = ((uint)(3));
			w56.XOptions = ((global::Gtk.AttachOptions)(4));
			w56.YOptions = ((global::Gtk.AttachOptions)(4));
			w2.Add (this.table1);
			this.scrolledwindow1.Add (w2);
			this.infoPanelVBOX.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.infoPanelVBOX [this.scrolledwindow1]));
			w59.Position = 1;
			this.Add (this.infoPanelVBOX);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.viewButton.Clicked += new global::System.EventHandler (this.OnClickView);
			this.logButton.Clicked += new global::System.EventHandler (this.OnClickLog);
		}
	}
}
