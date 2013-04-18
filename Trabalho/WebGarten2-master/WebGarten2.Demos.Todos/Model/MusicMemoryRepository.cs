using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class MusicMemoryRepository: InterfaceShared<Music>
    {
        private readonly IDictionary<int, Music> _repo = new Dictionary<int, Music>();
        private int _cid = 0;
        #region InterfaceShared<Music> Members

        public IEnumerable<Music> GetAll()
        {
            return _repo.Values;
        }

        public Music GetById(int id)
        {
            Music td = null;
            _repo.TryGetValue(id, out td);
            return td;
        }

        public void Add(Music td)
        {
            td.Id = _cid;
            _repo.Add(_cid++, td);
        }

        public Music GetByName(string name)
        {
            foreach (KeyValuePair<int, Music> p in _repo)
            {
                if (p.Value.Name.Equals(name))
                {
                    return p.Value;
                }
            }
            return null;
        }

        public void Remove(Music music) 
        {
            _repo.Remove(music.Id);
        }
        #endregion
    }
}
