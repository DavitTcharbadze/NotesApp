using FinalProject.Data;
using FinalProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private NotesRepository _notesRepository;

        public Form1()
        {
            InitializeComponent();
            _notesRepository = new NotesRepository();
            LoadNotes();

            dataGridViewNotes.CellClick += DataGridViewNotes_CellClick;
        }

        private void LoadNotes()
        {
            var notes = _notesRepository.GetAll();
            dataGridViewNotes.DataSource = notes;
        }

        private void ClearInputs()
        {
            richTextBox2.Clear();
            richTextBox1.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = richTextBox2.Text.Trim(); 
            string description = "";

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            Note newNote = new Note(name, description);
            _notesRepository.AddNote(newNote);
            LoadNotes();
            ClearInputs();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotes.CurrentRow == null)
            {
                MessageBox.Show("Please select a note to update.");
                return;
            }

            int id = (int)dataGridViewNotes.CurrentRow.Cells["Id"].Value;
            string name = richTextBox2.Text.Trim();
            string description = richTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            Note updatedNote = new Note(name, description) { Id = id };
            _notesRepository.UpdateNote(updatedNote);
            LoadNotes();
            ClearInputs();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewNotes.CurrentRow == null)
            {
                MessageBox.Show("Please select a note to delete.");
                return;
            }

            int id = (int)dataGridViewNotes.CurrentRow.Cells["Id"].Value;

            var confirmResult = MessageBox.Show("Are you sure to delete this note?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _notesRepository.DeleteNote(id);
                LoadNotes();
                ClearInputs();
            }
        }

        private void DataGridViewNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewNotes.Rows[e.RowIndex];
                richTextBox2.Text = row.Cells["Name"].Value?.ToString() ?? "";
                richTextBox1.Text = row.Cells["Description"].Value?.ToString() ?? "";
            }
        }
    }
}
