using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGarten2.Demos.Todos.Model
{
    class Album
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime Ano { set; get; }
        public List<Music> Musics { set; get; }
    }
}
