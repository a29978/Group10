using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class PlaylistMemoryRepositoryLocator
    {
        private readonly static InterfaceShared<Playlist> Repo = new PlaylistMemoryRepository();
        public static InterfaceShared<Playlist> Get()
        {
            return Repo;
        }
    }
}
