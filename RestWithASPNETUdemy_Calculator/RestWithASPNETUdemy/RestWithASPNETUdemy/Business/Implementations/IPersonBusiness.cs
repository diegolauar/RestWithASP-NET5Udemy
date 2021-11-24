using System.Collections.Generic;
using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);

        PersonVO FindById(long id);

        List<PersonVO> FindAll();

        PersonVO Update(PersonVO person);

        void Delete(long id);
    }
}