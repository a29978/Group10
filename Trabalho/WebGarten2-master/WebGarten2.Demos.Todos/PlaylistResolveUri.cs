using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebGarten2.Demos.Todos.Model;

namespace WebGarten2.Demos.Todos
{
    class PlaylistResolveUri
    {
        public static string For(Playlist pl)
        {
            return string.Format("http://localhost:8080/playlists/{0}", pl.Id);
        }

        public static string ForTodos()
        {
            return "http://localhost:8080/playlists";
        }

        public static string edit(Playlist pl) 
        {
            return string.Format("http://localhost:8080/edit/{0}",pl.Id);
        }
        public static string editTodos(Playlist pl) 
        {
            return string.Format("http://localhost:8080/editPost/{0}", pl.Id);
        }

        public static string delete(Playlist pl) 
        {
            return string.Format("http://localhost:8080/delete/{0}", pl.Id);
        }
    }
}
