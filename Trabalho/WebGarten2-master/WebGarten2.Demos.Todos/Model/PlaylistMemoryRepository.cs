using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class PlaylistMemoryRepository : InterfaceShared<Playlist>
    {
        private readonly IDictionary<int, Playlist> _repo = new Dictionary<int, Playlist>();
        private int _cid = 0;

        #region IPlaylistRepository Members

        public IEnumerable<Playlist> GetAll()
        {
            return _repo.Values;
        }

        public Playlist GetById(int id)
        {
            Playlist td = null;
            _repo.TryGetValue(id, out td);
            return td;
        }

        public void Add(Playlist td)
        {
            td.Id = _cid;
            _repo.Add(_cid++, td);
        }

        public Playlist GetByName(string name) 
        {
            foreach(KeyValuePair<int, Playlist> p in _repo)
            {
                if (p.Value.Name.Equals(name))
                {
                    return p.Value;
                }
            }
            return null;
        }
    
        #endregion
        public void Remove(Playlist pl) 
        {
            _repo.Remove(pl.Id);
        }
    }
}
