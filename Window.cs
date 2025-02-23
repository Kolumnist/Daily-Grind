using System.IO;

namespace Daily_Grind
{
	public partial class Window : Form
	{
		private readonly string txtPath = "../../../todos.txt";

		private bool currentlyOrderingItems = false;
		private string txtContent = "";
		private string[] todos = [];

		public Window()
		{
			InitializeComponent();

			FillTodoList();
			TodoBox.Text = txtContent;
		}

		private void FillTodoList()
		{
			txtContent = File.ReadAllText(txtPath);
			todos = txtContent.Split('\n');
			TodoList.Items.Clear();
			TodoList.Items.AddRange(todos);
		}

		private void Window_Load(object sender, EventArgs e)
		{
		}

		private void ButtonConfigure_Click(object sender, EventArgs e)
		{
			if (TodoBox.Enabled)
			{
				TodoBox.Enabled = false;
				TodoBox.Visible = false;
				ButtonConfigure.Text = "Configure";

				string newTodos = TodoBox.Text;
				File.WriteAllText(txtPath, newTodos);
				FillTodoList();
			}
			else
			{
				TodoBox.Enabled = true;
				TodoBox.Visible = true;
				ButtonConfigure.Text = "Save";
			}
		}

		private void TodoList_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (currentlyOrderingItems) return;
			currentlyOrderingItems = true;

			string checkedItem = TodoList.Items[e.Index].ToString()!;

			if (e.NewValue == CheckState.Checked)
			{
				if (e.Index != TodoList.Items.Count - 1) e.NewValue = TodoList.GetItemCheckState(e.Index + 1);

				for (int i = e.Index; i < TodoList.Items.Count - 1; i++)
				{
					TodoList.SetItemChecked(i, TodoList.GetItemChecked(i + 1));
					TodoList.Items[i] = TodoList.Items[i + 1];
				}
				TodoList.SetItemChecked(TodoList.Items.Count - 1, true);
				TodoList.Items[^1] = checkedItem;
			}
			else if (e.CurrentValue == CheckState.Checked)
			{
				if (e.Index != 0) e.NewValue = TodoList.GetItemCheckState(e.Index - 1);

				for (int i = e.Index; i > 0; i--)
				{
					TodoList.SetItemChecked(i, TodoList.GetItemChecked(i - 1));
					TodoList.Items[i] = TodoList.Items[i - 1];
				}
				TodoList.Items[0] = checkedItem;
				TodoList.SetItemChecked(0, false);
			}

			currentlyOrderingItems = false;
		}
	}
}
