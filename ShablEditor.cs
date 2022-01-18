using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocGen_2
{
    public partial class ShablEditor : Form
    {
        int countOfLines = 1;
        int indexes = 1;

        List<TextBox> labelBoxes = new();
        List<TextBox> tegBoxes = new();

        List<string> labelBoxesStr = new();
        List<string> tegBoxesStr = new();


        Shabls shabls;
        Form1 form;

        public ShablEditor(Form1 Forma)
        {
            InitializeComponent();
            labelBoxes.Add(new TextBox());
            labelBoxes[0].Location = new Point(10, 55);
            labelBoxes[0].Size = new Size(200, 23);
            labelBoxes[0].TabIndex = indexes;
            Controls.Add(labelBoxes[0]);
            indexes++;

            tegBoxes.Add(new TextBox());
            tegBoxes[0].Location = new Point(220, 55);
            tegBoxes[0].Size = new Size(200, 23);
            tegBoxes[0].TabIndex = indexes;
            Controls.Add(tegBoxes[0]);
            indexes++;

            form = Forma;
        }

        public ShablEditor(Form1 Forma, Shabls sh)
        {
            InitializeComponent();

            shabls = sh;

            labelBoxes.Clear();
            labelBoxesStr.Clear();
            tegBoxes.Clear();
            tegBoxes.Clear();

            numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
            numericUpDown1.ValueChanged += new EventHandler (numericUpDown1_ValueChanged2);

            labelBoxes.Add(new TextBox());
            labelBoxes[0].Location = new Point(10, 55);
            labelBoxes[0].Size = new Size(200, 23);
            labelBoxes[0].Text = shabls.LabelBoxes[0];
            labelBoxes[0].TabIndex = indexes;
            Controls.Add(labelBoxes[0]);
            indexes++;

            tegBoxes.Add(new TextBox());
            tegBoxes[0].Location = new Point(220, 55);
            tegBoxes[0].Size = new Size(200, 23);
            tegBoxes[0].Text = shabls.TegBoxes[0];
            tegBoxes[0].TabIndex = indexes;
            Controls.Add(tegBoxes[0]);
            indexes++;

            numericUpDown1.Value = shabls.CountOfLines;

            form = Forma;
        }

        private void numericUpDown1_ValueChanged2(object sender, EventArgs e)
        {

            for (int i = 1; i < shabls.CountOfLines; i++)
            {
                labelBoxes.Add(new TextBox());
                labelBoxes[i].Location = new Point(10, labelBoxes[countOfLines - 1].Location.Y + 30);
                labelBoxes[i].Size = new Size(200, 23);
                labelBoxes[i].Text = shabls.LabelBoxes[i];
                labelBoxes[i].TabIndex = indexes;
                indexes++;
                
                tegBoxes.Add(new TextBox());
                tegBoxes[i].Location = new Point(220, tegBoxes[countOfLines - 1].Location.Y + 30);
                tegBoxes[i].Size = new Size(200, 23);
                tegBoxes[i].Text = shabls.TegBoxes[i];
                tegBoxes[i].TabIndex = indexes;
                indexes++;

                Controls.Add(labelBoxes[i]);
                Controls.Add(tegBoxes[i]);
            }

            numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged2;
            numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
            numericUpDown1.Value = numericUpDown1.Value++;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > countOfLines)
            {
                Size sz = new Size(200, 23);
                for (int i = countOfLines; i < ((int)numericUpDown1.Value); i++)
                {
                    countOfLines++;
                    labelBoxes.Add(new());
                    labelBoxes[i].Location = new Point(10, labelBoxes[i-1].Location.Y + 30);
                    labelBoxes[i].Size = sz;
                    labelBoxes[i].TabIndex = indexes;
                    Controls.Add(labelBoxes[i]);
                    indexes++;

                    tegBoxes.Add(new());
                    tegBoxes[i].Location = new Point(220, tegBoxes[i - 1].Location.Y + 30);
                    tegBoxes[i].Size = sz;
                    tegBoxes[i].TabIndex = indexes;
                    Controls.Add(tegBoxes[i]);
                    indexes++;

                    button1.TabIndex = indexes;
                }
            }
            else if (numericUpDown1.Value < countOfLines)
            {
                for (int i = countOfLines; i > (int)numericUpDown1.Value; i--)
                {
                    Controls.Remove(labelBoxes[i-1]);
                    labelBoxes.RemoveAt(i-1);
                    Controls.Remove(tegBoxes[i-1]);
                    tegBoxes.RemoveAt(i-1);

                    indexes--;
                    indexes--;

                    button1.TabIndex = indexes;
                    //countOfLines++;
                }
                countOfLines = (int)numericUpDown1.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<numericUpDown1.Value; i++)
            {
                labelBoxesStr.Add(labelBoxes[i].Text);
                tegBoxesStr.Add(tegBoxes[i].Text);
            }

            form.shablR(new Shabls(countOfLines, labelBoxesStr, tegBoxesStr));

            Close();
        }
    }
}