using System;
using Avalonia.Controls;
using Avalonia.Media;
using MessageBox.Avalonia.Enums;

namespace MessageBox.Avalonia.DTO
{
    public abstract class AbstractMessageBoxParams
    {
        /// <summary>
        /// Window icon of app in title bar
        /// </summary>
        public WindowIcon WindowIcon { get; set; } = null;

        [Obsolete] public Style Style { get; set; } = Style.None;

        /// <summary>
        /// Ability of resizing window
        /// </summary>
        public bool CanResize { get; set; } = false;

        /// <summary>
        /// Show in center screen
        /// </summary>
        public bool ShowInCenter { get; set; } = true;

        /// <summary>
        /// Font in messagebox text
        /// </summary>
        public FontFamily FontFamily { get; set; } = FontFamily.Default;

        /// <summary>
        /// Title of window in title bar
        /// </summary>
        public string ContentTitle { get; set; } = string.Empty;

        /// <summary>
        /// Header of messagebox window
        /// </summary>
        public string ContentHeader { get; set; } = null;

        /// <summary>
        /// Main text of messagebox body
        /// </summary>
        public string ContentMessage { get; set; } = string.Empty;

        /// <summary>
        /// Minimal width of window (default 200)
        /// </summary>
        public double MinWidth { get; set; } = 200;

        /// <summary>
        /// Max width of window
        /// </summary>
        public double MaxWidth { get; set; } = double.PositiveInfinity;

        /// <summary>
        /// Actual width of window
        /// </summary>
        public double Width { get; set; } = double.NaN;

        /// <summary>
        /// Minimum height of window (default 100)
        /// </summary>
        public double MinHeight { get; set; } = 100;

        /// <summary>
        /// Max height of window
        /// </summary>
        public double MaxHeight { get; set; } = double.PositiveInfinity;

        /// <summary>
        /// Actual height of window
        /// </summary>
        public double Height { get; set; } = double.NaN;

        /// <summary>
        /// Setup height and weight based on content
        /// </summary>
        /// <remarks>
        /// Content - text size and icon (image) size
        /// </remarks>
        public SizeToContent SizeToContent { get; set; } = SizeToContent.WidthAndHeight;

        /// <summary>
        /// Position window
        /// </summary>
        public WindowStartupLocation WindowStartupLocation { get; set; } = WindowStartupLocation.Manual;

        /// <summary>
        /// Enables or disables system window decorations (title bar, buttons, etc)
        /// </summary>
        public bool HasSystemDecorations { get; set; } = true;

        /// <summary>
        /// Window under all windows
        /// </summary>
        public bool Topmost { get; set; } = false;
    }
}