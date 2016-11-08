using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DD.Core.Repository
{
    public interface ICardRepository
    {        
        IEnumerable<ICard> GetAll(IDbConnection con);
        int Insert(IDbConnection con, ICard card);
        bool Update(IDbConnection con, ICard card);
    }
}
