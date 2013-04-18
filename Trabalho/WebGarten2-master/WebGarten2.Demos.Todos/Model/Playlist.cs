using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class Playlist
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public IDictionary<string, int> _repo;

        public Playlist()
        {
            _repo= new Dictionary<string, int>();
        }
    }
}
