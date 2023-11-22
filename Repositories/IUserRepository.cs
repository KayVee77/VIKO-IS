using projektas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektas
{
    public interface IUserRepository <TEntity> 
        where TEntity : Entity
    {
        void Add(TEntity Entity );
        TEntity Get( string LogIn );
        void Update();
        void Remove();

    }
}
