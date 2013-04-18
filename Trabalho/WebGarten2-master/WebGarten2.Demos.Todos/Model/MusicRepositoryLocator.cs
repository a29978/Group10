using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class MusicRepositoryLocator
    {
        private readonly static InterfaceShared<Music> Repo = new MusicMemoryRepository();
        public static InterfaceShared<Music> Get()
        {
            return Repo;
        }
    }
}
