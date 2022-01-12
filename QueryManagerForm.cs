using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BBD_lab1
{
    public partial class QueryManagerForm : Form
    {
        private string path;
        private string ext;
        private string fileName;
        private MainForm mainForm;
        private bool saving = false;
        private const string defaultFileName = "Новый запрос";

        private string FilePath(bool existing = true) => Path.Combine(path, (existing ? fileName : comboBox_queryName.Text) + ext);

        public QueryManagerForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            path = mainForm.SavedQueriesPath;
            ext = mainForm.Ext;
            if (Directory.Exists(path)) comboBox_queryName.Items.AddRange(Directory.GetFiles(path, $"*{ext}").Select(x => Path.GetFileNameWithoutExtension(x)).ToArray());
            else Directory.CreateDirectory(path);
        }

        private void comboBox_queryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!saving)
            {
                string oldFileName = fileName;
                fileName = comboBox_queryName.Text;
                if (showSaveDialog())
                {
                    string filePath = FilePath(false);
                    if (File.Exists(filePath)) textBox_queryText.Text = File.ReadAllText(filePath);
                    else
                    {
                        fileName = oldFileName;
                        comboBox_queryName.Text = fileName;
                        MessageBox.Show("Запрос с указанным именем не найден", "Ошибка");
                    }
                }
                else comboBox_queryName.Text = oldFileName;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if ((textBox_queryText.Text != "" || comboBox_queryName.Text != "") && (textBox_queryText.Modified || comboBox_queryName.Text != fileName)) save();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(fileName != null)
            {
                string filePath = FilePath();
                if (File.Exists(filePath))
                {
                    if (MessageBox.Show($"Удалить запрос {fileName} ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        File.Delete(filePath);
                        comboBox_queryName.Text = "";
                        comboBox_queryName.Items.Remove(fileName);
                        fileName = null;
                        textBox_queryText.Clear();
                        textBox_queryText.Modified = true;
                    }
                }
                else MessageBox.Show("Запрос с указанным именем не найден", "Ошибка");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (showSaveDialog())
            {
                comboBox_queryName.Text = "";
                textBox_queryText.Clear();
                fileName = null;
            }
        }

        private void save()
        {
            saving = true;
            if (comboBox_queryName.Text == "") comboBox_queryName.Text = defaultFileName;
            var invalidChars = comboBox_queryName.Text.Intersect(Path.GetInvalidFileNameChars().AsEnumerable());
            if (invalidChars.Count() == 0)
            {
                if(fileName != comboBox_queryName.Text && comboBox_queryName.Items.Contains(comboBox_queryName.Text))
                {
                    var result = comboBox_queryName.Text == defaultFileName ?
                        DialogResult.No :
                        MessageBox.Show($"Запрос с именем {comboBox_queryName.Text} уже существует. Перезаписать?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        string newFileName = comboBox_queryName.Text;
                        comboBox_queryName.Items.Remove(fileName);
                        for (int i = 2; ; i++)
                        {
                            if (comboBox_queryName.Items.Contains($"{newFileName} ({i})") == false)
                            {
                                newFileName = $"{newFileName} ({i})";
                                break;
                            }
                        }
                        comboBox_queryName.Text = newFileName;
                    }
                    else fileName = comboBox_queryName.Text;
                }
                if (textBox_queryText.Modified || fileName == null)
                {
                    File.WriteAllText(FilePath(false), textBox_queryText.Text);
                    textBox_queryText.Modified = false;

                    // новый файл
                    if (fileName != comboBox_queryName.Text) fileName = null;
                }
                else
                {
                    File.Move(FilePath(), FilePath(false));
                    comboBox_queryName.Items.Remove(fileName);
                    fileName = null;
                }
                if(fileName == null)
                {
                    fileName = comboBox_queryName.Text;
                    comboBox_queryName.Items.Add(fileName);
                }
            }
            else MessageBox.Show("Имя файла содержит запрещённые символы: " + new string(invalidChars.ToArray()), "Запрещённые символы в имени файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            saving = false;
        }

        private bool showSaveDialog()
        {
            if (fileName != null && (textBox_queryText.Modified || comboBox_queryName.Text != fileName))
            {
                switch (MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes: save(); break;
                    case DialogResult.Cancel: return false;
                }
            }
            return true;
        }

        private void QueryManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !showSaveDialog();
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            if(textBox_queryText.Text != "")
            {
                mainForm.ExecuteQuery(textBox_queryText.Text, comboBox_queryName.Text);
            }
        }

        private void QueryManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.UpdateRecentQueries();
        }
    }
}
