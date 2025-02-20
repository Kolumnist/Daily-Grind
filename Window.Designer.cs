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
			TodoList.Items.AddRange(new object[] { resources.GetString("TodoList.Items"), resources.GetString("TodoList.Items1"), resources.GetString("TodoList.Items2"), resources.GetString("TodoList.Items3"), resources.GetString("TodoList.Items4"), resources.GetString("TodoList.Items5") });
			TodoList.Name = "TodoList";
			TodoList.SelectedIndexChanged += TodoList_SelectedIndexChanged;
			// 
			// Window
			// 
			AllowDrop = true;
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Window;
			ControlBox = true;
			Controls.Add(TodoList);
			Controls.Add(ButtonConfigure);
			HelpButton = false;
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = true;
			Name = "Window";
			ShowIcon = false;
			Load += Form1_Load;
			ResumeLayout(false);
		}

		#endregion

		private Button ButtonConfigure;
		private CheckedListBox TodoList;
	}
}
