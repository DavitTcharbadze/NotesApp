using FinalProject.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Data;

internal class NotesRepository
{
    private readonly AppDbContext _context;
    public NotesRepository()
    {
        _context = new AppDbContext();
    }
    public Note GetById(int id)
    {
        return _context.Notes.FirstOrDefault(x => x.Id == id);
    }
    public List<Note> GetAll()
    {
        return _context.Notes.ToList();
    }
    public void AddNote(Note note)
    {
        _context.Notes.Add(note);
        _context.SaveChanges();
    }
    public void UpdateNote(Note note)
    {
        var existingNote = _context.Notes.FirstOrDefault(x => x.Id == note.Id);
        if (existingNote != null)
        {
            existingNote.Name = note.Name;
            existingNote.Description = note.Description;
            _context.SaveChanges();
        }
    }

    public void DeleteNote(int id)
    {
        var note = _context.Notes.FirstOrDefault(x => x.Id == id);
        if (note != null)
        {
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }
    }

}
