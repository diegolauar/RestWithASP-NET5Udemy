using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Data.Converter.Implementation;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Implementations;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IRepository<Books> _repository;

        private readonly BooksConverter _converter;

        public BooksBusinessImplementation(IRepository<Books> repository)
        {
            _repository = repository;
            _converter = new BooksConverter();
        }

        public BooksVO Create(BooksVO books)
        {
            var booksEntity = _converter.Parse(books);
            booksEntity = _repository.Create(booksEntity);
            return _converter.Parse(booksEntity);
        }

        public BooksVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public List<BooksVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BooksVO Update(BooksVO books)
        {
            var booksEntity = _converter.Parse(books);
            booksEntity = _repository.Update(booksEntity);
            return _converter.Parse(booksEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}