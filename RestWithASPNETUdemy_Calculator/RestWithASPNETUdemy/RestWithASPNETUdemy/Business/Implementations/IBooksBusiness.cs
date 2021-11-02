using System.Collections.Generic;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public interface IBooksBusiness
    {
        Books Create(Books books);

        Books FindById(long id);

        List<Books> FindAll();

        Books Update(Books books);

        void Delete(long id);
    }
}