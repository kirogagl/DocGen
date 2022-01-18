using System;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace DocGen_2
{
    [Serializable]
    public partial class Form1 : Form
    {
        #region поля
        private Shabls shabls;
        private List<Label> labels = new();
        private List<TextBox> textBoxes = new();

        private string LastOpenLink = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        private string OpenLink;
        private string LastSaveLink = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        private string SaveLink = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        private string shaDoc;
        private int indexes = 0;

        _Application oWord;
        #endregion

        public Form1()
        {
            InitializeComponent();
            button1.TabIndex = 1;
        }

        //Функция для записи информации из шаблона для заполнения
        public void shablR(Shabls shs)
        {
            shabls = shs;
            drowMainForm();
        }

        #region отрисовка шаблона заполнения
        //Функция для отрисовки шаблона заполнения
        private void drowMainForm()
        {
            unDrowMainForm();
            indexes = shabls.CountOfLines;
            int startPos = 25;
            int pos = 0;
            for (int i = 0; i < indexes; i++)
            {
                pos = startPos * i;

                System.Drawing.Point point = new System.Drawing.Point(15, pos);

                labels.Add(new());
                labels[i].Text = shabls.LabelBoxes[i].ToString();
                labels[i].Location = point;
                labels[i].AutoSize = true;
                splitContainer2.Panel1.Controls.Add(labels[i]);

                textBoxes.Add(new());
                textBoxes[i].Location = point;
                textBoxes[i].Size = new System.Drawing.Size(280, 23);
                splitContainer2.Panel2.Controls.Add(textBoxes[i]);

            }

        }

        //Функция для очистки экрана
        private void unDrowMainForm()
        {
            for (int i = 0; i < indexes; i++)
            {
                splitContainer2.Panel1.Controls.Remove(labels[i]);
                splitContainer2.Panel2.Controls.Remove(textBoxes[i]);
            }
            labels.Clear();
            textBoxes.Clear();
        }
        #endregion

        #region файл
        //Создание шаблона для заполнения
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShablEditor shE = new(this);
            shE.Show();
        }

        //Открыть шаблон документа
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Word files(*.dotx)|*.dotx|All files(*.*)|*.*";
            of.Title = "Открыть новый шаблон (.dotx)";
            of.InitialDirectory = LastOpenLink;
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.Cancel) MessageBox.Show("Открытие шаблона отменено пользователем");
            else
            {
                OpenLink = of.FileName;
                LastOpenLink = Path.GetDirectoryName(OpenLink);
                shaDoc = OpenLink;
                MessageBox.Show("Шаблон документа .dotx выбран");
            }
        }

        //Сохранить шаблон заполнения
        private void saveShablToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shabls == null) MessageBox.Show("Нет данных для сохранения");
            else
            {
                string ser = JsonSerializer.Serialize<Shabls>(shabls);
                File.WriteAllText(LastSaveLink + "\\sh.json", ser);
                MessageBox.Show("Сохранено по адрессу: " + LastSaveLink + "\\sh.json");
            }
        }

        //Сохранить как шаблон для заполнения
        private void saveShablAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shabls == null) MessageBox.Show("Нет данных для сохранения");
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
                sf.Title = "Сохранить новый шаблон для заполнения (.json)";
                sf.InitialDirectory = LastSaveLink;
                DialogResult dr = sf.ShowDialog();
                if (dr == DialogResult.Cancel) MessageBox.Show("Сохранение отменено пользователем");
                else
                {
                    SaveLink = sf.FileName;
                    string ser = JsonSerializer.Serialize<Shabls>(shabls);
                    File.WriteAllText(SaveLink, ser);
                    MessageBox.Show("Сохранено по адрессу: " + SaveLink);
                }
            }
        }

        //Открыть шаблон для заполнения
        private void openShablToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool hlp = openShablHelper();
            if (hlp == true)
            {
                string deser = File.ReadAllText(OpenLink);
                shabls = JsonSerializer.Deserialize<Shabls>(deser);
                ShablEditor shE = new(this, shabls);
                shE.Show();
            }
        }

        //Функция для открытия Json файла
        private bool openShablHelper()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            of.Title = "Открыть новый шаблон для заполнения (.Json)";
            of.InitialDirectory = LastOpenLink;
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Открытие шаблона для заполнения отменено пользователем");
                return false;
            }
            else
            {
                OpenLink = of.FileName;
                LastOpenLink = Path.GetDirectoryName(OpenLink);
                return true;
            }
        }
#endregion

        #region сохранение сгенерированного документа
        //Сохранение сгенерированного документа
        private void saveDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Word files(*.docx)|*.docx|All files(*.*)|*.*";
            sf.Title = "Save new document.";
            sf.InitialDirectory = LastSaveLink;
            sf.FileName = "Сгенерированный файл";
            DialogResult dr = sf.ShowDialog();
            if (dr == DialogResult.Cancel) MessageBox.Show("Сохранение файла отменено пользователем");
            else
            {
                SaveLink = sf.FileName;

                try
                {
                    oWord = new Word.Application();
                    _Document oDoc = oWord.Documents.Add(shaDoc);
                    SetTemplate(oDoc);
                    oDoc.SaveAs(FileName: SaveLink);
                    oDoc.Close();
                    oWord.Quit();
                    MessageBox.Show($"Файл успешно сохранен по адрессу: \"{SaveLink}\".");
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Заполнение по закладкам шаблона dotx
        private void SetTemplate(_Document oDoc)
        {

            try
            {
                if (shabls == null) throw new NullReferenceException();
                for (int i = 0; i < shabls.CountOfLines; i++)
                {
                    oDoc.Bookmarks[shabls.TegBoxes[i]].Range.Text = textBoxes[i].Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Заполните все поля");
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Заполните все поля");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не задан шаблон для заполнения! \n(Файл будет сохранен не заполненным!)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region справка
        //Помощь
        private void instrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instr ins = new();
            ins.Show();
        }

        //О программе
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new();
            ab.Show();
        }
        #endregion

        #region синхронизация скроллинга панелей
        //split2 scrollSync
        private void splitContainer2_Panel1_Scroll(object sender, ScrollEventArgs e)
        {
            splitContainer2.Panel2.VerticalScroll.Value = splitContainer2.Panel1.VerticalScroll.Value;
        }

        private void splitContainer2_Panel2_Scroll(object sender, ScrollEventArgs e)
        {
            splitContainer2.Panel1.VerticalScroll.Value = splitContainer2.Panel2.VerticalScroll.Value;
        }

        private void splitContainer2_Panel2_MouseMove(object sender, MouseEventArgs e)
        {

            splitContainer2_Panel2_Scroll(null, null);
        }
        #endregion
    }
}
