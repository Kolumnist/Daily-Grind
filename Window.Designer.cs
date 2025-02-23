namespace Daily_Grind
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			ButtonConfigure = new Button();
			TodoList = new CheckedListBox();
			TodoBox = new TextBox();
			SuspendLayout();
			// 
			// ButtonConfigure
			// 
			ButtonConfigure.BackColor = SystemColors.ButtonHighlight;
			resources.ApplyResources(ButtonConfigure, "ButtonConfigure");
			ButtonConfigure.FlatAppearance.BorderSize = 0;
			ButtonConfigure.FlatAppearance.MouseDownBackColor = Color.Silver;
			ButtonConfigure.FlatAppearance.MouseOverBackColor = SystemColors.ButtonFace;
			ButtonConfigure.Name = "ButtonConfigure";
			ButtonConfigure.UseVisualStyleBackColor = false;
			ButtonConfigure.Click += ButtonConfigure_Click;
			// 
			// TodoList
			// 
			TodoList.BorderStyle = BorderStyle.None;
			resources.ApplyResources(TodoList, "TodoList");
			TodoList.FormattingEnabled = true;
			TodoList.Name = "TodoList";
			TodoList.ItemCheck += TodoList_ItemCheck;
			// 
			// TodoBox
			// 
			TodoBox.BorderStyle = BorderStyle.None;
			resources.ApplyResources(TodoBox, "TodoBox");
			TodoBox.Name = "TodoBox";
			// 
			// Window
			// 
			AllowDrop = true;
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			Controls.Add(TodoBox);
			Controls.Add(TodoList);
			Controls.Add(ButtonConfigure);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			Name = "Window";
			ShowIcon = false;
			Load += Window_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button ButtonConfigure;
		private CheckedListBox TodoList;
		private TextBox TodoBox;
	}
}
