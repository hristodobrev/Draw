using Draw.src.GUI;
using Draw.src.Model;
using Draw.src.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Draw
{
    public partial class MainForm : Form
    {
        private DialogProcessor dialogProcessor = new DialogProcessor();

        public MainForm()
        {
            InitializeComponent();
        }

        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Rotate90ToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.Rotate(90);
            viewPort.Invalidate();

            baseContextMenuStrip.Show();
        }

        private void RotateM90ToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.Rotate(-90);
            viewPort.Invalidate();
        }

        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }

        void DrawRectangleButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRectangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

            viewPort.Invalidate();
        }

        private void DrawEllipseButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        private void DrawCircleButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddCircle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";

            viewPort.Invalidate();
        }

        private void DrawCircleLinesButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddCircleLines();

            statusBar.Items[0].Text = "Последно действие: Рисуване на кръг с линии";

            viewPort.Invalidate();
        }

        private void DrawPolygonButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.AddPolygon();

            statusBar.Items[0].Text = "Последно действие: Рисуване на многоъгълник";

            viewPort.Invalidate();
        }

        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                var item = dialogProcessor.ContainsPoint(e.Location);
                if (item != null)
                {
                    item.IsSelected = !item.IsSelected;
                    if (dialogProcessor.Selection.Contains(item))
                        dialogProcessor.Selection.Remove(item);
                    else
                        dialogProcessor.Selection.Add(item);
                }

                statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                dialogProcessor.IsDragging = true;
                dialogProcessor.LastLocation = e.Location;

                ShowSelectedProperties();

                viewPort.Invalidate();
            }
        }

        void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection.Count > 0) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }

            statusBar.Items[1].Text = $"X: {e.Location.X}, Y: {e.Location.Y}";
        }

        void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dialogProcessor.IsDragging = false;
        }

        private void FillColorButtonClick(object sender, EventArgs e)
        {
            if (fillColorDialog.ShowDialog() == DialogResult.OK)
            {
                if (dialogProcessor.Selection.Count > 0)
                {
                    foreach (var item in dialogProcessor.Selection)
                        item.FillColor = fillColorDialog.Color;
                    statusBar.Items[0].Text = "Последно действие: Задаване на цвят";

                    viewPort.Invalidate();
                }
            }
        }

        private void OpacityTrackbarValueChanged(object sender, EventArgs e)
        {
            opacityNumeric.Value = opacityTrackbar.Value;

            if (dialogProcessor.Selection.Count > 0)
            {
                foreach (var item in dialogProcessor.Selection)
                    item.Opacity = opacityTrackbar.Value;

                statusBar.Items[0].Text = "Последно действие: Задаване на прозрачност";

                viewPort.Invalidate();
            }
        }

        private void OpacityNumericValueChanged(object sender, EventArgs e)
        {
            opacityTrackbar.Value = (int)opacityNumeric.Value;

            if (dialogProcessor.Selection.Count > 0)
            {
                foreach (var item in dialogProcessor.Selection)
                    item.Opacity = opacityTrackbar.Value;

                statusBar.Items[0].Text = "Последно действие: Задаване на прозрачност";

                viewPort.Invalidate();
            }
        }

        private void StrokeWidthNumericValueChanged(object sender, EventArgs e)
        {
            strokeWidthTrackBar.Value = (int)strokeWidthNumeric.Value;

            if (dialogProcessor.Selection.Count > 0)
            {
                foreach (var item in dialogProcessor.Selection)
                    item.StrokeWidth = strokeWidthTrackBar.Value;

                statusBar.Items[0].Text = "Последно действие: Задаване на размер на контур";

                viewPort.Invalidate();
            }
        }

        private void StrokeWidthTrackBarValueChanged(object sender, EventArgs e)
        {
            strokeWidthNumeric.Value = strokeWidthTrackBar.Value;

            if (dialogProcessor.Selection.Count > 0)
            {
                foreach (var item in dialogProcessor.Selection)
                    item.StrokeWidth = strokeWidthTrackBar.Value;

                statusBar.Items[0].Text = "Последно действие: Задаване на размер на контур";

                viewPort.Invalidate();
            }
        }

        private void TogglePropertiesButtonClick(object sender, EventArgs e)
        {
            shapePropertiesGroupBox.Visible = !shapePropertiesGroupBox.Visible;
            togglePropertiesButton.Checked = shapePropertiesGroupBox.Visible;
        }

        private void RotateButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.Rotate(45);

            statusBar.Items[0].Text = "Последно действие: Завъртане на 45 градуса";

            viewPort.Invalidate();
        }

        private void ApplyRotateButtonClick(object sender, EventArgs e)
        {
            dialogProcessor.Rotate((int)rotateNumeric.Value);

            statusBar.Items[0].Text = $"Последно действие: Завъртане на {rotateNumeric.Value} градуса";

            viewPort.Invalidate();
        }

        private void GroupButtonClick(object sender, EventArgs e)
        {
            GroupSelection();
        }

        private void UngroupButtonClick(object sender, EventArgs e)
        {
            UngroupSelection();
        }

        private void SelectNameButtonClick(object sender, EventArgs e)
        {
            var selected = dialogProcessor.ShapeList.FirstOrDefault(item => item.Name == nameTextBox.Text);
            if (selected != null)
            {
                dialogProcessor.ShapeList.ForEach(i => i.IsSelected = false);
                selected.IsSelected = true;
                dialogProcessor.Selection = new List<Shape> { selected };
                viewPort.Invalidate();
            }
        }

        private void ApplyPropertiesButtonClick(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count == 1)
                dialogProcessor.Selection[0].Name = nameTextBox.Text;

            dialogProcessor.Selection.ForEach(i =>
            {
                i.Angle = (int)angleNumeric.Value;
                i.Scale = (float)scaleNumeric.Value;
            });

            statusBar.Items[0].Text = $"Последно действие: Задаване на характеристики, Ъгъл: {angleNumeric.Value}, Мащаб: {scaleNumeric.Value}";
            viewPort.Invalidate();
        }

        private void ColorChangeButtonDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Color c = Color.FromName(e.ClickedItem.ToString());

            foreach (var item in dialogProcessor.Selection)
                item.FillColor = c;

            viewPort.Invalidate();
        }

        private void ShowSelectedProperties()
        {
            nameTextBox.Text = string.Empty;
            if (dialogProcessor.Selection.Count == 1)
            {
                nameTextBox.Text = dialogProcessor.Selection[0].Name;
                angleNumeric.Value = dialogProcessor.Selection[0].Angle % 360;
                scaleNumeric.Value = (decimal)dialogProcessor.Selection[0].Scale;
            }

            shapesTreeview.Nodes.Clear();
            foreach (var item in dialogProcessor.ShapeList)
            {
                if (item.GetType() == typeof(GroupShape))
                {
                    shapesTreeview.Nodes.Add(GetNodes((GroupShape)item));
                }
                else
                {
                    shapesTreeview.Nodes.Add(new TreeNode(item.Name));
                }
            }
        }

        private TreeNode GetNodes(GroupShape shape)
        {
            var nodes = new List<TreeNode>();
            foreach (var item in shape.Elements)
            {
                if (item.GetType() == typeof(GroupShape))
                {
                    nodes.Add(GetNodes((GroupShape)item));
                }
                else
                {
                    nodes.Add(new TreeNode(item.Name));
                }
            }

            return new TreeNode(shape.Name, nodes.ToArray());
        }

        private void SelectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void HotkeysToolStripMenuItemClick(object sender, EventArgs e)
        {
            var hotkeysForm = new HotkeysForm();
            hotkeysForm.ShowDialog();
        }

        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.A)
                    SelectAll();
                else if (e.KeyCode == Keys.U)
                    UnselectAll();
                else if (e.KeyCode == Keys.I)
                    InvertSelect();
                else if (e.KeyCode == Keys.G)
                    GroupSelection();
                else if (e.KeyCode == Keys.C)
                    dialogProcessor.CopySelection();
                else if (e.KeyCode == Keys.S)
                    Export();
                else if (e.KeyCode == Keys.O)
                    Import();
                else if (e.KeyCode == Keys.V)
                {
                    dialogProcessor.PasteSelection();
                    viewPort.Invalidate();
                }
            }

            if (e.KeyCode == Keys.S)
                pickUpSpeedButton.Checked = !pickUpSpeedButton.Checked;

            if (e.KeyCode == Keys.Delete)
                DeleteSelected();
        }

        private void InvertSelect()
        {
            var newSelection = dialogProcessor.ShapeList.Where(i => !dialogProcessor.Selection.Contains(i));
            dialogProcessor.Selection.ForEach(i => i.IsSelected = false);
            dialogProcessor.Selection = new List<Shape>(newSelection);
            dialogProcessor.Selection.ForEach(i => i.IsSelected = true);
            viewPort.Invalidate();
            ShowSelectedProperties();
        }

        private void DeleteSelected()
        {
            dialogProcessor.ShapeList.RemoveAll(i => dialogProcessor.Selection.Contains(i));
            dialogProcessor.Selection.Clear();
            viewPort.Invalidate();
            statusBar.Items[0].Text = $"Последно действие: Изтриване";
        }

        private void SelectAll()
        {
            dialogProcessor.Selection = new List<Shape>(dialogProcessor.ShapeList);
            dialogProcessor.Selection.ForEach(i => i.IsSelected = true);
            viewPort.Invalidate();
            statusBar.Items[0].Text = $"Последно действие: Указване на всички";
            ShowSelectedProperties();
        }

        private void UnselectAll()
        {
            dialogProcessor.Selection = new List<Shape>();
            dialogProcessor.ShapeList.ForEach(i => i.IsSelected = false);
            viewPort.Invalidate();
            statusBar.Items[0].Text = $"Последно действие: Премахване на указването";
            ShowSelectedProperties();
        }

        private void GroupSelection()
        {
            dialogProcessor.GroupSelection();
            statusBar.Items[0].Text = $"Последно действие: Групиране";
            viewPort.Invalidate();
            ShowSelectedProperties();
        }

        private void UngroupSelection()
        {
            dialogProcessor.UngroupSelection();
            statusBar.Items[0].Text = $"Последно действие: Разгрупиране";
            viewPort.Invalidate();
            ShowSelectedProperties();
        }

        private void ExportToolStripMenuItemClick(object sender, EventArgs e)
        {
            Export();
        }

        private void ImportToolStripMenuItemClick(object sender, EventArgs e)
        {
            Import();
        }

        private void Import()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "bin files (*.bin)|*.bin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.ShapeList = SerializationUtils.ReadFromBinaryFile<List<Shape>>(openFileDialog.FileName);
                dialogProcessor.Selection = dialogProcessor.ShapeList.Where(i => i.IsSelected).ToList();
                viewPort.Invalidate();
                statusBar.Items[0].Text = $"Последно действие: Импортиране";
            }
        }

        private void Export()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "bin files (*.bin)|*.bin";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SerializationUtils.WriteToBinaryFile(saveFileDialog.FileName, dialogProcessor.ShapeList);
                MessageBox.Show("Export completed!");
                statusBar.Items[0].Text = $"Последно действие: Експортиране";
            }
        }

        private void DeleteSelectedToolStripMenuItemClick(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void UngroupToolStripMenuItemClick(object sender, EventArgs e)
        {
            UngroupSelection();
        }

        private void GroupToolStripMenuItemClick(object sender, EventArgs e)
        {
            GroupSelection();
        }

        private void GroupSelectedToolStripMenuItemClick(object sender, EventArgs e)
        {
            GroupSelection();
        }

        private void InvertSelectionToolStripMenuItemClick(object sender, EventArgs e)
        {
            InvertSelect();
        }

        private void BaseContextMenuStripOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dialogProcessor.Selection.Count > 0)
            {
                e.Cancel = true;
                ContextMenuStrip = selectionContextMenuStrip;
                ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void SelectionContextMenuStripOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dialogProcessor.Selection.Count == 0)
            {
                e.Cancel = true;
                ContextMenuStrip = baseContextMenuStrip;
                ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void UnselectAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            UnselectAll();
        }

        private void UngroupSelectedToolStripMenuItemClick(object sender, EventArgs e)
        {
            UngroupSelection();
        }

        private void Rotate90ContextToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.Rotate(90);
            viewPort.Invalidate();
            statusBar.Items[0].Text = $"Последно действие: Завъртане на 90 градуса";
        }

        private void RotateM90ContextToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.Rotate(-90);
            viewPort.Invalidate();
            statusBar.Items[0].Text = $"Последно действие: Завъртане на -90 градуса";
        }

        private void NewRectangleToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.AddRectangle(Cursor.Position.X, Cursor.Position.Y);
            statusBar.Items[0].Text = $"Последно действие: Рисуване на правоъгълник";
            viewPort.Invalidate();
        }

        private void NewEllipseToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.AddEllipse(Cursor.Position.X, Cursor.Position.Y);
            statusBar.Items[0].Text = $"Последно действие: Рисуване на елипса";
            viewPort.Invalidate();
        }

        private void NewCircleToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.AddCircle(Cursor.Position.X, Cursor.Position.Y);
            statusBar.Items[0].Text = $"Последно действие: Рисуване на кръг";
            viewPort.Invalidate();
        }

        private void NewPolygonToolStripMenuItemClick(object sender, EventArgs e)
        {
            dialogProcessor.AddPolygon(Cursor.Position.X, Cursor.Position.Y);
            statusBar.Items[0].Text = $"Последно действие: Рисуване на многоъгълник";
            viewPort.Invalidate();
        }
    }
}
