
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.StyleCop
{
	internal partial class SettingsFilesOptionsPanel
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label label1;
		private global::Gtk.Table table2;
		private global::Gtk.Button button1;
		private global::Gtk.Button button2;
		private global::Gtk.Button browseButton;
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.Fixed fixed3;
		private global::Gtk.Fixed fixed4;
		private global::Gtk.Fixed fixed5;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label2;
		private global::Gtk.Entry linkedFilePathEntry;
		private global::Gtk.RadioButton noMergeRadioButton;
		private global::Gtk.RadioButton mergeWithParentsRadioButton;
		private global::Gtk.RadioButton mergeWithLinkedFileRadioButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.StyleCop.SettingsFilesOptionsPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.StyleCop.SettingsFilesOptionsPanel";
			// Container child MonoDevelop.StyleCop.SettingsFilesOptionsPanel.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Determines how to merge these settings with other settings files.");
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(4)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("Edit....");
			this.table2.Add (this.button1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.button1]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("Edit....");
			this.table2.Add (this.button2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.button2]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.browseButton = new global::Gtk.Button ();
			this.browseButton.CanFocus = true;
			this.browseButton.Name = "button3";
			this.browseButton.UseUnderline = true;
			this.browseButton.Label = global::Mono.Unix.Catalog.GetString ("...");
			this.table2.Add (this.browseButton);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.browseButton]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.table2.Add (this.fixed1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed1]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.table2.Add (this.fixed2);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed2]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.table2.Add (this.fixed3);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed3]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed4 = new global::Gtk.Fixed ();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			this.table2.Add (this.fixed4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed4]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			this.table2.Add (this.fixed5);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2 [this.fixed5]));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Location:");
			this.hbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.linkedFilePathEntry = new global::Gtk.Entry ();
			this.linkedFilePathEntry.CanFocus = true;
			this.linkedFilePathEntry.Name = "entry1";
			this.linkedFilePathEntry.IsEditable = true;
			this.linkedFilePathEntry.InvisibleChar = '●';
			this.hbox1.Add (this.linkedFilePathEntry);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.linkedFilePathEntry]));
			w11.Position = 1;
			this.table2.Add (this.hbox1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox1]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.noMergeRadioButton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Do not merge with any other settings files"));
			this.noMergeRadioButton.CanFocus = true;
			this.noMergeRadioButton.Name = "radiobutton1";
			this.noMergeRadioButton.Active = true;
			this.noMergeRadioButton.DrawIndicator = true;
			this.noMergeRadioButton.UseUnderline = true;
			this.noMergeRadioButton.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.table2.Add (this.noMergeRadioButton);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.noMergeRadioButton]));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.mergeWithParentsRadioButton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Merge with settings file found in parent folders"));
			this.mergeWithParentsRadioButton.CanFocus = true;
			this.mergeWithParentsRadioButton.Name = "radiobutton2";
			this.mergeWithParentsRadioButton.DrawIndicator = true;
			this.mergeWithParentsRadioButton.UseUnderline = true;
			this.mergeWithParentsRadioButton.Group = this.noMergeRadioButton.Group;
			this.table2.Add (this.mergeWithParentsRadioButton);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.mergeWithParentsRadioButton]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.mergeWithLinkedFileRadioButton = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Merge with the following settings file:"));
			this.mergeWithLinkedFileRadioButton.CanFocus = true;
			this.mergeWithLinkedFileRadioButton.Name = "radiobutton3";
			this.mergeWithLinkedFileRadioButton.DrawIndicator = true;
			this.mergeWithLinkedFileRadioButton.UseUnderline = true;
			this.mergeWithLinkedFileRadioButton.Group = this.noMergeRadioButton.Group;
			this.table2.Add(this.mergeWithLinkedFileRadioButton);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2[this.mergeWithLinkedFileRadioButton]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.table2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table2]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
