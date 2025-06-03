using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Data;
namespace FinalProject.Services;


internal class NotesService
{
    private readonly NotesRepository _notesRepository;
    public NotesService()
    {
        _notesRepository = new NotesRepository();
    }

}
