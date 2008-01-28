// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Database.Designer {
    
    
    public partial class ColumnsEditorWidget {
        
        private Gtk.HPaned hpaned;
        
        private Gtk.VBox vboxLeft;
        
        private Gtk.ScrolledWindow scrolledwindowLeft;
        
        private Gtk.TreeView treeColumns;
        
        private Gtk.HButtonBox hbuttonbox;
        
        private Gtk.Button buttonAdd;
        
        private Gtk.Button buttonRemove;
        
        private Gtk.Button buttonUp;
        
        private Gtk.Button buttonDown;
        
        private Gtk.ScrolledWindow scrolledwindowRight;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.Database.Designer.ColumnsEditorWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.Database.Designer.ColumnsEditorWidget";
            // Container child MonoDevelop.Database.Designer.ColumnsEditorWidget.Gtk.Container+ContainerChild
            this.hpaned = new Gtk.HPaned();
            this.hpaned.CanFocus = true;
            this.hpaned.Name = "hpaned";
            this.hpaned.Position = 662;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.vboxLeft = new Gtk.VBox();
            this.vboxLeft.Name = "vboxLeft";
            this.vboxLeft.Spacing = 6;
            // Container child vboxLeft.Gtk.Box+BoxChild
            this.scrolledwindowLeft = new Gtk.ScrolledWindow();
            this.scrolledwindowLeft.CanFocus = true;
            this.scrolledwindowLeft.Name = "scrolledwindowLeft";
            this.scrolledwindowLeft.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindowLeft.Gtk.Container+ContainerChild
            this.treeColumns = new Gtk.TreeView();
            this.treeColumns.CanFocus = true;
            this.treeColumns.Name = "treeColumns";
            this.treeColumns.HeadersClickable = true;
            this.scrolledwindowLeft.Add(this.treeColumns);
            this.vboxLeft.Add(this.scrolledwindowLeft);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vboxLeft[this.scrolledwindowLeft]));
            w2.Position = 0;
            // Container child vboxLeft.Gtk.Box+BoxChild
            this.hbuttonbox = new Gtk.HButtonBox();
            this.hbuttonbox.Name = "hbuttonbox";
            this.hbuttonbox.Spacing = 6;
            this.hbuttonbox.LayoutStyle = ((Gtk.ButtonBoxStyle)(3));
            // Container child hbuttonbox.Gtk.ButtonBox+ButtonBoxChild
            this.buttonAdd = new Gtk.Button();
            this.buttonAdd.CanFocus = true;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseStock = true;
            this.buttonAdd.UseUnderline = true;
            this.buttonAdd.Label = "gtk-add";
            this.hbuttonbox.Add(this.buttonAdd);
            Gtk.ButtonBox.ButtonBoxChild w3 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox[this.buttonAdd]));
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbuttonbox.Gtk.ButtonBox+ButtonBoxChild
            this.buttonRemove = new Gtk.Button();
            this.buttonRemove.Sensitive = false;
            this.buttonRemove.CanFocus = true;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseStock = true;
            this.buttonRemove.UseUnderline = true;
            this.buttonRemove.Label = "gtk-remove";
            this.hbuttonbox.Add(this.buttonRemove);
            Gtk.ButtonBox.ButtonBoxChild w4 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox[this.buttonRemove]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbuttonbox.Gtk.ButtonBox+ButtonBoxChild
            this.buttonUp = new Gtk.Button();
            this.buttonUp.Sensitive = false;
            this.buttonUp.CanFocus = true;
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.UseStock = true;
            this.buttonUp.UseUnderline = true;
            this.buttonUp.Label = "gtk-go-up";
            this.hbuttonbox.Add(this.buttonUp);
            Gtk.ButtonBox.ButtonBoxChild w5 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox[this.buttonUp]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child hbuttonbox.Gtk.ButtonBox+ButtonBoxChild
            this.buttonDown = new Gtk.Button();
            this.buttonDown.Sensitive = false;
            this.buttonDown.CanFocus = true;
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.UseStock = true;
            this.buttonDown.UseUnderline = true;
            this.buttonDown.Label = "gtk-go-down";
            this.hbuttonbox.Add(this.buttonDown);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox[this.buttonDown]));
            w6.Position = 3;
            w6.Expand = false;
            w6.Fill = false;
            this.vboxLeft.Add(this.hbuttonbox);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vboxLeft[this.hbuttonbox]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            this.hpaned.Add(this.vboxLeft);
            Gtk.Paned.PanedChild w8 = ((Gtk.Paned.PanedChild)(this.hpaned[this.vboxLeft]));
            w8.Resize = false;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.scrolledwindowRight = new Gtk.ScrolledWindow();
            this.scrolledwindowRight.CanFocus = true;
            this.scrolledwindowRight.Name = "scrolledwindowRight";
            this.scrolledwindowRight.ShadowType = ((Gtk.ShadowType)(1));
            this.hpaned.Add(this.scrolledwindowRight);
            this.Add(this.hpaned);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.buttonAdd.Clicked += new System.EventHandler(this.AddClicked);
            this.buttonRemove.Clicked += new System.EventHandler(this.RemoveClicked);
            this.buttonUp.Clicked += new System.EventHandler(this.UpClicked);
            this.buttonDown.Clicked += new System.EventHandler(this.DownClicked);
        }
    }
}
