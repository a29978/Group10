using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class AlbumMemoryRepository: InterfaceShared<Album>
    {
        private readonly IDictionary<int, Album> _repo = new Dictionary<int, Album>();
        private int _cid = 0;
        #region InterfaceShared<Album> Members

        public IEnumerable<Album> GetAll()
        {
            return _repo.Values;
        }

        public Album GetById(int id)
        {
            Album td = null;
            _repo.TryGetValue(id, out td);
            return td;
        }

        public void Add(Album td)
        {
            td.Id = _cid;
            _repo.Add(_cid++, td);
        }

        public Album GetByName(string name)
        {
            foreach (KeyValuePair<int, Album> p in _repo)
            {
                if (p.Value.Name.Equals(name))
                {
                    return p.Value;
                }
            }
            return null;
        }

        public void Remove(Album alb) 
        {
            _repo.Remove(alb.Id);
        }
        #endregion
    }
}
