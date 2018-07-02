/* Generated by Myra UI Editor at 7/2/2018 11:33:23 PM */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Graphics2D.UI
{
	partial class DebugOptionsWidget
	{
		private void BuildUI()
		{
			_checkBoxWidgetFrames = new CheckBox();
			_checkBoxWidgetFrames.Text = "Draw green frame around every widget";
			_checkBoxWidgetFrames.TextColor = Color.White;
			_checkBoxWidgetFrames.ImageWidthHint = 10;
			_checkBoxWidgetFrames.ImageHeightHint = 10;
			_checkBoxWidgetFrames.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxWidgetFrames.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxWidgetFrames.Id = "_checkBoxWidgetFrames";

			_checkBoxFocusedWidgetFrame = new CheckBox();
			_checkBoxFocusedWidgetFrame.Text = "Draw red frame around the focused widget";
			_checkBoxFocusedWidgetFrame.TextColor = Color.White;
			_checkBoxFocusedWidgetFrame.ImageWidthHint = 10;
			_checkBoxFocusedWidgetFrame.ImageHeightHint = 10;
			_checkBoxFocusedWidgetFrame.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxFocusedWidgetFrame.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxFocusedWidgetFrame.Id = "_checkBoxFocusedWidgetFrame";
			_checkBoxFocusedWidgetFrame.GridPositionY = 1;

			_checkBoxGlyphFrames = new CheckBox();
			_checkBoxGlyphFrames.Text = "Draw white frame around every letter glyph";
			_checkBoxGlyphFrames.TextColor = Color.White;
			_checkBoxGlyphFrames.ImageWidthHint = 10;
			_checkBoxGlyphFrames.ImageHeightHint = 10;
			_checkBoxGlyphFrames.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxGlyphFrames.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxGlyphFrames.Id = "_checkBoxGlyphFrames";
			_checkBoxGlyphFrames.GridPositionY = 2;

			_checkBoxDisableClipping = new CheckBox();
			_checkBoxDisableClipping.Text = "Disable clipping";
			_checkBoxDisableClipping.TextColor = Color.White;
			_checkBoxDisableClipping.ImageWidthHint = 10;
			_checkBoxDisableClipping.ImageHeightHint = 10;
			_checkBoxDisableClipping.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxDisableClipping.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxDisableClipping.Id = "_checkBoxDisableClipping";
			_checkBoxDisableClipping.GridPositionY = 3;

			
			DrawLinesColor = Color.White;
			RowsProportions.Add(new Proportion());
			RowsProportions.Add(new Proportion());
			RowsProportions.Add(new Proportion());
			RowsProportions.Add(new Proportion());
			Id = "Root";
			HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			Widgets.Add(_checkBoxWidgetFrames);
			Widgets.Add(_checkBoxFocusedWidgetFrame);
			Widgets.Add(_checkBoxGlyphFrames);
			Widgets.Add(_checkBoxDisableClipping);
		}

		
		public CheckBox _checkBoxWidgetFrames;
		public CheckBox _checkBoxFocusedWidgetFrame;
		public CheckBox _checkBoxGlyphFrames;
		public CheckBox _checkBoxDisableClipping;
	}
}