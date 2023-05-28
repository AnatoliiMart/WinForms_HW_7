namespace WinForms_HW_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = Directory.GetCurrentDirectory();
            textBox1.Size = new Size(this.Size.Width, this.Size.Height);
        }
        private void tsb_NewDoc_Click(object sender, EventArgs e) => textBox1.Text = string.Empty;

        private void toolStripMenuItemCut_Click(object sender, EventArgs e) => textBox1.Cut();

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e) => textBox1.Copy();

        private void toolStripMenuItemPaste_Click(object sender, EventArgs e) => textBox1.Paste();

        private void tsb_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);

            FileStream stream = new(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new(stream);

            if (stream.CanRead)
                textBox1.Text = reader.ReadToEnd();
            else
                MessageBox.Show("Файла не существует", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            reader.Close();
            stream.Close();
        }

        private void tsb_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);

            FileStream stream = new(saveFileDialog1.FileName + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new(stream);

            if (stream.CanWrite)
                writer.Write(textBox1.Text.ToString());
            else
                MessageBox.Show("Невозможно сохранить файл", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            writer.Close();
            stream.Close();
        }

        private void tsmi_FontColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(this);
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void tsmi_BackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(this);
            textBox1.BackColor = colorDialog1.Color;
        }

        private void tsmi_FontStyle_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog(this);
            textBox1.Font = fontDialog1.Font;
        }

    }
}