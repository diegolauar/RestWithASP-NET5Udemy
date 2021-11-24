using System.Collections.Generic;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public interface IBooksBusiness
    {
        BooksVO Create(BooksVO books);

        BooksVO FindById(long id);

        List<BooksVO> FindAll();

        BooksVO Update(BooksVO books);

        void Delete(long id);
    }
}