namespace WinForms_HW_7
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            новыйДокументToolStripMenuItem = new ToolStripMenuItem();
            tsm_New = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripMenuItem12 = new ToolStripMenuItem();
            toolStripMenuItem13 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsb_Cut = new ToolStripButton();
            tsb_Copy = new ToolStripButton();
            tsb_Paste = new ToolStripButton();
            tsb_Open = new ToolStripButton();
            tsb_Save = new ToolStripButton();
            tsb_NewDoc = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            tsmi_FontColor = new ToolStripMenuItem();
            tsmi_BackgroundColor = new ToolStripMenuItem();
            tsmi_FontStyle = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { новыйДокументToolStripMenuItem, toolStripMenuItem6, toolStripMenuItem10 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // новыйДокументToolStripMenuItem
            // 
            новыйДокументToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsm_New, toolStripMenuItem5, toolStripMenuItem4 });
            новыйДокументToolStripMenuItem.Name = "новыйДокументToolStripMenuItem";
            новыйДокументToolStripMenuItem.Size = new Size(59, 24);
            новыйДокументToolStripMenuItem.Text = "Файл";
            // 
            // tsm_New
            // 
            tsm_New.Name = "tsm_New";
            tsm_New.ShortcutKeys = Keys.Control | Keys.N;
            tsm_New.Size = new Size(216, 26);
            tsm_New.Text = "Создать";
            tsm_New.Click += tsb_NewDoc_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItem5.Size = new Size(216, 26);
            toolStripMenuItem5.Text = "Сохранить";
            toolStripMenuItem5.Click += tsb_Save_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.ShortcutKeys = Keys.Control | Keys.O;
            toolStripMenuItem4.Size = new Size(216, 26);
            toolStripMenuItem4.Text = "Открыть";
            toolStripMenuItem4.Click += tsb_Open_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(71, 24);
            toolStripMenuItem6.Text = "Шрифт";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(246, 26);
            toolStripMenuItem7.Text = "Изменить стиль";
            toolStripMenuItem7.Click += tsmi_FontStyle_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(246, 26);
            toolStripMenuItem8.Text = "Изменить цвет текста ";
            toolStripMenuItem8.Click += tsmi_FontColor_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(246, 26);
            toolStripMenuItem9.Text = "Изменить цвет фона";
            toolStripMenuItem9.Click += tsmi_BackgroundColor_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem11, toolStripMenuItem12, toolStripMenuItem13 });
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(123, 24);
            toolStripMenuItem10.Text = "Формат текста";
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.ShortcutKeys = Keys.Control | Keys.X;
            toolStripMenuItem11.Size = new Size(227, 26);
            toolStripMenuItem11.Text = "Вырезать";
            toolStripMenuItem11.Click += toolStripMenuItemCut_Click;
            // 
            // toolStripMenuItem12
            // 
            toolStripMenuItem12.Name = "toolStripMenuItem12";
            toolStripMenuItem12.ShortcutKeys = Keys.Control | Keys.C;
            toolStripMenuItem12.Size = new Size(227, 26);
            toolStripMenuItem12.Text = "Копировать";
            toolStripMenuItem12.Click += toolStripMenuItemCopy_Click;
            // 
            // toolStripMenuItem13
            // 
            toolStripMenuItem13.Name = "toolStripMenuItem13";
            toolStripMenuItem13.ShortcutKeys = Keys.Control | Keys.V;
            toolStripMenuItem13.Size = new Size(227, 26);
            toolStripMenuItem13.Text = "Вставить";
            toolStripMenuItem13.Click += toolStripMenuItemPaste_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_Cut, tsb_Copy, tsb_Paste, tsb_Open, tsb_Save, tsb_NewDoc, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Cut
            // 
            tsb_Cut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Cut.Image = Properties.Resources.icons8_вырезать_32;
            tsb_Cut.ImageTransparentColor = Color.Magenta;
            tsb_Cut.Name = "tsb_Cut";
            tsb_Cut.Size = new Size(29, 24);
            tsb_Cut.Text = "toolStripButton1";
            tsb_Cut.ToolTipText = "Вырезать";
            tsb_Cut.Click += toolStripMenuItemCut_Click;
            // 
            // tsb_Copy
            // 
            tsb_Copy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Copy.Image = Properties.Resources.icons8_скопировать_32;
            tsb_Copy.ImageTransparentColor = Color.Magenta;
            tsb_Copy.Name = "tsb_Copy";
            tsb_Copy.Size = new Size(29, 24);
            tsb_Copy.Text = "toolStripButton2";
            tsb_Copy.ToolTipText = "Копировать";
            tsb_Copy.Click += toolStripMenuItemCopy_Click;
            // 
            // tsb_Paste
            // 
            tsb_Paste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Paste.Image = Properties.Resources.icons8_вставить_30;
            tsb_Paste.ImageTransparentColor = Color.Magenta;
            tsb_Paste.Name = "tsb_Paste";
            tsb_Paste.Size = new Size(29, 24);
            tsb_Paste.Text = "toolStripButton3";
            tsb_Paste.ToolTipText = "Вставить";
            tsb_Paste.Click += toolStripMenuItemPaste_Click;
            // 
            // tsb_Open
            // 
            tsb_Open.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Open.Image = Properties.Resources.icons8_открыть_32;
            tsb_Open.ImageTransparentColor = Color.Magenta;
            tsb_Open.Name = "tsb_Open";
            tsb_Open.Size = new Size(29, 24);
            tsb_Open.Text = "toolStripButton4";
            tsb_Open.ToolTipText = "Открыть";
            tsb_Open.Click += tsb_Open_Click;
            // 
            // tsb_Save
            // 
            tsb_Save.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Save.Image = Properties.Resources.icons8_сохранить_30;
            tsb_Save.ImageTransparentColor = Color.Magenta;
            tsb_Save.Name = "tsb_Save";
            tsb_Save.Size = new Size(29, 24);
            tsb_Save.Text = "toolStripButton5";
            tsb_Save.ToolTipText = "Сохранить";
            tsb_Save.Click += tsb_Save_Click;
            // 
            // tsb_NewDoc
            // 
            tsb_NewDoc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_NewDoc.Image = Properties.Resources.icons8_новая_копия_32;
            tsb_NewDoc.ImageTransparentColor = Color.Magenta;
            tsb_NewDoc.Name = "tsb_NewDoc";
            tsb_NewDoc.Size = new Size(29, 24);
            tsb_NewDoc.Text = "Новый документ";
            tsb_NewDoc.Click += tsb_NewDoc_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { tsmi_FontColor, tsmi_BackgroundColor, tsmi_FontStyle });
            toolStripDropDownButton1.Image = Properties.Resources.icons8_цвет_текста_30;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(34, 24);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tsmi_FontColor
            // 
            tsmi_FontColor.Name = "tsmi_FontColor";
            tsmi_FontColor.Size = new Size(183, 26);
            tsmi_FontColor.Text = "Цвет шрифта";
            tsmi_FontColor.Click += tsmi_FontColor_Click;
            // 
            // tsmi_BackgroundColor
            // 
            tsmi_BackgroundColor.Name = "tsmi_BackgroundColor";
            tsmi_BackgroundColor.Size = new Size(183, 26);
            tsmi_BackgroundColor.Text = "Цвет фона";
            tsmi_BackgroundColor.Click += tsmi_BackgroundColor_Click;
            // 
            // tsmi_FontStyle
            // 
            tsmi_FontStyle.Name = "tsmi_FontStyle";
            tsmi_FontStyle.Size = new Size(183, 26);
            tsmi_FontStyle.Text = "Шрифт";
            tsmi_FontStyle.Click += tsmi_FontStyle_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(214, 76);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.X;
            toolStripMenuItem1.Size = new Size(213, 24);
            toolStripMenuItem1.Text = "Вырезать";
            toolStripMenuItem1.Click += toolStripMenuItemCut_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.C;
            toolStripMenuItem2.Size = new Size(213, 24);
            toolStripMenuItem2.Text = "Копировать";
            toolStripMenuItem2.Click += toolStripMenuItemCopy_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShortcutKeys = Keys.Control | Keys.V;
            toolStripMenuItem3.Size = new Size(213, 24);
            toolStripMenuItem3.Text = "Вставить";
            toolStripMenuItem3.Click += toolStripMenuItemPaste_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(0, 54);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 398);
            textBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsb_Cut;
        private ToolStripButton tsb_Copy;
        private ToolStripButton tsb_Paste;
        private ToolStripButton tsb_Open;
        private ToolStripButton tsb_Save;
        private ToolStripButton tsb_NewDoc;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private FontDialog fontDialog1;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem tsmi_FontColor;
        private ToolStripMenuItem tsmi_BackgroundColor;
        private ToolStripMenuItem tsmi_FontStyle;
        private ToolStripMenuItem новыйДокументToolStripMenuItem;
        private ToolStripMenuItem tsm_New;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
    }
}