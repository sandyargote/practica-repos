
using System;
using System.Collections.Generic;
using System.Text;
using EjemploWindowsForm.Domain;
using EjemploWindowsForm.Contracts;

namespace EjemploWindowsForm.Infraestructure
{
    internal class RepositoryEstudiante : IRepository<Estudiante, long>, IUnidOfWork
    {
        private Repository<Estudiante, long> _repository;
        public RepositoryEstudiante(string dataFilePath)
        {
            _repository = new Repository<Estudiante, long>(dataFilePath);
        }

        public void Add(Estudiante entity)
        {
            _repository.Add(entity);
        }

        public void Commit()
        {
            _repository.Commit();
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }

        public IEnumerable<Estudiante> GetAll()
        {
            return _repository.GetAll();
        }

        public Estudiante GetById(long id)
        {
            return _repository.GetById(id);
        }

        public void Update(Estudiante entity)
        {
            _repository.Update(entity);
        }
    }
}
