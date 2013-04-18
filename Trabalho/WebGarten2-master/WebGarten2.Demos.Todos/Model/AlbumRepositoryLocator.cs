using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class AlbumRepositoryLocator
    {
        private readonly static InterfaceShared<Album> Repo = new AlbumMemoryRepository();
        public static InterfaceShared<Album> Get()
        {
            return Repo;
        }
    }
}
