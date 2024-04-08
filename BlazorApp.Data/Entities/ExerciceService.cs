using BlazorApp.Data.DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Data.Entities
{
    public class ExerciceService
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public ExerciceService(ApplicationDBContext applicationDBContext) 
        { 
            _applicationDBContext= applicationDBContext; ;
        }

        // list of exercices
        public async Task<List<Exercice>> GetAllExerciceAsync()
        {
            return await _applicationDBContext.Exercices.ToListAsync();
        }

        // add new exercice
        public async Task<bool> AddNewExercice(Exercice exercice)
        {
            await _applicationDBContext.Exercices.AddAsync(exercice);
            await _applicationDBContext.SaveChangesAsync();
            return true;
        }

        // get exercice record by id
        public async Task<Exercice> GetExerciceById(int id)
        {
            Exercice exercice =await _applicationDBContext.Exercices.FirstOrDefaultAsync(x => x.Id == id);
            return exercice;
        }

        // update exercice details
        public async Task<bool> UpdateExerciceDetails(Exercice exercice)
        {
            _applicationDBContext.Exercices.Update(exercice);
            await _applicationDBContext.SaveChangesAsync(true);
            return true;
        }

        // delete exercice
        public async Task<bool> DeleteExercice(Exercice exercice)
        {
            _applicationDBContext.Exercices.Remove(exercice);
            await _applicationDBContext.SaveChangesAsync(true);
            return true;
        }
    }
}
